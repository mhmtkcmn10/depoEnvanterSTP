using depoEnvanterSTP.Database;
using depoEnvanterSTP.Tablolar;
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

namespace depoEnvanterSTP.Pages
{
    public partial class FormUrunTanimlama : Form
    {
        public FormUrunTanimlama()
        {
            InitializeComponent();
            DialogHazirla();
            btnEkle.Visible = false;
        }


        string resimAdresi;
        OpenFileDialog ofdResim = new OpenFileDialog();
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


        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (pbImage.Image == null)
                {
                    MessageBox.Show("Lütfen resim seçiniz ...");
                }
                else
                {

                    FileStream fsResim = new FileStream(resimAdresi, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fsResim);
                    byte[] resim2 = br.ReadBytes((int)fsResim.Length);

                    br.Close();
                    fsResim.Close();

                    if (txtUrunAdi.Text != "" && txtUrunKodu.Text != "" && txtMarka.Text != "" && txtModel.Text != "" && txtAdet.Text != "" && txtBirimFiyat.Text != "")
                    {
                        UrunTanimlama urun = new UrunTanimlama();
                        UrunTanimlamaDB urunDB = new UrunTanimlamaDB();
                        try
                        {

                            urun.OdaId = Convert.ToInt32(cbOdaAdi.SelectedValue.ToString());
                            urun.UrunAdi = txtUrunAdi.Text;
                            urun.UrunKodu = txtUrunKodu.Text;
                            urun.Marka = txtMarka.Text;
                            urun.Model = txtModel.Text;
                            urun.Adet = Convert.ToInt32(txtAdet.Text);
                            urun.BirimFiyat = Convert.ToDouble(txtBirimFiyat.Text);
                            urun.ToplamFiyat = Convert.ToDouble(txtToplamFiyat.Text);
                            urun.Aciklama = txtAciklama.Text;
                            urun.Resim = resim2;
                            urunDB.Ekle(urun);
                            Temizle();
                            lblMesaj.Text = "Kayıt Gerçekleşti";
                            lblMesaj.Visible = true;


                            lblUrunAdi.Visible = false;
                            lblUrunKodu.Visible = false;
                            lblMarka.Visible = false;
                            lblModel.Visible = false;
                            lblAdet.Visible = false;
                            lblBirim.Visible = false;
                            lblToplam.Visible = false;
                            lblOda.Visible = false;

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
                lblMesaj.Visible = true;
                lblMesaj.Text = "HATA :" + hata.Message;
            }
            

        }

        private void FormUrunTanimlama_Load(object sender, EventArgs e)
        {
            Oda oda = new Oda();
            OdaDB odaDB = new OdaDB();

            cbOdaAdi.DataSource = odaDB.Listele(oda);
            cbOdaAdi.DisplayMember = "OdaAdi";
            cbOdaAdi.ValueMember = "Id";
            

        }
        public void Temizle()
        {
            txtUrunAdi.Text = "";
            txtUrunKodu.Text = "";
            txtMarka.Text = "";
            txtModel.Text = "";
            txtAdet.Text = "";
            txtBirimFiyat.Text = "";
            txtToplamFiyat.Text = "";
            txtAciklama.Text = "";
            pbImage.Image = null;
            lblMesaj.Text = "";
            lblMesaj2.Text = "";

        }

        public void TextKontrol()
        {
            if (txtUrunAdi.Text != "" && txtUrunKodu.Text != "" && txtMarka.Text != "" && txtModel.Text != "" && txtAdet.Text != "" && txtBirimFiyat.Text != "")
            {
                btnEkle.Visible = true;
            }
            else
            {
                btnEkle.Visible = false;
            }
        }

        private void txtUrunKodu_TextChanged(object sender, EventArgs e)
        {
            TextKontrol();
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
            TextKontrol();
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
            TextKontrol();
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
            TextKontrol();
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
            TextKontrol();
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
            TextKontrol();
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
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
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
            if (txtBirimFiyat.Text=="")
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

            if (txtAdet.Text=="" && txtBirimFiyat.Text=="")
            {
                txtToplamFiyat.Text = "0";
            }
            
        }

        
    }
}



