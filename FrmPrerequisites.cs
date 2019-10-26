using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
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
                        // Set the number of rows to 'dataGridView1.DisplayedRowCount(false)' when you fixed the firewall problem.
                        int numberOfRows = dataGridView1.DisplayedRowCount(false) - 1;

                        // Correct the numberOfRows to 3 after you fixed the firewall.
                        if (numberOfRows == 2)
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
                Prerequisite prequisites = new Prerequisite();
                List<PrerequisiteViewModel> list = prequisites.GetPrerequisitesList();
                dataGridView1.Rows.Clear();
                for (int i = 0; i < list.Count; i++)
                {
                    dataGridView1.Rows.Add(list[i].Status, list[i].Name, list[i].Description);
                    if (dataGridView1.Rows[i].Cells[0].Value.Equals(true))
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                    }
                    else
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    }
                    // We can't find the status of the firewall yet. So its color would be yellow.
                    if (i == 2)
                        dataGridView1.Rows[2].DefaultCellStyle.BackColor = Color.Yellow;
                }

                BtnRerun.Enabled = true;

                // These lines enable the continue button if the publish path is entered and all the status properties are true.
                // At the moment, the firewall status does not get checked.
                if (!string.IsNullOrEmpty(TxtBxPublishPath.Text))
                {
                    // The variable 'count' is now set to 1 because the firewall status is not important at the moment.
                    int count = 1;

                    // The variable 'i' goes until 'list.count - 1' since the firewall status is not important yet.
                    for (int i = 0; i < list.Count - 1; i++)
                    {
                        if (list[i].Status == true)
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
                for (int i = 0; i < list.Count; i++)
                {
                    dataGridView1.Rows.Add(list[i].Status, list[i].Name, list[i].Description);
                    if (dataGridView1.Rows[i].Cells[0].Value.Equals(true))
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                    }
                    else
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    }
                    // Omit this part when the firewall problem gets fixed.
                    if(i == 2)
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                }
                // These codes enable the continue button if the publish path is entered and all the status properties are true.
                if (!string.IsNullOrEmpty(TxtBxPublishPath.Text))
                {
                    // Increment the numberOfRows by 1 when the firewall problem is fixed.
                    int numberOfRows = dataGridView1.DisplayedRowCount(false) - 1;

                    // Set this condition to 3 when the firewall problem is fixed.
                    if (numberOfRows == 2)
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

        private void FrmPrerequisites_Load(object sender, EventArgs e)
        {

        }
    }
}