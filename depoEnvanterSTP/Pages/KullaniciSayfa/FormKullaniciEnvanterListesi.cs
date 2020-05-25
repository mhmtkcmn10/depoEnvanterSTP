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

namespace depoEnvanterSTP.Pages.KullaniciSayfa
{
    public partial class FormKullaniciEnvanterListesi : Form
    {
        public FormKullaniciEnvanterListesi()
        {
            InitializeComponent();
            Listele();
        }
        UrunTanimlama urun = new UrunTanimlama();
        UrunTanimlamaDB urunDB = new UrunTanimlamaDB();
        private void FormKullaniciEnvanterListesi_Load(object sender, EventArgs e)
        {
            Oda oda = new Oda();
            OdaDB odaDB = new OdaDB();

            cbOda.DataSource = odaDB.Listele(oda);
            cbOda.DisplayMember = "OdaAdi";
            cbOda.ValueMember = "Id";
        }

        public void Listele()
        {
            dgEnvanter.DataSource = urunDB.Listele(urun);

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            dgEnvanter.DataSource = urunDB.Arama(urun);
            try
            {
                urun.OdaId = Convert.ToInt32(cbOda.SelectedValue.ToString());
                dgEnvanter.DataSource = urunDB.Arama(urun);
            }
            catch (Exception hata)
            {
                MessageBox.Show("HATA :" + hata.Message);
            }
        }

        private void btnGenelListele_Click(object sender, EventArgs e)
        {
            Listele();

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FormUrunTanimlama formUrun = new FormUrunTanimlama();
            formUrun.Show();
        }

        private void btnGoruntule_Click(object sender, EventArgs e)
        {
            try
            {
                UrunBilgiTasima.OdaId = dgEnvanter.SelectedRows[0].Cells["OdaAdi"].Value.ToString();
                UrunBilgiTasima.UrunAdi = dgEnvanter.SelectedRows[0].Cells["UrunAdi"].Value.ToString();
                UrunBilgiTasima.UrunKodu = dgEnvanter.SelectedRows[0].Cells["UrunKodu"].Value.ToString();
                UrunBilgiTasima.Marka = dgEnvanter.SelectedRows[0].Cells["Marka"].Value.ToString();
                UrunBilgiTasima.Model = dgEnvanter.SelectedRows[0].Cells["Model"].Value.ToString();
                UrunBilgiTasima.Adet = Convert.ToInt32(dgEnvanter.SelectedRows[0].Cells["Adet"].Value.ToString());
                UrunBilgiTasima.BirimFiyat = Convert.ToDouble(dgEnvanter.SelectedRows[0].Cells["BirimFiyat"].Value.ToString());
                UrunBilgiTasima.ToplamFiyat = Convert.ToDouble(dgEnvanter.SelectedRows[0].Cells["ToplamFiyat"].Value.ToString());
                UrunBilgiTasima.Aciklama = dgEnvanter.SelectedRows[0].Cells["Aciklama"].Value.ToString();

                MemoryStream ms = new MemoryStream();
                pbImage.Image.Save(ms, pbImage.Image.RawFormat);
                byte[] img = ms.ToArray();

                UrunBilgiTasima.Resim = img;

                FormUrunGoruntule formUrunGoruntule = new FormUrunGoruntule();
                formUrunGoruntule.Show();
            }
            catch (Exception hata)
            {
                MessageBox.Show("hata :" + hata.Message);

            }
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                UrunBilgiTasima.Id = Convert.ToInt32(dgEnvanter.SelectedRows[0].Cells["Id"].Value.ToString());
                UrunBilgiTasima.OdaId = dgEnvanter.SelectedRows[0].Cells["OdaAdi"].Value.ToString();
                UrunBilgiTasima.UrunAdi = dgEnvanter.SelectedRows[0].Cells["UrunAdi"].Value.ToString();
                UrunBilgiTasima.UrunKodu = dgEnvanter.SelectedRows[0].Cells["UrunKodu"].Value.ToString();
                UrunBilgiTasima.Marka = dgEnvanter.SelectedRows[0].Cells["Marka"].Value.ToString();
                UrunBilgiTasima.Model = dgEnvanter.SelectedRows[0].Cells["Model"].Value.ToString();
                UrunBilgiTasima.Adet = Convert.ToInt32(dgEnvanter.SelectedRows[0].Cells["Adet"].Value.ToString());
                UrunBilgiTasima.BirimFiyat = Convert.ToDouble(dgEnvanter.SelectedRows[0].Cells["BirimFiyat"].Value.ToString());
                UrunBilgiTasima.ToplamFiyat = Convert.ToDouble(dgEnvanter.SelectedRows[0].Cells["ToplamFiyat"].Value.ToString());
                UrunBilgiTasima.Aciklama = dgEnvanter.SelectedRows[0].Cells["Aciklama"].Value.ToString();

                MemoryStream ms = new MemoryStream();
                pbImage.Image.Save(ms, pbImage.Image.RawFormat);
                byte[] img = ms.ToArray();

                UrunBilgiTasima.Resim = img;

                FormUrunGuncelle formUrun = new FormUrunGuncelle();
                formUrun.Show();
            }
            catch (Exception hata)
            {
                MessageBox.Show("hata :" + hata.Message);

            }
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            dgEnvanter.DataSource = urunDB.Arama2(urun);
            try
            {
                urun.UrunAdi = txtArama.Text;
                urun.UrunKodu = txtArama.Text;
                urun.Marka = txtArama.Text;
                urun.Model = txtArama.Text;
                dgEnvanter.DataSource = urunDB.Arama2(urun);
            }
            catch (Exception hata)
            {
                MessageBox.Show("HATA :" + hata.Message);
            }
        }

        private void dgEnvanter_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            lblId.Text = dgEnvanter.SelectedRows[0].Cells["Id"].Value.ToString();
            byte[] picture = (byte[])dgEnvanter.CurrentRow.Cells["Resim"].Value;
            MemoryStream ms = new MemoryStream(picture);
            pbImage.Image = Image.FromStream(ms);
        }

        private void dgEnvanter_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            lblId.Text = dgEnvanter.SelectedRows[0].Cells["Id"].Value.ToString();
            byte[] picture = (byte[])dgEnvanter.CurrentRow.Cells["Resim"].Value;
            MemoryStream ms = new MemoryStream(picture);
            pbImage.Image = Image.FromStream(ms);
        }
    }
}
