using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace Installer
{
    public class FileManager
    {
        public FrmSoftwareInstallation FrmSoftwareInstallationObj { set; get; }

        public FileManager(FrmSoftwareInstallation frmSoftwareInstallationObj)
        {
            FrmSoftwareInstallationObj = frmSoftwareInstallationObj;
        }

        public void CreateKasraDirectory()
        {
            try
            {
                // Define 'Kasra' directory.
                string dir = FrmSoftwareInstallationObj.ProjectPath + "\\Kasra";

                // Create 'Kasra' directory.
                Directory.CreateDirectory(dir);

                // Create 'Etc' directory in 'Kasra'.
                Directory.CreateDirectory(dir + "\\Etc");

                // Create 'Patch' directory in 'Kasra'.
                Directory.CreateDirectory(dir + "\\Patch");

                // Create 'Lock' directory in 'Kasra'.
                Directory.CreateDirectory(dir + "\\Lock");

                // Create 'Project' directory in 'Kasra' to send the publish files into.
                Directory.CreateDirectory(dir + "\\Project");
                Directory.CreateDirectory(dir + "\\Project\\" + FrmSoftwareInstallationObj.WebsiteName);

                if(FrmSoftwareInstallationObj.MDFPath == FrmSoftwareInstallationObj.ProjectPath)
                {
                    // Create 'Etc' directory in 'Kasra'.
                    Directory.CreateDirectory(dir + "\\Data");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void CreateAutoBackupDirectory()
        {
            try
            {
                // Define 'AutoBackup' directory.
                string dir = FrmSoftwareInstallationObj.BackupPath + "\\AutoBackup";

                // Create 'AutoBackup' directory.
                Directory.CreateDirectory(dir);

                // Create 'Full' directory in 'AutoBackup'.
                Directory.CreateDirectory(dir + "\\Full");

                // Create 'Log' directory in 'AutoBackup'.
                Directory.CreateDirectory(dir + "\\Log");

                // Create 'Diff' directory in 'AutoBackup'.
                Directory.CreateDirectory(dir + "\\Diff");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void CopyAndLog()
        {
            try
            {
                string publishPath = FrmSoftwareInstallationObj.PublishPath + "\\App";
                // Save the project path where the publish files should be copied to.
                string projectPath = FrmSoftwareInstallationObj.ProjectPath + @"Kasra\Project\" + FrmSoftwareInstallationObj.WebsiteName;


                // Count all the files available in the publish path.
                int allFiles = Directory.GetFiles(publishPath, "*.*", SearchOption.AllDirectories).Length;
                int count = 0;

                // Create a folder named as the name of the website.
                Directory.CreateDirectory(projectPath);

                //Now Create all of the directories
                foreach (string dirPath in Directory.GetDirectories(publishPath, "*", SearchOption.AllDirectories))
                    Directory.CreateDirectory(dirPath.Replace(publishPath, projectPath));

                //Copies all the files & Replaces any file with the same name
                foreach (string newPath in Directory.GetFiles(publishPath, "*.*", SearchOption.AllDirectories))
                {
                    string s = newPath.Replace(publishPath, projectPath);
                    File.Copy(newPath, s, true);
                    count++;
                    FrmSoftwareInstallationObj.ProgressBarValue = count * 100 / allFiles;

                    // Log the copied information.
                    FrmSoftwareInstallationObj.TextAppend = DateTime.Now + "\r\nفایل " + Path.GetFileName(newPath) + " به مسیر " + s + " کپی شد.\r\n\r\n";
                }

                // Log that all the publish path files have been copied.
                FrmSoftwareInstallationObj.TextAppend = "\r\n" + DateTime.Now + "\r\nفایل های داخل مسیر پابلیش کامل و با موفقیت به مسیر پروژه کپی شدند.\r\n\r\n";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void SaveLog(string logFileName, string storagePath, string log)
        {
            try
            {
                string path = storagePath + @"\" + logFileName + ".txt";
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.Write(log);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void RestoreDatabase()
        {
            // Create 'Data' directory.
            string dir = FrmSoftwareInstallationObj.ProjectPath + "Kasra\\Data";
            Directory.CreateDirectory(dir);

            // Create the connection string.
            string connectionString = "Password=" + FrmSoftwareInstallationObj.Password + ";Persist Security Info=True;User ID=" + FrmSoftwareInstallationObj.Username + ";Initial Catalog=master" + ";Data Source=" + FrmSoftwareInstallationObj.InstanceName;

            SqlConnection cnn = new SqlConnection(connectionString);

            string path = FrmSoftwareInstallationObj.ProjectPath + "Kasra\\Data";

            string query = $@"CREATE DATABASE {FrmSoftwareInstallationObj.DatabaseName} ON PRIMARY 
                            (NAME = {FrmSoftwareInstallationObj.DatabaseName}_Data, 
                            FILENAME = '{path}\{FrmSoftwareInstallationObj.DatabaseName}.mdf', 
                            SIZE = 2MB, MAXSIZE = 10MB, FILEGROWTH = 10%) 
                            LOG ON (NAME = {FrmSoftwareInstallationObj.DatabaseName}_Log, 
                            FILENAME = '{path}\{FrmSoftwareInstallationObj.DatabaseName}.ldf', 
                            SIZE = 1MB, MAXSIZE = 5MB, FILEGROWTH = 10%)";
            try
            {
                SqlCommand myCommand = new SqlCommand(query, cnn);
                cnn.Open();
                myCommand.ExecuteNonQuery();

                // Go to the path in which contains all the querries.
                string pathToContainingFolder = Environment.CurrentDirectory + "\\ScriptsForInstaller";
                
                // Exceute the queries related to dropping the login and user.
                string q1 = File.ReadAllText(pathToContainingFolder + "/1.txt");
                string q2 = File.ReadAllText(pathToContainingFolder + "/2.txt");
                DropLoginOrUserOnExist(q1, q2);

                // Excute the queries related to creationg the login and user and EXEC.
                q1 = File.ReadAllText(pathToContainingFolder + "/3.txt");
                q2 = File.ReadAllText(pathToContainingFolder + "/4.txt");
                string q3 = File.ReadAllText(pathToContainingFolder + "/5.txt");
                CreateLoginOrUserAndExec(q1, q2, q3);

                // Execute the other queries.
                for(int i = 6; i <= 14; i++)
                {
                    q3 = File.ReadAllText(pathToContainingFolder + "/" + i + ".txt");
                    myCommand = new SqlCommand(q3, cnn);
                    myCommand.ExecuteNonQuery();
                }

                // Now restore the .bak file stored in Db folder.
                string pathToBAK = FrmSoftwareInstallationObj.PublishPath + $@"\Db\db.bak";
                connectionString += ";Integrated Security=True";
                cnn.Close();
                cnn = new SqlConnection(connectionString);
                cnn.Open();
                q3 = "Alter Database " + FrmSoftwareInstallationObj.DatabaseName + " SET SINGLE_USER WITH ROLLBACK IMMEDIATE;";
                q3 += "Restore Database " + FrmSoftwareInstallationObj.DatabaseName + " FROM DISK ='" + pathToBAK + "' WITH REPLACE;";
                myCommand = new SqlCommand(q3, cnn);
                myCommand.CommandTimeout = 0;
                myCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                if (cnn.State == System.Data.ConnectionState.Open)
                {
                    cnn.Close();
                }
            }
        }
        private void CreateLoginOrUserAndExec(string query1, string query2, string query3)
        {
            // Create the essential variables to connect to the SQL server.
            string connectionString;
            SqlConnection cnn;
            SqlCommand myCommand;
            try
            {
                // Execute the query related to creating login in the 'master' database.
                connectionString = "Password=" + FrmSoftwareInstallationObj.Password + ";Persist Security Info=True;User ID=" + FrmSoftwareInstallationObj.Username + ";Initial Catalog=master;Data Source=" + FrmSoftwareInstallationObj.InstanceName;
                cnn = new SqlConnection(connectionString);
                myCommand = new SqlCommand(query1, cnn);
                cnn.Open();
                myCommand.ExecuteNonQuery();

                // Now execute the query related to creating the user in each database except the 'master'
                // and then run the EXEC query.
                string[] dataBases = { FrmSoftwareInstallationObj.DatabaseName, "model", "tempdb" };

                for (int i = 0; i < dataBases.Length; i++)
                {
                    connectionString = "Password=" + FrmSoftwareInstallationObj.Password + ";Persist Security Info=True;User ID=" + FrmSoftwareInstallationObj.Username + ";Initial Catalog=" + dataBases[i] + ";Data Source=" + FrmSoftwareInstallationObj.InstanceName;
                    cnn = new SqlConnection(connectionString);
                    myCommand = new SqlCommand(query2, cnn);
                    cnn.Open();
                    myCommand.ExecuteNonQuery();

                    myCommand = new SqlCommand(query3, cnn);
                    myCommand.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void DropLoginOrUserOnExist(string query1, string query2)
        {
            // Create the essential variables to connect to the SQL server.
            string connectionString;
            SqlConnection cnn;
            SqlCommand myCommand;

            try
            {
                // Execute the query related to droping login in the 'master' database.
                connectionString = "Password=" + FrmSoftwareInstallationObj.Password + ";Persist Security Info=True;User ID=" + FrmSoftwareInstallationObj.Username + ";Initial Catalog=master;Data Source=" + FrmSoftwareInstallationObj.InstanceName;
                cnn = new SqlConnection(connectionString);
                myCommand = new SqlCommand(query1, cnn);
                cnn.Open();
                myCommand.ExecuteNonQuery();

                // Now execute the query related to dropping the user in each database except the 'master'.
                string[] dataBases = { FrmSoftwareInstallationObj.DatabaseName, "model", "tempdb" };

                for (int i = 0; i < dataBases.Length; i++)
                {
                    connectionString = "Password=" + FrmSoftwareInstallationObj.Password + ";Persist Security Info=True;User ID=" + FrmSoftwareInstallationObj.Username + ";Initial Catalog=" + dataBases[i] + ";Data Source=" + FrmSoftwareInstallationObj.InstanceName;
                    cnn = new SqlConnection(connectionString);
                    myCommand = new SqlCommand(query2, cnn);
                    cnn.Open();
                    myCommand.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}