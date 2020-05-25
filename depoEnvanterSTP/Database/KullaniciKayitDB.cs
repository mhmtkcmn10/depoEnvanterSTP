using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace depoEnvanterSTP.Database
{
    class KullaniciKayitDB : KullaniciVeritabani
    {
        public override void Ekle(IArayuz arayuz)
        {
            KullaniciKayit kk = (KullaniciKayit)arayuz;
            Baglan();
            komut = new System.Data.SqlClient.SqlCommand("usp_KullaniciEkle", baglanti);
            komut.CommandType = CommandType.StoredProcedure;

            komut.Parameters.AddWithValue("@Ad", kk.Ad);
            komut.Parameters.AddWithValue("@Soyad", kk.Soyad);
            komut.Parameters.AddWithValue("@DogumTarihi", kk.DogumTarihi);
            komut.Parameters.AddWithValue("@Adres", kk.Adres);
            komut.Parameters.AddWithValue("@Email", kk.Email);
            komut.Parameters.AddWithValue("@KullaniciAdi", kk.Kullaniciadi);
            komut.Parameters.AddWithValue("@Sifre", kk.Sifre);
            komut.Parameters.AddWithValue("@Resim", kk.Resim);
            
            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Dispose();
        }
        public override void AdminKullaniciEkle(IArayuz arayuz)
        {
            KullaniciKayit kk = (KullaniciKayit)arayuz;
            Baglan();
            komut = new System.Data.SqlClient.SqlCommand("usp_AdminKullaniciEkle", baglanti);
            komut.CommandType = CommandType.StoredProcedure;

            komut.Parameters.AddWithValue("@Ad", kk.Ad);
            komut.Parameters.AddWithValue("@Soyad", kk.Soyad);
            komut.Parameters.AddWithValue("@DogumTarihi", kk.DogumTarihi);
            komut.Parameters.AddWithValue("@Adres", kk.Adres);
            komut.Parameters.AddWithValue("@Email", kk.Email);
            komut.Parameters.AddWithValue("@KullaniciAdi", kk.Kullaniciadi);
            komut.Parameters.AddWithValue("@Sifre", kk.Sifre);
            komut.Parameters.AddWithValue("@Resim", kk.Resim);
            komut.Parameters.AddWithValue("@Tip", kk.Tip);

            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Dispose();
        }

        public override DataTable ListeleAdmin(IArayuz arayuz)
        {
            KullaniciKayit kul = (KullaniciKayit)arayuz;
            
            string sorgu = "SELECT * FROM tbl_KullaniciKayit WHERE KullaniciAdi='"+kul.Kullaniciadi+"' and Sifre='"+kul.Sifre+"'";

            komut = new System.Data.SqlClient.SqlCommand(sorgu, baglanti);
            komut.ExecuteNonQuery();
            tablo = new DataTable();
            adaptor = new System.Data.SqlClient.SqlDataAdapter(komut);
            adaptor.Fill(tablo);
            baglanti.Close();
            baglanti.Dispose();
            return tablo;
        }

        public override DataTable ListeleAdminKullanici(IArayuz arayuz)
        {
            KullaniciKayit kullaniciKayit = (KullaniciKayit)arayuz;
            Baglan();
            string sorgu = "SELECT Id,Ad+' '+Soyad as AdSoyad FROM tbl_KullaniciKayit";
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

        public override DataTable ListeleEmail(IArayuz arayuz)
        {
            KullaniciKayit kul = (KullaniciKayit)arayuz;
            string sorgu = "SELECT * FROM tbl_KullaniciKayit WHERE Email='" + kul.Email + "' and Sifre='" + kul.Sifre + "'";

            komut = new System.Data.SqlClient.SqlCommand(sorgu, baglanti);
            komut.ExecuteNonQuery();
            tablo = new DataTable();
            adaptor = new System.Data.SqlClient.SqlDataAdapter(komut);
            adaptor.Fill(tablo);
            baglanti.Close();
            baglanti.Dispose();
            return tablo;
        }

        public override DataTable ListeleSifre(IArayuz arayuz)
        {
            KullaniciKayit kul = (KullaniciKayit)arayuz;
            string sorgu = "SELECT * FROM tbl_KullaniciKayit WHERE Email='" + kul.Email + "'";

            komut = new System.Data.SqlClient.SqlCommand(sorgu, baglanti);
            komut.ExecuteNonQuery();
            tablo = new DataTable();
            adaptor = new System.Data.SqlClient.SqlDataAdapter(komut);
            adaptor.Fill(tablo);
            baglanti.Close();
            baglanti.Dispose();
            return tablo;
        }
        
        public override void Guncelle(IArayuz arayuz)
        {
            KullaniciKayit kk = (KullaniciKayit)arayuz;
            Baglan();
            komut = new System.Data.SqlClient.SqlCommand("usp_KullaniciGuncelle", baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@Id", kk.Id);
            komut.Parameters.AddWithValue("@Ad", kk.Ad);
            komut.Parameters.AddWithValue("@Soyad", kk.Soyad);
            komut.Parameters.AddWithValue("@DogumTarihi", kk.DogumTarihi);
            komut.Parameters.AddWithValue("@Adres", kk.Adres);
            komut.Parameters.AddWithValue("@Email", kk.Email);
            komut.Parameters.AddWithValue("@KullaniciAdi", kk.Kullaniciadi);
            komut.Parameters.AddWithValue("@Sifre", kk.Sifre);
            komut.Parameters.AddWithValue("@Resim", kk.Resim);
            komut.Parameters.AddWithValue("@Tip", kk.Tip);
            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Dispose();
        }

        public override void Sil(IArayuz arayuz)
        {
            KullaniciKayit kk = (KullaniciKayit)arayuz;
            Baglan();
            komut = new System.Data.SqlClient.SqlCommand("usp_KullaniciSil", baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@Id", kk.Id);
            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Dispose();
        }

        public override DataTable Arama(IArayuz arayuz)
        {
            KullaniciKayit kk = (KullaniciKayit)arayuz;
            Baglan();
            string sorgu = "select * from tbl_KullaniciKayit where KullaniciAdi like '%" + kk.Kullaniciadi + "%' or Email like '%" + kk.Email + "%' or Ad like '%" + kk.Ad + "%' or Soyad like '%" + kk.Soyad + "%' or Id = " + kk.Id.ToString();
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

        public override void GuncelleSifreDegistirme(IArayuz arayuz)
        {
            KullaniciKayit kk = (KullaniciKayit)arayuz;
            Baglan();
            komut = new System.Data.SqlClient.SqlCommand("usp_KullaniciSifreGuncelle", baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@Id", kk.Id);
            komut.Parameters.AddWithValue("@Sifre", kk.Sifre);
            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Dispose();
        }

        public override void GuncelleAktivasyon(IArayuz arayuz)
        {
            KullaniciKayit kk = (KullaniciKayit)arayuz;
            Baglan();
            komut = new System.Data.SqlClient.SqlCommand("usp_KullaniciAktivasyonGuncelle", baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@Email", kk.Email);
            komut.Parameters.AddWithValue("@Sifre", kk.Sifre);
            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Dispose();
        }

        public override DataTable ListeleAdminKullaniciListe(IArayuz arayuz)
        {
            KullaniciKayit kullaniciKayit = (KullaniciKayit)arayuz;
            Baglan();
            string sorgu = "SELECT * FROM tbl_KullaniciKayit";
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
    }
}
