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

namespace BankaUygulamasi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-NJ1FR1D\SQLEXPRESS;Initial Catalog=DbBankaTest;Integrated Security=True");

        public string hesap;
        private void Form2_Load(object sender, EventArgs e)
        {
            LblHesapNo.Text = hesap;

            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM TBLKISILER LEFT JOIN TBLHESAP ON TBLHESAP.HESAPNO = TBLKISILER.HESAPNO", baglanti);
            komut.Parameters.AddWithValue("@P1", LblHesapNo.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblAd.Text = dr[1] + " " + dr[2];
                LblTcKimlikNo.Text = dr[3].ToString();
                LblTelefon.Text = dr[4].ToString();
                LblBakiye.Text = dr[8].ToString();
            }
            baglanti.Close();
        }

        private void BtnGonder_Click(object sender, EventArgs e)
        {
            //Gönderilen hesabın para artışı
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update TBLHESAP SET BAKIYE = BAKIYE+@P1 WHERE HESAPNO=@P2", baglanti);
            komut.Parameters.AddWithValue("@P1", decimal.Parse(TxtTutar.Text));
            komut.Parameters.AddWithValue("@P2", MskHesapNo.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();

            //Gönderen hesabın para azalışı
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Update TBLHESAP SET BAKIYE = BAKIYE-@K1 WHERE HESAPNO=@K2", baglanti);
            komut2.Parameters.AddWithValue("@K1", decimal.Parse(TxtTutar.Text));
            komut2.Parameters.AddWithValue("@K2", hesap);
            komut2.ExecuteNonQuery();
            baglanti.Close();

            //Yapılan işlemin hareketler tablosuna işlenişi
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("INSERT INTO TBLHAREKET (GONDEREN, ALICI, TUTAR) VALUES (@Gonderen, @Alici, @Tutar)", baglanti);
            komut3.Parameters.AddWithValue("@Gonderen", hesap);
            komut3.Parameters.AddWithValue("@Alici", MskHesapNo.Text);
            komut3.Parameters.AddWithValue("@Tutar", decimal.Parse(TxtTutar.Text));
            komut3.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("İşlem Gerçekleşti.");
        }

        private void BtnHareketlerim_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
            frm.hesap = hesap;
            frm.Show();
        }
    }
}
