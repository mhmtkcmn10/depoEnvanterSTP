using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace depoEnvanterSTP.Pages.KullaniciSayfa
{
    public partial class FormKullaniciVakifSirketGoruntule : Form
    {
        public FormKullaniciVakifSirketGoruntule()
        {
            InitializeComponent();
            Load += FormKullaniciVakifSirketGoruntule_Load;
        }

        private void FormKullaniciVakifSirketGoruntule_Load(object sender, EventArgs e)
        {
            txtSirketAdi.Text = "" + Tablolar.SirketGoruntule.SirketAdi;
            txtSirketUnvanı.Text = "" + Tablolar.SirketGoruntule.SirketUnvani;
            txtVergiDairesi.Text = "" + Tablolar.SirketGoruntule.VergiDairesi;
            txtVergiNo.Text = "" + Tablolar.SirketGoruntule.VergiNo;
            txtTelefon.Text = "" + Tablolar.SirketGoruntule.Telefon;
            txtFaks.Text = "" + Tablolar.SirketGoruntule.Faks;
            txtAdres.Text = "" + Tablolar.SirketGoruntule.Adres;
            txtEmail.Text = "" + Tablolar.SirketGoruntule.Email;
        }
    }
}
