namespace Installer
{
    partial class FrmInstallAndSetUpSystem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GroupBxApplication = new System.Windows.Forms.GroupBox();
            this.TxtBxPortNumber = new System.Windows.Forms.TextBox();
            this.TxtBxWebsiteName = new System.Windows.Forms.TextBox();
            this.BtnProjectPathBrowser = new System.Windows.Forms.Button();
            this.TxtBxProjectPath = new System.Windows.Forms.TextBox();
            this.LbNote = new System.Windows.Forms.Label();
            this.LbProjectPath = new System.Windows.Forms.Label();
            this.LbPort = new System.Windows.Forms.Label();
            this.LbSiteName = new System.Windows.Forms.Label();
            this.GroupBxModuleSelection = new System.Windows.Forms.GroupBox();
            this.checkBxWebServer = new System.Windows.Forms.CheckBox();
            this.CkeckBxRestaurant = new System.Windows.Forms.CheckBox();
            this.BtnInstallSoftware = new System.Windows.Forms.Button();
            this.BtnPrevious = new System.Windows.Forms.Button();
            this.LbBankName = new System.Windows.Forms.Label();
            this.LbInstanceName = new System.Windows.Forms.Label();
            this.LbBankUsername = new System.Windows.Forms.Label();
            this.LbMDFPath = new System.Windows.Forms.Label();
            this.LbInstanceUsername = new System.Windows.Forms.Label();
            this.LbLDFPath = new System.Windows.Forms.Label();
            this.TxtBxDatabaseName = new System.Windows.Forms.TextBox();
            this.TxtBxDatabaseInstanceName = new System.Windows.Forms.TextBox();
            this.TxtBxDataBaseUsername = new System.Windows.Forms.TextBox();
            this.TxtBxDatabasePassword = new System.Windows.Forms.TextBox();
            this.TxtBxLDFPath = new System.Windows.Forms.TextBox();
            this.TxtBxMDFPath = new System.Windows.Forms.TextBox();
            this.LbBackupPath = new System.Windows.Forms.Label();
            this.GroupBxSQLServer = new System.Windows.Forms.GroupBox();
            this.BtnBackupPathBrowser = new System.Windows.Forms.Button();
            this.BtnLDFPathBrowser = new System.Windows.Forms.Button();
            this.BtnMDFParhBrowser = new System.Windows.Forms.Button();
            this.BtnVerification = new System.Windows.Forms.Button();
            this.TxtBxWebServerPassword = new System.Windows.Forms.TextBox();
            this.TxtBxWebServerUsername = new System.Windows.Forms.TextBox();
            this.LbWebServerPassword = new System.Windows.Forms.Label();
            this.LbWebServerUsername = new System.Windows.Forms.Label();
            this.CheckBxWebServerDatabase = new System.Windows.Forms.CheckBox();
            this.TxtBxBackupPath = new System.Windows.Forms.TextBox();
            this.FolderBrowserDialogPaths = new System.Windows.Forms.FolderBrowserDialog();
            this.GroupBxApplication.SuspendLayout();
            this.GroupBxModuleSelection.SuspendLayout();
            this.GroupBxSQLServer.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBxApplication
            // 
            this.GroupBxApplication.Controls.Add(this.TxtBxPortNumber);
            this.GroupBxApplication.Controls.Add(this.TxtBxWebsiteName);
            this.GroupBxApplication.Controls.Add(this.BtnProjectPathBrowser);
            this.GroupBxApplication.Controls.Add(this.TxtBxProjectPath);
            this.GroupBxApplication.Controls.Add(this.LbNote);
            this.GroupBxApplication.Controls.Add(this.LbProjectPath);
            this.GroupBxApplication.Controls.Add(this.LbPort);
            this.GroupBxApplication.Controls.Add(this.LbSiteName);
            this.GroupBxApplication.Location = new System.Drawing.Point(12, 12);
            this.GroupBxApplication.Name = "GroupBxApplication";
            this.GroupBxApplication.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GroupBxApplication.Size = new System.Drawing.Size(776, 105);
            this.GroupBxApplication.TabIndex = 0;
            this.GroupBxApplication.TabStop = false;
            this.GroupBxApplication.Text = "Application";
            // 
            // TxtBxPortNumber
            // 
            this.TxtBxPortNumber.BackColor = System.Drawing.Color.White;
            this.TxtBxPortNumber.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.TxtBxPortNumber.Location = new System.Drawing.Point(309, 19);
            this.TxtBxPortNumber.Name = "TxtBxPortNumber";
            this.TxtBxPortNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtBxPortNumber.Size = new System.Drawing.Size(131, 26);
            this.TxtBxPortNumber.TabIndex = 1;
            this.TxtBxPortNumber.Text = "80";
            this.TxtBxPortNumber.TextChanged += new System.EventHandler(this.TxtBxPortNumber_TextChanged);
            // 
            // TxtBxWebsiteName
            // 
            this.TxtBxWebsiteName.BackColor = System.Drawing.Color.White;
            this.TxtBxWebsiteName.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.TxtBxWebsiteName.Location = new System.Drawing.Point(507, 19);
            this.TxtBxWebsiteName.Name = "TxtBxWebsiteName";
            this.TxtBxWebsiteName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtBxWebsiteName.Size = new System.Drawing.Size(136, 26);
            this.TxtBxWebsiteName.TabIndex = 0;
            this.TxtBxWebsiteName.Text = "KasraEtime";
            // 
            // BtnProjectPathBrowser
            // 
            this.BtnProjectPathBrowser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnProjectPathBrowser.BackColor = System.Drawing.Color.Transparent;
            this.BtnProjectPathBrowser.BackgroundImage = global::Installer.Properties.Resources.Group_2193_min;
            this.BtnProjectPathBrowser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnProjectPathBrowser.FlatAppearance.BorderSize = 0;
            this.BtnProjectPathBrowser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProjectPathBrowser.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.BtnProjectPathBrowser.ForeColor = System.Drawing.Color.White;
            this.BtnProjectPathBrowser.Location = new System.Drawing.Point(309, 54);
            this.BtnProjectPathBrowser.Name = "BtnProjectPathBrowser";
            this.BtnProjectPathBrowser.Size = new System.Drawing.Size(80, 35);
            this.BtnProjectPathBrowser.TabIndex = 2;
            this.BtnProjectPathBrowser.Text = "انتخاب";
            this.BtnProjectPathBrowser.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnProjectPathBrowser.UseVisualStyleBackColor = false;
            this.BtnProjectPathBrowser.Click += new System.EventHandler(this.BtnProjectPathBrowser_Click);
            // 
            // TxtBxProjectPath
            // 
            this.TxtBxProjectPath.BackColor = System.Drawing.Color.White;
            this.TxtBxProjectPath.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.TxtBxProjectPath.Location = new System.Drawing.Point(395, 56);
            this.TxtBxProjectPath.Name = "TxtBxProjectPath";
            this.TxtBxProjectPath.ReadOnly = true;
            this.TxtBxProjectPath.Size = new System.Drawing.Size(248, 26);
            this.TxtBxProjectPath.TabIndex = 2;
            this.TxtBxProjectPath.TextChanged += new System.EventHandler(this.TxtBxProjectPath_TextChanged);
            // 
            // LbNote
            // 
            this.LbNote.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LbNote.AutoSize = true;
            this.LbNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbNote.Font = new System.Drawing.Font("Vazir", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.LbNote.ForeColor = System.Drawing.Color.Gray;
            this.LbNote.Location = new System.Drawing.Point(395, 85);
            this.LbNote.Name = "LbNote";
            this.LbNote.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LbNote.Size = new System.Drawing.Size(259, 15);
            this.LbNote.TabIndex = 4;
            this.LbNote.Text = ".را انتخاب نمایید C در این قسمت نام درایو مورد نظر به جز درایو ";
            // 
            // LbProjectPath
            // 
            this.LbProjectPath.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LbProjectPath.AutoSize = true;
            this.LbProjectPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbProjectPath.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.LbProjectPath.Location = new System.Drawing.Point(660, 56);
            this.LbProjectPath.Name = "LbProjectPath";
            this.LbProjectPath.Size = new System.Drawing.Size(86, 19);
            this.LbProjectPath.TabIndex = 1;
            this.LbProjectPath.Text = "مسیر درایو پروژه";
            // 
            // LbPort
            // 
            this.LbPort.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LbPort.AutoSize = true;
            this.LbPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbPort.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.LbPort.Location = new System.Drawing.Point(446, 22);
            this.LbPort.Name = "LbPort";
            this.LbPort.Size = new System.Drawing.Size(33, 19);
            this.LbPort.TabIndex = 1;
            this.LbPort.Text = "پورت";
            // 
            // LbSiteName
            // 
            this.LbSiteName.AutoSize = true;
            this.LbSiteName.BackColor = System.Drawing.Color.Transparent;
            this.LbSiteName.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.LbSiteName.Location = new System.Drawing.Point(660, 22);
            this.LbSiteName.Name = "LbSiteName";
            this.LbSiteName.Size = new System.Drawing.Size(59, 19);
            this.LbSiteName.TabIndex = 1;
            this.LbSiteName.Text = "اسم سایت";
            // 
            // GroupBxModuleSelection
            // 
            this.GroupBxModuleSelection.Controls.Add(this.checkBxWebServer);
            this.GroupBxModuleSelection.Controls.Add(this.CkeckBxRestaurant);
            this.GroupBxModuleSelection.Location = new System.Drawing.Point(12, 409);
            this.GroupBxModuleSelection.Name = "GroupBxModuleSelection";
            this.GroupBxModuleSelection.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GroupBxModuleSelection.Size = new System.Drawing.Size(776, 61);
            this.GroupBxModuleSelection.TabIndex = 2;
            this.GroupBxModuleSelection.TabStop = false;
            this.GroupBxModuleSelection.Text = "انتخاب ماژول ها";
            // 
            // checkBxWebServer
            // 
            this.checkBxWebServer.AutoSize = true;
            this.checkBxWebServer.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.checkBxWebServer.Location = new System.Drawing.Point(530, 32);
            this.checkBxWebServer.Name = "checkBxWebServer";
            this.checkBxWebServer.Size = new System.Drawing.Size(113, 23);
            this.checkBxWebServer.TabIndex = 1;
            this.checkBxWebServer.Text = "نصب وب سرویس";
            this.checkBxWebServer.UseVisualStyleBackColor = true;
            // 
            // CkeckBxRestaurant
            // 
            this.CkeckBxRestaurant.AutoSize = true;
            this.CkeckBxRestaurant.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.CkeckBxRestaurant.Location = new System.Drawing.Point(649, 32);
            this.CkeckBxRestaurant.Name = "CkeckBxRestaurant";
            this.CkeckBxRestaurant.Size = new System.Drawing.Size(121, 23);
            this.CkeckBxRestaurant.TabIndex = 0;
            this.CkeckBxRestaurant.Text = "نصب سیستم تغذیه";
            this.CkeckBxRestaurant.UseVisualStyleBackColor = true;
            // 
            // BtnInstallSoftware
            // 
            this.BtnInstallSoftware.BackColor = System.Drawing.Color.Transparent;
            this.BtnInstallSoftware.BackgroundImage = global::Installer.Properties.Resources.Group_2170_min;
            this.BtnInstallSoftware.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnInstallSoftware.Enabled = false;
            this.BtnInstallSoftware.FlatAppearance.BorderSize = 0;
            this.BtnInstallSoftware.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInstallSoftware.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.BtnInstallSoftware.ForeColor = System.Drawing.Color.White;
            this.BtnInstallSoftware.Location = new System.Drawing.Point(12, 476);
            this.BtnInstallSoftware.Name = "BtnInstallSoftware";
            this.BtnInstallSoftware.Size = new System.Drawing.Size(89, 35);
            this.BtnInstallSoftware.TabIndex = 3;
            this.BtnInstallSoftware.Text = "نصب نرم افزار";
            this.BtnInstallSoftware.UseVisualStyleBackColor = false;
            this.BtnInstallSoftware.Click += new System.EventHandler(this.BtnInstallSoftware_Click);
            // 
            // BtnPrevious
            // 
            this.BtnPrevious.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnPrevious.BackColor = System.Drawing.Color.Transparent;
            this.BtnPrevious.BackgroundImage = global::Installer.Properties.Resources.Group_2176_min;
            this.BtnPrevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPrevious.FlatAppearance.BorderSize = 0;
            this.BtnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPrevious.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.BtnPrevious.ForeColor = System.Drawing.Color.White;
            this.BtnPrevious.Location = new System.Drawing.Point(107, 476);
            this.BtnPrevious.Name = "BtnPrevious";
            this.BtnPrevious.Size = new System.Drawing.Size(89, 35);
            this.BtnPrevious.TabIndex = 4;
            this.BtnPrevious.Text = "بازگشت";
            this.BtnPrevious.UseVisualStyleBackColor = false;
            this.BtnPrevious.Click += new System.EventHandler(this.BtnPrevious_Click);
            // 
            // LbBankName
            // 
            this.LbBankName.AutoSize = true;
            this.LbBankName.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.LbBankName.Location = new System.Drawing.Point(660, 26);
            this.LbBankName.Name = "LbBankName";
            this.LbBankName.Size = new System.Drawing.Size(48, 19);
            this.LbBankName.TabIndex = 0;
            this.LbBankName.Text = "نام بانک";
            // 
            // LbInstanceName
            // 
            this.LbInstanceName.AutoSize = true;
            this.LbInstanceName.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.LbInstanceName.Location = new System.Drawing.Point(409, 28);
            this.LbInstanceName.Name = "LbInstanceName";
            this.LbInstanceName.Size = new System.Drawing.Size(70, 19);
            this.LbInstanceName.TabIndex = 1;
            this.LbInstanceName.Text = "نام اینستنس";
            // 
            // LbBankUsername
            // 
            this.LbBankUsername.AutoSize = true;
            this.LbBankUsername.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.LbBankUsername.Location = new System.Drawing.Point(661, 66);
            this.LbBankUsername.Name = "LbBankUsername";
            this.LbBankUsername.Size = new System.Drawing.Size(58, 19);
            this.LbBankUsername.TabIndex = 2;
            this.LbBankUsername.Text = "نام کاربری";
            // 
            // LbMDFPath
            // 
            this.LbMDFPath.AutoSize = true;
            this.LbMDFPath.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.LbMDFPath.Location = new System.Drawing.Point(657, 112);
            this.LbMDFPath.Name = "LbMDFPath";
            this.LbMDFPath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LbMDFPath.Size = new System.Drawing.Size(59, 19);
            this.LbMDFPath.TabIndex = 1;
            this.LbMDFPath.Text = "mdf مسیر";
            // 
            // LbInstanceUsername
            // 
            this.LbInstanceUsername.AutoSize = true;
            this.LbInstanceUsername.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.LbInstanceUsername.Location = new System.Drawing.Point(409, 66);
            this.LbInstanceUsername.Name = "LbInstanceUsername";
            this.LbInstanceUsername.Size = new System.Drawing.Size(47, 19);
            this.LbInstanceUsername.TabIndex = 3;
            this.LbInstanceUsername.Text = "رمز عبور";
            // 
            // LbLDFPath
            // 
            this.LbLDFPath.AutoSize = true;
            this.LbLDFPath.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.LbLDFPath.Location = new System.Drawing.Point(660, 145);
            this.LbLDFPath.Name = "LbLDFPath";
            this.LbLDFPath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LbLDFPath.Size = new System.Drawing.Size(51, 19);
            this.LbLDFPath.TabIndex = 2;
            this.LbLDFPath.Text = "ldf مسیر";
            // 
            // TxtBxDatabaseName
            // 
            this.TxtBxDatabaseName.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.TxtBxDatabaseName.Location = new System.Drawing.Point(507, 26);
            this.TxtBxDatabaseName.Name = "TxtBxDatabaseName";
            this.TxtBxDatabaseName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtBxDatabaseName.Size = new System.Drawing.Size(136, 26);
            this.TxtBxDatabaseName.TabIndex = 0;
            this.TxtBxDatabaseName.Text = "Framework";
            // 
            // TxtBxDatabaseInstanceName
            // 
            this.TxtBxDatabaseInstanceName.Font = new System.Drawing.Font("Vazir", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxDatabaseInstanceName.Location = new System.Drawing.Point(181, 26);
            this.TxtBxDatabaseInstanceName.Name = "TxtBxDatabaseInstanceName";
            this.TxtBxDatabaseInstanceName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtBxDatabaseInstanceName.Size = new System.Drawing.Size(222, 25);
            this.TxtBxDatabaseInstanceName.TabIndex = 1;
            // 
            // TxtBxDataBaseUsername
            // 
            this.TxtBxDataBaseUsername.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.TxtBxDataBaseUsername.Location = new System.Drawing.Point(507, 63);
            this.TxtBxDataBaseUsername.Name = "TxtBxDataBaseUsername";
            this.TxtBxDataBaseUsername.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtBxDataBaseUsername.Size = new System.Drawing.Size(136, 26);
            this.TxtBxDataBaseUsername.TabIndex = 2;
            this.TxtBxDataBaseUsername.Text = "sa";
            // 
            // TxtBxDatabasePassword
            // 
            this.TxtBxDatabasePassword.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.TxtBxDatabasePassword.Location = new System.Drawing.Point(267, 63);
            this.TxtBxDatabasePassword.Name = "TxtBxDatabasePassword";
            this.TxtBxDatabasePassword.PasswordChar = '*';
            this.TxtBxDatabasePassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtBxDatabasePassword.Size = new System.Drawing.Size(136, 26);
            this.TxtBxDatabasePassword.TabIndex = 3;
            // 
            // TxtBxLDFPath
            // 
            this.TxtBxLDFPath.BackColor = System.Drawing.Color.White;
            this.TxtBxLDFPath.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.TxtBxLDFPath.Location = new System.Drawing.Point(418, 145);
            this.TxtBxLDFPath.Name = "TxtBxLDFPath";
            this.TxtBxLDFPath.ReadOnly = true;
            this.TxtBxLDFPath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtBxLDFPath.Size = new System.Drawing.Size(225, 26);
            this.TxtBxLDFPath.TabIndex = 6;
            this.TxtBxLDFPath.TextChanged += new System.EventHandler(this.TxtBxLDFPath_TextChanged);
            // 
            // TxtBxMDFPath
            // 
            this.TxtBxMDFPath.BackColor = System.Drawing.Color.White;
            this.TxtBxMDFPath.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.TxtBxMDFPath.Location = new System.Drawing.Point(418, 105);
            this.TxtBxMDFPath.Name = "TxtBxMDFPath";
            this.TxtBxMDFPath.ReadOnly = true;
            this.TxtBxMDFPath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtBxMDFPath.Size = new System.Drawing.Size(225, 26);
            this.TxtBxMDFPath.TabIndex = 5;
            this.TxtBxMDFPath.TextChanged += new System.EventHandler(this.TxtBxMDFPath_TextChanged);
            // 
            // LbBackupPath
            // 
            this.LbBackupPath.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LbBackupPath.AutoSize = true;
            this.LbBackupPath.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.LbBackupPath.Location = new System.Drawing.Point(658, 181);
            this.LbBackupPath.Name = "LbBackupPath";
            this.LbBackupPath.Size = new System.Drawing.Size(61, 19);
            this.LbBackupPath.TabIndex = 11;
            this.LbBackupPath.Text = "مسیر بکاپ";
            // 
            // GroupBxSQLServer
            // 
            this.GroupBxSQLServer.Controls.Add(this.BtnBackupPathBrowser);
            this.GroupBxSQLServer.Controls.Add(this.BtnLDFPathBrowser);
            this.GroupBxSQLServer.Controls.Add(this.BtnMDFParhBrowser);
            this.GroupBxSQLServer.Controls.Add(this.BtnVerification);
            this.GroupBxSQLServer.Controls.Add(this.TxtBxWebServerPassword);
            this.GroupBxSQLServer.Controls.Add(this.TxtBxWebServerUsername);
            this.GroupBxSQLServer.Controls.Add(this.LbWebServerPassword);
            this.GroupBxSQLServer.Controls.Add(this.LbWebServerUsername);
            this.GroupBxSQLServer.Controls.Add(this.CheckBxWebServerDatabase);
            this.GroupBxSQLServer.Controls.Add(this.TxtBxBackupPath);
            this.GroupBxSQLServer.Controls.Add(this.LbBackupPath);
            this.GroupBxSQLServer.Controls.Add(this.TxtBxMDFPath);
            this.GroupBxSQLServer.Controls.Add(this.TxtBxLDFPath);
            this.GroupBxSQLServer.Controls.Add(this.TxtBxDatabasePassword);
            this.GroupBxSQLServer.Controls.Add(this.TxtBxDataBaseUsername);
            this.GroupBxSQLServer.Controls.Add(this.TxtBxDatabaseInstanceName);
            this.GroupBxSQLServer.Controls.Add(this.TxtBxDatabaseName);
            this.GroupBxSQLServer.Controls.Add(this.LbLDFPath);
            this.GroupBxSQLServer.Controls.Add(this.LbInstanceUsername);
            this.GroupBxSQLServer.Controls.Add(this.LbMDFPath);
            this.GroupBxSQLServer.Controls.Add(this.LbBankUsername);
            this.GroupBxSQLServer.Controls.Add(this.LbInstanceName);
            this.GroupBxSQLServer.Controls.Add(this.LbBankName);
            this.GroupBxSQLServer.Location = new System.Drawing.Point(12, 118);
            this.GroupBxSQLServer.Name = "GroupBxSQLServer";
            this.GroupBxSQLServer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GroupBxSQLServer.Size = new System.Drawing.Size(776, 285);
            this.GroupBxSQLServer.TabIndex = 1;
            this.GroupBxSQLServer.TabStop = false;
            this.GroupBxSQLServer.Text = "SQL Server";
            // 
            // BtnBackupPathBrowser
            // 
            this.BtnBackupPathBrowser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnBackupPathBrowser.BackColor = System.Drawing.Color.Transparent;
            this.BtnBackupPathBrowser.BackgroundImage = global::Installer.Properties.Resources.Group_2193_min;
            this.BtnBackupPathBrowser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBackupPathBrowser.FlatAppearance.BorderSize = 0;
            this.BtnBackupPathBrowser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBackupPathBrowser.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.BtnBackupPathBrowser.ForeColor = System.Drawing.Color.White;
            this.BtnBackupPathBrowser.Location = new System.Drawing.Point(323, 181);
            this.BtnBackupPathBrowser.Name = "BtnBackupPathBrowser";
            this.BtnBackupPathBrowser.Size = new System.Drawing.Size(80, 35);
            this.BtnBackupPathBrowser.TabIndex = 7;
            this.BtnBackupPathBrowser.Text = "انتخاب";
            this.BtnBackupPathBrowser.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnBackupPathBrowser.UseVisualStyleBackColor = false;
            this.BtnBackupPathBrowser.Click += new System.EventHandler(this.BtnBackupPathBrowser_Click);
            // 
            // BtnLDFPathBrowser
            // 
            this.BtnLDFPathBrowser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnLDFPathBrowser.BackColor = System.Drawing.Color.Transparent;
            this.BtnLDFPathBrowser.BackgroundImage = global::Installer.Properties.Resources.Group_2193_min;
            this.BtnLDFPathBrowser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnLDFPathBrowser.FlatAppearance.BorderSize = 0;
            this.BtnLDFPathBrowser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLDFPathBrowser.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.BtnLDFPathBrowser.ForeColor = System.Drawing.Color.White;
            this.BtnLDFPathBrowser.Location = new System.Drawing.Point(323, 143);
            this.BtnLDFPathBrowser.Name = "BtnLDFPathBrowser";
            this.BtnLDFPathBrowser.Size = new System.Drawing.Size(80, 35);
            this.BtnLDFPathBrowser.TabIndex = 6;
            this.BtnLDFPathBrowser.Text = "انتخاب";
            this.BtnLDFPathBrowser.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnLDFPathBrowser.UseVisualStyleBackColor = false;
            this.BtnLDFPathBrowser.Click += new System.EventHandler(this.BtnLDFPathBrowser_Click);
            // 
            // BtnMDFParhBrowser
            // 
            this.BtnMDFParhBrowser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnMDFParhBrowser.BackColor = System.Drawing.Color.Transparent;
            this.BtnMDFParhBrowser.BackgroundImage = global::Installer.Properties.Resources.Group_2193_min;
            this.BtnMDFParhBrowser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnMDFParhBrowser.FlatAppearance.BorderSize = 0;
            this.BtnMDFParhBrowser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMDFParhBrowser.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.BtnMDFParhBrowser.ForeColor = System.Drawing.Color.White;
            this.BtnMDFParhBrowser.Location = new System.Drawing.Point(323, 103);
            this.BtnMDFParhBrowser.Name = "BtnMDFParhBrowser";
            this.BtnMDFParhBrowser.Size = new System.Drawing.Size(80, 35);
            this.BtnMDFParhBrowser.TabIndex = 5;
            this.BtnMDFParhBrowser.Text = "انتخاب";
            this.BtnMDFParhBrowser.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnMDFParhBrowser.UseVisualStyleBackColor = false;
            this.BtnMDFParhBrowser.Click += new System.EventHandler(this.BtnMDFParhBrowser_Click);
            // 
            // BtnVerification
            // 
            this.BtnVerification.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnVerification.BackColor = System.Drawing.Color.Transparent;
            this.BtnVerification.BackgroundImage = global::Installer.Properties.Resources.Group_2169_min;
            this.BtnVerification.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnVerification.FlatAppearance.BorderSize = 0;
            this.BtnVerification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVerification.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.BtnVerification.ForeColor = System.Drawing.Color.White;
            this.BtnVerification.Location = new System.Drawing.Point(181, 61);
            this.BtnVerification.Name = "BtnVerification";
            this.BtnVerification.Size = new System.Drawing.Size(80, 35);
            this.BtnVerification.TabIndex = 4;
            this.BtnVerification.Text = "بررسی";
            this.BtnVerification.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnVerification.UseVisualStyleBackColor = false;
            this.BtnVerification.Click += new System.EventHandler(this.BtnVerification_Click);
            // 
            // TxtBxWebServerPassword
            // 
            this.TxtBxWebServerPassword.Enabled = false;
            this.TxtBxWebServerPassword.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.TxtBxWebServerPassword.Location = new System.Drawing.Point(267, 253);
            this.TxtBxWebServerPassword.Name = "TxtBxWebServerPassword";
            this.TxtBxWebServerPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtBxWebServerPassword.Size = new System.Drawing.Size(136, 26);
            this.TxtBxWebServerPassword.TabIndex = 10;
            // 
            // TxtBxWebServerUsername
            // 
            this.TxtBxWebServerUsername.Enabled = false;
            this.TxtBxWebServerUsername.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.TxtBxWebServerUsername.Location = new System.Drawing.Point(507, 253);
            this.TxtBxWebServerUsername.Name = "TxtBxWebServerUsername";
            this.TxtBxWebServerUsername.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtBxWebServerUsername.Size = new System.Drawing.Size(136, 26);
            this.TxtBxWebServerUsername.TabIndex = 9;
            // 
            // LbWebServerPassword
            // 
            this.LbWebServerPassword.AutoSize = true;
            this.LbWebServerPassword.Enabled = false;
            this.LbWebServerPassword.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.LbWebServerPassword.Location = new System.Drawing.Point(409, 256);
            this.LbWebServerPassword.Name = "LbWebServerPassword";
            this.LbWebServerPassword.Size = new System.Drawing.Size(47, 19);
            this.LbWebServerPassword.TabIndex = 17;
            this.LbWebServerPassword.Text = "رمز عبور";
            // 
            // LbWebServerUsername
            // 
            this.LbWebServerUsername.AutoSize = true;
            this.LbWebServerUsername.Enabled = false;
            this.LbWebServerUsername.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.LbWebServerUsername.Location = new System.Drawing.Point(661, 256);
            this.LbWebServerUsername.Name = "LbWebServerUsername";
            this.LbWebServerUsername.Size = new System.Drawing.Size(58, 19);
            this.LbWebServerUsername.TabIndex = 16;
            this.LbWebServerUsername.Text = "نام کاربری";
            // 
            // CheckBxWebServerDatabase
            // 
            this.CheckBxWebServerDatabase.AutoSize = true;
            this.CheckBxWebServerDatabase.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.CheckBxWebServerDatabase.Location = new System.Drawing.Point(431, 224);
            this.CheckBxWebServerDatabase.Name = "CheckBxWebServerDatabase";
            this.CheckBxWebServerDatabase.Size = new System.Drawing.Size(212, 23);
            this.CheckBxWebServerDatabase.TabIndex = 8;
            this.CheckBxWebServerDatabase.Text = "سرور بانک اصلاعاتی تحت شبکه میباشد";
            this.CheckBxWebServerDatabase.UseVisualStyleBackColor = true;
            this.CheckBxWebServerDatabase.CheckedChanged += new System.EventHandler(this.CheckBxWebServerDatabase_CheckedChanged);
            // 
            // TxtBxBackupPath
            // 
            this.TxtBxBackupPath.BackColor = System.Drawing.Color.White;
            this.TxtBxBackupPath.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.TxtBxBackupPath.Location = new System.Drawing.Point(418, 181);
            this.TxtBxBackupPath.Name = "TxtBxBackupPath";
            this.TxtBxBackupPath.ReadOnly = true;
            this.TxtBxBackupPath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TxtBxBackupPath.Size = new System.Drawing.Size(225, 26);
            this.TxtBxBackupPath.TabIndex = 7;
            // 
            // FrmInstallAndSetUpSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 511);
            this.Controls.Add(this.BtnPrevious);
            this.Controls.Add(this.GroupBxModuleSelection);
            this.Controls.Add(this.GroupBxSQLServer);
            this.Controls.Add(this.BtnInstallSoftware);
            this.Controls.Add(this.GroupBxApplication);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmInstallAndSetUpSystem";
            this.Text = "نصب و راه اندازی سیستم";
            this.Load += new System.EventHandler(this.FrmInstallAndSetUpSystem_Load);
            this.GroupBxApplication.ResumeLayout(false);
            this.GroupBxApplication.PerformLayout();
            this.GroupBxModuleSelection.ResumeLayout(false);
            this.GroupBxModuleSelection.PerformLayout();
            this.GroupBxSQLServer.ResumeLayout(false);
            this.GroupBxSQLServer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBxApplication;
        private System.Windows.Forms.GroupBox GroupBxModuleSelection;
        private System.Windows.Forms.Button BtnInstallSoftware;
        private System.Windows.Forms.Button BtnPrevious;
        private System.Windows.Forms.TextBox TxtBxProjectPath;
        private System.Windows.Forms.Label LbNote;
        private System.Windows.Forms.Label LbProjectPath;
        private System.Windows.Forms.Label LbPort;
        private System.Windows.Forms.Label LbSiteName;
        private System.Windows.Forms.Button BtnProjectPathBrowser;
        private System.Windows.Forms.TextBox TxtBxPortNumber;
        private System.Windows.Forms.TextBox TxtBxWebsiteName;
        private System.Windows.Forms.CheckBox checkBxWebServer;
        private System.Windows.Forms.CheckBox CkeckBxRestaurant;
        private System.Windows.Forms.Label LbBankName;
        private System.Windows.Forms.Label LbInstanceName;
        private System.Windows.Forms.Label LbBankUsername;
        private System.Windows.Forms.Label LbMDFPath;
        private System.Windows.Forms.Label LbInstanceUsername;
        private System.Windows.Forms.Label LbLDFPath;
        private System.Windows.Forms.TextBox TxtBxDatabaseName;
        private System.Windows.Forms.TextBox TxtBxDatabaseInstanceName;
        private System.Windows.Forms.TextBox TxtBxDataBaseUsername;
        private System.Windows.Forms.TextBox TxtBxDatabasePassword;
        private System.Windows.Forms.TextBox TxtBxLDFPath;
        private System.Windows.Forms.TextBox TxtBxMDFPath;
        private System.Windows.Forms.Label LbBackupPath;
        private System.Windows.Forms.GroupBox GroupBxSQLServer;
        private System.Windows.Forms.TextBox TxtBxWebServerPassword;
        private System.Windows.Forms.TextBox TxtBxWebServerUsername;
        private System.Windows.Forms.Label LbWebServerPassword;
        private System.Windows.Forms.Label LbWebServerUsername;
        private System.Windows.Forms.CheckBox CheckBxWebServerDatabase;
        private System.Windows.Forms.TextBox TxtBxBackupPath;
        protected System.Windows.Forms.FolderBrowserDialog FolderBrowserDialogPaths;
        private System.Windows.Forms.Button BtnVerification;
        private System.Windows.Forms.Button BtnLDFPathBrowser;
        private System.Windows.Forms.Button BtnMDFParhBrowser;
        private System.Windows.Forms.Button BtnBackupPathBrowser;
    }
}