using depoEnvanterSTP.Pages.ElemanSayfa;
using depoEnvanterSTP.Pages.KullaniciSayfa;
using depoEnvanterSTP.Tablolar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace depoEnvanterSTP.Pages
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();

        }
        //SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-8F8HA90\SQLEXPRESS; Initial Catalog=iksvDEPOestp;Integrated Security=True");
        SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDBConnectionString"].ConnectionString);

        string resimAdresi;
        
        private void btnUnut_Click(object sender, EventArgs e)
        {
            FormSifremiUnuttum formSifremiUnuttum = new FormSifremiUnuttum();
            this.Hide();
            formSifremiUnuttum.Show();
        }
        

        private void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                Database.KullaniciKayit kullanici = new Database.KullaniciKayit();
                kullanici.Kullaniciadi = txtKullaniciAdiEmail.Text;
                kullanici.Email = txtKullaniciAdiEmail.Text;
                kullanici.Sifre = txtPassword.Text;
                SqlDataReader dr;
                Database.LoginDB loginDB = new Database.LoginDB();
                loginDB.Baglan();
                baglanti.Open();
                DataTable tablo = loginDB.Listele(kullanici);


                if (tablo.Rows.Count > 0)
                {
                    Login.Id = Convert.ToInt32(tablo.Rows[0]["Id"].ToString());
                    Login.Ad = tablo.Rows[0]["Ad"].ToString();
                    Login.Soyad = tablo.Rows[0]["Soyad"].ToString();
                    Login.Email = txtKullaniciAdiEmail.Text;
                    Login.Kullaniciadi = txtKullaniciAdiEmail.Text;
                    Login.Sifre = tablo.Rows[0]["Sifre"].ToString();
                    

                    SqlCommand sqlCommand = new SqlCommand("SELECT * FROM tbl_Aktivasyon where AktivasyonKod=@AktivasyonKod", baglanti);
                    sqlCommand.Parameters.AddWithValue("@AktivasyonKod", txtPassword.Text);
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = sqlCommand;
                    DataSet dataset = new DataSet();
                    adapter.Fill(dataset);

                    if (dataset.Tables[0].Rows.Count == 0)
                    {
                       
                        if (char.Parse(tablo.Rows[0]["Tip"].ToString()) == 'Y')
                        {
                            AdminAnasayfa admin = new AdminAnasayfa();
                            this.Hide();
                            admin.Show();
                        }
                        else if (char.Parse(tablo.Rows[0]["Tip"].ToString()) == 'K')
                        {
                            FormKullaniciAnasayfa admin = new FormKullaniciAnasayfa();
                            this.Hide();
                            admin.Show();
                        }
                        else if (char.Parse(tablo.Rows[0]["Tip"].ToString()) == 'E')
                        {
                            FormElemanAnasayfa formEleman = new FormElemanAnasayfa();
                            this.Hide();
                            formEleman.Show();

                        }
                        else
                        {
                            lblMesaj.Visible = true;
                            lblMesaj.Text = "Hata";
                        }
                        baglanti.Close();
                    }

                    string Sifresi = dataset.Tables[0].Rows[0]["AktivasyonKod"].ToString();

                    if (Sifresi == txtPassword.Text)
                    {
                        FormKullaniciSifreDegistirme formKullaniciSifreDegistirme = new FormKullaniciSifreDegistirme();
                        this.Hide();
                        formKullaniciSifreDegistirme.Show();
                    }
                    else
                    {
                        lblMesaj.Text = "Giriş yaparken hata oluştu";
                        lblMesaj.Visible = true;

                    }
                }
                else
                {
                    lblMesaj.Text = "Kullanıcı Bilgisi ve Şifre geçersiz";
                    lblMesaj.Visible = true;
                }
                baglanti.Close();

            }
            catch (Exception hata)
            {

                lblMesaj.Text = "Hata kodu : " + hata.Message;
                lblMesaj.Visible = true;
            }
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            FormKullaniciKayit formKullaniciKayit = new FormKullaniciKayit();
            this.Hide();
            formKullaniciKayit.Show();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
