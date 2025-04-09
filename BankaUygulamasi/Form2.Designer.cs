namespace BankaUygulamasi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblAd = new System.Windows.Forms.Label();
            this.LblHesapNo = new System.Windows.Forms.Label();
            this.LblTelefon = new System.Windows.Forms.Label();
            this.LblTcKimlikNo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.MskHesapNo = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtTutar = new System.Windows.Forms.TextBox();
            this.BtnGonder = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.LblBakiye = new System.Windows.Forms.Label();
            this.BtnHareketlerim = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hesap No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefon:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tc Kimlik No:";
            // 
            // LblAd
            // 
            this.LblAd.AutoSize = true;
            this.LblAd.Location = new System.Drawing.Point(111, 20);
            this.LblAd.Name = "LblAd";
            this.LblAd.Size = new System.Drawing.Size(33, 18);
            this.LblAd.TabIndex = 4;
            this.LblAd.Text = "Null";
            // 
            // LblHesapNo
            // 
            this.LblHesapNo.AutoSize = true;
            this.LblHesapNo.Location = new System.Drawing.Point(111, 51);
            this.LblHesapNo.Name = "LblHesapNo";
            this.LblHesapNo.Size = new System.Drawing.Size(33, 18);
            this.LblHesapNo.TabIndex = 4;
            this.LblHesapNo.Text = "Null";
            // 
            // LblTelefon
            // 
            this.LblTelefon.AutoSize = true;
            this.LblTelefon.Location = new System.Drawing.Point(111, 82);
            this.LblTelefon.Name = "LblTelefon";
            this.LblTelefon.Size = new System.Drawing.Size(33, 18);
            this.LblTelefon.TabIndex = 4;
            this.LblTelefon.Text = "Null";
            // 
            // LblTcKimlikNo
            // 
            this.LblTcKimlikNo.AutoSize = true;
            this.LblTcKimlikNo.Location = new System.Drawing.Point(111, 113);
            this.LblTcKimlikNo.Name = "LblTcKimlikNo";
            this.LblTcKimlikNo.Size = new System.Drawing.Size(33, 18);
            this.LblTcKimlikNo.TabIndex = 4;
            this.LblTcKimlikNo.Text = "Null";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnGonder);
            this.groupBox1.Controls.Add(this.TxtTutar);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.MskHesapNo);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(19, 172);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 200);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Havale";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 18);
            this.label9.TabIndex = 0;
            this.label9.Text = "Hesap No:";
            // 
            // MskHesapNo
            // 
            this.MskHesapNo.Location = new System.Drawing.Point(104, 52);
            this.MskHesapNo.Mask = "000000";
            this.MskHesapNo.Name = "MskHesapNo";
            this.MskHesapNo.Size = new System.Drawing.Size(192, 26);
            this.MskHesapNo.TabIndex = 1;
            this.MskHesapNo.ValidatingType = typeof(int);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(52, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 18);
            this.label10.TabIndex = 2;
            this.label10.Text = "Tutar:";
            // 
            // TxtTutar
            // 
            this.TxtTutar.Location = new System.Drawing.Point(104, 92);
            this.TxtTutar.Name = "TxtTutar";
            this.TxtTutar.Size = new System.Drawing.Size(192, 26);
            this.TxtTutar.TabIndex = 3;
            // 
            // BtnGonder
            // 
            this.BtnGonder.Location = new System.Drawing.Point(150, 124);
            this.BtnGonder.Name = "BtnGonder";
            this.BtnGonder.Size = new System.Drawing.Size(95, 31);
            this.BtnGonder.TabIndex = 4;
            this.BtnGonder.Text = "Gönder";
            this.BtnGonder.UseVisualStyleBackColor = true;
            this.BtnGonder.Click += new System.EventHandler(this.BtnGonder_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(240, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Bakiye:";
            // 
            // LblBakiye
            // 
            this.LblBakiye.AutoSize = true;
            this.LblBakiye.Location = new System.Drawing.Point(297, 113);
            this.LblBakiye.Name = "LblBakiye";
            this.LblBakiye.Size = new System.Drawing.Size(33, 18);
            this.LblBakiye.TabIndex = 7;
            this.LblBakiye.Text = "Null";
            // 
            // BtnHareketlerim
            // 
            this.BtnHareketlerim.Location = new System.Drawing.Point(240, 77);
            this.BtnHareketlerim.Name = "BtnHareketlerim";
            this.BtnHareketlerim.Size = new System.Drawing.Size(130, 33);
            this.BtnHareketlerim.TabIndex = 8;
            this.BtnHareketlerim.Text = "Hareketlerim";
            this.BtnHareketlerim.UseVisualStyleBackColor = true;
            this.BtnHareketlerim.Click += new System.EventHandler(this.BtnHareketlerim_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(404, 404);
            this.Controls.Add(this.BtnHareketlerim);
            this.Controls.Add(this.LblBakiye);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LblTcKimlikNo);
            this.Controls.Add(this.LblTelefon);
            this.Controls.Add(this.LblHesapNo);
            this.Controls.Add(this.LblAd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblAd;
        private System.Windows.Forms.Label LblHesapNo;
        private System.Windows.Forms.Label LblTelefon;
        private System.Windows.Forms.Label LblTcKimlikNo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BtnGonder;
        private System.Windows.Forms.TextBox TxtTutar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox MskHesapNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblBakiye;
        private System.Windows.Forms.Button BtnHareketlerim;
    }
}