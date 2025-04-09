using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SifreliVeriler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-NJ1FR1D\SQLEXPRESS;Initial Catalog=Test;Integrated Security=True");

        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBLVERILER", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        void VerileriCozVeDataGridViewdeGoster()
        {
            try
            {
                using (baglanti)
                {
                    baglanti.Open();

                    SqlCommand komut = new SqlCommand("SELECT * FROM TBLVERILER", baglanti);
                    SqlDataReader dr = komut.ExecuteReader(); 

                    DataTable dt = new DataTable();
                    dt.Columns.Add("AD");
                    dt.Columns.Add("SOYAD");
                    dt.Columns.Add("MAIL");
                    dt.Columns.Add("SIFRE");
                    dt.Columns.Add("HESAPNO");

                    while (dr.Read())
                    {
                        string adcozum = Encoding.ASCII.GetString(Convert.FromBase64String(dr["AD"].ToString()));
                        string soyadcozum = Encoding.ASCII.GetString(Convert.FromBase64String(dr["SOYAD"].ToString()));
                        string mailcozum = Encoding.ASCII.GetString(Convert.FromBase64String(dr["MAIL"].ToString()));
                        string sifrecozum = Encoding.ASCII.GetString(Convert.FromBase64String(dr["SIFRE"].ToString()));
                        string hesapnocozum = Encoding.ASCII.GetString(Convert.FromBase64String(dr["HESAPNO"].ToString()));

                        dt.Rows.Add(adcozum, soyadcozum, mailcozum, sifrecozum, hesapnocozum);
                    }

                    dr.Close();

                    // DataTable, DataGridView'e bağlanıyor
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                // Hata durumunda kullanıcıya bilgi veriliyor
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string ad = TxtAd.Text;
            byte[] addizi = ASCIIEncoding.ASCII.GetBytes(ad);
            string adsifre = Convert.ToBase64String(addizi);

            string soyad = TxtSoyad.Text;
            byte[] soyaddizi = ASCIIEncoding.ASCII.GetBytes(soyad);
            string soyadsifre = Convert.ToBase64String(soyaddizi);

            string mail = TxtMail.Text;
            byte[] maildizi = ASCIIEncoding.ASCII.GetBytes(mail);
            string mailsifre = Convert.ToBase64String(maildizi);

            string sifre = TxtSifre.Text;
            byte[] sifredizi = ASCIIEncoding.ASCII.GetBytes(sifre);
            string sifresifre = Convert.ToBase64String(sifredizi);

            string hesapno = TxtHesapNo.Text;
            byte[] hesapnodizi = ASCIIEncoding.ASCII.GetBytes(hesapno);
            string hesapnosifre = Convert.ToBase64String(hesapnodizi);

            baglanti.Open();
            SqlCommand komut = new SqlCommand("Insert into TBLVERILER(AD,SOYAD,MAIL,SIFRE,HESAPNO) values(@p1,@p2,@p3,@p4,@p5)", baglanti);
            komut.Parameters.AddWithValue("@p1", adsifre);
            komut.Parameters.AddWithValue("@p2", soyadsifre);
            komut.Parameters.AddWithValue("@p3", mailsifre);
            komut.Parameters.AddWithValue("@p4", sifresifre);
            komut.Parameters.AddWithValue("@p5", hesapnosifre);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Veriler eklendi.");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
            VerileriCozVeDataGridViewdeGoster();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string adcozum = TxtAd.Text;
            byte[] adcozumdizi = Convert.FromBase64String(adcozum);
            string adverisi = ASCIIEncoding.ASCII.GetString(adcozumdizi);
            label6.Text = adverisi;
        }
    }
}
