using depoEnvanterSTP.Tablolar;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace depoEnvanterSTP.Database
{
    class StokGirisDB : VeritabaniStok
    {
        public override DataTable Arama(IArayuz arayuz)
        {
            StokGiris giris = (StokGiris)arayuz;

            Baglan();
            string sorgu = "select sg.Id,sg.BelgeNumarasi,k.Ad,k.Soyad,sg.GirisTarihi,u.UrunKodu,u.UrunAdi,sg.GirisAdet " +
                "from tbl_StokGiris sg " +
                "INNER JOIN tbl_KullaniciKayit k ON sg.Alici = k.Id " +
                "INNER JOIN tbl_UrunTanimlama u ON sg.UrunNo = u.Id " +
                "where sg.BelgeNumarasi LIKE '%"+giris.BelgeNumarasi+"%' or  sg.Id=" + giris.Id.ToString();
            
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
            StokGiris giris = (StokGiris)arayuz;
            Baglan();
            komut = new System.Data.SqlClient.SqlCommand("usp_StokUrunGiris", baglanti);
            komut.CommandType = CommandType.StoredProcedure;

            komut.Parameters.AddWithValue("@BelgeNumarasi", giris.BelgeNumarasi);
            komut.Parameters.AddWithValue("@Alici", giris.Alici);
            komut.Parameters.AddWithValue("@GirisTarihi", giris.GirisTarihi);
            komut.Parameters.AddWithValue("@UrunNo", giris.UrunNo);
            komut.Parameters.AddWithValue("@GirisAdet", giris.GirisAdet);


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
            StokGiris giris = new StokGiris();
            string sorgu = "select c.Id,BelgeNumarasi,k.Ad + ' ' + k.Soyad as Gönderici,Alici,Tarih,FiiliSevkTarihi,s.VergiNo,SevkAdresi,UrunNo,CikisAdet,u.UrunAdi,u.UrunKodu,u.Adet,CikisAdet2 " +
                "from tbl_StokUrunCikis c inner join tbl_UrunTanimlama u on c.UrunNo = u.Id " +
                "inner join tbl_Sirket s on c.VergiNumarasi = s.Id " +
                "inner join tbl_KullaniciKayit k on c.Gonderici = k.Id and c.Durum='A'  ";
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
            StokGiris giris = (StokGiris)arayuz;
            Baglan();
            komut = new System.Data.SqlClient.SqlCommand("usp_StokUrunGirisSil", baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@Id", giris.Id);
            komut.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Dispose();
        }

        public override DataTable StokDurumListele(IArayuz arayuz)
        {
            throw new NotImplementedException();
        }

        public override DataTable StokHarListele(IArayuz arayuz)
        {
            StokGiris giris = new StokGiris();
            string sorgu = "select sg.Id,sg.BelgeNumarasi,k.Ad,k.Soyad,sg.GirisTarihi,u.UrunKodu,u.UrunAdi,sg.GirisAdet " +
                "from tbl_StokGiris sg " +
                "INNER JOIN tbl_KullaniciKayit k ON sg.Alici = k.Id " +
                "INNER JOIN tbl_UrunTanimlama u ON sg.UrunNo = u.Id";
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
