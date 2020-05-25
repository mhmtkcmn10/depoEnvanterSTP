using depoEnvanterSTP.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace depoEnvanterSTP.Tablolar
{
    public class StokCikis:IArayuz
    {
        private int id;
        private string belgeNumarasi;
        private int gonderici;
        private string alici;
        private DateTime tarih;
        private DateTime fiiliSevkTarihi;
        private int vergiNumarasi;
        private string sevkAdresi;
        private int urunNo;
        private int cikisAdet;
        private string durum;

        private int cikisAdet2;



        public int Id { get => id; set => id = value; }
        public string BelgeNumarasi { get => belgeNumarasi; set => belgeNumarasi = value; }
        public int Gonderici { get => gonderici; set => gonderici = value; }
        public string Alici { get => alici; set => alici = value; }
       
        public int VergiNumarasi { get => vergiNumarasi; set => vergiNumarasi = value; }
        public string SevkAdresi { get => sevkAdresi; set => sevkAdresi = value; }
        public int UrunNo { get => urunNo; set => urunNo = value; }
        public DateTime Tarih { get => tarih; set => tarih = value; }
        public DateTime FiiliSevkTarihi { get => fiiliSevkTarihi; set => fiiliSevkTarihi = value; }
        public int CikisAdet { get => cikisAdet; set => cikisAdet = value; }
        public string Durum { get => durum; set => durum = value; }
        public int CikisAdet2 { get => cikisAdet2; set => cikisAdet2 = value; }
    }
}
