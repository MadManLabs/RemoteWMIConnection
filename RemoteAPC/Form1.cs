
/*using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
*/

using System;
using System.Windows.Forms;
using System.Management;
using System.DirectoryServices;
using Microsoft.Win32;
using System.IO;
using System.Collections.Generic;

namespace RemoteAPC
{
    public partial class Form1 : Form
    {
      
        Business bo = new Business(); //create object to hold queried data   
        List<string> items = new List<string>(); // <-- Add this
        public Form1()
        {
            InitializeComponent();
            DirectoryEntry root = new DirectoryEntry("WinNT:"); //connect to FDI active directory
            foreach (DirectoryEntry computers in root.Children)
            {
                foreach (DirectoryEntry computer in computers.Children)
                {
                    if (computer.Name != "Schema")
                    {
                        if (computer.Name.Contains("FDI") || computer.Name.Contains("HP") && !computer.Name.Contains("SQLServer")
                            && !computer.Name.Contains("SERVER")) //filter out unwanted names
                        { pcListComboBox.Items.Add(computer.Name); } //add pc to the combo box
                    }
                }

            }

            WMIClassComboBox.Items.Add("Win32_OperatingSystem");
            WMIClassComboBox.Items.Add("View Installed Applications");
            WMIClassComboBox.Items.Add("Reboot");
            WMIClassComboBox.Items.Add("Install an application");
        }

        private void connectButton_Click(object sender, EventArgs e) //remote connect to selected pc on click

        /******************** IN ORDER TO CONNECT REMOTELY, WMI MUST BE ALLOWED THROUGH THE REMOTE PC'S FIREWALL**************************/

        {

            if (pcListComboBox.SelectedIndex > -1)// ensure selection from pc combo
            {
                AppStatic.Workstation = this.pcListComboBox.Text;
                if (WMIClassComboBox.SelectedIndex > -1) //ensure selection from WMI Class Combo
                {
                    bo.PCName = pcListComboBox.Text;
                    ListViewItem row1 = new ListViewItem();
                    ListViewItem row2 = new ListViewItem();
                    ListViewItem row3 = new ListViewItem();
                    ListViewItem row4 = new ListViewItem();
                    ListViewItem row5 = new ListViewItem();
                    ListViewItem row6 = new ListViewItem();
                    ListViewItem row7 = new ListViewItem();
                    ListViewItem row8 = new ListViewItem();
                    ListViewItem row10 = new ListViewItem();
                    if (WMIClassComboBox.Text == "Win32_OperatingSystem")
                    { //connection for using same credentials as logged on PC
                        ManagementScope scope = new ManagementScope("\\\\" + bo.PCName + "\\root\\cimv2");
                        ObjectQuery query = new ObjectQuery("SELECT * FROM Win32_OperatingSystem");
                        ManagementObjectSearcher searcher = new ManagementObjectSearcher(scope, query);
                        try
                        {
                            ManagementObjectCollection colDisks;
                            DataDisplayColomn.Text = "Win32_OperatingSystem";
                            scope.Connect();
                            colDisks = searcher.Get();

                            foreach (ManagementObject objDisk in colDisks)
                            {
                                row1.Text = "PC name";
                                row1.SubItems.Add(objDisk["CSName"].ToString());
                                row2.Text = "Free physical memory";
                                row2.SubItems.Add(objDisk["FreePhysicalMemory"].ToString());
                                row3.Text = "SerialNumber";
                                row3.SubItems.Add(objDisk["SerialNumber"].ToString());
                                row4.Text = "RegisteredUser";
                                row4.SubItems.Add(objDisk["RegisteredUser"].ToString());
                                row5.Text = "FreeVirtualMemory";
                                row5.SubItems.Add(objDisk["FreeVirtualMemory"].ToString());
                                row6.Text = "LastBootUpTime";
                                row6.SubItems.Add(objDisk["LastBootUpTime"].ToString());
                                row7.Text = "Version";
                                row7.SubItems.Add(objDisk["Version"].ToString());
                                row8.Text = "SystemDrive";
                                row8.SubItems.Add(objDisk["SystemDrive"].ToString());
                                row10.Text = "NumberOfProcesses";
                                row10.SubItems.Add(objDisk["NumberOfProcesses"].ToString());
                            }
                            listView.Items.Add(row1);
                            listView.Items.Add(row2);
                            listView.Items.Add(row3);
                            listView.Items.Add(row4);
                            listView.Items.Add(row5);
                            listView.Items.Add(row6);
                            listView.Items.Add(row7);
                            listView.Items.Add(row8);
                            listView.Items.Add(row10);
                        }
                        catch { errorLabel.Text = "RPC Server is unavailable, insure remote pc has WMI enabled through Firewall"; }
                        finally
                        {
                            scope = null;
                            query = null;
                            searcher = null;
                            GC.SuppressFinalize(scope);
                            GC.SuppressFinalize(query);
                            GC.SuppressFinalize(searcher);
                        }

                    }
                    else if (WMIClassComboBox.Text == "View Installed Applications")
                    {
                        try
                        {
                            ConnectionOptions connectionOptions = new ConnectionOptions();
                          //  connectionOptions.Username = @"FDI\aopperator";
                          //   connectionOptions.Password = "Luke0112";
                           // connectionOptions.Impersonation = ImpersonationLevel.Impersonate;

                            ManagementScope scope = new ManagementScope("\\\\" + bo.PCName + "\\root\\CIMV2", connectionOptions);
                            scope.Connect();

                            string softwareRegLoc = @"Software\Microsoft\Windows\CurrentVersion\Uninstall";

                            ManagementClass registry = new ManagementClass(scope, new ManagementPath("StdRegProv"), null);
                            ManagementBaseObject inParams = registry.GetMethodParameters("EnumKey");
                            inParams["hDefKey"] = 0x80000002;//HKEY_LOCAL_MACHINE
                            inParams["sSubKeyName"] = softwareRegLoc;

                            // Read Registry Key Names 
                            ManagementBaseObject outParams = registry.InvokeMethod("EnumKey", inParams, null);
                            string[] programGuids = outParams["sNames"] as string[];
                            Form2 f2 = new Form2(bo);

                            foreach (string subKeyName in programGuids)
                            {
                                inParams = registry.GetMethodParameters("GetStringValue");
                                inParams["hDefKey"] = 0x80000002;//HKEY_LOCAL_MACHINE
                                inParams["sSubKeyName"] = softwareRegLoc + @"\" + subKeyName;
                                inParams["sValueName"] = "DisplayName";
                                // Read Registry Value 
                                outParams = registry.InvokeMethod("GetStringValue", inParams, null);

                                try
                                {
                                    string softwareName = outParams.Properties["sValue"].Value.ToString();
                                    items.Add(softwareName);
                                }
                                catch { }
                            }

                            f2.view.DataSource = items;
                            f2.pcNameLabel.Text = bo.PCName;
                            f2.ShowDialog();
                        }

                        catch { errorLabel.Text = "Error viewing installed applications"; }
                    }
                    else if (WMIClassComboBox.Text == "Reboot")
                    {
                        try
                        {
                            string computerName = bo.PCName; // computer name or IP address

                            ConnectionOptions options = new ConnectionOptions();
                            options.EnablePrivileges = true;
                            // To connect to the remote computer using a different account, specify these values:
                            // options.Username = "jmiller";
                            //  options.Password = "landScapePro2!";
                            //options.Authority = "ntlmdomain:DOMAIN";

                            ManagementScope scope = new ManagementScope(
                              "\\\\" + computerName + "\\root\\CIMV2", options);
                            scope.Connect();

                            System.Management.ObjectQuery oq = new System.Management.ObjectQuery("SELECT * FROM Win32_OperatingSystem");//This is WMI query
                            ManagementObjectSearcher query1 = new ManagementObjectSearcher(scope, oq);
                            ManagementObjectCollection queryCollection1 = query1.Get();
                            foreach (ManagementObject mo in queryCollection1)
                            {
                                string[] ss = { "" };
                                mo.InvokeMethod("Reboot", ss); //this 4 restart the remote system 
                                                               //mo.InvokeMethod("shutdown", ss); // this 4 shut down the remote system.
                                Console.WriteLine(mo.ToString());
                            }
                        }
                        catch 
                        {
                            errorLabel.Text = "Error rebooting";
                        }
                       
                    }
                    else if (WMIClassComboBox.Text == "Install an application")
                    {
                        Form3 f3 = new Form3(bo);
                        f3.ShowDialog();
                    }
                       
                    
                    
                   
                }
                else { errorLabel.Text = "Please select a WMI class"; }

            }
            else { errorLabel.Text = "Please select a PC to connect to"; }
        }

        //delete later
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void pcListComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void WMIClassComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void WMIClassLabel_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
    
