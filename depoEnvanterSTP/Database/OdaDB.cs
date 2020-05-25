using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace depoEnvanterSTP.Database
{
    class OdaDB : Veritabani
    {
        public override DataTable Arama(IArayuz arayuz)
        {
            Oda oda = (Oda)arayuz;
            Baglan();
            string sorgu = "select * from tbl_Oda where OdaAdi like '%" + oda.OdaAdi + "%' or Id = " + oda.Id.ToString();
            komut = new System.Data.SqlClient.SqlCommand(sorgu, baglanti);
            komut.CommandType = CommandType.Text;
            komut.ExecuteNonQuery();
            adaptor = new System.Data.SqlClient.SqlDataAdapter(komut);
            tablo = new DataTable();
            adaptor.Fill(tablo);
            baglanti.Close();
            baglanti.Dispose();


            return tablo;
        }

        public override DataTable Arama2(IArayuz arayuz)
        {
            throw new NotImplementedException();
        }

        public override void Ekle(IArayuz arayuz)
        {
            Oda oda = (Oda)arayuz;
            Baglan();
            komut = new System.Data.SqlClient.SqlCommand("usp_OdaEkle", baglanti);
            komut.CommandType = CommandType.StoredProcedure;

            komut.Parameters.AddWithValue("@OdaAdi", oda.OdaAdi);

            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Dispose();
        }

        public override void Guncelle(IArayuz arayuz)
        {
            Oda oda = (Oda)arayuz;
            Baglan();
            komut = new System.Data.SqlClient.SqlCommand("usp_OdaGuncelle", baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@Id", oda.Id);
            komut.Parameters.AddWithValue("@OdaAdi", oda.OdaAdi);
            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Dispose();
        }

        public override DataTable Listele(IArayuz arayuz)
        {
            Oda oda = (Oda)arayuz;
            string sorgu = "SELECT * FROM tbl_Oda ";
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
            Oda oda = (Oda)arayuz;
            Baglan();
            komut = new System.Data.SqlClient.SqlCommand("usp_OdaSil", baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@Id", oda.Id);
            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Dispose();
        }
    }
}
