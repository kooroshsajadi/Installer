namespace Installer
{
    partial class FrmSoftwareInstallation
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
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.TxtBxLog = new System.Windows.Forms.TextBox();
            this.GroupBx = new System.Windows.Forms.GroupBox();
            this.GroupBx.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(10, 9);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ProgressBar.RightToLeftLayout = true;
            this.ProgressBar.Size = new System.Drawing.Size(780, 46);
            this.ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ProgressBar.TabIndex = 1;
            this.ProgressBar.Click += new System.EventHandler(this.ProgressBar_Click);
            // 
            // TxtBxLog
            // 
            this.TxtBxLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBxLog.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBxLog.Location = new System.Drawing.Point(10, 61);
            this.TxtBxLog.Multiline = true;
            this.TxtBxLog.Name = "TxtBxLog";
            this.TxtBxLog.ReadOnly = true;
            this.TxtBxLog.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtBxLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtBxLog.Size = new System.Drawing.Size(780, 367);
            this.TxtBxLog.TabIndex = 2;
            this.TxtBxLog.TextChanged += new System.EventHandler(this.TxtBxLog_TextChanged);
            // 
            // GroupBx
            // 
            this.GroupBx.Controls.Add(this.ProgressBar);
            this.GroupBx.Controls.Add(this.TxtBxLog);
            this.GroupBx.Location = new System.Drawing.Point(2, 4);
            this.GroupBx.Name = "GroupBx";
            this.GroupBx.Size = new System.Drawing.Size(796, 434);
            this.GroupBx.TabIndex = 3;
            this.GroupBx.TabStop = false;
            // 
            // FrmSoftwareInstallation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GroupBx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FrmSoftwareInstallation";
            this.Text = "FrmSoftwareInstallation";
            this.Load += new System.EventHandler(this.FrmSoftwareInstallation_Load);
            this.GroupBx.ResumeLayout(false);
            this.GroupBx.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.TextBox TxtBxLog;
        private System.Windows.Forms.GroupBox GroupBx;
    }
}