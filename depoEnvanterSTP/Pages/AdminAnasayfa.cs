using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace depoEnvanterSTP.Pages
{
    public partial class AdminAnasayfa : Form
    {
        public AdminAnasayfa()
        {
            InitializeComponent();
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            FormUrunTanimlama formUrunTanimlama = new FormUrunTanimlama();
            formUrunTanimlama.Show();
        }

        private void btnEnvanterLis_Click(object sender, EventArgs e)
        {
            FormEnvanterLis formEnvanterLis = new FormEnvanterLis();
            formEnvanterLis.Show();
        }

        private void btnStokGiris_Click(object sender, EventArgs e)
        {
            FormStokGiris formStokGiris = new FormStokGiris();
            formStokGiris.Show();
        }

        private void btnStokCikis_Click(object sender, EventArgs e)
        {
            FormStokCikis formStokCikis = new FormStokCikis();
            formStokCikis.Show();
        }

        private void btnStokHar_Click(object sender, EventArgs e)
        {
            FormStokHar formStokHar = new FormStokHar();
            formStokHar.Show();
        }

        private void btnDepoOda_Click(object sender, EventArgs e)
        {
            FormDepoOda formDepoOda = new FormDepoOda();
            formDepoOda.Show();
        }

        private void btnVakifAyar_Click(object sender, EventArgs e)
        {
            FormVakifSirket formVakifSirket = new FormVakifSirket();
            formVakifSirket.Show();
        }

        private void btnKullanici_Click(object sender, EventArgs e)
        {
            FormAdminKullaniciAyarlari formAdminKullanici = new FormAdminKullaniciAyarlari();
            formAdminKullanici.Show();
        }

        private void AdminAnasayfa_Load(object sender, EventArgs e)
        {

        }
    }
}
