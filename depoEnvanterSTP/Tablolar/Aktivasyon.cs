using depoEnvanterSTP.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace depoEnvanterSTP.Tablolar
{
    public class Aktivasyon:IArayuz
    {
        private int id;
        private string aktivasyonKod;

        public int Id { get => id; set => id = value; }
        public string AktivasyonKod { get => aktivasyonKod; set => aktivasyonKod = value; }
    }
}
