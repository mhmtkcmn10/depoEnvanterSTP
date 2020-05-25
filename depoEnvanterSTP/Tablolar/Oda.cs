using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace depoEnvanterSTP.Database
{
    public class Oda:IArayuz
    {
        private int id;
        private string odaAdi;

        public int Id { get => id; set => id = value; }
        public string OdaAdi { get => odaAdi; set => odaAdi = value; }
    }
}
