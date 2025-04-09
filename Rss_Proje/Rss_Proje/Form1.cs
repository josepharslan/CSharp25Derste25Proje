using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Rss_Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void habergetir(String a)
        {
            listBox1.Items.Clear();
            XmlTextReader b = new XmlTextReader(a);
            while (b.Read())
            {
                if (b.Name == "title")
                {
                    listBox1.Items.Add(b.ReadString());
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            habergetir("http://www.hurriyet.com.tr/rss/anasayfa/");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            habergetir("https://www.donanimhaber.com/rss/tum/");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            habergetir("https://www.fotomac.com.tr/rss/anasayfa.xml");
        }
    }
}
