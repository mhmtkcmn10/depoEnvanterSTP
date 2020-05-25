using depoEnvanterSTP.Database;
using depoEnvanterSTP.Tablolar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace depoEnvanterSTP.Pages
{
    public partial class FormStokCikis : Form
    {
        public FormStokCikis()
        {
            InitializeComponent();
        }
        UrunTanimlama urun = new UrunTanimlama();
        UrunTanimlamaDB urunDB = new UrunTanimlamaDB();
        //SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-8F8HA90\SQLEXPRESS; Initial Catalog=iksvDEPOestp;Integrated Security=True");
        SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDBConnectionString"].ConnectionString);

        private void FormStokCikis_Load(object sender, EventArgs e)
        {
            lblId.Text = "";

            dgStokCikis.ColumnCount = 12;
            dgStokCikis.Columns[0].Name = "BelgeNumarasi";
            dgStokCikis.Columns[1].Name = "Gonderici";
            dgStokCikis.Columns[2].Name = "Alici";
            dgStokCikis.Columns[3].Name = "Tarih";
            dgStokCikis.Columns[4].Name = "FiiliSevkTarihi";
            dgStokCikis.Columns[5].Name = "VergiNumarasi";
            dgStokCikis.Columns[6].Name = "SevkAdresi";
            dgStokCikis.Columns[7].Name = "UrunNo";
            dgStokCikis.Columns[8].Name = "UrunKodu";
            dgStokCikis.Columns[9].Name = "UrunAdi";
            dgStokCikis.Columns[10].Name="CikisAdet";
            dgStokCikis.Columns[11].Name = "CikisAdet2";


            Oda oda = new Oda();
            OdaDB odaDB = new OdaDB();

            cbOda.DataSource = odaDB.Listele(oda);
            cbOda.DisplayMember = "OdaAdi";
            cbOda.ValueMember = "Id";

            KullaniciKayit kullanici = new KullaniciKayit();
            KullaniciKayitDB kullaniciDB = new KullaniciKayitDB();

            cbGonderici.DataSource = kullaniciDB.ListeleAdminKullanici(kullanici);
            cbGonderici.DisplayMember = "AdSoyad";
            cbGonderici.ValueMember = "Id";


            Sirket sirket = new Sirket();
            SirketDB sirketDB = new SirketDB();

            cbVergiNo.DataSource = sirketDB.Listele(sirket);
            cbVergiNo.DisplayMember = "VergiNo";
            cbVergiNo.ValueMember = "Id";

            baglanti.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT top 1 BelgeNumarasi FROM tbl_StokUrunCikis  order by Id desc", baglanti);

            SqlDataReader dr = cmd2.ExecuteReader();
            if (dr.Read())
            {
                if (dr["BelgeNumarasi"].ToString() == null)
                {
                    txtBelgeNo.Text = "";
                }
                else
                {
                    txtBelgeNo.Text = dr["BelgeNumarasi"].ToString();

                    string harf = txtBelgeNo.Text;
                    lbldeger.Text = harf.Substring(0,1);
                    lblsayı.Text = harf.Substring(1,7);

                    lblsayı.Text = (Convert.ToInt32(lblsayı.Text) + 1).ToString();

                    txtBelgeNo.Text = lbldeger.Text + lblsayı.Text;
                    
                }
                
            }
            baglanti.Close();
        }
        

        private void btnOdaListele_Click(object sender, EventArgs e)
        {
            try
            {
                urun.OdaId = Convert.ToInt32(cbOda.SelectedValue.ToString());
                dgUrunler.DataSource = urunDB.Arama(urun);

            }
            catch (Exception hata)
            {
                MessageBox.Show("HATA :" + hata.Message);
            }
        }

        int veriUrunAdet = 0;

        private void dgUrunler_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                lblId.Text = "";
                txtUrunKodu.Text = "";
                txtUrunAdi.Text = "";
                txtUrunAdet.Text = "";
                
                lblId.Text = dgUrunler.SelectedRows[0].Cells[0].Value.ToString();
                txtUrunKodu.Text = dgUrunler.SelectedRows[0].Cells[2].Value.ToString();
                txtUrunAdi.Text = dgUrunler.SelectedRows[0].Cells[3].Value.ToString();
                txtUrunAdet.Text = dgUrunler.SelectedRows[0].Cells[6].Value.ToString();
                
                veriUrunAdet = Convert.ToInt32(txtUrunAdet.Text);
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata: "+hata.Message);
            }
            
        }

        public void UrunEkle()
        {
            if (txtBelgeNo.Text != "" && txtBelgeNo.TextLength == 8 && txtAlici.Text != "" && txtSevkAdres.Text != "" && txtUrunAdet.Text != "" && Convert.ToInt32(txtUrunAdet.Text) <= veriUrunAdet && txtUrunAdet.Text != "0" && lblId.Text != "" && txtUrunAdi.Text != "" && txtUrunKodu.Text != "")
            {
                btnUrunEkle.Visible = true;
                //dgStokCikis.Visible = true;
            }
            else
            {
                btnUrunEkle.Visible = false;
                //dgStokCikis.Visible = false;
            }
        }
        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            string belgeNo = txtBelgeNo.Text;
            int gonderici = Convert.ToInt32(cbGonderici.SelectedValue);
            string alici = txtAlici.Text;
            string tarih = dtTarih.Value.ToString();
            string sevkTarih = dtSevkTarih.Value.ToString();
            int vergiNo = Convert.ToInt32(cbVergiNo.SelectedValue);
            string sevkAdres = txtSevkAdres.Text;

            int urunId = Convert.ToInt32(lblId.Text);
            string urunAdi = txtUrunAdi.Text;
            string urunKodu = txtUrunKodu.Text;
            int adet = Convert.ToInt32(txtUrunAdet.Text);
            int adet2 = Convert.ToInt32(txtUrunAdet.Text);


            dgStokCikis.Rows.Add(belgeNo, gonderici, alici, tarih, sevkTarih, vergiNo, sevkAdres, urunId, urunKodu, urunAdi, adet,adet2);

            lblId.Text = "";
            txtUrunKodu.Text = "";
            txtUrunAdi.Text = "";
            txtUrunAdet.Text = "";

            txtBelgeNo.Enabled = false;
            cbGonderici.Enabled = false;
            txtAlici.Enabled = false;
            dtTarih.Enabled = false;
            dtSevkTarih.Enabled = false;
            cbVergiNo.Enabled = false;
            txtSevkAdres.Enabled = false;

            btnStokCikisİslem.Visible = true;

        }

        private void btnStokCikisİslem_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            try
            {
                for (int i = 0; i < dgStokCikis.Rows.Count - 1; i++)
                {

                    StokCikis stok = new StokCikis();
                    StokCikisDB stokDB = new StokCikisDB();

                    stok.BelgeNumarasi = dgStokCikis.Rows[i].Cells["BelgeNumarasi"].Value.ToString();
                    stok.Gonderici = Convert.ToInt32(dgStokCikis.Rows[i].Cells["Gonderici"].Value.ToString());
                    stok.Alici = dgStokCikis.Rows[i].Cells["Alici"].Value.ToString();
                    stok.Tarih = Convert.ToDateTime(dgStokCikis.Rows[i].Cells["Tarih"].Value.ToString());
                    stok.FiiliSevkTarihi = Convert.ToDateTime(dgStokCikis.Rows[i].Cells["FiiliSevkTarihi"].Value.ToString());
                    stok.VergiNumarasi = Convert.ToInt32(dgStokCikis.Rows[i].Cells["VergiNumarasi"].Value.ToString());
                    stok.SevkAdresi = dgStokCikis.Rows[i].Cells["SevkAdresi"].Value.ToString();
                    stok.UrunNo = Convert.ToInt32(dgStokCikis.Rows[i].Cells["UrunNo"].Value.ToString());
                    stok.CikisAdet = Convert.ToInt32(dgStokCikis.Rows[i].Cells["CikisAdet"].Value.ToString());
                    stok.CikisAdet2 = Convert.ToInt32(dgStokCikis.Rows[i].Cells["CikisAdet2"].Value.ToString());



                    stokDB.Ekle(stok);
                    SqlCommand comUPDATE = new SqlCommand("UPDATE tbl_UrunTanimlama SET Adet=Adet-@Adet WHERE Id=@UrunNo", baglanti);
                    comUPDATE.Parameters.AddWithValue("@Adet", dgStokCikis.Rows[i].Cells["CikisAdet"].Value.ToString());
                    comUPDATE.Parameters.AddWithValue("@UrunNo", dgStokCikis.Rows[i].Cells["UrunNo"].Value.ToString());

                    comUPDATE.ExecuteNonQuery();

                    SqlCommand comUPDATE2 = new SqlCommand("UPDATE tbl_UrunTanimlama SET ToplamFiyat=BirimFiyat*Adet WHERE Id=@UrunNo", baglanti);
                    //comUPDATE2.Parameters.AddWithValue("@Adet", dgStokCikis.Rows[i].Cells["Adet"].Value.ToString());
                    comUPDATE2.Parameters.AddWithValue("@UrunNo", dgStokCikis.Rows[i].Cells["UrunNo"].Value.ToString());

                    comUPDATE2.ExecuteNonQuery();


                }
                //lblMesaj.Visible = true;
                //lblMesaj.Text = "KAYIT GERÇEKLEŞTİ";

                baglanti.Close();
                AlanTemizle();

                MessageBox.Show("Stok Çıkış Başarılı");
                this.Hide();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata : "+hata.Message);
            }
            

        }
        public void AlanTemizle()
        {
            lblId.Text = "";
            txtUrunKodu.Text = "";
            txtUrunAdi.Text = "";
            txtUrunAdet.Text = "";

            
            txtAlici.Text = "";
            txtSevkAdres.Text = "";


            txtBelgeNo.Enabled = true;
            cbGonderici.Enabled = true;
            txtAlici.Enabled = true;
            dtTarih.Enabled = true;
            dtSevkTarih.Enabled = true;
            cbVergiNo.Enabled = true;
            txtSevkAdres.Enabled = true;

            btnStokCikisİslem.Visible = false;

            //dgUrunler.Rows.Clear();
            dgStokCikis.Rows.Clear();


        }


        private void txtBelgeNo_TextChanged(object sender, EventArgs e)
        {
            UrunEkle();
        }

        private void txtAlici_TextChanged(object sender, EventArgs e)
        {
            UrunEkle();
        }

        private void txtSevkAdres_TextChanged(object sender, EventArgs e)
        {
            UrunEkle();
        }

        private void txtUrunAdet_TextChanged(object sender, EventArgs e)
        {
            UrunEkle();
        }

        private void txtUrunAdet_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnAlanTemizle_Click(object sender, EventArgs e)
        {
            AlanTemizle();
        }
    }
}
