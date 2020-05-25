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

namespace depoEnvanterSTP.Pages.KullaniciSayfa
{
    public partial class FormKullaniciVakifSirket : Form
    {
        public FormKullaniciVakifSirket()
        {
            InitializeComponent();
        }
        Sirket sirket = new Sirket();
        SirketDB sirketDB = new SirketDB();
        public void Listele()
        {
            dgVakıfSirket.DataSource = sirketDB.Listele(sirket);
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            Listele();
            txtArama.Visible = true;
            lblArama.Visible = true;
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            dgVakıfSirket.DataSource = sirketDB.Arama(sirket);
            try
            {
                sirket.SirketAdi = txtArama.Text;
                sirket.SirketUnvani = txtArama.Text;
                sirket.VergiDairesi = txtArama.Text;
                sirket.VergiNo = txtArama.Text;
                sirket.Adres = txtArama.Text;
                sirket.Email = txtArama.Text;

                dgVakıfSirket.DataSource = sirketDB.Arama(sirket);
            }
            catch (Exception hata)
            {
                lblMesaj.Visible = true;
                lblMesaj.Text = "Hata. " + hata.Message;
            }
        }

        private void dgVakıfSirket_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SirketGoruntule.SirketAdi = dgVakıfSirket.SelectedRows[0].Cells["SirketAdi"].Value.ToString();
            SirketGoruntule.SirketUnvani = dgVakıfSirket.SelectedRows[0].Cells["SirketUnvani"].Value.ToString();
            SirketGoruntule.VergiDairesi = dgVakıfSirket.SelectedRows[0].Cells["VergiDairesi"].Value.ToString();
            SirketGoruntule.VergiNo = dgVakıfSirket.SelectedRows[0].Cells["VergiNo"].Value.ToString();
            SirketGoruntule.Telefon = dgVakıfSirket.SelectedRows[0].Cells["Telefon"].Value.ToString();
            SirketGoruntule.Faks = dgVakıfSirket.SelectedRows[0].Cells["Faks"].Value.ToString();
            SirketGoruntule.Adres = dgVakıfSirket.SelectedRows[0].Cells["Adres"].Value.ToString();
            SirketGoruntule.Email = dgVakıfSirket.SelectedRows[0].Cells["Email"].Value.ToString();
            FormKullaniciVakifSirketGoruntule goruntule = new FormKullaniciVakifSirketGoruntule();
            goruntule.Show();
            

        }
    }
}
