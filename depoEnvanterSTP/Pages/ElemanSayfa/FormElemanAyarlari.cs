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
using System.Configuration;

namespace depoEnvanterSTP.Pages.ElemanSayfa
{
    public partial class FormElemanAyarlari : Form
    {
        public FormElemanAyarlari()
        {
            InitializeComponent();
            Load += FormElemanAyarlari_Load;
            DialogHazirla();

        }
        string resimAdresi;
        OpenFileDialog ofdResim = new OpenFileDialog();

        public void DialogHazirla()
        {
            ofdResim.Title = "Resim Seçiniz";
            ofdResim.Filter = "Jpeg Dosyalari(*.jpg)|*.jpg";

        }
        //SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-8F8HA90\SQLEXPRESS; Initial Catalog=iksvDEPOestp;Integrated Security=True");
        SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDBConnectionString"].ConnectionString);

        private const string MatchEmailPattern =
                  @"^(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"
           + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
                                                [0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
           + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
                                                [0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
           + @"([a-zA-Z]+[\w-]+\.)+[a-zA-Z]{2,4})$";

        private void FormElemanAyarlari_Load(object sender, EventArgs e)
        {
            lblId.Text = "" + Tablolar.Login.Id;
            txtAd.Text = "" + Tablolar.Login.Ad;
            txtSoyad.Text = "" + Tablolar.Login.Soyad;

            baglanti.Open();
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "SELECT * FROM tbl_KullaniciKayit WHERE Id='" + lblId.Text + "'";
            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                lblId.Text = dr["Id"].ToString();
                dtTarih.Value = Convert.ToDateTime(dr["DogumTarihi"].ToString());
                txtAdres.Text = dr["Adres"].ToString();
                txtEmail.Text = dr["Email"].ToString();
                txtKullanici.Text = dr["KullaniciAdi"].ToString();
                txtSifre.Text = dr["Sifre"].ToString();
                lblTip.Text = dr["Tip"].ToString();
                if (dr["Resim"] != null)
                {
                    Byte[] data = new Byte[0];
                    data = (Byte[])(dr["Resim"]);
                    MemoryStream mem = new MemoryStream(data);
                    pbImage.Image = Image.FromStream(mem);
                }
            }

            baglanti.Close();
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            bool retVal = false;
            retVal = Regex.IsMatch(txtEmail.Text, MatchEmailPattern);
            Database.KullaniciKayit kullanici = new Database.KullaniciKayit();
            Database.KullaniciKayitDB kayitDB = new Database.KullaniciKayitDB();

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
                    if (txtAd.Text != "" && txtSoyad.Text != "" && txtEmail.Text != "" && txtAdres.Text != "" && txtKullanici.Text != "" && txtSifre.Text != "" && dtTarih.Value.ToString() != "")
                    {

                        string sifre = txtSifre.Text;

                        if (sifre.Length == 8)
                        {
                            if (retVal)
                            {
                                try
                                {
                                    kullanici.Id = int.Parse(lblId.Text);
                                    kullanici.Ad = txtAd.Text;
                                    kullanici.Soyad = txtSoyad.Text;
                                    kullanici.DogumTarihi = dtTarih.Value;
                                    kullanici.Adres = txtAdres.Text;
                                    kullanici.Email = txtEmail.Text;
                                    kullanici.Kullaniciadi = txtKullanici.Text;
                                    kullanici.Sifre = txtSifre.Text;
                                    kullanici.Tip = Convert.ToChar(lblTip.Text);
                                    kullanici.Resim = img;

                                    kayitDB.Guncelle(kullanici);

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
                    else if (txtAd.Text == "" && txtSoyad.Text == "" && txtEmail.Text == "" && txtAdres.Text == "" && txtKullanici.Text == "" && txtSifre.Text == "" && dtTarih.Value.ToString() == "")
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

        private void txtKullanici_KeyPress(object sender, KeyPressEventArgs e)
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
