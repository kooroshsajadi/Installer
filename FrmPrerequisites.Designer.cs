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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GroupBx1 = new System.Windows.Forms.GroupBox();
            this.TxtBxPublishPath = new System.Windows.Forms.TextBox();
            this.BtnBrowse = new System.Windows.Forms.Button();
            this.LbPublishPath = new System.Windows.Forms.Label();
            this.BtnHelpPrequisites = new System.Windows.Forms.Button();
            this.BtnSystemInformation = new System.Windows.Forms.Button();
            this.BtnPrequisitesDiag = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColStatus = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColPrerequisite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDiscription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnRerun = new System.Windows.Forms.Button();
            this.BtnNext = new System.Windows.Forms.Button();
            this.GroupBx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBx1
            // 
            this.GroupBx1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GroupBx1.Controls.Add(this.TxtBxPublishPath);
            this.GroupBx1.Controls.Add(this.BtnBrowse);
            this.GroupBx1.Controls.Add(this.LbPublishPath);
            this.GroupBx1.Controls.Add(this.BtnHelpPrequisites);
            this.GroupBx1.Controls.Add(this.BtnSystemInformation);
            this.GroupBx1.Controls.Add(this.BtnPrequisitesDiag);
            this.GroupBx1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GroupBx1.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.GroupBx1.Location = new System.Drawing.Point(0, -6);
            this.GroupBx1.Name = "GroupBx1";
            this.GroupBx1.Size = new System.Drawing.Size(801, 193);
            this.GroupBx1.TabIndex = 0;
            this.GroupBx1.TabStop = false;
            // 
            // TxtBxPublishPath
            // 
            this.TxtBxPublishPath.BackColor = System.Drawing.SystemColors.Window;
            this.TxtBxPublishPath.Location = new System.Drawing.Point(504, 96);
            this.TxtBxPublishPath.Name = "TxtBxPublishPath";
            this.TxtBxPublishPath.ReadOnly = true;
            this.TxtBxPublishPath.Size = new System.Drawing.Size(203, 26);
            this.TxtBxPublishPath.TabIndex = 6;
            // 
            // BtnBrowse
            // 
            this.BtnBrowse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnBrowse.BackColor = System.Drawing.Color.Transparent;
            this.BtnBrowse.BackgroundImage = global::Installer.Properties.Resources.Group_2193_min;
            this.BtnBrowse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBrowse.FlatAppearance.BorderSize = 0;
            this.BtnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBrowse.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.BtnBrowse.ForeColor = System.Drawing.Color.White;
            this.BtnBrowse.Location = new System.Drawing.Point(418, 96);
            this.BtnBrowse.Name = "BtnBrowse";
            this.BtnBrowse.Size = new System.Drawing.Size(80, 30);
            this.BtnBrowse.TabIndex = 3;
            this.BtnBrowse.Text = "انتخاب";
            this.BtnBrowse.UseVisualStyleBackColor = false;
            this.BtnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // LbPublishPath
            // 
            this.LbPublishPath.AutoSize = true;
            this.LbPublishPath.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.LbPublishPath.Location = new System.Drawing.Point(713, 99);
            this.LbPublishPath.Name = "LbPublishPath";
            this.LbPublishPath.Size = new System.Drawing.Size(74, 19);
            this.LbPublishPath.TabIndex = 5;
            this.LbPublishPath.Text = " مسیر پابلیش";
            // 
            // BtnHelpPrequisites
            // 
            this.BtnHelpPrequisites.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnHelpPrequisites.BackColor = System.Drawing.Color.Transparent;
            this.BtnHelpPrequisites.BackgroundImage = global::Installer.Properties.Resources.Group_2176_2x_min;
            this.BtnHelpPrequisites.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnHelpPrequisites.FlatAppearance.BorderSize = 0;
            this.BtnHelpPrequisites.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHelpPrequisites.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.BtnHelpPrequisites.ForeColor = System.Drawing.Color.White;
            this.BtnHelpPrequisites.Location = new System.Drawing.Point(266, 13);
            this.BtnHelpPrequisites.Name = "BtnHelpPrequisites";
            this.BtnHelpPrequisites.Size = new System.Drawing.Size(185, 35);
            this.BtnHelpPrequisites.TabIndex = 2;
            this.BtnHelpPrequisites.Text = "راهنمای رفع و بررسی پیش نیاز";
            this.BtnHelpPrequisites.UseVisualStyleBackColor = false;
            this.BtnHelpPrequisites.Click += new System.EventHandler(this.BtnHelpPrequisites_Click);
            // 
            // BtnSystemInformation
            // 
            this.BtnSystemInformation.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnSystemInformation.BackColor = System.Drawing.Color.Transparent;
            this.BtnSystemInformation.BackgroundImage = global::Installer.Properties.Resources.Group_2176_2x_min;
            this.BtnSystemInformation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSystemInformation.FlatAppearance.BorderSize = 0;
            this.BtnSystemInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSystemInformation.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.BtnSystemInformation.ForeColor = System.Drawing.Color.White;
            this.BtnSystemInformation.Location = new System.Drawing.Point(444, 13);
            this.BtnSystemInformation.Name = "BtnSystemInformation";
            this.BtnSystemInformation.Size = new System.Drawing.Size(185, 35);
            this.BtnSystemInformation.TabIndex = 1;
            this.BtnSystemInformation.Text = "مشخصات سخت افزاری سیستم";
            this.BtnSystemInformation.UseVisualStyleBackColor = false;
            this.BtnSystemInformation.Click += new System.EventHandler(this.BtnSystemInformation_Click);
            // 
            // BtnPrequisitesDiag
            // 
            this.BtnPrequisitesDiag.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnPrequisitesDiag.BackColor = System.Drawing.Color.Transparent;
            this.BtnPrequisitesDiag.BackgroundImage = global::Installer.Properties.Resources.Group_2169_2x_min;
            this.BtnPrequisitesDiag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPrequisitesDiag.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPrequisitesDiag.FlatAppearance.BorderSize = 0;
            this.BtnPrequisitesDiag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPrequisitesDiag.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.BtnPrequisitesDiag.ForeColor = System.Drawing.Color.White;
            this.BtnPrequisitesDiag.Location = new System.Drawing.Point(620, 13);
            this.BtnPrequisitesDiag.Name = "BtnPrequisitesDiag";
            this.BtnPrequisitesDiag.Size = new System.Drawing.Size(185, 35);
            this.BtnPrequisitesDiag.TabIndex = 0;
            this.BtnPrequisitesDiag.Text = "بررسی پیش نیاز های نصب";
            this.BtnPrequisitesDiag.UseVisualStyleBackColor = false;
            this.BtnPrequisitesDiag.Click += new System.EventHandler(this.BtnPrequisitesDiag_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColStatus,
            this.ColPrerequisite,
            this.ColDiscription});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dataGridView1.Location = new System.Drawing.Point(0, 165);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(800, 233);
            this.dataGridView1.TabIndex = 2;
            // 
            // ColStatus
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.NullValue = false;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ColStatus.DefaultCellStyle = dataGridViewCellStyle12;
            this.ColStatus.FillWeight = 24.46675F;
            this.ColStatus.HeaderText = "وضعیت";
            this.ColStatus.Name = "ColStatus";
            this.ColStatus.ReadOnly = true;
            this.ColStatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ColPrerequisite
            // 
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ColPrerequisite.DefaultCellStyle = dataGridViewCellStyle13;
            this.ColPrerequisite.FillWeight = 98.65928F;
            this.ColPrerequisite.HeaderText = "پیش نیاز";
            this.ColPrerequisite.Name = "ColPrerequisite";
            this.ColPrerequisite.ReadOnly = true;
            this.ColPrerequisite.Width = 300;
            // 
            // ColDiscription
            // 
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ColDiscription.DefaultCellStyle = dataGridViewCellStyle14;
            this.ColDiscription.FillWeight = 176.8739F;
            this.ColDiscription.HeaderText = "توضیحات";
            this.ColDiscription.Name = "ColDiscription";
            this.ColDiscription.ReadOnly = true;
            this.ColDiscription.Width = 300;
            // 
            // BtnRerun
            // 
            this.BtnRerun.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnRerun.BackColor = System.Drawing.Color.Transparent;
            this.BtnRerun.BackgroundImage = global::Installer.Properties.Resources.Group_2169_min;
            this.BtnRerun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnRerun.Enabled = false;
            this.BtnRerun.FlatAppearance.BorderSize = 0;
            this.BtnRerun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRerun.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.BtnRerun.ForeColor = System.Drawing.Color.White;
            this.BtnRerun.Location = new System.Drawing.Point(98, 413);
            this.BtnRerun.Name = "BtnRerun";
            this.BtnRerun.Size = new System.Drawing.Size(90, 30);
            this.BtnRerun.TabIndex = 1;
            this.BtnRerun.Text = "بررسی مجدد";
            this.BtnRerun.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnRerun.UseVisualStyleBackColor = false;
            this.BtnRerun.Click += new System.EventHandler(this.BtnRerun_Click);
            // 
            // BtnNext
            // 
            this.BtnNext.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnNext.BackColor = System.Drawing.Color.Transparent;
            this.BtnNext.BackgroundImage = global::Installer.Properties.Resources.Group_2170_min;
            this.BtnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNext.Enabled = false;
            this.BtnNext.FlatAppearance.BorderSize = 0;
            this.BtnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNext.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.BtnNext.ForeColor = System.Drawing.Color.White;
            this.BtnNext.Location = new System.Drawing.Point(12, 413);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(80, 30);
            this.BtnNext.TabIndex = 4;
            this.BtnNext.Text = "ادامه";
            this.BtnNext.UseVisualStyleBackColor = false;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
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
            this.Controls.Add(this.BtnNext);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FrmPrerequisites";
            this.Text = "مشخصات سرور و پیش نیاز نصب";
            this.Load += new System.EventHandler(this.FrmPrerequisites_Load);
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