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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        public string hesap;
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-NJ1FR1D\SQLEXPRESS;Initial Catalog=DbBankaTest;Integrated Security=True");

        private void Form4_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM TBLHAREKET WHERE GONDEREN=@P1 OR ALICI=@P1", baglanti);
            komut.Parameters.AddWithValue("@P1",hesap);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
            
        }
    }
}
