using Microsoft.Web.Administration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace Installer
{
    class DataVerification
    {

        // This property is defined in order to get access to the data available in FrmInstallAndSetUpSystem.
        FrmInstallAndSetUpSystem FrmInstallAndSetUpSystemObj { set; get; }

        public DataVerification(FrmInstallAndSetUpSystem frmInstallAndSetUpSystem)
        {
            FrmInstallAndSetUpSystemObj = frmInstallAndSetUpSystem;
        }

        // This method connects to the IIS and checks the website names available in it
        // to find out if the 'websiteName' string is equal to any one of them or not.
        // If it finds equality, the the field related to the website name will get cleared.
        private string WebsiteNameVerification()
        {
            if (FrmInstallAndSetUpSystemObj.WebsiteName == string.Empty)
                return "!" + "نام سایت انتخاب نشده";
            else
            {
                bool exists = false;

                using (ServerManager manager = new ServerManager())
                {
                    exists = manager.Sites.Any(t => t.Name == FrmInstallAndSetUpSystemObj.WebsiteName);
                }
                if (exists)
                {
                    FrmInstallAndSetUpSystemObj.WebsiteName = string.Empty;
                    return "!" + "وبسایتی با این نام در سرور موجود است";
                }
                else
                    return string.Empty;
            }
            
        }

        // This method checks if the port number is valid integer and then checks for its availability.
        private string PortNumberVerification()
        {
            int portNumber = 0;
            if (FrmInstallAndSetUpSystemObj.PortNumber == string.Empty)
                return "!" + "پورت انتخاب نشده";

            else if (!int.TryParse(FrmInstallAndSetUpSystemObj.PortNumber, out portNumber))
            {
                FrmInstallAndSetUpSystemObj.PortNumber = string.Empty;
                return "!" + "عدد پورت اشتباه است";
            }

            else
            {
                IPGlobalProperties ipProperties = IPGlobalProperties.GetIPGlobalProperties();
                IPEndPoint[] ipEndPoints = ipProperties.GetActiveTcpListeners();
                bool result = ipEndPoints.ToList().Any(x => x.Port == portNumber);
                if (result)
                {
                    FrmInstallAndSetUpSystemObj.PortNumber = string.Empty;
                    return "!" + "این پورت در دسترس نیست لطفا شماره ی دیگری انتخاب کنید";
                }
                return string.Empty;
            }
        }

        // This method checks the connectability to the database.
        public void DatabaseConnectabilityVerification()
        {
            try
            {
                // Try to open the SQL server using the connection string.
                string connectionString = "Password=" + FrmInstallAndSetUpSystemObj.DatabasePassword + ";Persist Security Info=True;User ID=" + FrmInstallAndSetUpSystemObj.DatabaseUsername + ";Initial Catalog=master" + ";Data Source=" + FrmInstallAndSetUpSystemObj.DatabaseInstanceName;
                SqlConnection cnn = new SqlConnection(connectionString);
                cnn.Open();

                // Get the list of the databases in the server and check whether the given name is contained or not.
                List<string> list = GetDatabaseList(cnn);

                // This valriable turns to true if a database with the same name exists.
                bool databaseExists = false;
                // This variable will hold the database name which is equivalent to the given name.
                string databaseName = "";
                // The database names musn't be the same even if their characters differ in being lower or upper case.
                for(int i = 0; i < list.Count; i++)
                {
                    if(list[i].ToLower() == FrmInstallAndSetUpSystemObj.DatabaseName.ToLower())
                    {
                        databaseExists = true;
                        databaseName = list[i];
                        break;
                    }
                }
                if (databaseExists)
                {
                    MessageBox.Show("!" + "در سرور موجود است" + "." + "لطفا نام دیگری انتخاب کنید " + databaseName + " دیتابیسی با نام");
                    FrmInstallAndSetUpSystemObj.DatabaseName = string.Empty;
                }
                else
                    MessageBox.Show("." + "اتصال تایید شد");

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private static List<string> GetDatabaseList(SqlConnection cnn)
        {
            List<string> list = new List<string>();
            using (SqlCommand cmd = new SqlCommand("SELECT name from master.sys.databases", cnn))
            {
                using (IDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        list.Add(dr[0].ToString());
                    }
                }
            }
            return list;
        }
        public void ProjectPathVerification()
        {
            if (FrmInstallAndSetUpSystemObj.FolderBrowserSelectedPath.StartsWith("C"))
                MessageBox.Show("!" + "باشد " + "C " + "درایو انتخاب شده نباید درایو ");
            else if (FrmInstallAndSetUpSystemObj.FolderBrowserSelectedPath.Length != 3)
                MessageBox.Show("." + "را انتخاب کنید " + "C " + "در این قسمت فقط باید نام یک درایو به غیر از درایو ");
            else
                FrmInstallAndSetUpSystemObj.ProjectPath = FrmInstallAndSetUpSystemObj.FolderBrowserSelectedPath;
        }

        public void MDFPathVerification()
        {
            if (FrmInstallAndSetUpSystemObj.FolderBrowserSelectedPath.StartsWith("C"))
                MessageBox.Show("!" + "باشد " + "C " + "نباید در درایو " + "MDF " + "مسیر ");
            else
                FrmInstallAndSetUpSystemObj.MDFPath = FrmInstallAndSetUpSystemObj.FolderBrowserSelectedPath;
        }

        public void LDFPathVerification()
        {
            if (FrmInstallAndSetUpSystemObj.FolderBrowserSelectedPath.StartsWith("C"))
                MessageBox.Show("!" + "باشد " + "C " + "نباید در درایو " +"LDF " + "مسیر ");
            else
                FrmInstallAndSetUpSystemObj.LDFPath = FrmInstallAndSetUpSystemObj.FolderBrowserSelectedPath;
        }

        public void BackupPathVerification()
        {
            if (FrmInstallAndSetUpSystemObj.FolderBrowserSelectedPath.StartsWith("C"))
                MessageBox.Show("!" + "باشد " +"C " + "مسیر بکاپ گیری نباید در درایو ");
            else
                FrmInstallAndSetUpSystemObj.BackupPath = FrmInstallAndSetUpSystemObj.FolderBrowserSelectedPath;
        }

        // This method checks if any of the port number, website name, project path, MDF path,
        // LDF path, or backup path fields in the FrmInstallAndSetUPSystem is not empty, then adds its corresping string message
        // to the final verification message.
        public string FinalVerification()
        {
            // Create the final verification string.
            string finalMessage = string.Empty;

            // Add the port number verification message if it is not empty.
            string portNumberMessage = PortNumberVerification();
            if (portNumberMessage != string.Empty)
                finalMessage += portNumberMessage + "\n";

            // Add the website name verification message if it is not empty.
            string websiteNameMessage = WebsiteNameVerification();
            if (websiteNameMessage != string.Empty)
                finalMessage += websiteNameMessage + "\n";

            // Add the project path verification message if it is not empty.
            string projectPathMessage = (FrmInstallAndSetUpSystemObj.MDFPath == string.Empty) ? "!" + "مسیر پروژه انتخاب نشده\n" : string.Empty;
            if (projectPathMessage != string.Empty)
                finalMessage += projectPathMessage;

            // Add the MDF path verification message if it is not empty.
            string mDFPathMessage = (FrmInstallAndSetUpSystemObj.MDFPath == string.Empty) ? "!" + "انتخاب نشده " + "MDF " +"مسیر\n" : string.Empty;
            if (mDFPathMessage != string.Empty)
                finalMessage += mDFPathMessage;

            // Add the LDF verification message if it is not empty.
            string lDFPathMessage = (FrmInstallAndSetUpSystemObj.LDFPath == string.Empty) ? "!" + "انتخاب نشده " + "LDF " + "مسیر\n" : string.Empty;
            if (lDFPathMessage != string.Empty)
                finalMessage += lDFPathMessage;

            // Add the backup path verification message if it is not empty.
            string backupPathMessage = (FrmInstallAndSetUpSystemObj.BackupPath == string.Empty) ? "!" + "مسیر بکاپ گیری انتخاب نشده\n" : string.Empty;
            if (backupPathMessage != string.Empty)
                finalMessage += backupPathMessage;

            // If the final verification message is not enmty, return it.
            if (finalMessage != string.Empty)
                return finalMessage;

            // Otherwise an empty string is returned.
            return string.Empty;
        }
    }
}