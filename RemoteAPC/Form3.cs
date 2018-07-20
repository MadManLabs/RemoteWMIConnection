using System;
using System.IO;
using System.Collections.Generic;
using System.Management;
using System.DirectoryServices;
using System.Windows.Forms;
using System.Threading;

namespace RemoteAPC
{
    public partial class Form3 : Form
    {
        Business bo;
        public Form3(Business bo)
        {
            InitializeComponent();
            this.bo = bo;
            userLabel.Text = bo.PCName;

        }

        private void installButton_Click(object sender, EventArgs e)//determines if installing on local or remote pc and establishes connections accordingly and attemps  install
        {
            this.installButton.Enabled = false;
            //string _directoryName = "\\" + bo.PCName + "\\" + "C$\\"+ "RemoteInstall"; //DIRECTORY path to create on remote pc;
            //string filename = string.Empty;
            //string directory = string.Empty;

            string test = AppStatic.SoftwareWareInstsall;

            try
            {             
                //if all textboxes are filled
                if (!String.IsNullOrEmpty(AppStatic.SoftwareWareInstsall) &&
                    !String.IsNullOrEmpty(userNameTextBox.Text) &&
                    !String.IsNullOrEmpty(passwordTextBox.Text))
                {   //take app path, username, and password from user and store in Business Class
                    //bo.ApplicationPath = appPathTextBox.Text;
                    bo.Username = userNameTextBox.Text;
                    bo.Password = passwordTextBox.Text;
                    //filename = Path.GetFileName(bo.ApplicationPath);
                    //directory = Path.GetDirectoryName(bo.ApplicationPath);
                }
                //if (File.Exists(_directoryName + "\\" + filename)) { File.Delete(_directoryName + "\\" + filename); }
                //if (Directory.Exists(_directoryName)) { Directory.Delete(_directoryName); }
                //if (!Directory.Exists(_directoryName)) {  Directory.CreateDirectory(_directoryName); }
                //if (!File.Exists(_directoryName + "\\" + filename)) { File.Copy(bo.ApplicationPath, _directoryName); }
                ManagementScope ms = null; //scope object to read in connection params and class file

                // Connection options 
                ConnectionOptions co = new ConnectionOptions();
                co.Impersonation = ImpersonationLevel.Impersonate;//impersonate setting because connection will be a trusted device 
                co.Authentication = AuthenticationLevel.PacketPrivacy; //Packet Privacy enables all communication to be encrypted

                // local machine 
                if (bo.PCName.ToUpper() == Environment.MachineName.ToUpper())
                {
                    co.Authority = "ntlmdomain:" + bo.Domain;
                    ms = new ManagementScope(@"\ROOT\CIMV2", co);
                }
                // remote machine 
                else
                {
                    co.Authority = "kerberos:" + bo.Domain + @"\" + bo.PCName;
                    co.Username = bo.Username;
                    co.Password = bo.Password;
                    ms = new ManagementScope(@"\\" + bo.PCName + "." + bo.Domain + "\\root\\cimv2", co); //path of remote pc connection
                    ms.Options.Impersonation = ImpersonationLevel.Delegate; //delegates credentials of the calling object
                }


                ms.Connect();
                ManagementPath mp = new ManagementPath("Win32_Product");//wmi class to connect to with ManagementClass object
                ManagementClass mc = new ManagementClass(ms, mp, null); //create class instance
                ManagementBaseObject inParams = mc.GetMethodParameters("Install"); //get object to set the parameters for the WMI "install" method

                //see https://msdn.microsoft.com/en-us/library/aa390890(v=vs.85).aspx for more details concerning the install method

                inParams["PackageLocation"] = AppStatic.SoftwareWareInstsall; //path of software to be installed on REMOTE PC. (NOT on a drive)
                inParams["Options"] = string.Empty; //default options (to install quitely for ex.)
                inParams["AllUsers"] = true; //software installed for all users or just logged on user

                ManagementBaseObject retVal = mc.InvokeMethod("Install", inParams, null);//Finally, invoke the method and receive the 
                                                                                         //installation status


                string code = retVal["ReturnValue"].ToString(); //view the returned value of the install method

                string msg = null; //message to be displayed according to int value

                switch (code)

                {

                    case "0":

                        msg = "The installation completed successfully.";

                        break;

                    case "2":

                        msg = "The system cannot find the specified file. \n\r\n\r" + bo.ApplicationPath;

                        break;

                    case "3":

                        msg = "The system cannot find the path specified. \n\r\n\r" + bo.ApplicationPath;

                        break;

                    case "1619":

                        msg = "This installation package \n\r\n\r " + bo.ApplicationPath + "\n\r\n\rcould not be opened, please verify that it is accessible.";

                        break;

                    case "1620":

                        msg = "This installation package \n\r\n\r " + bo.ApplicationPath + "\n\r\n\rcould not be opened, please verify that it is a valid MSI package.";

                        break;

                    default:

                        msg = "Please see... \n\r\n\r http://msdn.microsoft.com/library/default.asp?url=/library/en-us/msi/setup/error_codes.asp \n\r\n\rError code: " + code;

                        break;

                }

                // Display outParams

                errorLabel.Text = msg; //add message to Form3 to be displayed



            }//end try

            catch (Exception ex)
            {

                MessageBox.Show("Exception: " + ex.Message);

            }
        } //end install button

        private void btnBrowse_Click(object sender, EventArgs e) {
            string path = String.Empty;
            string test = "\\" + AppStatic.Workstation + "\\C$";
            AppStatic.RemotePath = test + "\\RemoteInstalls";

            if (!System.IO.Directory.Exists(path)) { System.IO.Directory.CreateDirectory(AppStatic.RemotePath); }

            this.fdbRemotePath.SelectedPath = AppStatic.RemotePath;

            if (!File.Exists(AppStatic.RemotePath + "\\" + AppStatic.MSIPackage)) { File.Copy(AppStatic.SoftwareWareInstsall, AppStatic.RemotePath + "\\" + AppStatic.MSIPackage); }
            this.errorLabel.Text = "Software is ready to be installed";
            this.installButton.Enabled = true;
            this.fdbRemotePath.ShowDialog();

            appPathTextBox.Text = this.fdbRemotePath.SelectedPath;

            AppStatic.SoftwareWareInstsall = appPathTextBox.Text + "\\" + this.tboxSoftwarePath.Text;


        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void appPathTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void appPathLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) {
            filedialogueBox.ShowDialog(this);
            AppStatic.MSIPackage = filedialogueBox.SafeFileName;
            this.tboxSoftwarePath.Text = AppStatic.MSIPackage;
            //AppStatic.SoftwareWareInstsall = appPathTextBox.Text+ "\\" + AppStatic.MSIPackage;
            //File.Copy( AppStatic.RemotePath + "\\" + AppStatic.MSIPackage);

        }
    } //end partial class
} //end namespace
        
            
                
            
            




                
            
            
            
            

       
    

