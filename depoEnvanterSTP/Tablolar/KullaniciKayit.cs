using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace depoEnvanterSTP.Database
{
    public class KullaniciKayit:IArayuz
    {
        private int id;
        private string ad;
        private string soyad;
        private DateTime dogumTarihi;
        private string adres;
        private string email;
        private string kullaniciadi;
        private string sifre;
        private byte[] resim;
        private char tip;

        public int Id { get => id; set => id = value; }
        public string Ad { get => ad; set => ad = value; }
        public string Soyad { get => soyad; set => soyad = value; }
        public string Email { get => email; set => email = value; }
        public string Kullaniciadi { get => kullaniciadi; set => kullaniciadi = value; }
        public string Sifre { get => sifre; set => sifre = value; }
        public byte[] Resim { get => resim; set => resim = value; }
        public char Tip { get => tip; set => tip = value; }
        public DateTime DogumTarihi { get => dogumTarihi; set => dogumTarihi = value; }
        public string Adres { get => adres; set => adres = value; }
    }
}
