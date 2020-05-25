using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace depoEnvanterSTP.Database
{
    class LoginDB : Veritabani
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
            throw new NotImplementedException();
        }

        public override void Guncelle(IArayuz arayuz)
        {
            throw new NotImplementedException();
        }

        public override DataTable Listele(IArayuz arayuz)
        {
            KullaniciKayit kul = (KullaniciKayit)arayuz;

            string sorgu = "SELECT * FROM tbl_KullaniciKayit WHERE KullaniciAdi='" + kul.Kullaniciadi + "' and Sifre='" + kul.Sifre + "' or (Email='"+kul.Email+"')";

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
