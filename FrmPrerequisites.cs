using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace Installer
{
    public partial class FrmPrerequisites : Form
    {
        public string PublishPath
        {
            get { return TxtBxPublishPath.Text; }
        }
        public FrmPrerequisites()
        {
            InitializeComponent();
        }

        private void BtnSystemInformation_Click(object sender, EventArgs e)
        {
            try
            {
                // This line starts the 'System Information'.
                Process.Start(@"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Administrative Tools\System Information");
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
                
                FrmFeaturesInstallation frmFeaturesInstallation = new FrmFeaturesInstallation(TxtBxPublishPath.Text);
                frmFeaturesInstallation.Show();
                Hide();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = folderBrowserDialog1.ShowDialog();
                if (!string.IsNullOrWhiteSpace(folderBrowserDialog1.SelectedPath))
                {
                    if (folderBrowserDialog1.SelectedPath.StartsWith("C"))
                        MessageBox.Show( "." + "باشد" + " C " + "مسیر پابلیش نباید در درایو ");
                    else
                    {
                        TxtBxPublishPath.Text = folderBrowserDialog1.SelectedPath;
                        // These lines enable the 'BtnNext' if all of its status cells are true.
                        int numberOfRows = dataGridView1.DisplayedRowCount(false);
                        if(numberOfRows == 3)
                        {
                            int count = 0;
                            for (int i = 0; i < numberOfRows; i++)
                            {
                                if (dataGridView1.Rows[i].Cells[0].Value.ToString() == "True")
                                    count++;
                            }
                            if (count == numberOfRows)
                                BtnNext.Enabled = true;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnPrequisitesDiag_Click(object sender, EventArgs e)
        {
            try
            {
                Prerequisite prequisities = new Prerequisite();
                List<PrerequisiteViewModel> list = prequisities.GetPrerequisitesList();
                dataGridView1.Rows.Clear();
                foreach (PrerequisiteViewModel obj in list)
                {
                    dataGridView1.Rows.Add(obj.Status, obj.Name, obj.Description);
                }

                BtnRerun.Enabled = true;

                // These lines enable the continue button if the publish path is entered and all the status properties are true.
                if (!string.IsNullOrEmpty(TxtBxPublishPath.Text))
                {
                    int count = 0;
                    foreach (PrerequisiteViewModel obj in list)
                    {
                        if (obj.Status == true)
                            count++;
                    }
                    if (count == list.Count)
                    {
                        BtnNext.Enabled = true;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void BtnRerun_Click(object sender, EventArgs e)
        {
            try
            {
                Prerequisite prequisities = new Prerequisite();
                List<PrerequisiteViewModel> list = prequisities.GetPrerequisitesList();
                dataGridView1.Rows.Clear();
                foreach (PrerequisiteViewModel obj in list)
                {
                    dataGridView1.Rows.Add(obj.Status, obj.Name, obj.Description);
                }
                // These codes enable the continue button if the publish path is entered and all the status properties are true.
                if (!string.IsNullOrEmpty(TxtBxPublishPath.Text))
                {
                    int numberOfRows = dataGridView1.DisplayedRowCount(false);
                    if (numberOfRows == 3)
                    {
                        int count = 0;
                        for (int i = 0; i < numberOfRows; i++)
                        {
                            if (dataGridView1.Rows[i].Cells[0].Value.ToString() == "True")
                                count++;
                        }
                        if (count == numberOfRows)
                            BtnNext.Enabled = true;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // By clicking the button, first the address of a help pdf file is saved in the path variable
        // and then it is passed to the start method inorder to get opened.
        private void BtnHelpPrequisites_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"C:\users\kouro\Desktop\Ubuntu.pdf";
                Process.Start(path);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}