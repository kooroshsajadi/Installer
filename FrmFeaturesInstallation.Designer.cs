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
            this.GroupBx2 = new System.Windows.Forms.GroupBox();
            this.TxtBxLog = new System.Windows.Forms.TextBox();
            this.GroupBx1.SuspendLayout();
            this.GroupBx2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnSoftwareInstallation
            // 
            this.BtnSoftwareInstallation.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSoftwareInstallation.Location = new System.Drawing.Point(649, 15);
            this.BtnSoftwareInstallation.Name = "BtnSoftwareInstallation";
            this.BtnSoftwareInstallation.Size = new System.Drawing.Size(133, 23);
            this.BtnSoftwareInstallation.TabIndex = 0;
            this.BtnSoftwareInstallation.Text = "نصب نرم افزار های جانبی";
            this.BtnSoftwareInstallation.UseVisualStyleBackColor = true;
            this.BtnSoftwareInstallation.Click += new System.EventHandler(this.BtnSoftwareInstallation_Click);
            // 
            // BtnNext
            // 
            this.BtnNext.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNext.Location = new System.Drawing.Point(568, 15);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(75, 23);
            this.BtnNext.TabIndex = 1;
            this.BtnNext.Text = "ادامه";
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // BtnPrevious
            // 
            this.BtnPrevious.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrevious.Location = new System.Drawing.Point(487, 15);
            this.BtnPrevious.Name = "BtnPrevious";
            this.BtnPrevious.Size = new System.Drawing.Size(75, 23);
            this.BtnPrevious.TabIndex = 2;
            this.BtnPrevious.Text = "بازگشت";
            this.BtnPrevious.UseVisualStyleBackColor = true;
            this.BtnPrevious.Click += new System.EventHandler(this.BtnPrevious_Click);
            // 
            // CheckBxSQLServer2017
            // 
            this.CheckBxSQLServer2017.AutoSize = true;
            this.CheckBxSQLServer2017.Checked = true;
            this.CheckBxSQLServer2017.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBxSQLServer2017.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBxSQLServer2017.Location = new System.Drawing.Point(6, 19);
            this.CheckBxSQLServer2017.Name = "CheckBxSQLServer2017";
            this.CheckBxSQLServer2017.Size = new System.Drawing.Size(107, 17);
            this.CheckBxSQLServer2017.TabIndex = 3;
            this.CheckBxSQLServer2017.Text = "SQL Server 2017";
            this.CheckBxSQLServer2017.UseVisualStyleBackColor = true;
            // 
            // CheckBxIIS
            // 
            this.CheckBxIIS.AutoSize = true;
            this.CheckBxIIS.Checked = true;
            this.CheckBxIIS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBxIIS.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBxIIS.Location = new System.Drawing.Point(6, 42);
            this.CheckBxIIS.Name = "CheckBxIIS";
            this.CheckBxIIS.Size = new System.Drawing.Size(40, 17);
            this.CheckBxIIS.TabIndex = 4;
            this.CheckBxIIS.Text = "IIS";
            this.CheckBxIIS.UseVisualStyleBackColor = true;
            // 
            // CheckBxActiveDirectory
            // 
            this.CheckBxActiveDirectory.AutoSize = true;
            this.CheckBxActiveDirectory.Checked = true;
            this.CheckBxActiveDirectory.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBxActiveDirectory.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBxActiveDirectory.Location = new System.Drawing.Point(6, 65);
            this.CheckBxActiveDirectory.Name = "CheckBxActiveDirectory";
            this.CheckBxActiveDirectory.Size = new System.Drawing.Size(103, 17);
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
            this.CheckBxKeyA.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBxKeyA.Location = new System.Drawing.Point(212, 19);
            this.CheckBxKeyA.Name = "CheckBxKeyA";
            this.CheckBxKeyA.Size = new System.Drawing.Size(51, 17);
            this.CheckBxKeyA.TabIndex = 6;
            this.CheckBxKeyA.Text = "KeyA";
            this.CheckBxKeyA.UseVisualStyleBackColor = true;
            // 
            // CheckBxFlashPlayer
            // 
            this.CheckBxFlashPlayer.AutoSize = true;
            this.CheckBxFlashPlayer.Checked = true;
            this.CheckBxFlashPlayer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBxFlashPlayer.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBxFlashPlayer.Location = new System.Drawing.Point(212, 42);
            this.CheckBxFlashPlayer.Name = "CheckBxFlashPlayer";
            this.CheckBxFlashPlayer.Size = new System.Drawing.Size(84, 17);
            this.CheckBxFlashPlayer.TabIndex = 7;
            this.CheckBxFlashPlayer.Text = "Flash Player";
            this.CheckBxFlashPlayer.UseVisualStyleBackColor = true;
            // 
            // CheckBxKasraPrintService
            // 
            this.CheckBxKasraPrintService.AutoSize = true;
            this.CheckBxKasraPrintService.Checked = true;
            this.CheckBxKasraPrintService.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBxKasraPrintService.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBxKasraPrintService.Location = new System.Drawing.Point(212, 65);
            this.CheckBxKasraPrintService.Name = "CheckBxKasraPrintService";
            this.CheckBxKasraPrintService.Size = new System.Drawing.Size(116, 17);
            this.CheckBxKasraPrintService.TabIndex = 8;
            this.CheckBxKasraPrintService.Text = "Kasra Print Service";
            this.CheckBxKasraPrintService.UseVisualStyleBackColor = true;
            // 
            // GroupBx1
            // 
            this.GroupBx1.Controls.Add(this.GroupBx2);
            this.GroupBx1.Controls.Add(this.BtnSoftwareInstallation);
            this.GroupBx1.Controls.Add(this.BtnNext);
            this.GroupBx1.Controls.Add(this.BtnPrevious);
            this.GroupBx1.Location = new System.Drawing.Point(7, -3);
            this.GroupBx1.Name = "GroupBx1";
            this.GroupBx1.Size = new System.Drawing.Size(788, 175);
            this.GroupBx1.TabIndex = 9;
            this.GroupBx1.TabStop = false;
            // 
            // GroupBx2
            // 
            this.GroupBx2.Controls.Add(this.CheckBxSQLServer2017);
            this.GroupBx2.Controls.Add(this.CheckBxKasraPrintService);
            this.GroupBx2.Controls.Add(this.CheckBxIIS);
            this.GroupBx2.Controls.Add(this.CheckBxFlashPlayer);
            this.GroupBx2.Controls.Add(this.CheckBxActiveDirectory);
            this.GroupBx2.Controls.Add(this.CheckBxKeyA);
            this.GroupBx2.Location = new System.Drawing.Point(31, 51);
            this.GroupBx2.Name = "GroupBx2";
            this.GroupBx2.Size = new System.Drawing.Size(335, 101);
            this.GroupBx2.TabIndex = 3;
            this.GroupBx2.TabStop = false;
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
            this.GroupBx2.ResumeLayout(false);
            this.GroupBx2.PerformLayout();
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
        private System.Windows.Forms.GroupBox GroupBx2;
        private System.Windows.Forms.TextBox TxtBxLog;
    }
}