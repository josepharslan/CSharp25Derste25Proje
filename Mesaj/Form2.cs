using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mesaj
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string numara;
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-NJ1FR1D\SQLEXPRESS;Initial Catalog=Test2;Integrated Security=True");
        void gelenkutusu()
        {
            SqlDataAdapter da1 = new SqlDataAdapter("SELECT GONDEREN_KISI.AD + ' ' + GONDEREN_KISI.SOYAD AS 'GÖNDEREN', ALICI_KISI.AD + ' ' + ALICI_KISI.SOYAD AS 'ALICI', BASLIK, ICERIK FROM TBLMESAJLAR INNER JOIN TBLKISILER AS GONDEREN_KISI ON TBLMESAJLAR.GONDEREN = GONDEREN_KISI.NUMARA INNER JOIN TBLKISILER AS ALICI_KISI ON TBLMESAJLAR.ALICI = ALICI_KISI.NUMARA where ALICI=" + numara, baglanti);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;
        }
       
        void gidenkutusu()
        {
            SqlDataAdapter da2 = new SqlDataAdapter("SELECT GONDEREN_KISI.AD + ' ' + GONDEREN_KISI.SOYAD AS 'GÖNDEREN', ALICI_KISI.AD + ' ' + ALICI_KISI.SOYAD AS 'ALICI', BASLIK, ICERIK FROM TBLMESAJLAR INNER JOIN TBLKISILER AS GONDEREN_KISI ON TBLMESAJLAR.GONDEREN = GONDEREN_KISI.NUMARA INNER JOIN TBLKISILER AS ALICI_KISI ON TBLMESAJLAR.ALICI = ALICI_KISI.NUMARA WHERE GONDEREN=" + numara, baglanti);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            LblNumara.Text = numara;

            gelenkutusu();
            gidenkutusu();

            //Ad Soyad Çekme
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT AD,SOYAD FROM TBLKISILER WHERE NUMARA=" + numara, baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
                LblAdSoyad.Text = dr[0] + " " + dr[1];
            baglanti.Close();
        }

        private void BtnGonder_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Insert into TBLMESAJLAR(GONDEREN,ALICI,BASLIK,ICERIK) VALUES(@P1,@P2,@P3,@P4)", baglanti);
            komut.Parameters.AddWithValue("@P1", numara);
            komut.Parameters.AddWithValue("@P2", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("@P3", textBox1.Text);
            komut.Parameters.AddWithValue("@P4", richTextBox1.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Mesajınız başarıyla iletilmiştir.");
            gidenkutusu();
        }
    }
}
