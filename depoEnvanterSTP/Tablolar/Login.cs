using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace depoEnvanterSTP.Tablolar
{
    public static class Login
    {
        private static int id;
        private static string ad;
        private static string soyad;
        private static string dogumTarihi;
        private static string adres;
        private static string email;
        private static string kullaniciadi;
        private static string sifre;
        private static byte[] resim;
        private static char tip;

        public static int Id {
            get { return Login.id; }
            set { id = value; }
        }
        public static string Ad {
            get { return Login.ad; }
            set { ad = value;}
        }
        public static string Soyad {
            get { return Login.soyad; }
            set { soyad = value; }
        }
        public static string DogumTarihi
        {
            get { return Login.dogumTarihi; }
            set { dogumTarihi = value; }
        }
        public static string Adres
        {
            get { return Login.adres; }
            set { adres = value; }
        }
        public static string Email {
            get { return Login.email; }
            set { email = value; }
        }
        public static string Kullaniciadi {
            get { return Login.kullaniciadi; }
            set { kullaniciadi = value; }
        }
        public static string Sifre {
            get { return Login.sifre; }
            set { sifre = value; }
        }
        public static byte[] Resim {
            get { return Login.resim; }
            set { resim = value; }
        }
        public static char Tip {
            get { return Login.tip; }
            set { tip = value; }
        }

        
    }
}
