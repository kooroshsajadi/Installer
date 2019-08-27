using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Installer
{
    public partial class FrmFeaturesInstallation : Form
    {
        private SynchronizationContext synchronizationContext;

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
        public string PublishPath { set; get; }
        public FrmFeaturesInstallation(string publishPath)
        {
            PublishPath = publishPath;
            InitializeComponent();
        }

        private void FrmFeaturesInstallation_Load(object sender, EventArgs e)
        {
            synchronizationContext = SynchronizationContext.Current;
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            try
            {
                FrmPrerequisites frmPrerequisites = new FrmPrerequisites();
                frmPrerequisites.Show();
                Hide();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            try
            {
                FrmInstallAndSetUpSystem frmInstallAndSetUpSystem = new FrmInstallAndSetUpSystem(PublishPath);
                frmInstallAndSetUpSystem.Show();
                Hide();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnSoftwareInstallation_Click(object sender, EventArgs e)
        {
            try
            {
                // This part enables IIS features on the system.
                TxtBxLog.AppendText("در حال نصب..." + "\r\n\r\n");
                Task.Run(() =>
                {
                    Installation installation = new Installation(this);
                    if (CheckBxIIS.Checked)
                    {
                        installation.InstallIISAndLog();
                        installation.InstallKeyAAndLog();
                        installation.InstallKasraPointServiceSetupAndLog();
                    }
                    else
                    {
                        if (CheckBxKeyA.Checked)
                            installation.InstallKeyAAndLog();
                        if (CheckBxKasraPointService.Checked)
                            installation.InstallKasraPointServiceSetupAndLog();
                    }   
                    // Save the log in a physical path. Method 'SaveLog' is static.
                    string logFileName = "log1";
                    string storagePath = PublishPath + @"\App";
                    string log = TxtBxLog.Text;
                    FileManager.SaveLog(logFileName, storagePath, log);
                });
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}