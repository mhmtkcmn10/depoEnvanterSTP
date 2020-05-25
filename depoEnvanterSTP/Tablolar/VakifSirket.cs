using depoEnvanterSTP.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace depoEnvanterSTP.Tablolar
{
    public class VakifSirket : IArayuz
    {
        private int id;
        private string sirketAdi;
        private string sirketUnvani;
        private string adres;
        private string telefon;
        private string vergiNo;
        private string email;
        private string vergiDairesi;

        public int Id { get => id; set => id = value; }
        public string SirketAdi { get => sirketAdi; set => sirketAdi = value; }
        public string SirketUnvani { get => sirketUnvani; set => sirketUnvani = value; }
        public string Adres { get => adres; set => adres = value; }
        public string Telefon { get => telefon; set => telefon = value; }
        public string VergiNo { get => vergiNo; set => vergiNo = value; }
        public string Email { get => email; set => email = value; }
        public string VergiDairesi { get => vergiDairesi; set => vergiDairesi = value; }
    }
}
