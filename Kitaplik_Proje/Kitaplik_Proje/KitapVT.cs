using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Kitaplik_Proje
{
    class KitapVT
    {
        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Yusuf\Desktop\Kitaplik.mdb");

        public List<Kitap> Liste()
        {
            List<Kitap> ktp = new List<Kitap>();
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Select * FROM Kitaplar", baglanti);
            OleDbDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Kitap k = new Kitap();
                k.ID = int.Parse(dr[0].ToString());
                k.ADI = dr[1].ToString();
                k.YAZARI = dr[2].ToString();

                ktp.Add(k);
            }
            baglanti.Close();
            return ktp;
        }

        public void KitapEkle(Kitap kt)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("INSERT INTO Kitaplar(KitapAd,Yazar) Values(@p1,@p2)", baglanti);
            komut.Parameters.AddWithValue("@p1", kt.ADI);
            komut.Parameters.AddWithValue("@p2", kt.YAZARI);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
    }
}
