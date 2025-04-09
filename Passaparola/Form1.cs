using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passaparola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruno = 0, dogru = 0, yanlis = 0;

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                switch (soruno)
                {
                    case 1:
                        if (textBox1.Text == "Akdeniz")
                        {
                            btnA.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnA.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 2:
                        if (textBox1.Text == "Bursa")
                        {
                            btnB.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnB.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 3:
                        if (textBox1.Text == "Cuma")
                        {
                            btnC.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnC.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 4:
                        if (textBox1.Text == "Diyarbakır")
                        {
                            btnD.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnD.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 5:
                        if (textBox1.Text == "Eski")
                        {
                            btnE.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnE.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 6:
                        if (textBox1.Text == "Ferman")
                        {
                            btnF.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnF.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 7:
                        if (textBox1.Text == "Güneş")
                        {
                            btnG.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnG.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 8:
                        if (textBox1.Text == "Halı")
                        {
                            btnH.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnH.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 9:
                        if (textBox1.Text == "Isparta")
                        {
                            btnI.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnI.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 10:
                        if (textBox1.Text == "İçel")
                        {
                            btnİ.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnİ.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 11:
                        if (textBox1.Text == "Jandarma")
                        {
                            btnJ.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnJ.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 12:
                        if (textBox1.Text == "Kayısı")
                        {
                            btnK.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnK.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 13:
                        if (textBox1.Text == "Lale")
                        {
                            btnL.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnL.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 14:
                        if (textBox1.Text == "Mart")
                        {
                            btnM.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnM.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 15:
                        if (textBox1.Text == "Ney")
                        {
                            btnN.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnN.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 16:
                        if (textBox1.Text == "Ozan")
                        {
                            btnO.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnO.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 17:
                        if (textBox1.Text == "Pırasa")
                        {
                            btnP.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnP.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 18:
                        if (textBox1.Text == "Ramazan")
                        {
                            btnR.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnR.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 19:
                        if (textBox1.Text == "Snake")
                        {
                            btnS.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnS.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 20:
                        if (textBox1.Text == "Tarkan")
                        {
                            btnT.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnT.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 21:
                        if (textBox1.Text == "Umut")
                        {
                            btnU.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnU.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 22:
                        if (textBox1.Text == "Van")
                        {
                            btnV.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnV.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 23:
                        if (textBox1.Text == "Yıldırım")
                        {
                            btnY.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnY.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 24:
                        if (textBox1.Text == "Zeytin")
                        {
                            btnZ.BackColor = Color.Green;
                            dogru++;
                            lblDogru.Text = dogru.ToString();
                        }
                        else
                        {
                            btnZ.BackColor = Color.Red;
                            yanlis++;
                            lblYanlis.Text = yanlis.ToString();
                        }
                        break;
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            textBox1.Text = "";
            linkLabel1.Text = "Sonraki";
            soruno++;
            this.Text = "Soru " + soruno;

            if (soruno == 1)
            {
                richTextBox1.Text = "Ülkemizin Güney kısmındaki kıyı bölgesi?";
                btnA.BackColor = Color.Yellow;
            }

            if (soruno == 2)
            {
                richTextBox1.Text = "Yeşilliğiyle ünlü Marmara ilimiz?";
                btnB.BackColor = Color.Yellow;
            }

            if (soruno == 3)
            {
                richTextBox1.Text = "Müslümanların kutsal günü?";
                btnC.BackColor = Color.Yellow;
            }

            if (soruno == 4)
            {
                richTextBox1.Text = "Karpuzuyla ünlü ilimiz?";
                btnD.BackColor = Color.Yellow;
            }

            if (soruno == 5)
            {
                richTextBox1.Text = "Yeni kelimesinin zıt anlamlısı?";
                btnE.BackColor = Color.Yellow;
            }

            if (soruno == 6)
            {
                richTextBox1.Text = "Padişahın emirlerinin yazılı hali?";
                btnF.BackColor = Color.Yellow;
            }

            if (soruno == 7)
            {
                richTextBox1.Text = "Dünyanın ısı kaynağı?";
                btnG.BackColor = Color.Yellow;
            }

            if (soruno == 8)
            {
                richTextBox1.Text = "Öğrencilerin kötü karne getirince bakıştığı nesne?";
                btnH.BackColor = Color.Yellow;
            }

            if (soruno == 9)
            {
                richTextBox1.Text = "Gülüyle ünlü ilimiz?";
                btnI.BackColor = Color.Yellow;
            }

            if (soruno == 10)
            {
                richTextBox1.Text = "Mersin'in diğer ismi?";
                btnİ.BackColor = Color.Yellow;
            }

            if (soruno == 11)
            {
                richTextBox1.Text = "Askeri bir topluluk?";
                btnJ.BackColor = Color.Yellow;
            }

            if (soruno == 12)
            {
                richTextBox1.Text = "Malatya'nın meşhur meyvesi?";
                btnK.BackColor = Color.Yellow;
            }

            if (soruno == 13)
            {
                richTextBox1.Text = "Her yıl bahar aylarında düzenlenen meşhur çiçek festivali?";
                btnL.BackColor = Color.Yellow;
            }

            if (soruno == 14)
            {
                richTextBox1.Text = "Yılın üçüncü ayı?";
                btnM.BackColor = Color.Yellow;
            }

            if (soruno == 15)
            {
                richTextBox1.Text = "Üflemeli bir müzik aleti?";
                btnN.BackColor = Color.Yellow;
            }

            if (soruno == 16)
            {
                richTextBox1.Text = "Halk şairi?";
                btnO.BackColor = Color.Yellow;
            }

            if (soruno == 17)
            {
                richTextBox1.Text = "Çocukların çok sevmediği pirinç havuç gibi sebzeler ile yapılan yemek?";
                btnP.BackColor = Color.Yellow;
            }

            if (soruno == 18)
            {
                richTextBox1.Text = "11 ayın sultanı?";
                btnR.BackColor = Color.Yellow;
            }

            if (soruno == 19)
            {
                richTextBox1.Text = "İngilizcede yılan?";
                btnS.BackColor = Color.Yellow;
            }

            if (soruno == 20)
            {
                richTextBox1.Text = "Türkiye'nin megastarı?";
                btnT.BackColor = Color.Yellow;
            }

            if (soruno == 21)
            {
                richTextBox1.Text = "Ümit kelimesinin eş anlamlısı?";
                btnU.BackColor = Color.Yellow;
            }

            if (soruno == 22)
            {
                richTextBox1.Text = "Kahvaltısı ile ünlü ilimiz?";
                btnV.BackColor = Color.Yellow;
            }

            if (soruno == 23)
            {
                richTextBox1.Text = "Şimşek kelimesinin eş anlamlısı?";
                btnY.BackColor = Color.Yellow;
            }

            if (soruno == 24)
            {
                richTextBox1.Text = "Ege bölgesinin en çok ağacı bulunan yağı da yapılan bir kahvaltı besini?";
                btnZ.BackColor = Color.Yellow;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}