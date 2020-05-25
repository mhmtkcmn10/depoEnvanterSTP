using depoEnvanterSTP.Tablolar;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace depoEnvanterSTP.Database
{
    class StokCikisDB : VeritabaniStok
    {
        public override DataTable Arama(IArayuz arayuz)
        {
            StokCikis stok = (StokCikis)arayuz;

            Baglan();
            string sorgu = "select sc.Id,sc.BelgeNumarasi,k.Ad,k.Soyad,sc.Alici,sc.Tarih,sc.FiiliSevkTarihi,s.VergiNo,sc.SevkAdresi,u.UrunKodu,u.UrunAdi,sc.CikisAdet,sc.Durum," +
                "sc.CikisAdet2, sc.UrunNo, u.Adet from tbl_StokUrunCikis sc " +
                "INNER JOIN tbl_KullaniciKayit k ON sc.Gonderici = k.Id " +
                "INNER JOIN tbl_Sirket s ON sc.VergiNumarasi = s.Id " +
                "INNER JOIN tbl_UrunTanimlama u ON sc.UrunNo = u.Id " +
                "WHERE sc.BelgeNumarasi LIKE '%"+stok.BelgeNumarasi+"%' or sc.SevkAdresi LIKE '%"+stok.SevkAdresi+"%' or  sc.Id=" + stok.Id.ToString();
            
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
            StokCikis stok = (StokCikis)arayuz;
            Baglan();
            komut = new System.Data.SqlClient.SqlCommand("usp_StokCikisUrunEkle", baglanti);
            komut.CommandType = CommandType.StoredProcedure;

            komut.Parameters.AddWithValue("@BelgeNumarasi", stok.BelgeNumarasi);
            komut.Parameters.AddWithValue("@Gonderici", stok.Gonderici);
            komut.Parameters.AddWithValue("@Alici", stok.Alici);
            komut.Parameters.AddWithValue("@Tarih", stok.Tarih);
            komut.Parameters.AddWithValue("@FiiliSevkTarihi", stok.FiiliSevkTarihi);
            komut.Parameters.AddWithValue("@VergiNumarasi", stok.VergiNumarasi);
            komut.Parameters.AddWithValue("@SevkAdresi", stok.SevkAdresi);
            komut.Parameters.AddWithValue("@UrunNo", stok.UrunNo);
            komut.Parameters.AddWithValue("@CikisAdet", stok.CikisAdet);
            komut.Parameters.AddWithValue("@CikisAdet2", stok.CikisAdet);



            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Dispose();
        }

        public override void Guncelle(IArayuz arayuz)
        {
            StokCikis stok = (StokCikis)arayuz;
    
            Baglan();
            komut = new System.Data.SqlClient.SqlCommand("usp_StokUrunCikisAdetGuncelle", baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@Id", stok.Id);
            komut.Parameters.AddWithValue("@CikisAdet", stok.CikisAdet);
            komut.Parameters.AddWithValue("@CikisAdet2", stok.CikisAdet2);

            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Dispose();
        }

        public override DataTable Listele(IArayuz arayuz)
        {
            throw new NotImplementedException();
        }

        public override void Sil(IArayuz arayuz)
        {
            StokCikis cikis = (StokCikis)arayuz;

            Baglan();
            komut = new System.Data.SqlClient.SqlCommand("usp_StokUrunCikisSil", baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@Id", cikis.Id);
            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Dispose();
        }

        public override DataTable StokDurumListele(IArayuz arayuz)
        {
            StokCikis cikis = (StokCikis)arayuz;

            string sorgu = "select sc.Id,sc.BelgeNumarasi,k.Ad,k.Soyad,sc.Alici,sc.Tarih,sc.FiiliSevkTarihi,s.VergiNo,sc.SevkAdresi,u.UrunKodu,u.UrunAdi,sc.CikisAdet,sc.Durum," +
                "sc.CikisAdet2, sc.UrunNo, u.Adet from tbl_StokUrunCikis sc " +
                "INNER JOIN tbl_KullaniciKayit k ON sc.Gonderici = k.Id " +
                "INNER JOIN tbl_Sirket s ON sc.VergiNumarasi = s.Id " +
                "INNER JOIN tbl_UrunTanimlama u ON sc.UrunNo = u.Id " +
                "WHERE sc.Durum='"+cikis.Durum+"'";
            Baglan();
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

        public override DataTable StokHarListele(IArayuz arayuz)
        {
            StokCikis cikis = (StokCikis)arayuz;
            string sorgu = "select sc.Id,sc.BelgeNumarasi,k.Ad,k.Soyad,sc.Alici,sc.Tarih,sc.FiiliSevkTarihi,s.VergiNo,sc.SevkAdresi,u.UrunKodu,u.UrunAdi,sc.CikisAdet,sc.Durum," +
                "sc.CikisAdet2,sc.UrunNo, u.Adet from tbl_StokUrunCikis sc " +
                "INNER JOIN tbl_KullaniciKayit k ON sc.Gonderici = k.Id " +
                "INNER JOIN tbl_Sirket s ON sc.VergiNumarasi = s.Id " +
                "INNER JOIN tbl_UrunTanimlama u ON sc.UrunNo = u.Id ";
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
    }
}
