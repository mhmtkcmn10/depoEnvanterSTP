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
    public partial class FormKullaniciDepoOda : Form
    {
        
        public FormKullaniciDepoOda()
        {
            InitializeComponent();
        }
        Database.Oda oda = new Database.Oda();
        Database.OdaDB odaDB = new Database.OdaDB();

        private void btnListele_Click(object sender, EventArgs e)
        {

            dgOda.DataSource = odaDB.Listele(oda);

            label3.Visible = true;
            txtArama.Visible = true;
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
    }
}
