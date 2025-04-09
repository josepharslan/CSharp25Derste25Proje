namespace ResimProje
{
    partial class Form1
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
            this.BtnRenkSec = new System.Windows.Forms.Button();
            this.BtnResimSec = new System.Windows.Forms.Button();
            this.BtnYazdir = new System.Windows.Forms.Button();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtMetin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtBoyut = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnRenkSec
            // 
            this.BtnRenkSec.Location = new System.Drawing.Point(15, 14);
            this.BtnRenkSec.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.BtnRenkSec.Name = "BtnRenkSec";
            this.BtnRenkSec.Size = new System.Drawing.Size(213, 39);
            this.BtnRenkSec.TabIndex = 0;
            this.BtnRenkSec.Text = "Renk Seç";
            this.BtnRenkSec.UseVisualStyleBackColor = true;
            this.BtnRenkSec.Click += new System.EventHandler(this.BtnRenkSec_Click);
            // 
            // BtnResimSec
            // 
            this.BtnResimSec.Location = new System.Drawing.Point(15, 75);
            this.BtnResimSec.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.BtnResimSec.Name = "BtnResimSec";
            this.BtnResimSec.Size = new System.Drawing.Size(213, 39);
            this.BtnResimSec.TabIndex = 1;
            this.BtnResimSec.Text = "Resim Seç";
            this.BtnResimSec.UseVisualStyleBackColor = true;
            this.BtnResimSec.Click += new System.EventHandler(this.BtnResimSec_Click);
            // 
            // BtnYazdir
            // 
            this.BtnYazdir.Location = new System.Drawing.Point(15, 136);
            this.BtnYazdir.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.BtnYazdir.Name = "BtnYazdir";
            this.BtnYazdir.Size = new System.Drawing.Size(213, 39);
            this.BtnYazdir.TabIndex = 2;
            this.BtnYazdir.Text = "Yazdır";
            this.BtnYazdir.UseVisualStyleBackColor = true;
            this.BtnYazdir.Click += new System.EventHandler(this.BtnYazdir_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Location = new System.Drawing.Point(15, 197);
            this.BtnKaydet.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(213, 39);
            this.BtnKaydet.TabIndex = 3;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Metin:";
            // 
            // TxtMetin
            // 
            this.TxtMetin.Location = new System.Drawing.Point(87, 265);
            this.TxtMetin.Name = "TxtMetin";
            this.TxtMetin.Size = new System.Drawing.Size(150, 29);
            this.TxtMetin.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Boyut:";
            // 
            // TxtBoyut
            // 
            this.TxtBoyut.Location = new System.Drawing.Point(87, 320);
            this.TxtBoyut.Name = "TxtBoyut";
            this.TxtBoyut.Size = new System.Drawing.Size(150, 29);
            this.TxtBoyut.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(259, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(446, 340);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AcceptButton = this.BtnKaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 374);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TxtBoyut);
            this.Controls.Add(this.TxtMetin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.BtnYazdir);
            this.Controls.Add(this.BtnResimSec);
            this.Controls.Add(this.BtnRenkSec);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnRenkSec;
        private System.Windows.Forms.Button BtnResimSec;
        private System.Windows.Forms.Button BtnYazdir;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtMetin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtBoyut;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

