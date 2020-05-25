using depoEnvanterSTP.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace depoEnvanterSTP.Tablolar
{
    public class Sirket:IArayuz
    {
        private int id;
        private string sirketAdi;
        private string sirketUnvani;
        private string vergiDairesi;
        private string vergiNo;
        private string telefon;
        private string faks;
        private string adres;
        private string email;

        public int Id { get => id; set => id = value; }
        public string SirketAdi { get => sirketAdi; set => sirketAdi = value; }
        public string SirketUnvani { get => sirketUnvani; set => sirketUnvani = value; }
        public string VergiDairesi { get => vergiDairesi; set => vergiDairesi = value; }
        public string VergiNo { get => vergiNo; set => vergiNo = value; }
        public string Telefon { get => telefon; set => telefon = value; }
        public string Faks { get => faks; set => faks = value; }
        public string Adres { get => adres; set => adres = value; }
        public string Email { get => email; set => email = value; }
    }
}
