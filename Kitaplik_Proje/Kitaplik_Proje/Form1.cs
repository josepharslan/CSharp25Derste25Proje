﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kitaplik_Proje
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        KitapVT vtsinif = new KitapVT();
        private void BtnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = vtsinif.Liste();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            Kitap ktpsinif = new Kitap();
            ktpsinif.ADI = TxtKitapAd.Text;
            ktpsinif.YAZARI = TxtYazar.Text;

            vtsinif.KitapEkle(ktpsinif);
            MessageBox.Show("Kitap eklendi.");
        }
    }
}
