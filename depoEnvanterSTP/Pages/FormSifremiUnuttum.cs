using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail; //Gerekli olan kütüphanemiz bu.
using System.Data.SqlClient; // benim gibi sql veritabanı işlemi yapacaksanız bunuda eklemelisiniz
using System.Net;
using System.Text.RegularExpressions;
using depoEnvanterSTP.Tablolar;
using depoEnvanterSTP.Database;

namespace depoEnvanterSTP.Pages
{
    public partial class FormSifremiUnuttum : Form
    {
        public FormSifremiUnuttum()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        string aktKod;
        
        private const string MatchEmailPattern =
                  @"^(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"
           + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
                                                [0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
           + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
                                                [0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
           + @"([a-zA-Z]+[\w-]+\.)+[a-zA-Z]{2,4})$";


        private void btnGönder_Click(object sender, EventArgs e)
        {
            try
            {
                Database.KullaniciKayit kullanici = new Database.KullaniciKayit();
                kullanici.Email = txtEmail.Text;
                Database.KullaniciKayitDB kuldb = new Database.KullaniciKayitDB();
                kuldb.Baglan();
                DataTable tablo = kuldb.ListeleSifre(kullanici);
                aktKod = rnd.Next(10000000, 99999999).ToString();

                Aktivasyon aktivasyon = new Aktivasyon();
                AktivasyonDB aktivasyonDB = new AktivasyonDB();
                aktivasyonDB.Baglan();

                bool retVal = false;
                retVal = Regex.IsMatch(txtEmail.Text, MatchEmailPattern);
                if (retVal)
                {
                    if (tablo.Rows.Count > 0)
                    {
                        kullanici.Email = tablo.Rows[0]["Email"].ToString();

                        if (kullanici.Email == txtEmail.Text)
                        {
                            MailMessage message = new MailMessage();
                            SmtpClient istemci = new SmtpClient();
                            istemci.Credentials = new NetworkCredential("iksvinfo@gmail.com", "iksvESTP34");
                            istemci.Port = 587;
                            istemci.Host = "smtp.gmail.com";
                            istemci.EnableSsl = true;
                            message.To.Add(txtEmail.Text);
                            message.From = new MailAddress(txtEmail.Text);
                            message.Subject = "Aktivasyon Kodu";
                            message.Body = "Aktivasyon kodunuz artık yeni şifreniz oldu   : " + aktKod;
                            istemci.Send(message);
                            MessageBox.Show("Aktivasyon kodu mail adresine gönderildi. Yönlendiriliyorsunuz ... Daha sonra şifrenizi güncellemeyi unutmayınız ...", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                            aktivasyon.AktivasyonKod = aktKod;
                            aktivasyonDB.Ekle(aktivasyon);
                            Database.KullaniciKayit kulakt = new Database.KullaniciKayit();
                            Database.KullaniciKayitDB kulaktdb = new Database.KullaniciKayitDB();

                            kulaktdb.Baglan();
                            kulakt.Email = txtEmail.Text;
                            kulakt.Sifre = aktKod;
                            kulaktdb.GuncelleAktivasyon(kulakt);
                            txtEmail.Text = " ";

                            Pages.FormLogin formLogin = new FormLogin();
                            this.Hide();
                            formLogin.Show();
                        }
                        else
                        {
                            lblMesaj.Visible = true;
                            lblMesaj.Text = "Kayıtlı Email adresi bulunamadı";
                        }

                    }
                    else
                    {

                        lblMesaj.Visible = true;
                        lblMesaj.Text = "Kayıtlı Email adresi bulunamadı";
                    }
                }
                else
                {
                    lblMesaj.Visible = true;
                    lblMesaj.Text = "E-Mail adresi geçersiz formatta";
                }




            }
            catch (Exception hata)
            {
                lblMesaj.Visible = true;
                lblMesaj.Text = "Hata kodu : " + hata.Message;
            }

        }

    }
}
