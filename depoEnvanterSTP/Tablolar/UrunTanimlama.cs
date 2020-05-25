using depoEnvanterSTP.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace depoEnvanterSTP.Tablolar
{
    public class UrunTanimlama:IArayuz
    {
        private int id;
        private string urunAdi;
        private string urunKodu;
        private int odaId;
        private int adet;
        private double birimFiyat;
        private double toplamFiyat;
        private string aciklama;
        private byte[] resim;
        private string marka;
        private string model;

        public int Id { get => id; set => id = value; }
        public string UrunAdi { get => urunAdi; set => urunAdi = value; }
        public string UrunKodu { get => urunKodu; set => urunKodu = value; }
        public int OdaId { get => odaId; set => odaId = value; }
        public int Adet { get => adet; set => adet = value; }
        public double BirimFiyat { get => birimFiyat; set => birimFiyat = value; }
        public double ToplamFiyat { get => toplamFiyat; set => toplamFiyat = value; }
        public string Aciklama { get => aciklama; set => aciklama = value; }
        public byte[] Resim { get => resim; set => resim = value; }
        public string Marka { get => marka; set => marka = value; }
        public string Model { get => model; set => model = value; }
    }
}
