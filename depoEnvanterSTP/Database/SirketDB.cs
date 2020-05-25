using depoEnvanterSTP.Tablolar;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace depoEnvanterSTP.Database
{
    class SirketDB : Veritabani
    {
        public override DataTable Arama(IArayuz arayuz)
        {
            Sirket sirket = (Sirket)arayuz;
            Baglan();
            string sorgu = "select * from tbl_Sirket where SirketAdi like '%" + sirket.SirketAdi + "%' or SirketUnvani like '%" + sirket.SirketUnvani + "%' or  VergiNo like '%" + sirket.VergiNo + "%'  or Adres like '%"+sirket.Adres+"%' or Email like '%"+sirket.Email+"%' or Id = " + sirket.Id.ToString();
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
            Sirket sirket = (Sirket)arayuz;
            Baglan();
            komut = new System.Data.SqlClient.SqlCommand("usp_SirketEkle", baglanti);
            komut.CommandType = CommandType.StoredProcedure;

            komut.Parameters.AddWithValue("@SirketAdi", sirket.SirketAdi);
            komut.Parameters.AddWithValue("@SirketUnvani", sirket.SirketUnvani);
            komut.Parameters.AddWithValue("@VergiDairesi", sirket.VergiDairesi);
            komut.Parameters.AddWithValue("@VergiNo", sirket.VergiNo);
            komut.Parameters.AddWithValue("@Telefon", sirket.Telefon);
            komut.Parameters.AddWithValue("@Faks", sirket.Faks);
            komut.Parameters.AddWithValue("@Adres", sirket.Adres);
            komut.Parameters.AddWithValue("@Email", sirket.Email);


            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Dispose();
        }

        public override void Guncelle(IArayuz arayuz)
        {
            Sirket sirket = (Sirket)arayuz;
            Baglan();
            komut = new System.Data.SqlClient.SqlCommand("usp_SirketGuncelle", baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@Id", sirket.Id);
            komut.Parameters.AddWithValue("@SirketAdi", sirket.SirketAdi);
            komut.Parameters.AddWithValue("@SirketUnvani", sirket.SirketUnvani);
            komut.Parameters.AddWithValue("@VergiDairesi", sirket.VergiDairesi);
            komut.Parameters.AddWithValue("@VergiNo", sirket.VergiNo);
            komut.Parameters.AddWithValue("@Telefon", sirket.Telefon);
            komut.Parameters.AddWithValue("@Faks", sirket.Faks);
            komut.Parameters.AddWithValue("@Adres", sirket.Adres);
            komut.Parameters.AddWithValue("@Email", sirket.Email);
            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Dispose();
        }

        public override DataTable Listele(IArayuz arayuz)
        {
            Sirket sirket = (Sirket)arayuz;
            string sorgu = "SELECT * FROM tbl_Sirket ";
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
            Sirket sirket = (Sirket)arayuz;
            Baglan();
            komut = new System.Data.SqlClient.SqlCommand("usp_SirketSil", baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@Id", sirket.Id);
            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Dispose();
        }
    }
}
