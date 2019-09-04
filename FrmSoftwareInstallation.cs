using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Installer
{
    public partial class FrmSoftwareInstallation : Form
    {
        private SynchronizationContext synchronizationContext;
        
        public string PublishPath { set; get; }
        public string WebsiteName { set; get; }
        public string PortNumber { set; get; }
        public string ProjectPath { set; get; }
        public string DatabaseName { set; get; }
        public string InstanceName { set; get; }
        public string Username { set; get; }
        public string Password { set; get; }
        public string MDFPath { set; get; }
        public string LDFPath { set; get; }
        public string BackupPath { set; get; }
        public bool RestaurantCheckBox { set; get; }
        public bool WebServiceCheckBox { set; get; }
        public bool WebServerDatabaseCheckBox { set; get; }
        public int ProgressBarValue
        {
            get { return ProgressBar.Value; }
            set
            {
                synchronizationContext.Post(o =>
                {
                    ProgressBar.Value = int.Parse(o.ToString());
                }, value);
            }
        }
        public string TextAppend
        {
            set
            {
                synchronizationContext.Post(o =>
                {
                    TxtBxLog.AppendText(o.ToString());
                }, value);
            }
        }

        public FrmSoftwareInstallation(string publishPath, string websiteName, string portNumber, string projectPath, string mDFPath, string lDFPath, string backupPath, string databaseName, string instanceName, string username, string password)
        {
            PublishPath = publishPath;
            WebsiteName = websiteName;
            PortNumber = portNumber;
            ProjectPath = projectPath;
            MDFPath = mDFPath;
            LDFPath = lDFPath;
            BackupPath = backupPath;
            DatabaseName = databaseName;
            InstanceName = instanceName;
            Username = username;
            Password = password;
            InitializeComponent();
        }

        private void ProgressBar_Click(object sender, EventArgs e)
        {

        }

        private void FrmSoftwareInstallation_Load(object sender, EventArgs e)
        {
            try
            {
                synchronizationContext = SynchronizationContext.Current;
                TxtBxLog.AppendText("در حال ساختن فولدر های لازم...\r\n\r\n");
                Task.Run(() =>
                {
                    
                    FileManager fileMngObj = new FileManager(this);

                    //fileMngObj.CreateKasraDirectory();
                    //fileMngObj.CreateAutoBackupDirectory();
                    fileMngObj.RestoreDatabase();
                    // Copy the essential files into the project folder in order to configure the website.
                    //fileMngObj.CopyAndLog();
                    Installation installation = new Installation(this);
                    //installation.ConfigureWebsite();
                    // Log that the site configuration was a success.
                    TextAppend = "\r\n\r\n" + DateTime.Now + "\r\nسایت با موفقیت ساخته شد.";
                    // Save the log in a physical path. Method 'SaveLog' is static.
                    string logFileName = "log2";
                    string storagePath = ProjectPath + @"Kasra\Project\" + WebsiteName;
                    string log = TxtBxLog.Text;
                    FileManager.SaveLog(logFileName, storagePath, log);
                    MessageBox.Show("." + "فرایند نصب با موفقیت تکمیل شد");
                });

                Task.Run(() =>
                {
                    FileManager fileMngObj = new FileManager(this);
                    fileMngObj.RestoreDatabase();
                });
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TxtBxLog_TextChanged(object sender, EventArgs e)
        {

        }
    }
}