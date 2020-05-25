using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace depoEnvanterSTP.Pages.KullaniciSayfa
{
    public partial class FormKullaniciEkle : Form
    {
        public FormKullaniciEkle()
        {
            InitializeComponent();
            btnEkle.Visible = false;
            DialogHazirla();
        }
        string Sifre = "";
        string Harfler = "QWERTYUIOPĞÜASDFGHJKLŞİZXCVBNMÖÇqwertyuıopğüasdfghjklşizxcvbnmöç";
        string Rakamlar = "1234567890";
        string OzelKarakterler = "é<!>'^+%&/()=?_£#$½{[]}/,.;:@|";

        bool HarfVar = false;
        bool RakamVar = false;
        bool OzelKarakterVar = false;

        string resimAdresi;
        OpenFileDialog ofdResim = new OpenFileDialog();

        private const string MatchEmailPattern =
                 @"^(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"
          + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
                                                [0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
          + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
                                                [0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
          + @"([a-zA-Z]+[\w-]+\.)+[a-zA-Z]{2,4})$";

        public void DialogHazirla()
        {
            ofdResim.Title = "Resim Seçiniz";
            ofdResim.Filter = "Resim Dosyası |*.jpg;*.nef;*.png*.jpeg*.jfif|Tüm Dosyalar |*.*";

        }
        
        public void TextKontrol()
        {
            if (txtAd.Text == "" && txtSoyad.Text == "" && txtEmail.Text == "" && txtKullanici.Text == "" && txtSifre.Text == "" && txtSifreTekrar.Text == "" && txtadres.Text == "")//&& cbMail.Text == ""
            {
                btnEkle.Visible = false;
            }
            else if (txtAd.Text != "" && txtSoyad.Text != "" && txtEmail.Text != "" && txtKullanici.Text != "" && txtSifre.Text != "" && txtSifreTekrar.Text != "" && txtadres.Text != "")//&& cbMail.Text != ""
            {
                btnEkle.Visible = true;
            }

        }

        public void SifreKontrol()
        {
            Sifre = txtSifre.Text;
            if (Sifre.Length < 8)
            {
                lblSifreKontrol.Text = "8 haneli karakter geçerlidir";
                lblSifreKontrol.Visible = true;
            }
            else
            {
                foreach (var item in Sifre)
                {
                    if (Harfler.IndexOf(item) != -1)
                    {
                        HarfVar = true;
                    }
                    if (Rakamlar.IndexOf(item) != -1)
                    {
                        RakamVar = true;
                    }
                    if (OzelKarakterler.IndexOf(item) != -1)
                    {
                        OzelKarakterVar = true;
                    }
                }

                if (HarfVar == true && RakamVar == true && OzelKarakterVar == true)
                {
                    lblSifreKontrol.Text = "Kuvvetli Sifre";
                }
                else if (HarfVar == true && RakamVar == true || HarfVar == true && OzelKarakterVar == true || RakamVar == true && OzelKarakterVar == true)
                {
                    lblSifreKontrol.Text = "Orta Seviye Şifre";
                }
                else
                {
                    lblSifreKontrol.Text = "Zayıf Şifre";
                }
            }
        }
        
        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                TextKontrol();
                if (pbImage.Image == null)
                {
                    lblmesaj.Text = "Resim seçiniz";
                    lblmesaj.Visible = true;
                }
                else
                {
                    FileStream fsResim = new FileStream(resimAdresi, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fsResim);
                    byte[] resim2 = br.ReadBytes((int)fsResim.Length);

                    br.Close();
                    fsResim.Close();


                    if (txtAd.Text != "" && txtSoyad.Text != "" && txtadres.Text != "" && txtEmail.Text != "" && txtKullanici.Text != "" && txtSifre.Text != "" && txtSifreTekrar.Text != "" && dtTarih.Value.ToString() != "" && cbTip.SelectedValue!="")//&& cbMail.Text != ""
                    {

                        bool retVal = false;
                        retVal = Regex.IsMatch(txtEmail.Text, MatchEmailPattern);
                        if (retVal)
                        {
                            if (txtSifre.Text == txtSifreTekrar.Text)
                            {

                                Database.KullaniciKayit kk = new Database.KullaniciKayit();
                                Database.KullaniciKayitDB kkDB = new Database.KullaniciKayitDB();
                                try
                                {

                                    kk.Ad = txtAd.Text;
                                    kk.Soyad = txtSoyad.Text;
                                    kk.DogumTarihi = dtTarih.Value;
                                    kk.Adres = txtadres.Text;
                                    kk.Email = txtEmail.Text;
                                    kk.Kullaniciadi = txtKullanici.Text;
                                    kk.Sifre = txtSifre.Text;
                                    kk.Resim = resim2;

                                    if (cbTip.SelectedValue=="Yönetici")
                                    {
                                        kk.Tip = 'Y';
                                    }
                                    else if(cbTip.SelectedValue == "Kullanıcı")
                                    {
                                        kk.Tip = 'K';
                                    }
                                    else
                                    {
                                        kk.Tip = 'E';
                                    }


                                    kkDB.AdminKullaniciEkle(kk);
                                    lblmesaj.Text = "Kayıt Gerçekleşti";
                                    lblmesaj.Visible = true;
                                    this.Hide();

                                }
                                catch (Exception ex)
                                {
                                    lblmesaj.Text = "Kayıtlı veri ... Alanları kontrol ediniz ...";
                                    lblmesaj.Visible = true;
                                    lblEmail.Visible = true;
                                    lblKullaniciAdi.Visible = true;

                                }

                            }
                            else
                            {
                                lblSifre.Text = "*";
                                lblSifreTekrar.Text = "*";
                                lblSifre.Visible = true;
                                lblSifreTekrar.Visible = true;
                                txtSifre.Text = " ";
                                txtSifreTekrar.Text = " ";

                            }
                        }
                        else
                        {
                            lblEmail.Visible = true;
                            lblmailkontrol.Visible = true;
                            lblmailkontrol.Text = "E-Mail adresi geçersiz formatta";
                        }

                    }
                    else
                    {
                        lblmesaj.Text = "Gerekli alanlar boş bırakılamaz";
                        lblmesaj.Visible = true;
                    }

                }
            }
            catch (Exception hata)
            {
                lblmesaj.Text = "Hata:" + hata.Message;
                lblmesaj.Visible = true;
            }
        }

        private void btnResim_Click(object sender, EventArgs e)
        {
            if (ofdResim.ShowDialog() == DialogResult.OK)
            {
                pbImage.Image = System.Drawing.Image.FromFile(ofdResim.FileName);
                resimAdresi = ofdResim.FileName.ToString();
            }
        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {
            TextKontrol();
        }

        private void txtSoyad_TextChanged(object sender, EventArgs e)
        {
            TextKontrol();
        }

        private void txtadres_TextChanged(object sender, EventArgs e)
        {
            TextKontrol();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            TextKontrol();
        }

        private void txtKullanici_TextChanged(object sender, EventArgs e)
        {
            TextKontrol();

        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {
            TextKontrol();
            SifreKontrol();
        }

        private void txtSifreTekrar_TextChanged(object sender, EventArgs e)
        {
            TextKontrol();
        }

        private void txtAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);

        }

        private void txtSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '@' && e.KeyChar != '.';

            if ((int)e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }

        private void txtKullanici_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar);

            if ((int)e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }

        private void txtSifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }

        private void txtSifreTekrar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }
        
    }
}
