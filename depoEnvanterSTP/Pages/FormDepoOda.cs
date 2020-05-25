using depoEnvanterSTP.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace depoEnvanterSTP.Pages
{
    public partial class FormDepoOda : Form
    {
        public FormDepoOda()
        {
            InitializeComponent();
            
        }
        
        DialogResult dialog = new DialogResult();

        Oda oda = new Oda();
        OdaDB odaDB = new OdaDB();
        public void Temizle()
        {
            lblId.Text = "";
            txtOdaAdi.Text = "";

        }

        public void Listele()
        {
            dgOda.DataSource = odaDB.Listele(oda);

            label3.Visible = true;
            txtArama.Visible = true;
            Temizle();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            Listele();

        }
        private void dgOda_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            lblId.Text = dgOda.SelectedRows[0].Cells["Id"].Value.ToString();
            txtOdaAdi.Text = dgOda.SelectedRows[0].Cells["OdaAdi"].Value.ToString();

            btnSil.Visible = true;
            btnGuncelle.Visible = true;
            btnEkle.Visible = false;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                oda.Id = int.Parse(lblId.Text);
                dialog = MessageBox.Show("Veriyi silmeyi onaylıyor musunuz ?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialog == DialogResult.Yes)
                {
                    odaDB.Sil(oda);
                    Listele();
                    Temizle();
                    lblMesaj.Text = "Veri Silindi ...";
                    lblMesaj.Visible = true;
                }
                else
                {
                    Temizle();
                    Listele();
                }

            }
            catch (Exception hata)
            {

                lblMesaj.Text = "Hata: " + hata.Message.ToString();
                lblMesaj.Visible = true;
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtOdaAdi.Text != "")
                {
                    try
                    {
                        oda.Id = int.Parse(lblId.Text);
                        oda.OdaAdi = txtOdaAdi.Text;

                        odaDB.Guncelle(oda);

                        lblMesaj.Text = "Veri Güncellendi ...";
                        lblMesaj.Visible = true;
                        Listele();
                        Temizle();
                    }
                    catch (Exception)
                    {
                        lblMesaj.Text = "Kayıtlı veri mevcuttur ...";
                        lblMesaj.Visible = true;
                        Temizle();

                    }
                }
                else
                {
                    lblMesaj.Text = "Alan Boş Olamaz";
                    lblMesaj.Visible = true;
                }
            }
            catch (Exception hata)
            {
                lblMesaj.Text = "Hata: " + hata.Message.ToString();
                lblMesaj.Visible = true;
            }
        }

        private void txtOdaAdi_TextChanged(object sender, EventArgs e)
        {
            if (txtOdaAdi.Text != "")
            {
                btnEkle.Visible = true;
            }
            else
            {
                btnEkle.Visible = false;
                btnSil.Visible = false;
                btnGuncelle.Visible = false;
            }
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            dgOda.DataSource = odaDB.Listele(oda);
            try
            {
                oda.OdaAdi = txtArama.Text;
                dgOda.DataSource = odaDB.Arama(oda);
            }
            catch (Exception hata)
            {
                lblMesaj.Visible = true;
                lblMesaj.Text = "Hata. " + hata.Message;
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtOdaAdi.Text == "")
                {
                    lblMesaj.Visible = true;
                    lblMesaj.Text = "Gerekli alan boş bırakılamaz ...";
                }
                else
                {
                    try
                    {
                        oda.OdaAdi = txtOdaAdi.Text;
                        odaDB.Ekle(oda);
                        lblMesaj.Text = "KAYIT GERÇEKLEŞTİ";
                        lblMesaj.Visible = true;
                        Listele();
                        Temizle();
                    }
                    catch (Exception)
                    {
                        lblMesaj.Text = "Kayıtlı veri mevcuttur ...";
                        lblMesaj.Visible = true;
                        Temizle();
                    }
                }
            }
            catch (Exception ex)
            {
                lblMesaj.Text = ex.ToString();
                lblMesaj.Visible = true;

                MessageBox.Show(ex.ToString());
            }

        }


    }
}
