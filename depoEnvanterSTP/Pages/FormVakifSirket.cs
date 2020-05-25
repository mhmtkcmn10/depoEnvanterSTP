using depoEnvanterSTP.Database;
using depoEnvanterSTP.Tablolar;
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
using System.Text.RegularExpressions;

namespace depoEnvanterSTP.Pages
{
    public partial class FormVakifSirket : Form
    {
        public FormVakifSirket()
        {
            InitializeComponent();
        }
        Sirket sirket = new Sirket();
        SirketDB sirketDB = new SirketDB();
        DialogResult dialog = new DialogResult();
        private const string MatchEmailPattern =
                 @"^(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"
          + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
                                                [0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
          + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
                                                [0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
          + @"([a-zA-Z]+[\w-]+\.)+[a-zA-Z]{2,4})$";

        public static bool TelefonFormatKontrol(string Telefon)
        {
            string RegexDesen = @"^(0(\d{3})(\d{3})(\d{2})(\d{2}))$";
            Match Eslesme = Regex.Match(Telefon, RegexDesen, RegexOptions.IgnoreCase);
            return Eslesme.Success; // bool değer döner
        }
        public static bool FaksFormatKontrol(string Faks)
        {
            string RegexDesen = @"^(0(\d{3})(\d{3})(\d{2})(\d{2}))$";
            Match Eslesme = Regex.Match(Faks, RegexDesen, RegexOptions.IgnoreCase);
            return Eslesme.Success; // bool değer döner
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FormVakfSirketEkle sirketEkle = new FormVakfSirketEkle();
            sirketEkle.Show();
        }

        public void Listele()
        {
            dgVakifSirket.DataSource = sirketDB.Listele(sirket);
        }


        private void btnListele_Click(object sender, EventArgs e)
        {
            Listele();
            txtArama.Visible = true;
            lblArama.Visible = true;
        }
        private void dgVakifSirket_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            lblId.Text = dgVakifSirket.SelectedRows[0].Cells["Id"].Value.ToString();
        }

        private void dgVakifSirket_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            panel5.Visible = true;
            lblId.Text = dgVakifSirket.SelectedRows[0].Cells["Id"].Value.ToString();
            txtSirketAdi.Text = dgVakifSirket.SelectedRows[0].Cells["SirketAdi"].Value.ToString();
            txtSirketUnvanı.Text = dgVakifSirket.SelectedRows[0].Cells["SirketUnvani"].Value.ToString();
            txtVergiDairesi.Text = dgVakifSirket.SelectedRows[0].Cells["VergiDairesi"].Value.ToString();
            txtVergiNo.Text = dgVakifSirket.SelectedRows[0].Cells["VergiNo"].Value.ToString();
            txtTelefon.Text = dgVakifSirket.SelectedRows[0].Cells["Telefon"].Value.ToString();
            txtFaks.Text = dgVakifSirket.SelectedRows[0].Cells["Faks"].Value.ToString();
            txtAdres.Text = dgVakifSirket.SelectedRows[0].Cells["Adres"].Value.ToString();
            txtEmail.Text = dgVakifSirket.SelectedRows[0].Cells["Email"].Value.ToString();

        }
        public void Temizle()
        {
            txtSirketAdi.Text = "";
            txtSirketUnvanı.Text = "";
            txtVergiDairesi.Text = "";
            txtVergiNo.Text = "";
            txtTelefon.Text = "";
            txtFaks.Text = "";
            txtAdres.Text = "";
            txtEmail.Text = "";

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            dgVakifSirket.DataSource = sirketDB.Arama(sirket);
            try
            {
                sirket.SirketAdi = txtArama.Text;
                sirket.SirketUnvani = txtArama.Text;
                sirket.VergiDairesi = txtArama.Text;
                sirket.VergiNo = txtArama.Text;
                sirket.Adres = txtArama.Text;
                sirket.Email = txtArama.Text;

                dgVakifSirket.DataSource = sirketDB.Arama(sirket);
            }
            catch (Exception hata)
            {
                lblMesaj.Visible = true;
                lblMesaj.Text = "Hata. " + hata.Message;
            }
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                sirket.Id = int.Parse(lblId.Text);
                dialog = MessageBox.Show("Veriyi silmeyi onaylıyor musunuz ?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialog == DialogResult.Yes)
                {
                    sirketDB.Sil(sirket);
                    Listele();
                    lblMesaj.Text = "Veri Silindi ...";
                    lblMesaj.Visible = true;
                }
                else
                {
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
                bool retVal = false;
                retVal = Regex.IsMatch(txtEmail.Text, MatchEmailPattern);
                if (txtSirketAdi.Text != "" && txtSirketUnvanı.Text != "" && txtVergiDairesi.Text != "" && txtVergiNo.Text != "" && txtTelefon.Text != ""
                    && txtFaks.Text != "" && txtAdres.Text != "" && txtEmail.Text != "")
                {
                    if (retVal)
                    {
                        if (txtVergiNo.TextLength == 10)
                        {
                            bool TelefonDogruMu = TelefonFormatKontrol(txtTelefon.Text);
                            bool FaksDogruMu = FaksFormatKontrol(txtFaks.Text);
                            if (TelefonDogruMu == true && FaksDogruMu == true)
                            {
                                try
                                {
                                    sirket.Id = int.Parse(lblId.Text);
                                    sirket.SirketAdi = txtSirketAdi.Text;
                                    sirket.SirketUnvani = txtSirketUnvanı.Text;
                                    sirket.VergiDairesi = txtVergiDairesi.Text;
                                    sirket.VergiNo = txtVergiNo.Text;
                                    sirket.Telefon = txtTelefon.Text;
                                    sirket.Faks = txtFaks.Text;
                                    sirket.Adres = txtAdres.Text;
                                    sirket.Email = txtEmail.Text;

                                    sirketDB.Guncelle(sirket);

                                    lblMesaj.Text = "Veri Güncellendi ...";
                                    lblMesaj.Visible = true;
                                    Listele();
                                    Temizle();

                                    lblEmail.Visible = false;
                                    lblTelefon.Visible = false;
                                    lblFaks.Visible = false;
                                    lblVergiNumarasi.Visible = false;
                                    lblTelFaks.Visible = false;
                                    lblMailKontrol.Visible = false;
                                    panel5.Visible = false;
                                }
                                catch (Exception ex)
                                {
                                    lblMesaj.Text = "Kayıtlı veri ... Alanları kontrol ediniz ...";
                                    lblMesaj.Visible = true;
                                    lblVergiNumarasi.Visible = true;
                                }
                            }
                            else
                            {
                                lblTelefon.Visible = true;
                                lblFaks.Visible = true;
                                lblTelFaks.Text = "Seçili alanları kontrol ediniz ...";
                                lblTelFaks.Visible = true;
                            }
                        }
                        else
                        {
                            lblMesaj.Text = "Seçili alanları kontrol ediniz ...";
                            lblMesaj.Visible = true;

                            lblVergiNumarasi.Visible = true;
                        }


                    }
                    else
                    {
                        lblMailKontrol.Visible = true;
                        lblMailKontrol.Text = "E-Mail adresi geçersiz formatta";
                        lblEmail.Visible = true;

                    }
                }
                else
                {
                    lblMesaj.Text = "Alanlar boş geçilemez ...";
                    lblMesaj.Visible = true;

                }
            }
            catch (Exception hata)
            {
                lblMesaj.Text = "Hata: " + hata.Message.ToString();
                lblMesaj.Visible = true;
            }
        }
        

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            bool retVal = false;
            retVal = Regex.IsMatch(txtEmail.Text, MatchEmailPattern);
            if (retVal)
            {
                lblMailKontrol.Visible = false;
                lblEmail.Visible = false;
            }
            else
            {
                lblMailKontrol.Visible = true;
                lblEmail.Visible = true;
            }
        }

        private void txtTelefon_TextChanged(object sender, EventArgs e)
        {
            bool TelefonDogruMu = TelefonFormatKontrol(txtTelefon.Text);
            if (TelefonDogruMu == true)
            {
                lblTelefon.Visible = false;

            }
            else
            {
                lblTelefon.Visible = true;
            }
        }

        private void txtFaks_TextChanged(object sender, EventArgs e)
        {
            bool FaksDogruMu = FaksFormatKontrol(txtFaks.Text);
            if (FaksDogruMu == true)
            {
                lblFaks.Visible = false;
            }
            else
            {
                lblFaks.Visible = true;
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '@' && e.KeyChar != '.' && e.KeyChar != '_';

            if ((int)e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }

        private void txtFaks_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtVergiNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
