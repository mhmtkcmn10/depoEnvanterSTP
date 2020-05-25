using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using depoEnvanterSTP.Database;

namespace depoEnvanterSTP.Pages
{
    public partial class FormAdminKullaniciAyarlari : Form
    {
        public FormAdminKullaniciAyarlari()
        {
            InitializeComponent();
            DialogHazirla();
        }
        DialogResult dialog = new DialogResult();
        string resimAdresi;
        OpenFileDialog ofdResim = new OpenFileDialog();
        
        KullaniciKayit kullanici = new KullaniciKayit();
        KullaniciKayitDB kayitDB = new KullaniciKayitDB();


        private void FormAdminKullaniciAyarlari_Load(object sender, EventArgs e)
        {

        }
        

        public void Listele()
        {
            Database.KullaniciKayit kk = new Database.KullaniciKayit();
            Database.KullaniciKayitDB kkd = new Database.KullaniciKayitDB();
            dgKullanici.DataSource = kkd.ListeleAdminKullaniciListe(kk);
            //MemoryStream ms = new MemoryStream();
            //pbImage.Image.Save(ms, pbImage.Image.RawFormat);
            //byte[] img = ms.ToArray();
            Byte[] picture = (Byte[])dgKullanici.CurrentRow.Cells["Resim"].Value;
            MemoryStream ms = new MemoryStream(picture);
            //pbImage.Image = Image.FromStream(ms);
            //string path = ms.ToString();

            //for (int i = 0; i < dgKullanici.Columns.Count; i++)
            //{
                    //dgKullanici.Rows[0].Cells["Resim"].Value = ScaleImage(Image.FromFile(ms), 100, 100);
            
            //}
        }
        public void DialogHazirla()
        {
            ofdResim.Title = "Yüklemek istediğiniz resmi seçiniz ...";
            ofdResim.Filter = "Resim Dosyası |*.jpg;*.nef;*.png*.jpeg*.jfif|Tüm Dosyalar |*.*";

        }
        private const string MatchEmailPattern =
                  @"^(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"
           + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
                                                [0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
           + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
                                                [0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
           + @"([a-zA-Z]+[\w-]+\.)+[a-zA-Z]{2,4})$";


        private void btnResim_Click(object sender, EventArgs e)
        {
            if (ofdResim.ShowDialog() == DialogResult.OK)
            {
                pbImage.Image = System.Drawing.Image.FromFile(ofdResim.FileName);
                resimAdresi = ofdResim.FileName.ToString();
            }
        }
        
        public void Temizle()
        {
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtAdres.Text = "";
            txtEmail.Text = "";
            txtKullaniciAdi.Text = "";
            txtSifre.Text = "";
            dgKullanici.Text = "";
            lblMesaj.Text = "";
            cbTip.Text = "";
            pbImage.Image = null;
            lblmailkontrol.Text = "";
        }
        private void btnListele_Click(object sender, EventArgs e)
        {
            Listele();
            txtArama.Visible = true;
            lblArama.Visible = true;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Pages.KullaniciSayfa.FormKullaniciEkle form = new KullaniciSayfa.FormKullaniciEkle();
            form.Show();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                kullanici.Id = int.Parse(txtId.Text);
                dialog = MessageBox.Show("Veriyi silmeyi onaylıyor musunuz ?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialog == DialogResult.Yes)
                {
                    kayitDB.Sil(kullanici);
                    Listele();
                    lblMesaj.Text = "Silme işlemi gerçekleşti ...";
                    lblMesaj.Visible = true;
                }
                else
                {
                    Listele();
                }

            }
            catch (Exception hata)
            {

                lblMesaj.Text = "Hata: " + hata.Message.ToString();
                lblMesaj.Visible = true;
            }
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            dgKullanici.DataSource = kayitDB.Arama(kullanici);
            try
            {
                kullanici.Ad = txtArama.Text;
                kullanici.Soyad = txtArama.Text;
                kullanici.Kullaniciadi = txtArama.Text;
                kullanici.Email = txtArama.Text;
                dgKullanici.DataSource = kayitDB.Arama(kullanici);
            }
            catch (Exception hata)
            {
                lblMesaj.Visible = true;
                lblMesaj.Text = "Hata. " + hata.Message;
            }
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            bool retVal = false;
            retVal = Regex.IsMatch(txtEmail.Text, MatchEmailPattern);
            
            try
            {
                MemoryStream ms = new MemoryStream();
                pbImage.Image.Save(ms, pbImage.Image.RawFormat);
                byte[] img = ms.ToArray();
                if (pbImage.Image == null)
                {
                    lblMesaj.Text = "Resim seçiniz";
                    lblMesaj.Visible = true;
                }
                else
                {
                    if (txtAd.Text != "" && txtSoyad.Text != "" && txtEmail.Text != "" && txtAdres.Text != "" && txtKullaniciAdi.Text != "" && txtSifre.Text != "" && dtTarih.Value.ToString() != "")
                    {

                        string sifre = txtSifre.Text;

                        if (sifre.Length == 8)
                        {
                            if (retVal)
                            {
                                try
                                {
                                    kullanici.Id = int.Parse(txtId.Text);
                                    kullanici.Ad = txtAd.Text;
                                    kullanici.Soyad = txtSoyad.Text;
                                    kullanici.DogumTarihi = dtTarih.Value;
                                    kullanici.Adres = txtAdres.Text;
                                    kullanici.Email = txtEmail.Text;
                                    kullanici.Kullaniciadi = txtKullaniciAdi.Text;
                                    kullanici.Sifre = txtSifre.Text;
                                    kullanici.Resim = img;

                                    if (cbTip.SelectedText == "Yönetici")
                                    {
                                        kullanici.Tip = 'Y';
                                    }
                                    else if(cbTip.SelectedText == "Kullanıcı")
                                    {
                                        kullanici.Tip = 'K';
                                    }
                                    else
                                    {
                                        kullanici.Tip = 'E';

                                    }

                                    kayitDB.Guncelle(kullanici);
                                    Listele();
                                    panel5.Visible = false;
                                    lblMesaj.Text = "Veri Güncellendi ...";
                                    lblMesaj.Visible = true;
                                }
                                catch (Exception hata)
                                {
                                    lblmailkontrol.Text = "Kayıtlı veri girişi ... \nİşaretlenen alanları kontrol ediniz...";
                                    lblmailkontrol.Visible = true;
                                    lblEmail.Visible = true;
                                    lblKullaniciAdi.Visible = true;
                                }
                            }
                            else
                            {
                                lblmailkontrol.Text = "E-Mail adresi geçersiz formatta";
                                lblmailkontrol.Visible = true;
                            }
                        }
                        else
                        {
                            lblMesaj.Visible = true;
                            lblMesaj.Text = "Şifre 8 haneli karakter içermelidir ...";

                        }
                    }
                    else if (txtAd.Text == "" && txtSoyad.Text == "" && txtEmail.Text == "" && txtAdres.Text == "" && txtKullaniciAdi.Text == "" && txtSifre.Text == "" && dtTarih.Value.ToString() == "" && pbImage.Image == null)
                    {
                        lblMesaj.Text = "Gerekli alanlar boş geçilemez";
                        lblMesaj.Visible = true;
                        
                    }
                    else
                    {
                        lblMesaj.Text = "Yaptığınız işlemlere dikkat ediniz ...";
                        lblMesaj.Visible = true;


                    }
                }

            }
            catch (Exception hata)
            {
                lblMesaj.Text = "Hata: " + hata.Message.ToString();
                lblMesaj.Visible = true;
                lblAd.Visible = true;
                lblSoyad.Visible = true;
                lblAdres.Visible = true;
                lblEmail.Visible = true;
                lblKullaniciAdi.Visible = true;
                lblSifre.Visible = true;
                lblTip.Visible = true;
                lblResimYukle.Visible = true;
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
        private void dgKullanici_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtId.Text = dgKullanici.SelectedRows[0].Cells["Id"].Value.ToString();
        }

        private void dgKullanici_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            panel5.Visible = true;

            

            try
            {
                txtId.Text = dgKullanici.SelectedRows[0].Cells["Id"].Value.ToString();
                txtAd.Text = dgKullanici.SelectedRows[0].Cells["Ad"].Value.ToString();
                txtSoyad.Text = dgKullanici.SelectedRows[0].Cells["Soyad"].Value.ToString();
                dtTarih.Text = dgKullanici.SelectedRows[0].Cells["DogumTarihi"].Value.ToString();
                txtAdres.Text = dgKullanici.SelectedRows[0].Cells["Adres"].Value.ToString();
                txtEmail.Text = dgKullanici.SelectedRows[0].Cells["Email"].Value.ToString();
                txtKullaniciAdi.Text = dgKullanici.SelectedRows[0].Cells["KullaniciAdi"].Value.ToString();
                txtSifre.Text = dgKullanici.SelectedRows[0].Cells["Sifre"].Value.ToString();

                Byte[] picture = (Byte[])dgKullanici.CurrentRow.Cells["Resim"].Value;
                MemoryStream ms = new MemoryStream(picture);
                pbImage.Image = Image.FromStream(ms);

                if (dgKullanici.SelectedRows[0].Cells["Tip"].Value.ToString() == "Y")
                {
                    cbTip.Text = "Yönetici";
                }
                if (dgKullanici.SelectedRows[0].Cells["Tip"].Value.ToString() == "K")
                {
                    cbTip.Text = "Kullanıcı";
                }
                if (dgKullanici.SelectedRows[0].Cells["Tip"].Value.ToString() == "E")
                {
                    cbTip.Text = "Eleman";
                }


                lblMesaj.Visible = false;
                lblAd.Visible = false;
                lblSoyad.Visible = false;
                lblAdres.Visible = false;
                lblEmail.Visible = false;
                lblKullaniciAdi.Visible = false;
                lblSifre.Visible = false;
                lblTip.Visible = false;
                lblResimYukle.Visible = false;
            }
            catch (Exception hata)
            {
                lblMesaj.Visible = true;
                lblMesaj.Text = "Lütfen boş veri satırı içeren veriyi seçmeyiniz ...";
            }

            

        }

        private void dgKullanici_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < dgKullanici.Rows.Count - 1; i++)
            {
                DataGridViewCellStyle renk = new DataGridViewCellStyle();

                if (Convert.ToChar(dgKullanici.Rows[i].Cells["Tip"].Value.ToString()) == 'Y')
                {
                    renk.BackColor = Color.SteelBlue;
                    renk.ForeColor = Color.White;
                }
                else if (Convert.ToChar(dgKullanici.Rows[i].Cells["Tip"].Value.ToString()) == 'K')
                {
                    renk.BackColor = Color.Salmon;
                    renk.ForeColor = Color.White;
                }
                else
                {
                    renk.BackColor = Color.White;
                    renk.ForeColor = Color.SteelBlue;
                }
                dgKullanici.Rows[i].DefaultCellStyle = renk;

            }
        }
        public void TextKontrol()
        {  

        }
        string Sifre = "";
        string Harfler = "QWERTYUIOPĞÜASDFGHJKLŞİZXCVBNMÖÇqwertyuıopğüasdfghjklşizxcvbnmöç";
        string Rakamlar = "1234567890";
        string OzelKarakterler = "é<!>'^+%&/()=?_£#$½{[]}/,.;:@|";

        bool HarfVar = false;
        bool RakamVar = false;
        bool OzelKarakterVar = false;

        public void SifreKontrol()
        {
            Sifre = txtSifre.Text;
            if (Sifre.Length < 8)
            {
                lblMesaj.Text = "8 haneli karakter geçerlidir";
                lblMesaj.Visible = true;
            }
            else if (txtSifre.Text == "")
            {
                lblMesaj.Text = "";
                lblMesaj.Visible = false;
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
                    lblMesaj.Text = "Kuvvetli Sifre";
                    lblMesaj.Visible = true;

                }
                else if (HarfVar == true && RakamVar == true || HarfVar == true && OzelKarakterVar == true || RakamVar == true && OzelKarakterVar == true)
                {
                    lblMesaj.Text = "Orta Seviye Şifre";
                    lblMesaj.Visible = true;
                }
                else
                {
                    lblMesaj.Text = "Zayıf Şifre";
                    lblMesaj.Visible = true;
                }
            }
        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {
            TextKontrol();
            if (txtAd.Text=="")
            {
                lblAd.Visible = true;

            }
            else
            {
                lblAd.Visible = false;
            }

        }

        private void txtSoyad_TextChanged(object sender, EventArgs e)
        {
            TextKontrol();
            if (txtSoyad.Text == "")
            {
                lblSoyad.Visible = true;

            }
            else
            {
                lblSoyad.Visible = false;
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            TextKontrol();
            if (txtEmail.Text == "")
            {
                lblEmail.Visible = true;

            }
            else
            {
                lblEmail.Visible = false;
            }
        }

        private void txtKullaniciAdi_TextChanged(object sender, EventArgs e)
        {
            TextKontrol();
            if (txtKullaniciAdi.Text == "")
            {
                lblKullaniciAdi.Visible = true;

            }
            else
            {
                lblKullaniciAdi.Visible = false;
            }
        }
        private void txtAdres_TextChanged(object sender, EventArgs e)
        {
            TextKontrol();
            if (txtAdres.Text == "")
            {
                lblAdres.Visible = true;

            }
            else
            {
                lblAdres.Visible = false;
            }
        }
        private void txtSifre_TextChanged(object sender, EventArgs e)
        {
            TextKontrol();
            SifreKontrol();
            if (txtSifre.Text == "")
            {
                lblSifre.Visible = true;

            }
            else
            {
                lblSifre.Visible = false;
            }
        }

        private void cbTip_TextChanged(object sender, EventArgs e)
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
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '@' && e.KeyChar != '.' && e.KeyChar != '_';

            if ((int)e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }

        private void txtKullaniciAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '_';

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
    }
}
