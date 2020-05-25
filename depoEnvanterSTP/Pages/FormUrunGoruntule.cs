using depoEnvanterSTP.Database;
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
    public partial class FormUrunGoruntule : Form
    {
        public FormUrunGoruntule()
        {
            InitializeComponent();
            Load += FormUrunGoruntule_Load;
        }

        private void FormUrunGoruntule_Load(object sender, EventArgs e)
        {
            Oda oda = new Oda();
            OdaDB odaDB = new OdaDB();

            cbOdaAdi.DataSource = odaDB.Listele(oda);
            cbOdaAdi.DisplayMember = "OdaAdi";
            cbOdaAdi.ValueMember = "Id";


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
    }
}
