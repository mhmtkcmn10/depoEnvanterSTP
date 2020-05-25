using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace depoEnvanterSTP.Database
{
    abstract class VeritabaniStok
    {
        private string yol;
        public SqlConnection baglanti; // Bağlantı
        public DataTable tablo; // Tablo 
        public SqlDataAdapter adaptor; // 
        public SqlDataReader okuyucu;
        public SqlCommand komut;
        //  static string conString;
        DataTable tbl = new DataTable();
        public void Baglan()
        {
            //baglanti = new SqlConnection(@"Data Source=DESKTOP-8F8HA90\SQLEXPRESS; Initial Catalog=iksvDEPOestp;Integrated Security=True");
            baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDBConnectionString"].ConnectionString);

            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
        }
        public abstract DataTable Listele(IArayuz arayuz);
        public abstract DataTable StokHarListele(IArayuz arayuz);
        public abstract DataTable StokDurumListele(IArayuz arayuz);

        public abstract void Sil(IArayuz arayuz);
        public abstract void Guncelle(IArayuz arayuz);
        public abstract void Ekle(IArayuz arayuz);
        public abstract DataTable Arama(IArayuz arayuz);



    }
}
