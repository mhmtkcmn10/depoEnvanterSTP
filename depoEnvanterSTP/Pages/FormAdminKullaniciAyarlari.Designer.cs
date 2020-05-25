namespace depoEnvanterSTP.Pages
{
    partial class FormAdminKullaniciAyarlari
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdminKullaniciAyarlari));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgKullanici = new System.Windows.Forms.DataGridView();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.lblArama = new System.Windows.Forms.Label();
            this.btnEkle = new XanderUI.XUIButton();
            this.btnListele = new XanderUI.XUISuperButton();
            this.btnSil = new XanderUI.XUIButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblResimYukle = new System.Windows.Forms.Label();
            this.lblTip = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblmailkontrol = new System.Windows.Forms.Label();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.dtTarih = new System.Windows.Forms.DateTimePicker();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbTip = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btnResim = new XanderUI.XUIButton();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGuncelle = new XanderUI.XUIButton();
            this.btnTemizle = new XanderUI.XUIButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgKullanici)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1209, 20);
            this.panel2.TabIndex = 89;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1209, 40);
            this.panel1.TabIndex = 88;
            // 
            // dgKullanici
            // 
            this.dgKullanici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgKullanici.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgKullanici.Location = new System.Drawing.Point(40, 135);
            this.dgKullanici.Name = "dgKullanici";
            this.dgKullanici.Size = new System.Drawing.Size(833, 423);
            this.dgKullanici.TabIndex = 103;
            this.dgKullanici.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgKullanici_CellFormatting);
            this.dgKullanici.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgKullanici_RowHeaderMouseClick);
            this.dgKullanici.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgKullanici_RowHeaderMouseDoubleClick);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.lblMesaj);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(40, 558);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(833, 50);
            this.panel7.TabIndex = 102;
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblMesaj.ForeColor = System.Drawing.Color.Red;
            this.lblMesaj.Location = new System.Drawing.Point(50, 8);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(0, 17);
            this.lblMesaj.TabIndex = 0;
            this.lblMesaj.Visible = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.txtArama);
            this.panel6.Controls.Add(this.lblArama);
            this.panel6.Controls.Add(this.btnEkle);
            this.panel6.Controls.Add(this.btnListele);
            this.panel6.Controls.Add(this.btnSil);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(40, 60);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(833, 75);
            this.panel6.TabIndex = 101;
            // 
            // txtArama
            // 
            this.txtArama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtArama.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtArama.Location = new System.Drawing.Point(524, 43);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(264, 26);
            this.txtArama.TabIndex = 143;
            this.txtArama.Visible = false;
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            // 
            // lblArama
            // 
            this.lblArama.AutoSize = true;
            this.lblArama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblArama.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblArama.Location = new System.Drawing.Point(630, 20);
            this.lblArama.Name = "lblArama";
            this.lblArama.Size = new System.Drawing.Size(56, 20);
            this.lblArama.TabIndex = 142;
            this.lblArama.Text = "Arama";
            this.lblArama.Visible = false;
            // 
            // btnEkle
            // 
            this.btnEkle.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEkle.ButtonImage = global::depoEnvanterSTP.Properties.Resources.plus;
            this.btnEkle.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnEkle.ButtonText = "Ekle";
            this.btnEkle.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnEkle.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnEkle.CornerRadius = 5;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnEkle.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnEkle.HoverBackgroundColor = System.Drawing.Color.SteelBlue;
            this.btnEkle.HoverTextColor = System.Drawing.Color.White;
            this.btnEkle.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnEkle.Location = new System.Drawing.Point(239, 16);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(125, 40);
            this.btnEkle.TabIndex = 141;
            this.btnEkle.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnEkle.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnListele
            // 
            this.btnListele.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(202)))), ((int)(((byte)(142)))));
            this.btnListele.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnListele.ButtonImage")));
            this.btnListele.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btnListele.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btnListele.ButtonText = "Listele";
            this.btnListele.CornerRadius = 5;
            this.btnListele.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnListele.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.btnListele.HoverTextColor = System.Drawing.Color.White;
            this.btnListele.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btnListele.Location = new System.Drawing.Point(6, 16);
            this.btnListele.Name = "btnListele";
            this.btnListele.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnListele.SelectedTextColor = System.Drawing.Color.White;
            this.btnListele.Size = new System.Drawing.Size(183, 40);
            this.btnListele.SuperSelected = false;
            this.btnListele.TabIndex = 123;
            this.btnListele.TextColor = System.Drawing.Color.White;
            this.btnListele.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSil.ButtonImage = global::depoEnvanterSTP.Properties.Resources.quit;
            this.btnSil.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnSil.ButtonText = "Sil";
            this.btnSil.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnSil.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnSil.CornerRadius = 5;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSil.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSil.HoverBackgroundColor = System.Drawing.Color.SteelBlue;
            this.btnSil.HoverTextColor = System.Drawing.Color.White;
            this.btnSil.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnSil.Location = new System.Drawing.Point(370, 16);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(125, 40);
            this.btnSil.TabIndex = 124;
            this.btnSil.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnSil.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.lblResimYukle);
            this.panel5.Controls.Add(this.lblTip);
            this.panel5.Controls.Add(this.lblSifre);
            this.panel5.Controls.Add(this.lblAdres);
            this.panel5.Controls.Add(this.lblSoyad);
            this.panel5.Controls.Add(this.lblAd);
            this.panel5.Controls.Add(this.lblmailkontrol);
            this.panel5.Controls.Add(this.lblKullaniciAdi);
            this.panel5.Controls.Add(this.lblEmail);
            this.panel5.Controls.Add(this.dtTarih);
            this.panel5.Controls.Add(this.txtAdres);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.cbTip);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.pbImage);
            this.panel5.Controls.Add(this.btnResim);
            this.panel5.Controls.Add(this.txtSifre);
            this.panel5.Controls.Add(this.txtId);
            this.panel5.Controls.Add(this.txtKullaniciAdi);
            this.panel5.Controls.Add(this.txtEmail);
            this.panel5.Controls.Add(this.txtSoyad);
            this.panel5.Controls.Add(this.txtAd);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.btnGuncelle);
            this.panel5.Controls.Add(this.btnTemizle);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(873, 60);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(296, 548);
            this.panel5.TabIndex = 100;
            this.panel5.Visible = false;
            // 
            // lblResimYukle
            // 
            this.lblResimYukle.AutoSize = true;
            this.lblResimYukle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblResimYukle.ForeColor = System.Drawing.Color.Red;
            this.lblResimYukle.Location = new System.Drawing.Point(275, 228);
            this.lblResimYukle.Name = "lblResimYukle";
            this.lblResimYukle.Size = new System.Drawing.Size(15, 20);
            this.lblResimYukle.TabIndex = 172;
            this.lblResimYukle.Text = "*";
            this.lblResimYukle.Visible = false;
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTip.ForeColor = System.Drawing.Color.Red;
            this.lblTip.Location = new System.Drawing.Point(276, 192);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(15, 20);
            this.lblTip.TabIndex = 171;
            this.lblTip.Text = "*";
            this.lblTip.Visible = false;
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSifre.ForeColor = System.Drawing.Color.Red;
            this.lblSifre.Location = new System.Drawing.Point(276, 165);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(15, 20);
            this.lblSifre.TabIndex = 170;
            this.lblSifre.Text = "*";
            this.lblSifre.Visible = false;
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAdres.ForeColor = System.Drawing.Color.Red;
            this.lblAdres.Location = new System.Drawing.Point(276, 84);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(15, 20);
            this.lblAdres.TabIndex = 169;
            this.lblAdres.Text = "*";
            this.lblAdres.Visible = false;
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSoyad.ForeColor = System.Drawing.Color.Red;
            this.lblSoyad.Location = new System.Drawing.Point(276, 32);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(15, 20);
            this.lblSoyad.TabIndex = 167;
            this.lblSoyad.Text = "*";
            this.lblSoyad.Visible = false;
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAd.ForeColor = System.Drawing.Color.Red;
            this.lblAd.Location = new System.Drawing.Point(276, 6);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(15, 20);
            this.lblAd.TabIndex = 166;
            this.lblAd.Text = "*";
            this.lblAd.Visible = false;
            // 
            // lblmailkontrol
            // 
            this.lblmailkontrol.AutoSize = true;
            this.lblmailkontrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblmailkontrol.ForeColor = System.Drawing.Color.Red;
            this.lblmailkontrol.Location = new System.Drawing.Point(71, 469);
            this.lblmailkontrol.Name = "lblmailkontrol";
            this.lblmailkontrol.Size = new System.Drawing.Size(0, 15);
            this.lblmailkontrol.TabIndex = 165;
            this.lblmailkontrol.Visible = false;
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblKullaniciAdi.ForeColor = System.Drawing.Color.Red;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(276, 142);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(15, 20);
            this.lblKullaniciAdi.TabIndex = 164;
            this.lblKullaniciAdi.Text = "*";
            this.lblKullaniciAdi.Visible = false;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblEmail.ForeColor = System.Drawing.Color.Red;
            this.lblEmail.Location = new System.Drawing.Point(276, 116);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(15, 20);
            this.lblEmail.TabIndex = 163;
            this.lblEmail.Text = "*";
            this.lblEmail.Visible = false;
            // 
            // dtTarih
            // 
            this.dtTarih.Location = new System.Drawing.Point(74, 58);
            this.dtTarih.Name = "dtTarih";
            this.dtTarih.Size = new System.Drawing.Size(196, 20);
            this.dtTarih.TabIndex = 162;
            // 
            // txtAdres
            // 
            this.txtAdres.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtAdres.Location = new System.Drawing.Point(74, 84);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(196, 20);
            this.txtAdres.TabIndex = 161;
            this.txtAdres.TextChanged += new System.EventHandler(this.txtAdres_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(6, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 160;
            this.label9.Text = "Adres";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(6, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 158;
            this.label8.Text = "Tarih";
            // 
            // cbTip
            // 
            this.cbTip.ForeColor = System.Drawing.Color.SteelBlue;
            this.cbTip.FormattingEnabled = true;
            this.cbTip.Items.AddRange(new object[] {
            "Yönetici",
            "Kullanıcı",
            "Eleman"});
            this.cbTip.Location = new System.Drawing.Point(74, 191);
            this.cbTip.Name = "cbTip";
            this.cbTip.Size = new System.Drawing.Size(196, 21);
            this.cbTip.TabIndex = 157;
            this.cbTip.TextChanged += new System.EventHandler(this.cbTip_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(6, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 13);
            this.label7.TabIndex = 156;
            this.label7.Text = "Tip";
            // 
            // pbImage
            // 
            this.pbImage.BackColor = System.Drawing.Color.White;
            this.pbImage.Location = new System.Drawing.Point(74, 254);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(196, 203);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 155;
            this.pbImage.TabStop = false;
            // 
            // btnResim
            // 
            this.btnResim.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnResim.ButtonImage = global::depoEnvanterSTP.Properties.Resources.plus;
            this.btnResim.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnResim.ButtonText = "Resim Yükle";
            this.btnResim.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnResim.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnResim.CornerRadius = 5;
            this.btnResim.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnResim.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnResim.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnResim.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnResim.Location = new System.Drawing.Point(74, 218);
            this.btnResim.Name = "btnResim";
            this.btnResim.Size = new System.Drawing.Size(191, 30);
            this.btnResim.TabIndex = 154;
            this.btnResim.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnResim.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnResim.Click += new System.EventHandler(this.btnResim_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtSifre.Location = new System.Drawing.Point(74, 165);
            this.txtSifre.MaxLength = 8;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(196, 20);
            this.txtSifre.TabIndex = 153;
            this.txtSifre.TextChanged += new System.EventHandler(this.txtSifre_TextChanged);
            this.txtSifre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSifre_KeyPress);
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtId.Location = new System.Drawing.Point(6, 218);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(10, 21);
            this.txtId.TabIndex = 142;
            this.txtId.Visible = false;
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtKullaniciAdi.Location = new System.Drawing.Point(74, 139);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(196, 20);
            this.txtKullaniciAdi.TabIndex = 152;
            this.txtKullaniciAdi.TextChanged += new System.EventHandler(this.txtKullaniciAdi_TextChanged);
            this.txtKullaniciAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKullaniciAdi_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtEmail.Location = new System.Drawing.Point(74, 113);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(196, 20);
            this.txtEmail.TabIndex = 151;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            // 
            // txtSoyad
            // 
            this.txtSoyad.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtSoyad.Location = new System.Drawing.Point(74, 32);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(196, 20);
            this.txtSoyad.TabIndex = 150;
            this.txtSoyad.TextChanged += new System.EventHandler(this.txtSoyad_TextChanged);
            this.txtSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoyad_KeyPress);
            // 
            // txtAd
            // 
            this.txtAd.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtAd.Location = new System.Drawing.Point(74, 6);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(196, 20);
            this.txtAd.TabIndex = 149;
            this.txtAd.TextChanged += new System.EventHandler(this.txtAd_TextChanged);
            this.txtAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAd_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(5, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 148;
            this.label6.Text = "Şifre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(5, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 147;
            this.label5.Text = "Kullanıcı Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 146;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 145;
            this.label3.Text = "Soyad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(5, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 144;
            this.label2.Text = "Ad";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnGuncelle.ButtonImage = global::depoEnvanterSTP.Properties.Resources.refresh;
            this.btnGuncelle.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnGuncelle.ButtonText = "Güncelle";
            this.btnGuncelle.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnGuncelle.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnGuncelle.CornerRadius = 5;
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnGuncelle.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnGuncelle.HoverBackgroundColor = System.Drawing.Color.SteelBlue;
            this.btnGuncelle.HoverTextColor = System.Drawing.Color.White;
            this.btnGuncelle.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnGuncelle.Location = new System.Drawing.Point(9, 496);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(184, 40);
            this.btnGuncelle.TabIndex = 143;
            this.btnGuncelle.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnGuncelle.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnTemizle.ButtonImage = global::depoEnvanterSTP.Properties.Resources.delete;
            this.btnTemizle.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnTemizle.ButtonText = "Alan Temizle";
            this.btnTemizle.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnTemizle.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnTemizle.CornerRadius = 5;
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnTemizle.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnTemizle.HoverBackgroundColor = System.Drawing.Color.SteelBlue;
            this.btnTemizle.HoverTextColor = System.Drawing.Color.White;
            this.btnTemizle.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnTemizle.Location = new System.Drawing.Point(193, 497);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(97, 40);
            this.btnTemizle.TabIndex = 125;
            this.btnTemizle.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnTemizle.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1169, 60);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(40, 548);
            this.panel4.TabIndex = 99;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(40, 548);
            this.panel3.TabIndex = 98;
            // 
            // FormAdminKullaniciAyarlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1209, 608);
            this.Controls.Add(this.dgKullanici);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAdminKullaniciAyarlari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Ayarları";
            this.Load += new System.EventHandler(this.FormAdminKullaniciAyarlari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgKullanici)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgKullanici;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblMesaj;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.Label lblArama;
        private XanderUI.XUIButton btnEkle;
        private XanderUI.XUISuperButton btnListele;
        private XanderUI.XUIButton btnSil;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox cbTip;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pbImage;
        private XanderUI.XUIButton btnResim;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private XanderUI.XUIButton btnGuncelle;
        private XanderUI.XUIButton btnTemizle;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dtTarih;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblmailkontrol;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.Label lblResimYukle;
    }
}