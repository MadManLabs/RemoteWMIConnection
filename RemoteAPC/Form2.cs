using System;
using System.Management;
using System.Windows.Forms;


namespace RemoteAPC
{
    public partial class Form2 : Form
    {
        public Business bo;
        public Form2(Business bo) //constructor 
        {
            InitializeComponent();
            this.bo = bo;
        }

        private void Form2_Load(object sender, EventArgs e) { }
        private void uninstallBtn_Click(object sender, EventArgs e)
        {
            if (view.SelectedIndex > -1) //if there was a selection in the list box
            { bo.Application = view.SelectedItem.ToString(); } //set application to be uninstalled
            else { installLabel.Text = "select something"; }
            string ProgramName = bo.Application;
            ManagementScope scope = new ManagementScope("\\\\" + bo.PCName + "\\root\\CIMV2"); //set scope to remote pc
            ObjectQuery query = new ObjectQuery("SELECT * FROM Win32_Product WHERE Name = '" + ProgramName + "'");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(scope, query);
            try
            {

                scope.Connect();

                foreach (ManagementObject mo in searcher.Get())
                {
                    try
                    {
                        if (mo["Name"].ToString() == ProgramName)
                        {
                            object hr = mo.InvokeMethod("Uninstall", null); installLabel.Text = "Uninstalled successfuly";
                        }
                    }
                    catch
                    { installLabel.Text = "uninstall unsuccessful"; }
                }
            }
            catch { installLabel.Text = "Error "; }
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
    }
}
