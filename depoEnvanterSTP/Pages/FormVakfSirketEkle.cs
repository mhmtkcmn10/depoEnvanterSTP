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
using depoEnvanterSTP.Tablolar;
using depoEnvanterSTP.Database;
using System.Configuration;

namespace depoEnvanterSTP.Pages
{
    public partial class FormVakfSirketEkle : Form
    {
        public FormVakfSirketEkle()
        {
            InitializeComponent();
        }
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
                                    Sirket sirket = new Sirket();
                                    SirketDB sirketDB = new SirketDB();
                                    sirket.SirketAdi = txtSirketAdi.Text;
                                    sirket.SirketUnvani = txtSirketUnvanı.Text;
                                    sirket.VergiDairesi = txtVergiDairesi.Text;
                                    sirket.VergiNo = txtVergiNo.Text;
                                    sirket.Telefon = txtTelefon.Text;
                                    sirket.Faks = txtFaks.Text;
                                    sirket.Adres = txtAdres.Text;
                                    sirket.Email = txtEmail.Text;

                                    sirketDB.Ekle(sirket);
                                    lblMesaj.Text = "KAYIT GERÇEKLEŞTİ";
                                    lblMesaj.Visible = true;
                                    this.Hide();

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
                lblMesaj.Text = "Hata:" + hata.Message;
                lblMesaj.Visible = true;
            }
        }

        private void txtVergiNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtFaks_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '@' && e.KeyChar != '.' && e.KeyChar != '_';

            if ((int)e.KeyChar == 32)
            {
                e.Handled = true;
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
    }
}
