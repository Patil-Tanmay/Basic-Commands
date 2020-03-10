using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.Threading;


namespace BasicCommands
{
    public partial class Form1 : Form   
    {   
        
        BackgroundWorker _copyWorker = new BackgroundWorker();
        BackgroundWorker _moveWorker = new BackgroundWorker();
        BackgroundWorker _deleteworker = new BackgroundWorker();

        public Form1()
        {
            InitializeComponent();


            _copyWorker.WorkerSupportsCancellation = true;
            _moveWorker.WorkerSupportsCancellation = true;

            _copyWorker.WorkerReportsProgress = true;
            _moveWorker.WorkerReportsProgress = true;

            _copyWorker.ProgressChanged += worker_progresschanged;
            _moveWorker.ProgressChanged += worker_progresschanged;

           
            _copyWorker.DoWork += copywork;
            _moveWorker.DoWork += movework;
            
        }
        //used in copy_click button
        string copy_s;
        //used in move click button
        string move_s;
        //calling move function inn here so that value of progrssbar gets changed accordingly 
       
        private void movework(object sender,DoWorkEventArgs e)
        {
            move(textBox1.Text,move_s);
        }
        //calling copy function in do work so that value of progressbar gets changed accordingly
        private void copywork(object sender, DoWorkEventArgs e)
        {
            copy_p(textBox1.Text,copy_s);
            
        }
        //progressbar function
        private void worker_progresschanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
           
            label2.Text = progressBar1.Value.ToString() +"%";
            if (progressBar1.Value==100) {
                progressBar1.Value = 0;
                label2.Text = progressBar1.Value + "%";
            }
        }

        string path;
     
        //file selection
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.RestoreDirectory = true;
            fd.Filter = "All Files(*.*)|*.*";
            fd.Title = "Select a File";
            fd.FileName = "Any File";
            
            if (fd.ShowDialog() == DialogResult.OK)
            {
                 path = fd.FileName;               
            }
            textBox1.Text = path;


        }
        string temp;
        //to execute cmd commands
        private static string Execute(string Startfunc, String Arguments, String SetWorkingdir = null)
        {
           
            string text = null;
            Process p = new Process();
            p.StartInfo.FileName = Startfunc;
            p.StartInfo.Arguments = Arguments;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.RedirectStandardOutput = true;
            if (SetWorkingdir != null)
                p.StartInfo.WorkingDirectory = SetWorkingdir;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.CreateNoWindow = true;
            p.EnableRaisingEvents = true;
            p.Start();
            do
            {
                Application.DoEvents();
                string output = p.StandardOutput.ReadToEnd();
                text += output;
                string err = p.StandardError.ReadToEnd();
                text += err;
            }
            while (!p.HasExited);
            return text;
        }
        //copy paste funtion
        public void copy_p(string source,string destination)
        {
            FileStream fsout = new FileStream(destination,FileMode.Create);
            FileStream fsin = new FileStream(source, FileMode.Open);
            byte[] bt = new byte[1047856];
            int readbyte;
            while((readbyte=fsin.Read(bt ,0, bt.Length)) > 0)
            {
                fsout.Write(bt, 0, readbyte);
                _copyWorker.ReportProgress((int)(fsin.Position*100/fsin.Length));
            }
            fsin.Close();
            fsout.Close();
        }

        private void Copy_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fdb = new FolderBrowserDialog();
            if (fdb.ShowDialog()==DialogResult.OK)
            {
              copy_s=  Path.Combine(fdb.SelectedPath,Path.GetFileName(textBox1.Text));
                _copyWorker.RunWorkerAsync();
            }
       
      
        }
        //funtion to move file
        public void move(string source,string des)
        {

            copy_p(source, des);
            if (System.IO.File.Exists(source))
            {
                System.IO.File.Delete(source);
            }
        }

        private void Move_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fdb = new FolderBrowserDialog();
            if (fdb.ShowDialog() == DialogResult.OK)
            {   //very good way to get an destination path
                move_s = Path.Combine(fdb.SelectedPath, Path.GetFileName(textBox1.Text));
                MessageBox.Show(""+move_s);
                _moveWorker.RunWorkerAsync();

            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void Form1_MaximumSizeChanged(object sender, EventArgs e)
        {
            this.MaximumSize = new System.Drawing.Size(464, 454);
        }

        private void Form1_MinimumSizeChanged(object sender, EventArgs e)
        {
            this.MinimumSize = new System.Drawing.Size(361, 305);
        }
        //resizing the form size according to my conditions
        //furhter i set the tabcontrol's property to dock then i changed the form size 
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (tabControl1.SelectedTab == tabPage2)
            {
                this.Width= this.Width + 100;
                this.Height= this.Height + 100;
            }
            else
            {
                this.Width = this.Width - 100;
                this.Height = this.Height - 100;
            }
            

        }
     
        private void FIle_delete_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(textBox1.Text))
             {
              System.IO.File.Delete(textBox1.Text);
            }
           
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _Zip.Form2 f = new _Zip.Form2();  
            f.ShowDialog();
        }
    }
}
