using depoEnvanterSTP.Database;
using depoEnvanterSTP.Pages.KullaniciSayfa;
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
    public partial class FormKullaniciAnasayfa : Form
    {
        public FormKullaniciAnasayfa()
        {
            InitializeComponent();
            Load += FormKullaniciAnasayfa_Load;
        }
        //SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-8F8HA90\SQLEXPRESS; Initial Catalog=iksvDEPOestp;Integrated Security=True");
        SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDBConnectionString"].ConnectionString);

        void FormKullaniciAnasayfa_Load(object sender, EventArgs e)
        {
            lblId.Text = "" + Tablolar.Login.Id;
            lblAd.Text =""+Tablolar.Login.Ad;
            lblSoyad.Text =""+Tablolar.Login.Soyad;
            
           baglanti.Open();
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "SELECT * FROM tbl_KullaniciKayit WHERE Id='"+lblId.Text+"'";
            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                lblId.Text= dr["Id"].ToString();
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

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            FormUrunTanimlama formUrunTanimlama = new FormUrunTanimlama();
            formUrunTanimlama.Show();
        }

        private void btnEnvanterLis_Click(object sender, EventArgs e)
        {
            FormKullaniciEnvanterListesi formKullaniciEnvanterListesi = new FormKullaniciEnvanterListesi();
            formKullaniciEnvanterListesi.Show();
        }

        private void btnStokGiris_Click(object sender, EventArgs e)
        {
            FormStokGiris formStokGiris = new FormStokGiris();
            formStokGiris.Show();
        }
        
        private void btnStokHar_Click(object sender, EventArgs e)
        {
            FormStokHar formStokHar = new FormStokHar();
            formStokHar.Show();
        }

        private void btnDepoOda_Click(object sender, EventArgs e)
        {
            FormKullaniciDepoOda depoOda = new FormKullaniciDepoOda();
            depoOda.Show();
        }

        private void btnVakifAyar_Click(object sender, EventArgs e)
        {
            FormKullaniciVakifSirket vakifSirket = new FormKullaniciVakifSirket();
            vakifSirket.Show();
        }

        private void btnStokCikis_Click(object sender, EventArgs e)
        {
            FormStokCikis formStokCikis = new FormStokCikis();
            formStokCikis.Show();
        }

        private void btnKullanici_Click(object sender, EventArgs e)
        {
            FormKullaniciAyar formKullaniciAyar = new FormKullaniciAyar();
            formKullaniciAyar.Show();
        }
        
    }
}
