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
    public partial class FormStokHar : Form
    {
        public FormStokHar()
        {
            InitializeComponent();
        }
        StokCikis cikis = new StokCikis();
        StokCikisDB cikisDB = new StokCikisDB();
        StokGiris giris = new StokGiris();
        StokGirisDB girisDB = new StokGirisDB();
        //SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-8F8HA90\SQLEXPRESS; Initial Catalog=iksvDEPOestp;Integrated Security=True");
        SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDBConnectionString"].ConnectionString);

        public void StokCikisListele()
        {
            dgStokHar.DataSource = cikisDB.StokHarListele(cikis);
        }
        public void StokGirisListele()
        {
            dgStokHar2.DataSource = girisDB.StokHarListele(giris);
        }

        private void btnStokCikisListe_Click(object sender, EventArgs e)
        {
            StokCikisListele();
            dgStokHar.Visible = true;
            dgStokHar2.Visible = false;

            lblArama.Visible = true;
            txtCikisArama.Visible = true;
            txtGirisArama.Visible = false;

            btnStokGirisSil.Visible = false;


            Temizle();


        }
        private void btnStokGirisListe_Click(object sender, EventArgs e)
        {
            StokGirisListele();
            dgStokHar.Visible = false;
            dgStokHar2.Visible = true;

            lblArama.Visible = true;
            txtGirisArama.Visible = true;
            txtCikisArama.Visible = false;

            label2.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label12.Visible = false;
            txtUrunAdi.Visible = false;
            txtUrunKodu.Visible = false;
            txtUrunAdet.Visible = false;
            txtUrunCikisAdet.Visible = false;
            btnStokCikisSil.Visible = false;

           
            Temizle();
        }

        public void Temizle()
        {
            lblId.Text = "";
            lblUrunNo.Text = "";
            lblUrunCikisAdet.Text = "";
            lblUrunDurum.Text = "";
            txtUrunKodu.Text = "";
            txtUrunAdi.Text = "";
            txtUrunAdet.Text = "";
            txtUrunCikisAdet.Text = "";
            lblStokGirisID.Text = "";
        }


        private void dgStokHar_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                lblId.Text = dgStokHar.SelectedRows[0].Cells["Id"].Value.ToString();
                lblUrunNo.Text = dgStokHar.SelectedRows[0].Cells["UrunNo"].Value.ToString();
                lblUrunCikisAdet.Text = dgStokHar.SelectedRows[0].Cells["CikisAdet"].Value.ToString();
                lblUrunDurum.Text = dgStokHar.SelectedRows[0].Cells["Durum"].Value.ToString();
                txtUrunKodu.Text = dgStokHar.SelectedRows[0].Cells["UrunKodu"].Value.ToString();
                txtUrunAdi.Text = dgStokHar.SelectedRows[0].Cells["UrunAdi"].Value.ToString();
                txtUrunAdet.Text = dgStokHar.SelectedRows[0].Cells["Adet"].Value.ToString();
                txtUrunCikisAdet.Text = dgStokHar.SelectedRows[0].Cells["CikisAdet"].Value.ToString();

                label2.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                label12.Visible = true;
                txtUrunAdi.Visible = true;
                txtUrunKodu.Visible = true;
                txtUrunAdet.Visible = true;
                txtUrunCikisAdet.Visible = true;

                if (lblUrunDurum.Text == "P")
                {
                    btnStokCikisUrunGüncelle.Visible = false;
                }
                else
                {
                    btnStokCikisUrunGüncelle.Visible = true;

                }
                if (lblUrunDurum.Text == "A")
                {
                    btnStokCikisSil.Visible = true;
                }
                else
                {
                    btnStokCikisSil.Visible = true;

                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata : "+hata.Message);
            }
        }

        private void btnStokCikisDurum_Click(object sender, EventArgs e)
        {
            dgStokHar.Visible = true;
            dgStokHar2.Visible = false;
            Temizle();
            try
            {
                cikis.Durum = cbSCDurum.SelectedText.ToString();
                dgStokHar.DataSource = cikisDB.StokDurumListele(cikis);

            }
            catch (Exception hata)
            {
                MessageBox.Show("HATA :" + hata.Message);
            }
        }

        private void btnStokCikisUrunGüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(lblUrunCikisAdet.Text) > int.Parse(txtUrunCikisAdet.Text))
                {
                    cikis.Id = int.Parse(lblId.Text);
                    cikis.CikisAdet = int.Parse(txtUrunCikisAdet.Text);
                    cikis.CikisAdet2 = int.Parse(txtUrunCikisAdet.Text);

                    cikisDB.Guncelle(cikis);

                    int sonuc = int.Parse(lblUrunCikisAdet.Text) - int.Parse(txtUrunCikisAdet.Text);
                    baglanti.Open();

                    SqlCommand comUPDATE3 = new SqlCommand("UPDATE tbl_UrunTanimlama SET Adet=Adet+@Adet WHERE Id=@UrunNo", baglanti);
                    comUPDATE3.Parameters.AddWithValue("@Adet", sonuc);
                    comUPDATE3.Parameters.AddWithValue("@UrunNo", lblUrunNo.Text);

                    comUPDATE3.ExecuteNonQuery();

                    SqlCommand comUPDATE4 = new SqlCommand("UPDATE tbl_UrunTanimlama SET ToplamFiyat=Adet*BirimFiyat WHERE Id=@UrunNo", baglanti);
                    comUPDATE4.Parameters.AddWithValue("@UrunNo", lblUrunNo.Text);
                    comUPDATE4.ExecuteNonQuery();

                    lblMesaj.Visible = true;
                    lblMesaj.Text = "Veri Güncellendi ...";
                    StokCikisListele();
                    baglanti.Close();
                    Temizle();
                }
                else
                {
                    cikis.Id = int.Parse(lblId.Text);
                    cikis.CikisAdet = int.Parse(txtUrunCikisAdet.Text);
                    cikis.CikisAdet2 = int.Parse(txtUrunCikisAdet.Text);

                    cikisDB.Guncelle(cikis);

                    int sonuc = int.Parse(txtUrunCikisAdet.Text) - int.Parse(lblUrunCikisAdet.Text);
                    baglanti.Open();

                    SqlCommand comUPDATE3 = new SqlCommand("UPDATE tbl_UrunTanimlama SET Adet=Adet-@Adet WHERE Id=@UrunNo", baglanti);
                    comUPDATE3.Parameters.AddWithValue("@Adet", sonuc);
                    comUPDATE3.Parameters.AddWithValue("@UrunNo", lblUrunNo.Text);

                    comUPDATE3.ExecuteNonQuery();

                    SqlCommand comUPDATE4 = new SqlCommand("UPDATE tbl_UrunTanimlama SET ToplamFiyat=Adet*BirimFiyat WHERE Id=@UrunNo", baglanti);
                    comUPDATE4.Parameters.AddWithValue("@UrunNo", lblUrunNo.Text);
                    comUPDATE4.ExecuteNonQuery();


                    lblMesaj.Visible = true;
                    lblMesaj.Text = "Veri Güncellendi ...";

                    StokCikisListele();
                    baglanti.Close();
                    Temizle();

                }

            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata : " + hata.Message);

            }
        }

        private void txtCikisArama_TextChanged(object sender, EventArgs e)
        {
            try
            {
                cikis.BelgeNumarasi = txtCikisArama.Text;
                cikis.SevkAdresi = txtCikisArama.Text;
                dgStokHar.DataSource = cikisDB.Arama(cikis);
            }
            catch (Exception hata)
            {
                MessageBox.Show("HATA :" + hata.Message);
            }
        }

        private void txtGirisArama_TextChanged(object sender, EventArgs e)
        {
            try
            {
                giris.BelgeNumarasi = txtGirisArama.Text;
                dgStokHar2.DataSource = girisDB.Arama(giris);
            }
            catch (Exception hata)
            {
                MessageBox.Show("HATA :" + hata.Message);
            }
        }

        private void txtUrunCikisAdet_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }
        DialogResult dialog;
        private void btnStokCikisSil_Click(object sender, EventArgs e)
        {
            try
            {
                cikis.Id = int.Parse(lblId.Text);

                if (lblUrunDurum.Text=="P")
                {
                    dialog = MessageBox.Show("Veriyi silmeyi onaylıyor musunuz ?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dialog == DialogResult.Yes)
                    {
                       
                        StokCikisListele();
                        cikisDB.Sil(cikis);
                        Temizle();
                        lblMesaj.Visible = true;
                        lblMesaj.Text = "Veri Silindi ... (P)";
                    }
                    else
                    {
                        StokCikisListele();
                    }

                }
                else
                {
                    dialog = MessageBox.Show("Veriyi silmeyi onaylıyor musunuz ?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dialog == DialogResult.Yes)
                    {
                        baglanti.Open();

                        SqlCommand comUPDATE3 = new SqlCommand("UPDATE tbl_UrunTanimlama SET Adet=Adet+@Adet WHERE Id=@UrunNo", baglanti);
                        comUPDATE3.Parameters.AddWithValue("@Adet", lblUrunCikisAdet.Text);
                        comUPDATE3.Parameters.AddWithValue("@UrunNo", lblUrunNo.Text);

                        comUPDATE3.ExecuteNonQuery();

                        SqlCommand comUPDATE4 = new SqlCommand("UPDATE tbl_UrunTanimlama SET ToplamFiyat=Adet*BirimFiyat WHERE Id=@UrunNo", baglanti);
                        comUPDATE4.Parameters.AddWithValue("@UrunNo", lblUrunNo.Text);
                        comUPDATE4.ExecuteNonQuery();

                        baglanti.Close();
                        StokCikisListele();
                        cikisDB.Sil(cikis);
                        Temizle();
                        lblMesaj.Visible = true;
                        lblMesaj.Text = "Veri Silindi ... (A)";
                    }
                    else
                    {
                        StokCikisListele();
                    }
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("HATA :" + hata.Message);

            }
        }
        public void UrunCikisKontrol()
        {
            if (txtUrunCikisAdet.Text == "" || txtUrunCikisAdet.Text=="0")
            {
                btnStokCikisUrunGüncelle.Visible = false;

            }
            else if (int.Parse(txtUrunCikisAdet.Text) <= int.Parse(txtUrunAdet.Text))
            {
                btnStokCikisUrunGüncelle.Visible = true;
            }

            else
            {
                btnStokCikisUrunGüncelle.Visible = false;

            }
        }
        private void txtUrunCikisAdet_TextChanged(object sender, EventArgs e)
        {
            UrunCikisKontrol();
        }

        private void dgStokHar2_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            lblStokGirisID.Text = dgStokHar2.SelectedRows[0].Cells["Id"].Value.ToString();
            btnStokGirisSil.Visible = true;

        }

        private void btnStokGirisSil_Click(object sender, EventArgs e)
        {
            try
            {
                giris.Id = int.Parse(lblStokGirisID.Text);

                dialog = MessageBox.Show("Veriyi silmeyi onaylıyor musunuz ?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialog == DialogResult.Yes)
                {
                    girisDB.Sil(giris);
                    StokGirisListele();
                    lblMesaj.Visible = true;
                    lblMesaj.Text = "Veri Silindi ...";
                }
                else
                {
                    StokGirisListele();
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("HATA :" + hata.Message);

            }
        }

        private void FormStokHar_Load(object sender, EventArgs e)
        {

        }
    }
}
