using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace depoEnvanterSTP.Tablolar
{
    public static class SirketGoruntule
    {
        private static string id;
        private static string sirketAdi;
        private static string sirketUnvani;
        private static string vergiDairesi;
        private static string vergiNo;
        private static string telefon;
        private static string faks;
        private static string adres;
        private static string email;

        public static string Id {
            get { return SirketGoruntule.id; }
            set { id = value; }
        }
        public static string SirketAdi {
            get { return SirketGoruntule.sirketAdi; }
            set { sirketAdi = value; }
        }

        public static string SirketUnvani {
            get { return SirketGoruntule.sirketUnvani; }
            set { sirketUnvani = value; }
        }
        public static string VergiDairesi {
            get { return SirketGoruntule.vergiDairesi; }
            set { vergiDairesi = value; }
        }
        public static string VergiNo {
            get { return SirketGoruntule.vergiNo; }
            set { vergiNo = value; }
        }
        public static string Telefon {
            get { return SirketGoruntule.telefon; }
            set { telefon = value; }
        }
        public static string Faks {
            get { return SirketGoruntule.faks; }
            set { faks = value; }
        }
        public static string Adres {
            get { return SirketGoruntule.adres; }
            set { adres = value; }
        }
        public static string Email {
            get { return SirketGoruntule.email; }
            set { email = value; }
        }
    }
}
