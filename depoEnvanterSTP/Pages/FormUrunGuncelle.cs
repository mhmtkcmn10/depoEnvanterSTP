using depoEnvanterSTP.Database;
using depoEnvanterSTP.Tablolar;
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

namespace depoEnvanterSTP.Pages
{
    public partial class FormUrunGuncelle : Form
    {
        public FormUrunGuncelle()
        {
            InitializeComponent();
            Load += FormUrunGuncelle_Load;
            DialogHazirla();

        }
        private void FormUrunGuncelle_Load(object sender, EventArgs e)
        {
            Oda oda = new Oda();
            OdaDB odaDB = new OdaDB();

            cbOdaAdi.DataSource = odaDB.Listele(oda);
            cbOdaAdi.DisplayMember = "OdaAdi";
            cbOdaAdi.ValueMember = "Id";

            lblId.Text = "" + Tablolar.UrunBilgiTasima.Id;
            cbOdaAdi.Text = "" + Tablolar.UrunBilgiTasima.OdaId;
            txtUrunAdi.Text = "" + Tablolar.UrunBilgiTasima.UrunAdi;
            txtUrunKodu.Text = "" + Tablolar.UrunBilgiTasima.UrunKodu;
            txtMarka.Text = "" + Tablolar.UrunBilgiTasima.Marka;
            txtModel.Text = "" + Tablolar.UrunBilgiTasima.Model;
            txtAdet.Text = "" + Tablolar.UrunBilgiTasima.Adet;
            txtBirimFiyat.Text = "" + Tablolar.UrunBilgiTasima.BirimFiyat;
            txtToplamFiyat.Text = "" + Tablolar.UrunBilgiTasima.ToplamFiyat;
            txtAciklama.Text = "" + Tablolar.UrunBilgiTasima.Aciklama;

            byte[] picture = (byte[])Tablolar.UrunBilgiTasima.Resim;
            MemoryStream ms = new MemoryStream(picture);
            pbImage.Image = Image.FromStream(ms);

        }
        
        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                MemoryStream ms = new MemoryStream();
                pbImage.Image.Save(ms, pbImage.Image.RawFormat);
                byte[] img = ms.ToArray();
                if (pbImage.Image == null)
                {
                    MessageBox.Show("Lütfen resim seçiniz ...");
                }
                else
                {
                    if (txtUrunAdi.Text != "" && txtUrunKodu.Text != "" && txtMarka.Text != "" && txtModel.Text != "" && txtAdet.Text != "" && txtBirimFiyat.Text != "" && txtToplamFiyat.Text != "")
                    {
                        UrunTanimlama urun = new UrunTanimlama();
                        UrunTanimlamaDB urunDB = new UrunTanimlamaDB();
                        try
                        {
                            urun.Id = int.Parse(lblId.Text);
                            urun.OdaId = Convert.ToInt32(cbOdaAdi.SelectedValue.ToString());
                            urun.UrunAdi = txtUrunAdi.Text;
                            urun.UrunKodu = txtUrunKodu.Text;
                            urun.Marka = txtMarka.Text;
                            urun.Model = txtModel.Text;
                            urun.Adet = Convert.ToInt32(txtAdet.Text);
                            urun.BirimFiyat = Convert.ToDouble(txtBirimFiyat.Text);
                            urun.ToplamFiyat = Convert.ToDouble(txtToplamFiyat.Text);
                            urun.Aciklama = txtAciklama.Text;
                            urun.Resim = img;
                            urunDB.Guncelle(urun);
                            lblMesaj.Visible = true;
                            lblMesaj.Text = "Güncelleme Gerçekleşti";
                        }
                        catch (Exception hata)
                        {
                            lblMesaj2.Visible = true;
                            lblMesaj2.Text = "Kayıtlı veri mevcutur. Alanı kontrol ediniz...";
                            lblUrunKodu.Visible = true;
                        }
                    }
                    else
                    {
                        lblMesaj.Text = "Gerekli alanlar boş bırakılamaz";
                        lblMesaj.Visible = true;
                    }

                }

            }
            catch (Exception hata)
            {
                lblMesaj.Text = "HATA :" + hata.Message;
                lblMesaj.Visible = true;
            }
        }
        

        private void txtUrunKodu_TextChanged(object sender, EventArgs e)
        {
           
            if (txtUrunKodu.Text == "")
            {
                lblUrunKodu.Visible = true;
            }
            else
            {
                lblUrunKodu.Visible = false;
            }
        }

        private void txtUrunAdi_TextChanged(object sender, EventArgs e)
        {
           
            if (txtUrunAdi.Text == "")
            {
                lblUrunAdi.Visible = true;
            }
            else
            {
                lblUrunAdi.Visible = false;

            }
        }

        private void txtMarka_TextChanged(object sender, EventArgs e)
        {
            
            if (txtMarka.Text == "")
            {
                lblMarka.Visible = true;
            }
            else
            {
                lblMarka.Visible = false;

            }
        }

        private void txtModel_TextChanged(object sender, EventArgs e)
        {
           
            if (txtModel.Text == "")
            {
                lblModel.Visible = true;
            }
            else
            {
                lblModel.Visible = false;

            }
        }

        private void txtAdet_TextChanged(object sender, EventArgs e)
        {
            
            if (txtAdet.Text == "")
            {
                lblAdet.Visible = true;
            }
            else
            {
                lblAdet.Visible = false;
            }
        }

        private void txtBirimFiyat_TextChanged(object sender, EventArgs e)
        {
            
            if (txtBirimFiyat.Text == "")
            {
                lblBirim.Visible = true;
            }
            else
            {
                lblBirim.Visible = false;

            }
        }
        private void txtAdet_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtBirimFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtToplamFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }
        OpenFileDialog ofdResim = new OpenFileDialog();
        string resimAdresi;
        public void DialogHazirla()
        {
            ofdResim.Title = "Resim Seçiniz";
            ofdResim.Filter = "Resim Dosyası |*.jpg;*.nef;*.png*.jpeg*.jfif|Tüm Dosyalar |*.*";

        }
        private void btnResim_Click(object sender, EventArgs e)
        {
            if (ofdResim.ShowDialog() == DialogResult.OK)
            {
                pbImage.Image = System.Drawing.Image.FromFile(ofdResim.FileName);
                resimAdresi = ofdResim.FileName.ToString();
            }
        }

        private void txtAdet_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtAdet.Text != null && txtAdet.Text != string.Empty)
            {
                if (txtBirimFiyat.Text != null && txtBirimFiyat.Text != string.Empty)
                {
                    txtToplamFiyat.Text = (Convert.ToDouble(txtAdet.Text) * Convert.ToDouble(txtBirimFiyat.Text)).ToString();

                }

            }
            if (txtAdet.Text == "")
            {
                txtToplamFiyat.Text = txtBirimFiyat.Text;
            }
            if (txtAdet.Text == "" && txtBirimFiyat.Text == "")
            {
                txtToplamFiyat.Text = "0";
            }

        }

        private void txtBirimFiyat_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtBirimFiyat.Text != null && txtBirimFiyat.Text != string.Empty)
            {
                if (txtAdet.Text != null && txtAdet.Text != string.Empty)
                {
                    txtToplamFiyat.Text = (Convert.ToDouble(txtAdet.Text) * Convert.ToDouble(txtBirimFiyat.Text)).ToString();
                }

            }
            if (txtBirimFiyat.Text == "")
            {
                txtToplamFiyat.Text = txtAdet.Text;
            }
            if (txtAdet.Text == "" && txtBirimFiyat.Text == "")
            {
                txtToplamFiyat.Text = "0";
            }
        }

        private void txtToplamFiyat_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtToplamFiyat.Text != null && txtToplamFiyat.Text != string.Empty)
            {
                if (txtBirimFiyat.Text != null && txtBirimFiyat.Text != string.Empty)

                {
                    txtToplamFiyat.Text = (Convert.ToDouble(txtAdet.Text) * Convert.ToDouble(txtBirimFiyat.Text)).ToString();
                }
                else if (txtAdet.Text != null && txtAdet.Text != string.Empty)
                {
                    txtToplamFiyat.Text = (Convert.ToDouble(txtAdet.Text) * Convert.ToDouble(txtBirimFiyat.Text)).ToString();
                }
            }

            if (txtAdet.Text == "" && txtBirimFiyat.Text == "")
            {
                txtToplamFiyat.Text = "0";
            }

        }
    }
}
