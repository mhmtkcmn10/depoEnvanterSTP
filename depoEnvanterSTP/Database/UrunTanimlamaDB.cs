using depoEnvanterSTP.Tablolar;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace depoEnvanterSTP.Database
{
    class UrunTanimlamaDB : Veritabani
    {
        public override DataTable Arama(IArayuz arayuz)
        {
            UrunTanimlama urun = (UrunTanimlama)arayuz;
            string sorgu = "SELECT u.Id,OdaAdi,UrunKodu,UrunAdi,Marka,Model,Adet,BirimFiyat,ToplamFiyat,Aciklama,Resim " +
                "           FROM tbl_UrunTanimlama u " +
                "           INNER JOIN tbl_Oda o ON u.OdaId = o.Id" +
                "           WHERE o.Id='"+urun.OdaId+"'";
            Baglan();
            //string sorgu = "SELECT * FROM tbl_UrunTanimlama W  Id = " + sirket.Id.ToString();
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
            UrunTanimlama urun = (UrunTanimlama)arayuz;
            string sorgu = "SELECT u.Id,OdaAdi,UrunKodu,UrunAdi,Marka,Model,Adet,BirimFiyat,ToplamFiyat,Aciklama,Resim " +
                "           FROM tbl_UrunTanimlama u " +
                "           INNER JOIN tbl_Oda o ON u.OdaId = o.Id" +
                "           WHERE UrunAdi LIKE '%" + urun.UrunAdi + "%' or UrunKodu LIKE '%" + urun.UrunKodu+ "%' or Marka LIKE '%" + urun.Marka+ "%' or  Model LIKE '%" + urun.Model+"%'";
            Baglan();
            //string sorgu = "SELECT * FROM tbl_UrunTanimlama W  Id = " + sirket.Id.ToString();
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

        public override void Ekle(IArayuz arayuz)
        {
            UrunTanimlama urun = (UrunTanimlama)arayuz;
            Baglan();
            komut = new System.Data.SqlClient.SqlCommand("usp_UrunTanEkle", baglanti);
            komut.CommandType = CommandType.StoredProcedure;

            komut.Parameters.AddWithValue("@UrunAdi", urun.UrunAdi);
            komut.Parameters.AddWithValue("@UrunKodu", urun.UrunKodu);
            komut.Parameters.AddWithValue("@OdaId", urun.OdaId);
            komut.Parameters.AddWithValue("@Adet", urun.Adet);
            komut.Parameters.AddWithValue("@BirimFiyat", urun.BirimFiyat);
            komut.Parameters.AddWithValue("@ToplamFiyat", urun.ToplamFiyat);
            komut.Parameters.AddWithValue("@Aciklama",urun.Aciklama);
            komut.Parameters.AddWithValue("@Resim", urun.Resim);
            komut.Parameters.AddWithValue("@Marka", urun.Marka);
            komut.Parameters.AddWithValue("@Model", urun.Model);
            
            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Dispose();
        }

        public override void Guncelle(IArayuz arayuz)
        {
            UrunTanimlama urun = (UrunTanimlama)arayuz;
            Baglan();
            komut = new System.Data.SqlClient.SqlCommand("usp_UrunGuncelle", baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@Id", urun.Id);
            komut.Parameters.AddWithValue("@UrunAdi", urun.UrunAdi);
            komut.Parameters.AddWithValue("@UrunKodu", urun.UrunKodu);
            komut.Parameters.AddWithValue("@OdaId", urun.OdaId);
            komut.Parameters.AddWithValue("@Adet", urun.Adet);
            komut.Parameters.AddWithValue("@BirimFiyat", urun.BirimFiyat);
            komut.Parameters.AddWithValue("@ToplamFiyat", urun.ToplamFiyat);
            komut.Parameters.AddWithValue("@Aciklama", urun.Aciklama);
            komut.Parameters.AddWithValue("@Resim", urun.Resim);
            komut.Parameters.AddWithValue("@Marka", urun.Marka);
            komut.Parameters.AddWithValue("@Model", urun.Model);
            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Dispose();
        }

        public override DataTable Listele(IArayuz arayuz)
        {
            UrunTanimlama urun = (UrunTanimlama)arayuz;
            string sorgu = "SELECT u.Id,OdaAdi,UrunKodu,UrunAdi,Marka,Model,Adet,BirimFiyat,ToplamFiyat,Aciklama,Resim " +
                "           FROM tbl_UrunTanimlama u " +
                "           INNER JOIN tbl_Oda o ON u.OdaId = o.Id ORDER BY OdaAdi";
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
            UrunTanimlama urun = (UrunTanimlama)arayuz;
            Baglan();
            komut = new System.Data.SqlClient.SqlCommand("usp_UrunSil", baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@Id", urun.Id);
            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Dispose();
        }
    }
}
