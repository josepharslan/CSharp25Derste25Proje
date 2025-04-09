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

namespace AkaryakitIstasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-Q5AS3R4\SQLEXPRESS;Initial Catalog=AkaryakitIstasyonu;Integrated Security=True;Encrypt=False");

        void listele()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from TBLBENZIN WHERE PETROLTURU='Kursunsuz95'", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblKursunsuz95.Text = dr[3].ToString();
                progressBar1.Value = int.Parse(dr[4].ToString());
                LblKursunsuz95Litre.Text = dr[4].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("Select * from TBLBENZIN WHERE PETROLTURU='Diesel'", baglanti);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                LblDiesel.Text = dr1[3].ToString();
                progressBar2.Value = int.Parse(dr1[4].ToString());
                LblDieselLitre.Text = dr1[4].ToString();

            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select * from TBLBENZIN WHERE PETROLTURU='Gaz'", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                LblGaz.Text = dr2[3].ToString();
                progressBar3.Value = int.Parse(dr2[4].ToString());
                LblGazLitre.Text = dr2[4].ToString();

            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("Select * from TBLBENZIN WHERE PETROLTURU='Kursunsuz95'", baglanti);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                LblKursunsuzAlis.Text = dr3[2].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("Select * from TBLBENZIN WHERE PETROLTURU='Diesel'", baglanti);
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                LblDizelAlis.Text = dr4[2].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("Select * from TBLBENZIN WHERE PETROLTURU='Gaz'", baglanti);
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                LblGazAlis.Text = dr5[2].ToString();
            }
            baglanti.Close();
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("SELECT * FROM TBLKASA", baglanti);
            SqlDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            {
                LblKasa.Text = dr6[0].ToString();
            }
            baglanti.Close();

            SqlCommand komut7 = new SqlCommand("SELECT * FROM TBLBENZIN", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut7);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox1.DataSource = dt;
            comboBox1.ValueMember = "ID";
            comboBox1.DisplayMember = "PETROLTURU";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            double kursunsuz95, litre, tutar;
            kursunsuz95 = double.Parse(LblKursunsuz95.Text);
            litre = Convert.ToDouble(numericUpDown1.Value);
            tutar = kursunsuz95 * litre;
            TxtKursunsuz95Fiyat.Text = tutar.ToString();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            double diesel, litre, tutar;
            diesel = double.Parse(LblDiesel.Text);
            litre = Convert.ToDouble(numericUpDown2.Value);
            tutar = diesel * litre;
            TxtDieselFiyat.Text = tutar.ToString();
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            double gaz, litre, tutar;
            gaz = double.Parse(LblGaz.Text);
            litre = double.Parse(numericUpDown3.Value.ToString());
            tutar = gaz * litre;
            TxtGazFiyat.Text = tutar.ToString();
        }

        private void BtnDepoDoldur_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value != 0)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Insert into TBLHAREKET(PLAKA,BENZINTURU,LITRE,FIYAT) VALUES (@p1,@p2,@p3,@p4)", baglanti);
                komut.Parameters.AddWithValue("@p1", TxtPlaka.Text);
                komut.Parameters.AddWithValue("@p2", "Kursunsuz95");
                komut.Parameters.AddWithValue("@p3", numericUpDown1.Value);
                komut.Parameters.AddWithValue("@p4", TxtKursunsuz95Fiyat.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();

                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("UPDATE TBLKASA SET BAKIYE= BAKIYE+@p1", baglanti);
                komut2.Parameters.AddWithValue("@p1", TxtKursunsuz95Fiyat.Text);
                komut2.ExecuteNonQuery();
                baglanti.Close();

                baglanti.Open();
                SqlCommand komut3 = new SqlCommand("UPDATE TBLBENZIN SET STOK = STOK-@p1 WHERE PETROLTURU='Kursunsuz95'", baglanti);
                komut3.Parameters.AddWithValue("@p1", numericUpDown1.Value);
                komut3.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Satış başarıyla gerçekleşmiştir.");
                listele();
            }
            if (numericUpDown2.Value != 0)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Insert into TBLHAREKET(PLAKA,BENZINTURU,LITRE,FIYAT) VALUES (@p1,@p2,@p3,@p4)", baglanti);
                komut.Parameters.AddWithValue("@p1", TxtPlaka.Text);
                komut.Parameters.AddWithValue("@p2", "Diesel");
                komut.Parameters.AddWithValue("@p3", numericUpDown2.Value);
                komut.Parameters.AddWithValue("@p4", TxtDieselFiyat.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();

                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("UPDATE TBLKASA SET BAKIYE= BAKIYE+@p1", baglanti);
                komut2.Parameters.AddWithValue("@p1", TxtDieselFiyat.Text);
                komut2.ExecuteNonQuery();
                baglanti.Close();

                baglanti.Open();
                SqlCommand komut3 = new SqlCommand("UPDATE TBLBENZIN SET STOK = STOK-@p1 WHERE PETROLTURU='Diesel'", baglanti);
                komut3.Parameters.AddWithValue("@p1", numericUpDown2.Value);
                komut3.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Satış başarıyla gerçekleşmiştir.");
                listele();
            }
            if (numericUpDown3.Value != 0)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Insert into TBLHAREKET(PLAKA,BENZINTURU,LITRE,FIYAT) VALUES (@p1,@p2,@p3,@p4)", baglanti);
                komut.Parameters.AddWithValue("@p1", TxtPlaka.Text);
                komut.Parameters.AddWithValue("@p2", "Gaz");
                komut.Parameters.AddWithValue("@p3", numericUpDown3.Value);
                komut.Parameters.AddWithValue("@p4", TxtGazFiyat.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();

                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("UPDATE TBLKASA SET BAKIYE= BAKIYE+@p1", baglanti);
                komut2.Parameters.AddWithValue("@p1", TxtGazFiyat.Text);
                komut2.ExecuteNonQuery();
                baglanti.Close();

                baglanti.Open();
                SqlCommand komut3 = new SqlCommand("UPDATE TBLBENZIN SET STOK = STOK-@p1 WHERE PETROLTURU='Gaz'", baglanti);
                komut3.Parameters.AddWithValue("@p1", numericUpDown3.Value);
                komut3.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Satış başarıyla gerçekleşmiştir.");
                listele();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal bakiyeGuncellemeDegeri = 0;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("UPDATE TBLBENZIN SET STOK = STOK+@p1 WHERE ID=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1", numericUpDown4.Value);
            komut.Parameters.AddWithValue("@p2", comboBox1.SelectedValue);
            komut.ExecuteNonQuery();
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("UPDATE TBLKASA SET BAKIYE= BAKIYE-@p1", baglanti);
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    bakiyeGuncellemeDegeri = decimal.Parse(LblKursunsuzAlis.Text) * numericUpDown4.Value;
                    break;
                case 1:
                    bakiyeGuncellemeDegeri = decimal.Parse(LblDizelAlis.Text) * numericUpDown4.Value;
                    break;
                case 2:
                    bakiyeGuncellemeDegeri = decimal.Parse(LblGazAlis.Text) * numericUpDown4.Value;
                    break;

            }

            komut2.Parameters.AddWithValue("@p1", bakiyeGuncellemeDegeri.ToString());
            komut2.ExecuteNonQuery();
            baglanti.Close();


            listele();
        }
    }
}

