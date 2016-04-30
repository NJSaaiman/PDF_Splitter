using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Diagnostics;
using System.Threading.Tasks;

namespace PDF_Splitter
{
    public partial class frmMain : MetroForm
    {
        public frmMain()
        {
            InitializeComponent();

            
            tbFileSize.Minimum = 1;
            tbFileSize.Maximum = 50;
            textFileSize.Text = tbFileSize.Value.ToString();

            tbFileSize.ValueChanged += tbFileSize_ValueChanged;
            
            
        }

        void tbFileSize_ValueChanged(object sender, EventArgs e)
        {
            textFileSize.Text = tbFileSize.Value.ToString();
            //tbFileSize.Update();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string sourcePath = txtSourceLocation.Text;
            string destination = txtOutputLocation.Text;

            if (Directory.Exists(sourcePath))
            {
                if (Directory.Exists(destination))
                {
                    
                    string fileName = Path.Combine(destination, "Merged.pdf");
                    button1.Enabled = false;
                    progress.Visible = true;
                    progress.Enabled = true;
                  
                        Array.ForEach(Directory.GetFiles(destination), File.Delete);
                        if (this.radioSplitFiles.Checked)
                        {
                            Utils.MergePDFs(fileName, Directory.GetFiles(sourcePath));
                            if (this.radioSplitSize.Checked)
                            {
                                Utils.ExtractPagePerSize(fileName, destination, 1, decimal.Parse(textFileSize.Text));
                            }
                            else if (this.radioSplitPage.Checked)
                            {
                                Utils.ExtractPagePerPage(fileName, destination, int.Parse(textFileSize.Text));
                            }

                            if (File.Exists(fileName))
                            {
                                File.Delete(fileName);
                            }
                        }
                        else if (radioCombineFiles.Checked)
                        {
                            Utils.MergePDFs(fileName, Directory.GetFiles(sourcePath));
                        }

                  
                        if (MetroFramework.MetroMessageBox.Show(this, "Requested operation has been completed. Do you want to open the destination folder", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                        {
                            Process.Start("explorer.exe", destination);
                        }
                
                        button1.Enabled = false;
                        progress.Visible = true;
                         progress.Enabled = true;
                    
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Invalid output path specified.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSourceLocation.Text = "";
                }

            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Invalid source path specified.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSourceLocation.Text = "";
            }
            
        }

       

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void butSourceFind_Click(object sender, EventArgs e)
        {
            txtSourceLocation.Text = Helpers.ShowFolderSelectDialog("Select folder where original pdf's are stored");
            txtSourceLocation.Focus();
        }

        private void butOutputFind_Click(object sender, EventArgs e)
        {
            txtOutputLocation.Text = Helpers.ShowFolderSelectDialog("Select folder to store pdf's after the split");
            txtOutputLocation.Focus();
        }

        
    }
}
