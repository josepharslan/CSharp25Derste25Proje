using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace List_Ornek
{
    class Kisiler
    {
        string ad;
        string soyad;
        string meslek;

        public string adi
        {
            get { return ad; }
            set { ad = value; }

        }

        public string soyadi
        {
            get { return soyad; }
            set { soyad = value; }
        }
        public string mesleki
        {
            get { return meslek; }
            set { meslek = value; }
        }
    }
}
