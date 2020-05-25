using depoEnvanterSTP.Database;
using depoEnvanterSTP.Tablolar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace depoEnvanterSTP.Pages
{
    public partial class FormStokGiris : Form
    {
        public FormStokGiris()
        {
            InitializeComponent();
        }
        StokGiris giris = new StokGiris();
        StokGirisDB girisDB = new StokGirisDB();
        //SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-8F8HA90\SQLEXPRESS; Initial Catalog=iksvDEPOestp;Integrated Security=True");
        SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDBConnectionString"].ConnectionString);

        private void FormStokGiris_Load(object sender, EventArgs e)
        {
            dgStokGiris.ColumnCount = 8;
            dgStokGiris.Columns[0].Name = "BelgeNumarasi";
            dgStokGiris.Columns[1].Name = "Alici";
            dgStokGiris.Columns[2].Name = "GirisTarihi";
            dgStokGiris.Columns[3].Name = "UrunNo";
            dgStokGiris.Columns[4].Name = "GirisAdet";
            dgStokGiris.Columns[5].Name = "CikisAdet";
            dgStokGiris.Columns[6].Name = "ToplamAdet";
            dgStokGiris.Columns[7].Name = "CikisAdet2";




            KullaniciKayit kullanici = new KullaniciKayit();
            KullaniciKayitDB kullaniciDB = new KullaniciKayitDB();

            cbAlici.DataSource = kullaniciDB.ListeleAdminKullanici(kullanici);
            cbAlici.DisplayMember = "AdSoyad";
            cbAlici.ValueMember = "Id";
            

            dgStokCikis.DataSource = girisDB.Listele(giris);


            baglanti.Open();
            for (int i = 0; i < dgStokCikis.Rows.Count - 1; i++)
            {

                int stokcikisadet2 = Convert.ToInt32(dgStokCikis.Rows[i].Cells["CikisAdet2"].Value.ToString());

                if (stokcikisadet2==0)
                {
                    string update = "update tbl_StokUrunCikis set Durum='P' where UrunNo=@UrunNo and CikisAdet2='0'";
                    SqlCommand command = new SqlCommand(update, baglanti);
                    command.Parameters.AddWithValue("@UrunNo", dgStokCikis.Rows[i].Cells["UrunNo"].Value.ToString());
                    command.ExecuteNonQuery();
                }
                else
                {
                    dgStokCikis.DataSource = girisDB.Listele(giris);

                }


            }
            baglanti.Close();
            dgStokCikis.DataSource = girisDB.Listele(giris);
        }
        int veri = 0;
        private void dgStokCikis_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                lblUrunNo.Text = dgStokCikis.SelectedRows[0].Cells[8].Value.ToString();

                txtBelgeNo.Text = dgStokCikis.SelectedRows[0].Cells[1].Value.ToString();
                txtUrunAdet.Text = dgStokCikis.SelectedRows[0].Cells[13].Value.ToString();
                txtUrunAdi.Text = dgStokCikis.SelectedRows[0].Cells[10].Value.ToString();
                txtUrunKodu.Text = dgStokCikis.SelectedRows[0].Cells[11].Value.ToString();

                lblUrunCikisAdet.Text = dgStokCikis.SelectedRows[0].Cells[9].Value.ToString();
                lblToplamAdet.Text = dgStokCikis.SelectedRows[0].Cells[12].Value.ToString();
                lblCikisAdet2.Text = dgStokCikis.SelectedRows[0].Cells[13].Value.ToString();


                veri = Convert.ToInt32(txtUrunAdet.Text);
            }
            catch (Exception hata)
            {
                MessageBox.Show("HATA : "+hata.Message);
            }
        }

        public void UrunEkle()
        {
            if (txtBelgeNo.Text != "" && txtBelgeNo.TextLength == 8  && txtUrunAdet.Text != "" && Convert.ToInt32(txtUrunAdet.Text) <= veri && txtUrunAdet.Text != "0" && lblUrunNo.Text != "" && txtUrunAdi.Text != "" && txtUrunKodu.Text != "")
            {
                btnUrunEkle.Visible = true;
                //dgStokCikis.Visible = true;
            }
            else
            {
                btnUrunEkle.Visible = false;
                //dgStokCikis.Visible = false;
            }
        }


        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            string belgeNo = txtBelgeNo.Text;
            int alici = Convert.ToInt32(cbAlici.SelectedValue);
            string tarih = dtTarih.Value.ToString();

            int urunId = Convert.ToInt32(lblUrunNo.Text);
            int adet = Convert.ToInt32(txtUrunAdet.Text);
            int cikisadet = Convert.ToInt32(lblUrunCikisAdet.Text);

            int toplamadet = Convert.ToInt32(lblToplamAdet.Text);
            int cikisadet2 = Convert.ToInt32(lblCikisAdet2.Text);

            
            dgStokGiris.Rows.Add(belgeNo, alici, tarih, urunId, adet,cikisadet,toplamadet,cikisadet2);

            btnStokGirisİslem.Visible = true;


        }

        private void btnStokGirisİslem_Click(object sender, EventArgs e)
        {
            int cikisAdet;
            int girisAdet;
            int toplamAdet;
            int cikisAdet2;
            baglanti.Open();

            try
            {
                for (int i = 0; i < dgStokGiris.Rows.Count - 1; i++)
                {

                    giris.BelgeNumarasi = dgStokGiris.Rows[i].Cells["BelgeNumarasi"].Value.ToString();
                    giris.Alici = Convert.ToInt32(dgStokGiris.Rows[i].Cells["Alici"].Value.ToString());
                    giris.GirisTarihi = Convert.ToDateTime(dgStokGiris.Rows[i].Cells["GirisTarihi"].Value.ToString());
                    giris.UrunNo = Convert.ToInt32(dgStokGiris.Rows[i].Cells["UrunNo"].Value.ToString());
                    giris.GirisAdet = Convert.ToInt32(dgStokGiris.Rows[i].Cells["GirisAdet"].Value.ToString());


                    cikisAdet = Convert.ToInt32(dgStokGiris.Rows[i].Cells["CikisAdet"].Value.ToString());
                    girisAdet = Convert.ToInt32(dgStokGiris.Rows[i].Cells["GirisAdet"].Value.ToString());
                    toplamAdet = Convert.ToInt32(dgStokGiris.Rows[i].Cells["ToplamAdet"].Value.ToString());
                    cikisAdet2 = Convert.ToInt32(dgStokGiris.Rows[i].Cells["CikisAdet2"].Value.ToString());


                    girisDB.Ekle(giris);

                    if (cikisAdet == girisAdet)
                    {
                        string kayit = "update tbl_StokUrunCikis set Durum='P' where UrunNo=@UrunNo and BelgeNumarasi=@BelgeNumarasi";
                        SqlCommand komut = new SqlCommand(kayit, baglanti);
                        komut.Parameters.AddWithValue("@UrunNo", dgStokGiris.Rows[i].Cells["UrunNo"].Value.ToString());
                        komut.Parameters.AddWithValue("@BelgeNumarasi", dgStokGiris.Rows[i].Cells["BelgeNumarasi"].Value.ToString());

                        komut.ExecuteNonQuery();

                        string kayit2 = "update tbl_StokUrunCikis set CikisAdet2='0' where UrunNo=@UrunNo and BelgeNumarasi=@BelgeNumarasi";
                        SqlCommand komut2 = new SqlCommand(kayit2, baglanti);
                        komut2.Parameters.AddWithValue("@UrunNo", dgStokGiris.Rows[i].Cells["UrunNo"].Value.ToString());
                        komut2.Parameters.AddWithValue("@BelgeNumarasi", dgStokGiris.Rows[i].Cells["BelgeNumarasi"].Value.ToString());

                        komut2.ExecuteNonQuery();

                        SqlCommand comUPDATE = new SqlCommand("UPDATE tbl_UrunTanimlama SET Adet=Adet+@Adet WHERE Id=@UrunNo", baglanti);
                        comUPDATE.Parameters.AddWithValue("@Adet", dgStokGiris.Rows[i].Cells["GirisAdet"].Value.ToString());
                        comUPDATE.Parameters.AddWithValue("@UrunNo", dgStokGiris.Rows[i].Cells["UrunNo"].Value.ToString());

                        comUPDATE.ExecuteNonQuery();

                        SqlCommand comUPDATE2 = new SqlCommand("UPDATE tbl_UrunTanimlama SET ToplamFiyat=BirimFiyat*Adet WHERE Id=@UrunNo", baglanti);
                        comUPDATE2.Parameters.AddWithValue("@UrunNo", dgStokGiris.Rows[i].Cells["UrunNo"].Value.ToString());

                        comUPDATE2.ExecuteNonQuery();

                    }
                    else
                    {
                        string update = "update tbl_StokUrunCikis set Durum='A' where UrunNo=@UrunNo and BelgeNumarasi=@BelgeNumarasi";
                        SqlCommand command = new SqlCommand(update, baglanti);
                        command.Parameters.AddWithValue("@UrunNo", dgStokGiris.Rows[i].Cells["UrunNo"].Value.ToString());
                        command.Parameters.AddWithValue("@BelgeNumarasi", dgStokGiris.Rows[i].Cells["BelgeNumarasi"].Value.ToString());

                        command.ExecuteNonQuery();

                        string update2 = "update tbl_StokUrunCikis set CikisAdet2=CikisAdet2-@GirisAdet where UrunNo=@UrunNo and BelgeNumarasi=@BelgeNumarasi";
                        SqlCommand command2 = new SqlCommand(update2, baglanti);
                        command2.Parameters.AddWithValue("@UrunNo", dgStokGiris.Rows[i].Cells["UrunNo"].Value.ToString());
                        command2.Parameters.AddWithValue("@GirisAdet", dgStokGiris.Rows[i].Cells["GirisAdet"].Value.ToString());
                        command2.Parameters.AddWithValue("@BelgeNumarasi", dgStokGiris.Rows[i].Cells["BelgeNumarasi"].Value.ToString());


                        command2.ExecuteNonQuery();

                        SqlCommand comUPDATE3 = new SqlCommand("UPDATE tbl_UrunTanimlama SET Adet=Adet+@Adet WHERE Id=@UrunNo", baglanti);
                        comUPDATE3.Parameters.AddWithValue("@Adet", dgStokGiris.Rows[i].Cells["GirisAdet"].Value.ToString());
                        comUPDATE3.Parameters.AddWithValue("@UrunNo", dgStokGiris.Rows[i].Cells["UrunNo"].Value.ToString());

                        comUPDATE3.ExecuteNonQuery();

                        SqlCommand comUPDATE4 = new SqlCommand("UPDATE tbl_UrunTanimlama SET ToplamFiyat=BirimFiyat*Adet WHERE Id=@UrunNo", baglanti);
                        comUPDATE4.Parameters.AddWithValue("@UrunNo", dgStokGiris.Rows[i].Cells["UrunNo"].Value.ToString());

                        comUPDATE4.ExecuteNonQuery();
                    }
                }

                for (int i = 0; i < dgStokCikis.Rows.Count - 1; i++)
                {

                    int stokcikisadet2 = Convert.ToInt32(dgStokCikis.Rows[i].Cells["CikisAdet2"].Value.ToString());

                    if (stokcikisadet2 == 0)
                    {
                        string update = "update tbl_StokUrunCikis set Durum='P' where UrunNo=@UrunNo and CikisAdet2='0'";
                        SqlCommand command = new SqlCommand(update, baglanti);
                        command.Parameters.AddWithValue("@UrunNo", dgStokCikis.Rows[i].Cells["UrunNo"].Value.ToString());
                        command.ExecuteNonQuery();
                    }
                    else
                    {
                        dgStokCikis.DataSource = girisDB.Listele(giris);

                    }
                    
                }

                lblMesaj.Visible = true;
                lblMesaj.Text = "Stok Giriş Gerçekleşti";
                btnStokGirisİslem.Visible = false;
                baglanti.Close();

                Temizle();

                dgStokCikis.DataSource = girisDB.Listele(giris);
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata : "+hata.Message);
            }
        }

        public void Temizle()
        {
            txtBelgeNo.Text = "";

            lblUrunNo.Text = "";
            txtUrunKodu.Text = "";
            txtUrunAdi.Text = "";
            txtUrunAdet.Text = "";

            lblUrunCikisAdet.Text = "";
            lblToplamAdet.Text = "";
            dgStokGiris.Rows.Clear();
        }
        private void btnAlanTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void txtUrunAdet_TextChanged(object sender, EventArgs e)
        {
            UrunEkle();
        }
    }
}
