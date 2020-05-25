using depoEnvanterSTP.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace depoEnvanterSTP.Tablolar
{
    public class StokGiris:IArayuz
    {
        private int id;
        private string belgeNumarasi;
        private int alici;
        private DateTime girisTarihi;
        private int urunNo;
        private int girisAdet;


        public int Id { get => id; set => id = value; }
        public string BelgeNumarasi { get => belgeNumarasi; set => belgeNumarasi = value; }
        public int Alici { get => alici; set => alici = value; }
        public DateTime GirisTarihi { get => girisTarihi; set => girisTarihi = value; }
        public int UrunNo { get => urunNo; set => urunNo = value; }
        public int GirisAdet { get => girisAdet; set => girisAdet = value; }
        
    }
}
