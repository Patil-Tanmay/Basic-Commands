namespace _Zip
{
    partial class Form2
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
            this.File_zip = new System.Windows.Forms.Button();
            this.Folder_zip = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.File_select = new System.Windows.Forms.Button();
            this.txtfile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Folder_select = new System.Windows.Forms.Button();
            this.txtfolder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._Extarct = new System.Windows.Forms.Button();
            this.Zipfile = new System.Windows.Forms.Button();
            this.txtzip = new System.Windows.Forms.TextBox();
            this.ziplabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // File_zip
            // 
            this.File_zip.Location = new System.Drawing.Point(417, 37);
            this.File_zip.Name = "File_zip";
            this.File_zip.Size = new System.Drawing.Size(62, 23);
            this.File_zip.TabIndex = 18;
            this.File_zip.Text = "Zip";
            this.File_zip.UseVisualStyleBackColor = true;
            this.File_zip.Click += new System.EventHandler(this.File_zip_Click_1);
            // 
            // Folder_zip
            // 
            this.Folder_zip.Location = new System.Drawing.Point(417, 9);
            this.Folder_zip.Name = "Folder_zip";
            this.Folder_zip.Size = new System.Drawing.Size(62, 22);
            this.Folder_zip.TabIndex = 17;
            this.Folder_zip.Text = "Zip";
            this.Folder_zip.UseVisualStyleBackColor = true;
            this.Folder_zip.Click += new System.EventHandler(this.Folder_zip_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(70, 100);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(304, 29);
            this.progressBar1.TabIndex = 16;
            // 
            // File_select
            // 
            this.File_select.Location = new System.Drawing.Point(380, 37);
            this.File_select.Name = "File_select";
            this.File_select.Size = new System.Drawing.Size(31, 22);
            this.File_select.TabIndex = 15;
            this.File_select.Text = "....";
            this.File_select.UseVisualStyleBackColor = true;
            this.File_select.Click += new System.EventHandler(this.File_select_Click);
            // 
            // txtfile
            // 
            this.txtfile.Location = new System.Drawing.Point(70, 36);
            this.txtfile.Multiline = true;
            this.txtfile.Name = "txtfile";
            this.txtfile.Size = new System.Drawing.Size(304, 23);
            this.txtfile.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 22);
            this.label2.TabIndex = 13;
            this.label2.Text = "File";
            // 
            // Folder_select
            // 
            this.Folder_select.Location = new System.Drawing.Point(380, 9);
            this.Folder_select.Name = "Folder_select";
            this.Folder_select.Size = new System.Drawing.Size(31, 22);
            this.Folder_select.TabIndex = 12;
            this.Folder_select.Text = "....";
            this.Folder_select.UseVisualStyleBackColor = true;
            this.Folder_select.Click += new System.EventHandler(this.Folder_select_Click_1);
            // 
            // txtfolder
            // 
            this.txtfolder.Location = new System.Drawing.Point(70, 9);
            this.txtfolder.Multiline = true;
            this.txtfolder.Name = "txtfolder";
            this.txtfolder.Size = new System.Drawing.Size(304, 22);
            this.txtfolder.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Folder";
            // 
            // _Extarct
            // 
            this._Extarct.Location = new System.Drawing.Point(417, 66);
            this._Extarct.Name = "_Extarct";
            this._Extarct.Size = new System.Drawing.Size(62, 23);
            this._Extarct.TabIndex = 22;
            this._Extarct.Text = "Extract_file";
            this._Extarct.UseVisualStyleBackColor = true;
            this._Extarct.Click += new System.EventHandler(this._Extarct_Click);
            // 
            // Zipfile
            // 
            this.Zipfile.Location = new System.Drawing.Point(380, 66);
            this.Zipfile.Name = "Zipfile";
            this.Zipfile.Size = new System.Drawing.Size(31, 22);
            this.Zipfile.TabIndex = 21;
            this.Zipfile.Text = "....";
            this.Zipfile.UseVisualStyleBackColor = true;
            this.Zipfile.Click += new System.EventHandler(this.Zipfile_Click);
            // 
            // txtzip
            // 
            this.txtzip.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtzip.Location = new System.Drawing.Point(70, 65);
            this.txtzip.Multiline = true;
            this.txtzip.Name = "txtzip";
            this.txtzip.Size = new System.Drawing.Size(304, 23);
            this.txtzip.TabIndex = 20;
            // 
            // ziplabel
            // 
            this.ziplabel.Location = new System.Drawing.Point(3, 66);
            this.ziplabel.Name = "ziplabel";
            this.ziplabel.Size = new System.Drawing.Size(61, 22);
            this.ziplabel.TabIndex = 19;
            this.ziplabel.Text = "Zip";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 141);
            this.Controls.Add(this._Extarct);
            this.Controls.Add(this.Zipfile);
            this.Controls.Add(this.txtzip);
            this.Controls.Add(this.ziplabel);
            this.Controls.Add(this.File_zip);
            this.Controls.Add(this.Folder_zip);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.File_select);
            this.Controls.Add(this.txtfile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Folder_select);
            this.Controls.Add(this.txtfolder);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Zipper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button File_zip;
        private System.Windows.Forms.Button Folder_zip;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button File_select;
        private System.Windows.Forms.TextBox txtfile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Folder_select;
        private System.Windows.Forms.TextBox txtfolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button _Extarct;
        private System.Windows.Forms.Button Zipfile;
        private System.Windows.Forms.TextBox txtzip;
        private System.Windows.Forms.Label ziplabel;
    }
}