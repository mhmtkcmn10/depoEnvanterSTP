using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace depoEnvanterSTP.Tablolar
{
    public static class UrunBilgiTasima
    {
        private static int id;
        private static string urunAdi;
        private static string urunKodu;
        private static string odaId;
        private static int adet;
        private static double birimFiyat;
        private static double toplamFiyat;
        private static string aciklama;
        private static byte[] resim;
        private static string marka;
        private static string model;

        public static int Id
        {
            get { return UrunBilgiTasima.id; }
            set { id = value; }
        }

        public static string UrunAdi
        {
            get { return UrunBilgiTasima.urunAdi; }
            set { urunAdi = value; }
        }
        public static string UrunKodu
        {
            get { return UrunBilgiTasima.urunKodu; }
            set { urunKodu = value; }
        }
        public static string OdaId
        {
            get { return UrunBilgiTasima.odaId; }
            set { odaId = value; }
        }
        public static int Adet
        {
            get { return UrunBilgiTasima.adet; }
            set { adet = value; }
        }
        public static double BirimFiyat
        {
            get { return UrunBilgiTasima.birimFiyat; }
            set { birimFiyat = value; }
        }
        public static double ToplamFiyat
        {
            get { return UrunBilgiTasima.toplamFiyat; }
            set { toplamFiyat = value; }
        }
        public static string Aciklama
        {
            get { return UrunBilgiTasima.aciklama; }
            set { aciklama = value; }
        }
        public static byte[] Resim
        {
            get { return UrunBilgiTasima.resim; }
            set { resim = value; }
        }
        public static string Marka
        {
            get { return UrunBilgiTasima.marka; }
            set { marka  = value; }
        }
        public static string Model
        {
            get { return UrunBilgiTasima.model; }
            set { model = value; }
        }
    }
}
