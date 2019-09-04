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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.GroupBxApplication.Location = new System.Drawing.Point(12, 41);
            this.GroupBxApplication.Name = "GroupBxApplication";
            this.GroupBxApplication.Size = new System.Drawing.Size(776, 100);
            this.GroupBxApplication.TabIndex = 0;
            this.GroupBxApplication.TabStop = false;
            this.GroupBxApplication.Text = "Application";
            // 
            // TxtBxPortNumber
            // 
            this.TxtBxPortNumber.Location = new System.Drawing.Point(445, 14);
            this.TxtBxPortNumber.Name = "TxtBxPortNumber";
            this.TxtBxPortNumber.Size = new System.Drawing.Size(91, 21);
            this.TxtBxPortNumber.TabIndex = 1;
            this.TxtBxPortNumber.Text = "80";
            this.TxtBxPortNumber.TextChanged += new System.EventHandler(this.TxtBxPortNumber_TextChanged);
            // 
            // TxtBxWebsiteName
            // 
            this.TxtBxWebsiteName.Location = new System.Drawing.Point(597, 14);
            this.TxtBxWebsiteName.Name = "TxtBxWebsiteName";
            this.TxtBxWebsiteName.Size = new System.Drawing.Size(100, 21);
            this.TxtBxWebsiteName.TabIndex = 0;
            this.TxtBxWebsiteName.Text = "KasraEtime";
            // 
            // BtnProjectPathBrowser
            // 
            this.BtnProjectPathBrowser.Location = new System.Drawing.Point(445, 55);
            this.BtnProjectPathBrowser.Name = "BtnProjectPathBrowser";
            this.BtnProjectPathBrowser.Size = new System.Drawing.Size(27, 22);
            this.BtnProjectPathBrowser.TabIndex = 2;
            this.BtnProjectPathBrowser.Text = "...";
            this.BtnProjectPathBrowser.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnProjectPathBrowser.UseVisualStyleBackColor = true;
            this.BtnProjectPathBrowser.Click += new System.EventHandler(this.BtnProjectPathBrowser_Click);
            // 
            // TxtBxProjectPath
            // 
            this.TxtBxProjectPath.Location = new System.Drawing.Point(479, 55);
            this.TxtBxProjectPath.Name = "TxtBxProjectPath";
            this.TxtBxProjectPath.ReadOnly = true;
            this.TxtBxProjectPath.Size = new System.Drawing.Size(218, 21);
            this.TxtBxProjectPath.TabIndex = 2;
            this.TxtBxProjectPath.TextChanged += new System.EventHandler(this.TxtBxProjectPath_TextChanged);
            // 
            // LbNote
            // 
            this.LbNote.AutoSize = true;
            this.LbNote.Location = new System.Drawing.Point(418, 80);
            this.LbNote.Name = "LbNote";
            this.LbNote.Size = new System.Drawing.Size(288, 13);
            this.LbNote.TabIndex = 4;
            this.LbNote.Text = ".را انتخاب کنید C در این قسمت فقط درایو مورد نظر به جز درایو ";
            // 
            // LbProjectPath
            // 
            this.LbProjectPath.AutoSize = true;
            this.LbProjectPath.Location = new System.Drawing.Point(711, 58);
            this.LbProjectPath.Name = "LbProjectPath";
            this.LbProjectPath.Size = new System.Drawing.Size(59, 13);
            this.LbProjectPath.TabIndex = 1;
            this.LbProjectPath.Text = "مسیر پروژه";
            // 
            // LbPort
            // 
            this.LbPort.AutoSize = true;
            this.LbPort.Location = new System.Drawing.Point(542, 17);
            this.LbPort.Name = "LbPort";
            this.LbPort.Size = new System.Drawing.Size(28, 13);
            this.LbPort.TabIndex = 1;
            this.LbPort.Text = "پورت";
            // 
            // LbSiteName
            // 
            this.LbSiteName.AutoSize = true;
            this.LbSiteName.Location = new System.Drawing.Point(711, 17);
            this.LbSiteName.Name = "LbSiteName";
            this.LbSiteName.Size = new System.Drawing.Size(59, 13);
            this.LbSiteName.TabIndex = 1;
            this.LbSiteName.Text = "اسم سایت";
            // 
            // GroupBxModuleSelection
            // 
            this.GroupBxModuleSelection.Controls.Add(this.checkBxWebServer);
            this.GroupBxModuleSelection.Controls.Add(this.CkeckBxRestaurant);
            this.GroupBxModuleSelection.Location = new System.Drawing.Point(12, 438);
            this.GroupBxModuleSelection.Name = "GroupBxModuleSelection";
            this.GroupBxModuleSelection.Size = new System.Drawing.Size(776, 57);
            this.GroupBxModuleSelection.TabIndex = 2;
            this.GroupBxModuleSelection.TabStop = false;
            this.GroupBxModuleSelection.Text = "انتخاب ماژول ها";
            // 
            // checkBxWebServer
            // 
            this.checkBxWebServer.AutoSize = true;
            this.checkBxWebServer.Location = new System.Drawing.Point(492, 34);
            this.checkBxWebServer.Name = "checkBxWebServer";
            this.checkBxWebServer.Size = new System.Drawing.Size(194, 17);
            this.checkBxWebServer.TabIndex = 1;
            this.checkBxWebServer.Text = "آیا مایل به نصب وب سرویس میباشید";
            this.checkBxWebServer.UseVisualStyleBackColor = true;
            // 
            // CkeckBxRestaurant
            // 
            this.CkeckBxRestaurant.AutoSize = true;
            this.CkeckBxRestaurant.Location = new System.Drawing.Point(492, 11);
            this.CkeckBxRestaurant.Name = "CkeckBxRestaurant";
            this.CkeckBxRestaurant.Size = new System.Drawing.Size(205, 17);
            this.CkeckBxRestaurant.TabIndex = 0;
            this.CkeckBxRestaurant.Text = "آیا مایل به نصب سیستم تغذیه میباشید";
            this.CkeckBxRestaurant.UseVisualStyleBackColor = true;
            // 
            // BtnInstallSoftware
            // 
            this.BtnInstallSoftware.Enabled = false;
            this.BtnInstallSoftware.Location = new System.Drawing.Point(709, 12);
            this.BtnInstallSoftware.Name = "BtnInstallSoftware";
            this.BtnInstallSoftware.Size = new System.Drawing.Size(79, 23);
            this.BtnInstallSoftware.TabIndex = 3;
            this.BtnInstallSoftware.Text = "نصب نرم افزار";
            this.BtnInstallSoftware.UseVisualStyleBackColor = true;
            this.BtnInstallSoftware.Click += new System.EventHandler(this.BtnInstallSoftware_Click);
            // 
            // BtnPrevious
            // 
            this.BtnPrevious.Location = new System.Drawing.Point(609, 12);
            this.BtnPrevious.Name = "BtnPrevious";
            this.BtnPrevious.Size = new System.Drawing.Size(75, 23);
            this.BtnPrevious.TabIndex = 4;
            this.BtnPrevious.Text = "بازگشت";
            this.BtnPrevious.UseVisualStyleBackColor = true;
            this.BtnPrevious.Click += new System.EventHandler(this.BtnPrevious_Click);
            // 
            // LbBankName
            // 
            this.LbBankName.AutoSize = true;
            this.LbBankName.Location = new System.Drawing.Point(727, 17);
            this.LbBankName.Name = "LbBankName";
            this.LbBankName.Size = new System.Drawing.Size(43, 13);
            this.LbBankName.TabIndex = 0;
            this.LbBankName.Text = "نام بانک";
            // 
            // LbInstanceName
            // 
            this.LbInstanceName.AutoSize = true;
            this.LbInstanceName.Location = new System.Drawing.Point(503, 17);
            this.LbInstanceName.Name = "LbInstanceName";
            this.LbInstanceName.Size = new System.Drawing.Size(67, 13);
            this.LbInstanceName.TabIndex = 1;
            this.LbInstanceName.Text = "نام اینستنس";
            // 
            // LbBankUsername
            // 
            this.LbBankUsername.AutoSize = true;
            this.LbBankUsername.Location = new System.Drawing.Point(747, 52);
            this.LbBankUsername.Name = "LbBankUsername";
            this.LbBankUsername.Size = new System.Drawing.Size(23, 13);
            this.LbBankUsername.TabIndex = 2;
            this.LbBankUsername.Text = "یوزر";
            // 
            // LbMDFPath
            // 
            this.LbMDFPath.AutoSize = true;
            this.LbMDFPath.Location = new System.Drawing.Point(717, 117);
            this.LbMDFPath.Name = "LbMDFPath";
            this.LbMDFPath.Size = new System.Drawing.Size(55, 13);
            this.LbMDFPath.TabIndex = 1;
            this.LbMDFPath.Text = "mdf مسیر";
            // 
            // LbInstanceUsername
            // 
            this.LbInstanceUsername.AutoSize = true;
            this.LbInstanceUsername.Location = new System.Drawing.Point(534, 49);
            this.LbInstanceUsername.Name = "LbInstanceUsername";
            this.LbInstanceUsername.Size = new System.Drawing.Size(36, 13);
            this.LbInstanceUsername.TabIndex = 3;
            this.LbInstanceUsername.Text = "پسورد";
            // 
            // LbLDFPath
            // 
            this.LbLDFPath.AutoSize = true;
            this.LbLDFPath.Location = new System.Drawing.Point(721, 161);
            this.LbLDFPath.Name = "LbLDFPath";
            this.LbLDFPath.Size = new System.Drawing.Size(49, 13);
            this.LbLDFPath.TabIndex = 2;
            this.LbLDFPath.Text = "ldf مسیر";
            // 
            // TxtBxDatabaseName
            // 
            this.TxtBxDatabaseName.Location = new System.Drawing.Point(597, 14);
            this.TxtBxDatabaseName.Name = "TxtBxDatabaseName";
            this.TxtBxDatabaseName.Size = new System.Drawing.Size(100, 21);
            this.TxtBxDatabaseName.TabIndex = 0;
            this.TxtBxDatabaseName.Text = "Framework";
            // 
            // TxtBxDatabaseInstanceName
            // 
            this.TxtBxDatabaseInstanceName.Location = new System.Drawing.Point(220, 14);
            this.TxtBxDatabaseInstanceName.Name = "TxtBxDatabaseInstanceName";
            this.TxtBxDatabaseInstanceName.Size = new System.Drawing.Size(277, 21);
            this.TxtBxDatabaseInstanceName.TabIndex = 1;
            // 
            // TxtBxDataBaseUsername
            // 
            this.TxtBxDataBaseUsername.Location = new System.Drawing.Point(597, 49);
            this.TxtBxDataBaseUsername.Name = "TxtBxDataBaseUsername";
            this.TxtBxDataBaseUsername.Size = new System.Drawing.Size(100, 21);
            this.TxtBxDataBaseUsername.TabIndex = 2;
            this.TxtBxDataBaseUsername.Text = "sa";
            // 
            // TxtBxDatabasePassword
            // 
            this.TxtBxDatabasePassword.Location = new System.Drawing.Point(328, 46);
            this.TxtBxDatabasePassword.Name = "TxtBxDatabasePassword";
            this.TxtBxDatabasePassword.PasswordChar = '*';
            this.TxtBxDatabasePassword.Size = new System.Drawing.Size(169, 21);
            this.TxtBxDatabasePassword.TabIndex = 3;
            // 
            // TxtBxLDFPath
            // 
            this.TxtBxLDFPath.Location = new System.Drawing.Point(506, 158);
            this.TxtBxLDFPath.Name = "TxtBxLDFPath";
            this.TxtBxLDFPath.ReadOnly = true;
            this.TxtBxLDFPath.Size = new System.Drawing.Size(191, 21);
            this.TxtBxLDFPath.TabIndex = 6;
            this.TxtBxLDFPath.TextChanged += new System.EventHandler(this.TxtBxLDFPath_TextChanged);
            // 
            // TxtBxMDFPath
            // 
            this.TxtBxMDFPath.Location = new System.Drawing.Point(506, 117);
            this.TxtBxMDFPath.Name = "TxtBxMDFPath";
            this.TxtBxMDFPath.ReadOnly = true;
            this.TxtBxMDFPath.Size = new System.Drawing.Size(191, 21);
            this.TxtBxMDFPath.TabIndex = 5;
            this.TxtBxMDFPath.TextChanged += new System.EventHandler(this.TxtBxMDFPath_TextChanged);
            // 
            // LbBackupPath
            // 
            this.LbBackupPath.AutoSize = true;
            this.LbBackupPath.Location = new System.Drawing.Point(685, 197);
            this.LbBackupPath.Name = "LbBackupPath";
            this.LbBackupPath.Size = new System.Drawing.Size(85, 13);
            this.LbBackupPath.TabIndex = 11;
            this.LbBackupPath.Text = "مسیر بکاپ گیری";
            // 
            // GroupBxSQLServer
            // 
            this.GroupBxSQLServer.Controls.Add(this.BtnBackupPathBrowser);
            this.GroupBxSQLServer.Controls.Add(this.BtnLDFPathBrowser);
            this.GroupBxSQLServer.Controls.Add(this.BtnMDFParhBrowser);
            this.GroupBxSQLServer.Controls.Add(this.BtnVerification);
            this.GroupBxSQLServer.Controls.Add(this.TxtBxWebServerPassword);
            this.GroupBxSQLServer.Controls.Add(this.TxtBxWebServerUsername);
            this.GroupBxSQLServer.Controls.Add(this.label3);
            this.GroupBxSQLServer.Controls.Add(this.label1);
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
            this.GroupBxSQLServer.Location = new System.Drawing.Point(12, 147);
            this.GroupBxSQLServer.Name = "GroupBxSQLServer";
            this.GroupBxSQLServer.Size = new System.Drawing.Size(776, 285);
            this.GroupBxSQLServer.TabIndex = 1;
            this.GroupBxSQLServer.TabStop = false;
            this.GroupBxSQLServer.Text = "SQL Server";
            // 
            // BtnBackupPathBrowser
            // 
            this.BtnBackupPathBrowser.Location = new System.Drawing.Point(428, 189);
            this.BtnBackupPathBrowser.Name = "BtnBackupPathBrowser";
            this.BtnBackupPathBrowser.Size = new System.Drawing.Size(27, 22);
            this.BtnBackupPathBrowser.TabIndex = 7;
            this.BtnBackupPathBrowser.Text = "...";
            this.BtnBackupPathBrowser.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnBackupPathBrowser.UseVisualStyleBackColor = true;
            this.BtnBackupPathBrowser.Click += new System.EventHandler(this.BtnBackupPathBrowser_Click);
            // 
            // BtnLDFPathBrowser
            // 
            this.BtnLDFPathBrowser.Location = new System.Drawing.Point(473, 157);
            this.BtnLDFPathBrowser.Name = "BtnLDFPathBrowser";
            this.BtnLDFPathBrowser.Size = new System.Drawing.Size(27, 22);
            this.BtnLDFPathBrowser.TabIndex = 6;
            this.BtnLDFPathBrowser.Text = "...";
            this.BtnLDFPathBrowser.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnLDFPathBrowser.UseVisualStyleBackColor = true;
            this.BtnLDFPathBrowser.Click += new System.EventHandler(this.BtnLDFPathBrowser_Click);
            // 
            // BtnMDFParhBrowser
            // 
            this.BtnMDFParhBrowser.Location = new System.Drawing.Point(473, 116);
            this.BtnMDFParhBrowser.Name = "BtnMDFParhBrowser";
            this.BtnMDFParhBrowser.Size = new System.Drawing.Size(27, 22);
            this.BtnMDFParhBrowser.TabIndex = 5;
            this.BtnMDFParhBrowser.Text = "...";
            this.BtnMDFParhBrowser.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnMDFParhBrowser.UseVisualStyleBackColor = true;
            this.BtnMDFParhBrowser.Click += new System.EventHandler(this.BtnMDFParhBrowser_Click);
            // 
            // BtnVerification
            // 
            this.BtnVerification.Location = new System.Drawing.Point(220, 79);
            this.BtnVerification.Name = "BtnVerification";
            this.BtnVerification.Size = new System.Drawing.Size(75, 23);
            this.BtnVerification.TabIndex = 4;
            this.BtnVerification.Text = "Verify";
            this.BtnVerification.UseVisualStyleBackColor = true;
            this.BtnVerification.Click += new System.EventHandler(this.BtnVerification_Click);
            // 
            // TxtBxWebServerPassword
            // 
            this.TxtBxWebServerPassword.Enabled = false;
            this.TxtBxWebServerPassword.Location = new System.Drawing.Point(257, 245);
            this.TxtBxWebServerPassword.Name = "TxtBxWebServerPassword";
            this.TxtBxWebServerPassword.Size = new System.Drawing.Size(198, 21);
            this.TxtBxWebServerPassword.TabIndex = 10;
            // 
            // TxtBxWebServerUsername
            // 
            this.TxtBxWebServerUsername.Enabled = false;
            this.TxtBxWebServerUsername.Location = new System.Drawing.Point(520, 245);
            this.TxtBxWebServerUsername.Name = "TxtBxWebServerUsername";
            this.TxtBxWebServerUsername.Size = new System.Drawing.Size(191, 21);
            this.TxtBxWebServerUsername.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(461, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "پسورد";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(717, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "نام کاربری";
            // 
            // CheckBxWebServerDatabase
            // 
            this.CheckBxWebServerDatabase.AutoSize = true;
            this.CheckBxWebServerDatabase.Location = new System.Drawing.Point(559, 213);
            this.CheckBxWebServerDatabase.Name = "CheckBxWebServerDatabase";
            this.CheckBxWebServerDatabase.Size = new System.Drawing.Size(211, 17);
            this.CheckBxWebServerDatabase.TabIndex = 8;
            this.CheckBxWebServerDatabase.Text = "سرور بانک اصلاعاتی تحت شبکه میباشد";
            this.CheckBxWebServerDatabase.UseVisualStyleBackColor = true;
            this.CheckBxWebServerDatabase.CheckedChanged += new System.EventHandler(this.CheckBxWebServerDatabase_CheckedChanged);
            // 
            // TxtBxBackupPath
            // 
            this.TxtBxBackupPath.Location = new System.Drawing.Point(461, 189);
            this.TxtBxBackupPath.Name = "TxtBxBackupPath";
            this.TxtBxBackupPath.ReadOnly = true;
            this.TxtBxBackupPath.Size = new System.Drawing.Size(225, 21);
            this.TxtBxBackupPath.TabIndex = 7;
            // 
            // FrmInstallAndSetUpSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 507);
            this.Controls.Add(this.BtnPrevious);
            this.Controls.Add(this.BtnInstallSoftware);
            this.Controls.Add(this.GroupBxModuleSelection);
            this.Controls.Add(this.GroupBxSQLServer);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox CheckBxWebServerDatabase;
        private System.Windows.Forms.TextBox TxtBxBackupPath;
        protected System.Windows.Forms.FolderBrowserDialog FolderBrowserDialogPaths;
        private System.Windows.Forms.Button BtnVerification;
        private System.Windows.Forms.Button BtnLDFPathBrowser;
        private System.Windows.Forms.Button BtnMDFParhBrowser;
        private System.Windows.Forms.Button BtnBackupPathBrowser;
    }
}