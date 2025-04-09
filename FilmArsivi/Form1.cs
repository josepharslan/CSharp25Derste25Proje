using CefSharp;
using CefSharp.WinForms.Internals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmArsivi
{
    public partial class Form1 : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-NJ1FR1D\SQLEXPRESS;Initial Catalog=FilmArsivi;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        void filmler()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBLFILMLER",baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            filmler();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Insert into TBLFILMLER(AD,KATEGORI,LINK) Values(@p1,@p2,@p3)", baglanti);
            komut.Parameters.AddWithValue("@p1",TxtFilmAd.Text);
            komut.Parameters.AddWithValue("@p2",TxtFilmKategori.Text);
            komut.Parameters.AddWithValue("@p3",TxtFilmLink.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Film listenize eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            string link = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            chromiumWebBrowser1.LoadUrl(link);
        }

        private void BtnHakkimizda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu proje Yusuf Arslan tarafından 11 Şubat 2025 tarihinde kodlandı.","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnTamEkran_Click(object sender, EventArgs e)
        {

        }

        private void BtnRenkDegistir_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int red = random.Next(0, 256);
            int green = random.Next(0, 256);
            int blue = random.Next(0, 256);
            this.BackColor = Color.FromArgb(red, green, blue);
        }
    }
}
