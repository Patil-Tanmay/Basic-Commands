using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ionic.Zip;
using System.IO;


namespace _Zip
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Folder_select_Click_1(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Please Select a path";
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtfolder.Text = fbd.SelectedPath;
            }
        }

        private void File_select_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.ValidateNames = true;
            fd.Multiselect = false;
            fd.Filter = "All Files | *.*";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                txtfile.Text = fd.FileName;
            }
        }

        private void Folder_zip_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtfolder.Text))
            {
                MessageBox.Show("Please select a proper folder", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtfolder.Focus();
                return;
            }
            string path = txtfolder.Text;
            Thread thread = new Thread(t =>
            {
                using (Ionic.Zip.ZipFile zip = new Ionic.Zip.ZipFile())
                {
                    zip.AddDirectory(path);
                    System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(path);
                    zip.SaveProgress += Zip_SaveProgress;
                    zip.Save(string.Format("{0}{1}.zip", di.Parent.FullName, di.Name));
                }

            })
            { IsBackground = true };
            thread.Start();
        }

        private void Zip_SaveProgress(object sender, SaveProgressEventArgs e)
        {
            if (e.EventType == Ionic.Zip.ZipProgressEventType.Saving_BeforeWriteEntry)
            {
                progressBar1.Invoke(new MethodInvoker(delegate
                {
                    progressBar1.Maximum = e.EntriesTotal;
                    progressBar1.Value = e.EntriesSaved + 1;
                    progressBar1.Update();
                   
                }
                ));
            }
        }

        private void File_zip_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtfile.Text))
            {
                MessageBox.Show("Please select a proper file", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtfile.Focus();
                return;
            }
            string filename = txtfile.Text;
            Thread thread = new Thread(t =>
            {
                using (Ionic.Zip.ZipFile zip = new Ionic.Zip.ZipFile())
                {
                    FileInfo fi = new FileInfo(filename);
                    zip.AddFile(filename);
                    System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(filename);
                    zip.SaveProgress += Zip_fileSaveProgress;
                    zip.Save(string.Format("{0}/{1}.zip", di.Parent.FullName, di.Name));
                }

            })
            { IsBackground = true };
            thread.Start();
        }
        private void Zip_fileSaveProgress(object sender, SaveProgressEventArgs e)
        {
            if (e.EventType == Ionic.Zip.ZipProgressEventType.Saving_EntryBytesRead)
            {
                progressBar1.Invoke(new MethodInvoker(delegate
                {
                    progressBar1.Maximum = 100;
                    progressBar1.Value = (int)((e.BytesTransferred * 100) / e.TotalBytesToTransfer);
                    progressBar1.Update();
                }
                 ));
            }
        }

     
    }
}
