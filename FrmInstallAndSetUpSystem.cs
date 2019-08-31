using System;
using System.Windows.Forms;

namespace Installer
{
    public partial class FrmInstallAndSetUpSystem : Form
    {
        // This getter gets the selected path received by the 'FolderBrowserDialogPaths'.
        public string FolderBrowserSelectedPath
        {
            get { return FolderBrowserDialogPaths.SelectedPath; }
        }

        public string ProjectPath
        {
            set { TxtBxProjectPath.Text = value; }

            get { return TxtBxProjectPath.Text; }
        }

        public string WebsiteName
        {
            get { return TxtBxWebsiteName.Text; }
            set { TxtBxWebsiteName.Text = value; }
        }

        public string PortNumber
        {
            set { TxtBxPortNumber.Text = value; }
            get { return TxtBxPortNumber.Text; }
        }

        public string DatabaseName
        {
            set { TxtBxDatabaseName.Text = value; }
            get { return TxtBxDatabaseName.Text; }
        }

        public string DatabaseInstanceName
        {
            get { return TxtBxDatabaseInstanceName.Text; }
        }

        public string DatabaseUsername
        {
            get { return TxtBxDataBaseUsername.Text; }
        }

        public string DatabasePassword
        {
            get { return TxtBxDatabasePassword.Text; }
        }

        public string MDFPath
        {
            set { TxtBxMDFPath.Text = value; }
            get { return TxtBxMDFPath.Text; }
        }

        public string LDFPath
        {
            set { TxtBxLDFPath.Text = value; }
            get { return TxtBxLDFPath.Text; }
        }

        public string BackupPath
        {
            set { TxtBxBackupPath.Text = value; }
            get { return TxtBxBackupPath.Text; }
        }
        
        public string PublishPath { set; get; }

        public FrmInstallAndSetUpSystem(string publishPath)
        {
            PublishPath = publishPath;
            InitializeComponent();
        }

        private void FrmInstallAndSetUpSystem_Load(object sender, EventArgs e)
        {

        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            try
            {
                FrmFeaturesInstallation frmFeaturesInstallation = new FrmFeaturesInstallation(PublishPath);
                frmFeaturesInstallation.Show();
                Hide();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnInstallSoftware_Click(object sender, EventArgs e)
        {
            try
            {
                DataVerification dataVerification = new DataVerification(this);
                string verificationMessage = dataVerification.FinalVerification();
                if (verificationMessage.Equals(string.Empty))
                {
                    FrmSoftwareInstallation frmSoftwareInstallationObj = new FrmSoftwareInstallation(PublishPath, TxtBxWebsiteName.Text, TxtBxPortNumber.Text, TxtBxProjectPath.Text, TxtBxMDFPath.Text, TxtBxLDFPath.Text, TxtBxBackupPath.Text, TxtBxDatabaseName.Text, TxtBxDatabaseInstanceName.Text);
                    frmSoftwareInstallationObj.RestaurantCheckBox = CkeckBxRestaurant.Checked ? true : false;
                    frmSoftwareInstallationObj.WebServerDatabaseCheckBox = CheckBxWebServerDatabase.Checked ? true : false;
                    frmSoftwareInstallationObj.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show(verificationMessage);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnProjectPathBrowser_Click(object sender, EventArgs e)
        {
            try
            {
                DataVerification dataVerification = new DataVerification(this);
                DialogResult result = FolderBrowserDialogPaths.ShowDialog();
                if(result == DialogResult.OK)
                    dataVerification.ProjectPathVerification();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnVerification_Click(object sender, EventArgs e)
        {
            try
            {
                DataVerification dataVerification = new DataVerification(this);
                dataVerification.DatabaseConnectabilityVerification();
                BtnInstallSoftware.Enabled = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                TxtBxDatabaseName.Text = string.Empty;
                TxtBxDatabaseInstanceName.Text = string.Empty;
                TxtBxDataBaseUsername.Text = string.Empty;
                TxtBxDatabasePassword.Text = string.Empty;
            }
        }

        private void BtnMDFParhBrowser_Click(object sender, EventArgs e)
        {
            try
            {
                DataVerification dataVerification = new DataVerification(this);
                DialogResult result = FolderBrowserDialogPaths.ShowDialog();
                if (result == DialogResult.OK)
                    dataVerification.MDFPathVerification();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnLDFPathBrowser_Click(object sender, EventArgs e)
        {
            try
            {
                DataVerification dataVerification = new DataVerification(this);
                DialogResult result = FolderBrowserDialogPaths.ShowDialog();
                if (result == DialogResult.OK)
                    dataVerification.LDFPathVerification();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TxtBxMDFPath_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtBxLDFPath_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnBackupPathBrowser_Click(object sender, EventArgs e)
        {
            try
            {
                DataVerification dataVerification = new DataVerification(this);
                DialogResult result = FolderBrowserDialogPaths.ShowDialog();
                if (result == DialogResult.OK)
                    dataVerification.BackupPathVerification();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CheckBxWebServerDatabase_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBxWebServerDatabase.Checked)
            {
                TxtBxWebServerUsername.Enabled = true;
                TxtBxWebServerPassword.Enabled = true;
            }
            else
            {
                TxtBxWebServerUsername.Text = string.Empty;
                TxtBxWebServerPassword.Text = string.Empty;
                TxtBxWebServerUsername.Enabled = false;
                TxtBxWebServerPassword.Enabled = false;
            }
        }

        private void TxtBxPortNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtBxProjectPath_TextChanged(object sender, EventArgs e)
        {

        }
    }
}