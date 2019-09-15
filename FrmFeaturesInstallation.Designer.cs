namespace Installer
{
    partial class FrmFeaturesInstallation
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
            this.BtnSoftwareInstallation = new System.Windows.Forms.Button();
            this.BtnNext = new System.Windows.Forms.Button();
            this.BtnPrevious = new System.Windows.Forms.Button();
            this.CheckBxSQLServer2017 = new System.Windows.Forms.CheckBox();
            this.CheckBxIIS = new System.Windows.Forms.CheckBox();
            this.CheckBxActiveDirectory = new System.Windows.Forms.CheckBox();
            this.CheckBxKeyA = new System.Windows.Forms.CheckBox();
            this.CheckBxFlashPlayer = new System.Windows.Forms.CheckBox();
            this.CheckBxKasraPrintService = new System.Windows.Forms.CheckBox();
            this.GroupBx1 = new System.Windows.Forms.GroupBox();
            this.TxtBxLog = new System.Windows.Forms.TextBox();
            this.GroupBx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnSoftwareInstallation
            // 
            this.BtnSoftwareInstallation.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnSoftwareInstallation.BackColor = System.Drawing.Color.Transparent;
            this.BtnSoftwareInstallation.BackgroundImage = global::Installer.Properties.Resources.Group_2169_2x_min;
            this.BtnSoftwareInstallation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSoftwareInstallation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSoftwareInstallation.FlatAppearance.BorderSize = 0;
            this.BtnSoftwareInstallation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnSoftwareInstallation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnSoftwareInstallation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSoftwareInstallation.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.BtnSoftwareInstallation.ForeColor = System.Drawing.Color.White;
            this.BtnSoftwareInstallation.Location = new System.Drawing.Point(178, 105);
            this.BtnSoftwareInstallation.Name = "BtnSoftwareInstallation";
            this.BtnSoftwareInstallation.Size = new System.Drawing.Size(185, 35);
            this.BtnSoftwareInstallation.TabIndex = 0;
            this.BtnSoftwareInstallation.Text = "نصب نرم افزار های جانبی";
            this.BtnSoftwareInstallation.UseVisualStyleBackColor = false;
            this.BtnSoftwareInstallation.Click += new System.EventHandler(this.BtnSoftwareInstallation_Click);
            // 
            // BtnNext
            // 
            this.BtnNext.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnNext.BackColor = System.Drawing.Color.Transparent;
            this.BtnNext.BackgroundImage = global::Installer.Properties.Resources.Group_2170_min;
            this.BtnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNext.FlatAppearance.BorderSize = 0;
            this.BtnNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNext.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.BtnNext.ForeColor = System.Drawing.Color.White;
            this.BtnNext.Location = new System.Drawing.Point(6, 105);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(80, 35);
            this.BtnNext.TabIndex = 1;
            this.BtnNext.Text = "ادامه";
            this.BtnNext.UseVisualStyleBackColor = false;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // BtnPrevious
            // 
            this.BtnPrevious.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnPrevious.BackColor = System.Drawing.Color.Transparent;
            this.BtnPrevious.BackgroundImage = global::Installer.Properties.Resources.Group_2176_min;
            this.BtnPrevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPrevious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPrevious.FlatAppearance.BorderSize = 0;
            this.BtnPrevious.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BtnPrevious.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BtnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPrevious.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.BtnPrevious.ForeColor = System.Drawing.Color.White;
            this.BtnPrevious.Location = new System.Drawing.Point(92, 105);
            this.BtnPrevious.Name = "BtnPrevious";
            this.BtnPrevious.Size = new System.Drawing.Size(80, 35);
            this.BtnPrevious.TabIndex = 2;
            this.BtnPrevious.Text = "بازگشت";
            this.BtnPrevious.UseVisualStyleBackColor = false;
            this.BtnPrevious.Click += new System.EventHandler(this.BtnPrevious_Click);
            // 
            // CheckBxSQLServer2017
            // 
            this.CheckBxSQLServer2017.AutoSize = true;
            this.CheckBxSQLServer2017.Checked = true;
            this.CheckBxSQLServer2017.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBxSQLServer2017.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.CheckBxSQLServer2017.Location = new System.Drawing.Point(201, 20);
            this.CheckBxSQLServer2017.Name = "CheckBxSQLServer2017";
            this.CheckBxSQLServer2017.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CheckBxSQLServer2017.Size = new System.Drawing.Size(116, 23);
            this.CheckBxSQLServer2017.TabIndex = 3;
            this.CheckBxSQLServer2017.Text = "SQL Server 2017";
            this.CheckBxSQLServer2017.UseVisualStyleBackColor = true;
            this.CheckBxSQLServer2017.Visible = false;
            // 
            // CheckBxIIS
            // 
            this.CheckBxIIS.AutoSize = true;
            this.CheckBxIIS.Checked = true;
            this.CheckBxIIS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBxIIS.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.CheckBxIIS.Location = new System.Drawing.Point(740, 20);
            this.CheckBxIIS.Name = "CheckBxIIS";
            this.CheckBxIIS.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CheckBxIIS.Size = new System.Drawing.Size(41, 23);
            this.CheckBxIIS.TabIndex = 4;
            this.CheckBxIIS.Text = "IIS";
            this.CheckBxIIS.UseVisualStyleBackColor = true;
            // 
            // CheckBxActiveDirectory
            // 
            this.CheckBxActiveDirectory.AutoSize = true;
            this.CheckBxActiveDirectory.Checked = true;
            this.CheckBxActiveDirectory.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBxActiveDirectory.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.CheckBxActiveDirectory.Location = new System.Drawing.Point(323, 20);
            this.CheckBxActiveDirectory.Name = "CheckBxActiveDirectory";
            this.CheckBxActiveDirectory.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CheckBxActiveDirectory.Size = new System.Drawing.Size(112, 23);
            this.CheckBxActiveDirectory.TabIndex = 5;
            this.CheckBxActiveDirectory.Text = "Active Directory";
            this.CheckBxActiveDirectory.UseVisualStyleBackColor = true;
            this.CheckBxActiveDirectory.Visible = false;
            // 
            // CheckBxKeyA
            // 
            this.CheckBxKeyA.AutoSize = true;
            this.CheckBxKeyA.Checked = true;
            this.CheckBxKeyA.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBxKeyA.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.CheckBxKeyA.Location = new System.Drawing.Point(441, 20);
            this.CheckBxKeyA.Name = "CheckBxKeyA";
            this.CheckBxKeyA.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CheckBxKeyA.Size = new System.Drawing.Size(56, 23);
            this.CheckBxKeyA.TabIndex = 6;
            this.CheckBxKeyA.Text = "KeyA";
            this.CheckBxKeyA.UseVisualStyleBackColor = true;
            // 
            // CheckBxFlashPlayer
            // 
            this.CheckBxFlashPlayer.AutoSize = true;
            this.CheckBxFlashPlayer.Checked = true;
            this.CheckBxFlashPlayer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBxFlashPlayer.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.CheckBxFlashPlayer.Location = new System.Drawing.Point(639, 20);
            this.CheckBxFlashPlayer.Name = "CheckBxFlashPlayer";
            this.CheckBxFlashPlayer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CheckBxFlashPlayer.Size = new System.Drawing.Size(95, 23);
            this.CheckBxFlashPlayer.TabIndex = 7;
            this.CheckBxFlashPlayer.Text = "Flash Player";
            this.CheckBxFlashPlayer.UseVisualStyleBackColor = true;
            // 
            // CheckBxKasraPrintService
            // 
            this.CheckBxKasraPrintService.AutoSize = true;
            this.CheckBxKasraPrintService.Checked = true;
            this.CheckBxKasraPrintService.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBxKasraPrintService.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.CheckBxKasraPrintService.Location = new System.Drawing.Point(503, 20);
            this.CheckBxKasraPrintService.Name = "CheckBxKasraPrintService";
            this.CheckBxKasraPrintService.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CheckBxKasraPrintService.Size = new System.Drawing.Size(130, 23);
            this.CheckBxKasraPrintService.TabIndex = 8;
            this.CheckBxKasraPrintService.Text = "Kasra Print Service";
            this.CheckBxKasraPrintService.UseVisualStyleBackColor = true;
            // 
            // GroupBx1
            // 
            this.GroupBx1.Controls.Add(this.CheckBxKasraPrintService);
            this.GroupBx1.Controls.Add(this.CheckBxSQLServer2017);
            this.GroupBx1.Controls.Add(this.CheckBxKeyA);
            this.GroupBx1.Controls.Add(this.CheckBxFlashPlayer);
            this.GroupBx1.Controls.Add(this.CheckBxIIS);
            this.GroupBx1.Controls.Add(this.CheckBxActiveDirectory);
            this.GroupBx1.Controls.Add(this.BtnSoftwareInstallation);
            this.GroupBx1.Controls.Add(this.BtnNext);
            this.GroupBx1.Controls.Add(this.BtnPrevious);
            this.GroupBx1.Location = new System.Drawing.Point(7, -3);
            this.GroupBx1.Name = "GroupBx1";
            this.GroupBx1.Size = new System.Drawing.Size(788, 175);
            this.GroupBx1.TabIndex = 9;
            this.GroupBx1.TabStop = false;
            // 
            // TxtBxLog
            // 
            this.TxtBxLog.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxLog.Location = new System.Drawing.Point(7, 178);
            this.TxtBxLog.Multiline = true;
            this.TxtBxLog.Name = "TxtBxLog";
            this.TxtBxLog.ReadOnly = true;
            this.TxtBxLog.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtBxLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtBxLog.Size = new System.Drawing.Size(788, 269);
            this.TxtBxLog.TabIndex = 4;
            // 
            // FrmFeaturesInstallation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtBxLog);
            this.Controls.Add(this.GroupBx1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FrmFeaturesInstallation";
            this.Text = "نصب نرم افزارهای جانبی";
            this.Load += new System.EventHandler(this.FrmFeaturesInstallation_Load);
            this.GroupBx1.ResumeLayout(false);
            this.GroupBx1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSoftwareInstallation;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.Button BtnPrevious;
        private System.Windows.Forms.CheckBox CheckBxSQLServer2017;
        private System.Windows.Forms.CheckBox CheckBxIIS;
        private System.Windows.Forms.CheckBox CheckBxActiveDirectory;
        private System.Windows.Forms.CheckBox CheckBxKeyA;
        private System.Windows.Forms.CheckBox CheckBxFlashPlayer;
        private System.Windows.Forms.CheckBox CheckBxKasraPrintService;
        private System.Windows.Forms.GroupBox GroupBx1;
        private System.Windows.Forms.TextBox TxtBxLog;
    }
}