namespace Installer
{
    partial class FrmPrerequisites
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GroupBx1 = new System.Windows.Forms.GroupBox();
            this.TxtBxPublishPath = new System.Windows.Forms.TextBox();
            this.BtnBrowse = new System.Windows.Forms.Button();
            this.LbPublishPath = new System.Windows.Forms.Label();
            this.BtnHelpPrequisites = new System.Windows.Forms.Button();
            this.BtnSystemInformation = new System.Windows.Forms.Button();
            this.BtnPrequisitesDiag = new System.Windows.Forms.Button();
            this.BtnNext = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnRerun = new System.Windows.Forms.Button();
            this.ColStatus = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColPrerequisite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDiscription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupBx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBx1
            // 
            this.GroupBx1.Controls.Add(this.TxtBxPublishPath);
            this.GroupBx1.Controls.Add(this.BtnBrowse);
            this.GroupBx1.Controls.Add(this.LbPublishPath);
            this.GroupBx1.Controls.Add(this.BtnHelpPrequisites);
            this.GroupBx1.Controls.Add(this.BtnSystemInformation);
            this.GroupBx1.Controls.Add(this.BtnPrequisitesDiag);
            this.GroupBx1.Controls.Add(this.BtnNext);
            this.GroupBx1.Location = new System.Drawing.Point(0, -6);
            this.GroupBx1.Name = "GroupBx1";
            this.GroupBx1.Size = new System.Drawing.Size(801, 193);
            this.GroupBx1.TabIndex = 0;
            this.GroupBx1.TabStop = false;
            // 
            // TxtBxPublishPath
            // 
            this.TxtBxPublishPath.BackColor = System.Drawing.SystemColors.Window;
            this.TxtBxPublishPath.Location = new System.Drawing.Point(457, 102);
            this.TxtBxPublishPath.Name = "TxtBxPublishPath";
            this.TxtBxPublishPath.ReadOnly = true;
            this.TxtBxPublishPath.Size = new System.Drawing.Size(207, 21);
            this.TxtBxPublishPath.TabIndex = 6;
            // 
            // BtnBrowse
            // 
            this.BtnBrowse.Location = new System.Drawing.Point(424, 102);
            this.BtnBrowse.Name = "BtnBrowse";
            this.BtnBrowse.Size = new System.Drawing.Size(27, 20);
            this.BtnBrowse.TabIndex = 3;
            this.BtnBrowse.Text = "...";
            this.BtnBrowse.UseVisualStyleBackColor = true;
            this.BtnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // LbPublishPath
            // 
            this.LbPublishPath.AutoSize = true;
            this.LbPublishPath.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPublishPath.Location = new System.Drawing.Point(694, 102);
            this.LbPublishPath.Name = "LbPublishPath";
            this.LbPublishPath.Size = new System.Drawing.Size(100, 13);
            this.LbPublishPath.TabIndex = 5;
            this.LbPublishPath.Text = "انتخاب مسیر پابلیش";
            // 
            // BtnHelpPrequisites
            // 
            this.BtnHelpPrequisites.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHelpPrequisites.Location = new System.Drawing.Point(231, 19);
            this.BtnHelpPrequisites.Name = "BtnHelpPrequisites";
            this.BtnHelpPrequisites.Size = new System.Drawing.Size(163, 23);
            this.BtnHelpPrequisites.TabIndex = 2;
            this.BtnHelpPrequisites.Text = "راهنمای رفع و بررسی پیش نیاز";
            this.BtnHelpPrequisites.UseVisualStyleBackColor = true;
            this.BtnHelpPrequisites.Click += new System.EventHandler(this.BtnHelpPrequisites_Click);
            // 
            // BtnSystemInformation
            // 
            this.BtnSystemInformation.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSystemInformation.Location = new System.Drawing.Point(400, 19);
            this.BtnSystemInformation.Name = "BtnSystemInformation";
            this.BtnSystemInformation.Size = new System.Drawing.Size(158, 23);
            this.BtnSystemInformation.TabIndex = 1;
            this.BtnSystemInformation.Text = "مشخصات سخت افزاری سیستم";
            this.BtnSystemInformation.UseVisualStyleBackColor = true;
            this.BtnSystemInformation.Click += new System.EventHandler(this.BtnSystemInformation_Click);
            // 
            // BtnPrequisitesDiag
            // 
            this.BtnPrequisitesDiag.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrequisitesDiag.Location = new System.Drawing.Point(564, 19);
            this.BtnPrequisitesDiag.Name = "BtnPrequisitesDiag";
            this.BtnPrequisitesDiag.Size = new System.Drawing.Size(143, 23);
            this.BtnPrequisitesDiag.TabIndex = 0;
            this.BtnPrequisitesDiag.Text = "بررسی پیش نیاز های نصب";
            this.BtnPrequisitesDiag.UseVisualStyleBackColor = true;
            this.BtnPrequisitesDiag.Click += new System.EventHandler(this.BtnPrequisitesDiag_Click);
            // 
            // BtnNext
            // 
            this.BtnNext.Enabled = false;
            this.BtnNext.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNext.Location = new System.Drawing.Point(713, 19);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(75, 23);
            this.BtnNext.TabIndex = 4;
            this.BtnNext.Text = "ادامه";
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColStatus,
            this.ColPrerequisite,
            this.ColDiscription});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dataGridView1.Location = new System.Drawing.Point(0, 161);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(800, 233);
            this.dataGridView1.TabIndex = 2;
            // 
            // BtnRerun
            // 
            this.BtnRerun.Enabled = false;
            this.BtnRerun.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRerun.Location = new System.Drawing.Point(697, 415);
            this.BtnRerun.Name = "BtnRerun";
            this.BtnRerun.Size = new System.Drawing.Size(90, 23);
            this.BtnRerun.TabIndex = 1;
            this.BtnRerun.Text = "بررسی مجدد";
            this.BtnRerun.UseVisualStyleBackColor = true;
            this.BtnRerun.Click += new System.EventHandler(this.BtnRerun_Click);
            // 
            // ColStatus
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.NullValue = false;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ColStatus.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColStatus.FillWeight = 24.46675F;
            this.ColStatus.HeaderText = "وضعیت";
            this.ColStatus.Name = "ColStatus";
            this.ColStatus.ReadOnly = true;
            this.ColStatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ColPrerequisite
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ColPrerequisite.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColPrerequisite.FillWeight = 98.65928F;
            this.ColPrerequisite.HeaderText = "پیش نیاز";
            this.ColPrerequisite.Name = "ColPrerequisite";
            this.ColPrerequisite.ReadOnly = true;
            this.ColPrerequisite.Width = 300;
            // 
            // ColDiscription
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ColDiscription.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColDiscription.FillWeight = 176.8739F;
            this.ColDiscription.HeaderText = "توضیحات";
            this.ColDiscription.Name = "ColDiscription";
            this.ColDiscription.ReadOnly = true;
            this.ColDiscription.Width = 300;
            // 
            // FrmPrerequisites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnRerun);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.GroupBx1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FrmPrerequisites";
            this.Text = "مشخصات سرور و پیش نیاز نصب";
            this.GroupBx1.ResumeLayout(false);
            this.GroupBx1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBx1;
        private System.Windows.Forms.TextBox TxtBxPublishPath;
        private System.Windows.Forms.Button BtnBrowse;
        private System.Windows.Forms.Label LbPublishPath;
        private System.Windows.Forms.Button BtnHelpPrequisites;
        private System.Windows.Forms.Button BtnSystemInformation;
        private System.Windows.Forms.Button BtnPrequisitesDiag;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnRerun;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrerequisite;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDiscription;
    }
}