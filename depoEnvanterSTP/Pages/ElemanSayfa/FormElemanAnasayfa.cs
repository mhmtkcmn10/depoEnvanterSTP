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

namespace depoEnvanterSTP.Pages.ElemanSayfa
{
    public partial class FormElemanAnasayfa : Form
    {
        public FormElemanAnasayfa()
        {
            InitializeComponent();
            Load += FormElemanAnasayfa_Load;
        }
        //SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-8F8HA90\SQLEXPRESS; Initial Catalog=iksvDEPOestp;Integrated Security=True");
        SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDBConnectionString"].ConnectionString);

        private void FormElemanAnasayfa_Load(object sender, EventArgs e)
        {
            lblId.Text = "" + Tablolar.Login.Id;
            lblAd.Text = "" + Tablolar.Login.Ad;
            lblSoyad.Text = "" + Tablolar.Login.Soyad;

            baglanti.Open();
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "SELECT * FROM tbl_KullaniciKayit WHERE Id='" + lblId.Text + "'";
            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                lblId.Text = dr["Id"].ToString();
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

        private void btnEnvanterLis_Click(object sender, EventArgs e)
        {
            FormElemanEnvanterListesi formElemanEnvanterListesi = new FormElemanEnvanterListesi();
            formElemanEnvanterListesi.Show();
        }

        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            FormElemanAyarlari formElemanAyarlari = new FormElemanAyarlari();
            formElemanAyarlari.Show();
        }
    }
}
