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

namespace depoEnvanterSTP.Pages.KullaniciSayfa
{
    public partial class FormKullaniciSifreDegistirme : Form
    {
        public FormKullaniciSifreDegistirme()
        {
            InitializeComponent();
        }
        
        private void FormKullaniciSifreDegistirme_Load(object sender, EventArgs e)
        {
            lblId.Text = " " + Tablolar.Login.Id;
            lblAd.Text = " " + Tablolar.Login.Ad;
            lblSoyad.Text = " " + Tablolar.Login.Soyad;
            txtSifre.Text = " " + Tablolar.Login.Sifre;
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
                lblSifre.Text = "8 haneli karakter geçerlidir";
                lblSifre.Visible = true;
            }
            else if (txtSifre.Text == "")
            {
                lblSifre.Text = "";
                lblSifre.Visible = false;
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
                    lblSifre.Text = "Kuvvetli Sifre";
                    lblSifre.Visible = true;

                }
                else if (HarfVar == true && RakamVar == true || HarfVar == true && OzelKarakterVar == true || RakamVar == true && OzelKarakterVar == true)
                {
                    lblSifre.Text = "Orta Seviye Şifre";
                    lblSifre.Visible = true;
                }
                else
                {
                    lblSifre.Text = "Zayıf Şifre";
                    lblSifre.Visible = true;
                }
            }
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Database.KullaniciKayit kullanici = new Database.KullaniciKayit();
            Database.KullaniciKayitDB kayitDB = new Database.KullaniciKayitDB();
           
            try
            {
                if (txtSifre.Text==txtSifreTekrar.Text)
                {
                    string sifre = txtSifre.Text;

                    if (sifre.Length==8)
                    {
                        kullanici.Id = int.Parse(lblId.Text);
                        kullanici.Sifre = txtSifre.Text;

                        //SifreKontrol();
                        kayitDB.GuncelleSifreDegistirme(kullanici);

                        lblMesaj.Text = "Veri Güncellendi ...";
                        lblMesaj.Visible = true;

                        FormLogin login = new FormLogin();
                        login.Show();
                        this.Hide();

                    }
                    else
                    {
                        lblMesaj.Text = "Şifre 8 haneli olmak zorunda ...";
                        lblMesaj.Visible = true;
                        txtSifre.Text = "";
                        txtSifreTekrar.Text = "";
                    }
                   
                }
                else
                {
                    lblMesaj.Text = "Yaptığınız işlemlere dikkat ediniz ...";
                    lblMesaj.Visible = true;
                }
                
            }
            catch (Exception hata)
            {

                lblMesaj.Text = "Hata: " + hata.Message.ToString();
                lblMesaj.Visible = true;
            }
        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {
            SifreKontrol();
        }

        private void txtSifreTekrar_TextChanged(object sender, EventArgs e)
        {
            SifreKontrol();
        }
    }
}
