using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteAPC
{
   public class Business
    {   private string pcName;
        private string applicationPath;
        private string password;
        private string application;
        private string username;
        private string domain = "FDI.com";
        private string errorMessage;
       public string PCName
        {   get { return this.pcName; }
            set { this.pcName = value; }
        }     
        public string ApplicationPath
        {
            get { return this.applicationPath; }
            set { this.applicationPath = value; }
        }
        public string Password
        { get { return this.password; }
          set { this.password = value; }
        }
        public string Username
        {
            get { return this.username; }
            set { this.username = value; }
        }
        public string Domain
        {
            get { return this.domain; }
        }
        public string Application
        {
            get { return this.application; }
            set { this.application = value; }
        }
        public string ErrorMessage
        {
            get { return this.errorMessage; }
            set { this.errorMessage = value; }
        }

    }
}
