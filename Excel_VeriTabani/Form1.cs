using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace Excel_VeriTabani
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\yusuf\OneDrive\Masaüstü\VeriTabani.xlsx; Extended Properties= 'Excel 12.0 Xml; HDR=YES;'");
        void listele()
        {
            baglanti.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM [Sayfa1$]", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void BtnListele_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("insert into [Sayfa1$] (Saat,Ders) VALUES (@p1, @p2)",baglanti);
            komut.Parameters.AddWithValue("@p1", txtSaat.Text);
            komut.Parameters.AddWithValue("@p2", txtDers.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Yeni ders eklendi.");
            listele();
        }
    }
}
