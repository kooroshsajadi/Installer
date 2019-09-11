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
        // This property is defined in order to save whether the IIS got installed or not using the installer.
        public bool IISInstalled { set; get; }

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

                // Change the attribute which determines whether the IIS got installed using the app or not.
                // The purpose is to transfer the value to the last form.
                // In the last form it is asked if the user wants a restart wright now when IIS is installed completely.
                frmInstallAndSetUpSystem.IISInstalled = IISInstalled;

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
                        IISInstalled = true;
                    }
                    if (CheckBxKeyA.Checked)
                        installation.InstallKeyAAndLog();
                    if (CheckBxKasraPrintService.Checked)
                        installation.InstallKasraPrintServiceAndLog();
                    // Save the log in a physical path. Method 'SaveLog' is static.
                    string logFileName = "log1";
                    string storagePath = PublishPath + @"\App";
                    string log = TxtBxLog.Text;
                    FileManager.SaveLog(logFileName, storagePath, log);
                    BtnSoftwareInstallation.Enabled = false;
                    MessageBox.Show("." + "فرایند نصب با موفقیت کامل شد");
                });
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}