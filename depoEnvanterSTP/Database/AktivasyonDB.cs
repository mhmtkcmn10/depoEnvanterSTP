using depoEnvanterSTP.Tablolar;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace depoEnvanterSTP.Database
{
    class AktivasyonDB : Veritabani
    {
        public override DataTable Arama(IArayuz arayuz)
        {
            throw new NotImplementedException();
        }

        public override DataTable Arama2(IArayuz arayuz)
        {
            throw new NotImplementedException();
        }

        public override void Ekle(IArayuz arayuz)
        {
            Aktivasyon aktivasyon = (Aktivasyon)arayuz;
            Baglan();
            komut = new System.Data.SqlClient.SqlCommand("usp_AktivasyonEkle", baglanti);
            komut.CommandType = CommandType.StoredProcedure;

            komut.Parameters.AddWithValue("@AktivasyonKod", aktivasyon.AktivasyonKod);

            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Dispose();
        }

        public override void Guncelle(IArayuz arayuz)
        {
            throw new NotImplementedException();
        }

        public override DataTable Listele(IArayuz arayuz)
        {
            Aktivasyon aktivasyon = (Aktivasyon)arayuz;
            string sorgu = "SELECT * FROM tbl_Aktivasyon ";
            Baglan();
            komut = new System.Data.SqlClient.SqlCommand(sorgu, baglanti);
            komut.ExecuteNonQuery();
            tablo = new DataTable();
            adaptor = new System.Data.SqlClient.SqlDataAdapter(komut);
            adaptor.Fill(tablo);
            baglanti.Close();
            baglanti.Dispose();
            return tablo;
        }

        public override void Sil(IArayuz arayuz)
        {
            throw new NotImplementedException();
        }
    }
}
