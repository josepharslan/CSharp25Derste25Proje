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

namespace PastaneUrunMaliyetlendirme
{
    public partial class Form1 : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-NJ1FR1D\SQLEXPRESS;Initial Catalog=DbPastane;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }
        public void MalzemeListe()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from tblmalzemeler", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        void UrunListesi()
        {
            SqlDataAdapter da2 = new SqlDataAdapter("Select * from tblurunler", baglanti);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;
        }
        void Kasa()
        {
            SqlDataAdapter da3 = new SqlDataAdapter("select * from tblkasa", baglanti);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            dataGridView1.DataSource = dt3;
        }
        void Urunler()
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from tblurunler", baglanti); baglanti.Close();
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbUrun.ValueMember = "URUNID";
            cmbUrun.DisplayMember = "AD";
            cmbUrun.DataSource = dt;
            baglanti.Close();
        }
        void Malzemeler()
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from tblmalzemeler", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbMalzeme.ValueMember = "MALZEMEID";
            cmbMalzeme.DisplayMember = "AD";
            cmbMalzeme.DataSource = dt;
            baglanti.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MalzemeListe();

            Urunler();

            Malzemeler();
        }

        private void btnUrunListesi_Click(object sender, EventArgs e)
        {
            UrunListesi();
        }

        private void btnMalzemeListesi_Click(object sender, EventArgs e)
        {
            MalzemeListe();
        }

        private void btnKasa_Click(object sender, EventArgs e)
        {
            Kasa();
        }


        private void btnMalzemeEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into tblmalzemeler(ad,stok,fıyat,notlar) values(@p1,@p2,@p3,@p4)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtMalzemeAd.Text);
            komut.Parameters.AddWithValue("@p2", decimal.Parse(txtMalzemeStok.Text));
            komut.Parameters.AddWithValue("@p3", decimal.Parse(txtMalzemeFiyat.Text));
            komut.Parameters.AddWithValue("@p4", txtMalzemeNot.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Malzeme Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MalzemeListe();
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into tblurunler(ad) values(@p1)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtUrunAd.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            UrunListesi();
        }

        private void btnUrunOlustur_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into tblfırın(urunıd,malzemeıd,mıktar,malıyet) values(@p1,@p2,@p3,@p4)", baglanti);
            komut.Parameters.AddWithValue("@p1", cmbUrun.SelectedValue);
            komut.Parameters.AddWithValue("@p2", cmbMalzeme.SelectedValue);
            komut.Parameters.AddWithValue("@p3", decimal.Parse(txtMiktar.Text));
            komut.Parameters.AddWithValue("@p4", decimal.Parse(txtMaliyet.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Malzeme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            listBox1.Items.Add(cmbMalzeme.Text + " - " + txtMaliyet.Text);

        }

        private void txtMiktar_TextChanged(object sender, EventArgs e)
        {
            double maliyet;
            if (txtMiktar.Text == "")
            {
                txtMiktar.Text = "0";
            }

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from tblmalzemeler where malzemeıd=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", cmbMalzeme.SelectedValue);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
                txtMaliyet.Text = dr[3].ToString();
            baglanti.Close();
            maliyet = Convert.ToDouble(txtMaliyet.Text) / 1000 * Convert.ToDouble(txtMiktar.Text);
            txtMaliyet.Text = maliyet.ToString();
        }


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtUrunId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtUrunAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select sum(malıyet) from tblfırın where urunıd =@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", txtUrunId.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
                txtUrunMFiyat.Text = dr[0].ToString();
            baglanti.Close();
        }
    }
}
