namespace depoEnvanterSTP.Pages.KullaniciSayfa
{
    partial class FormKullaniciSifreDegistirme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKullaniciSifreDegistirme));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblSifre = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.txtSifreTekrar = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.btnGuncelle = new XanderUI.XUIButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(255, 20);
            this.panel2.TabIndex = 87;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 40);
            this.panel1.TabIndex = 86;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.lblSifre);
            this.panel5.Controls.Add(this.lblId);
            this.panel5.Controls.Add(this.lblMesaj);
            this.panel5.Controls.Add(this.txtSifreTekrar);
            this.panel5.Controls.Add(this.txtSifre);
            this.panel5.Controls.Add(this.lblSoyad);
            this.panel5.Controls.Add(this.lblAd);
            this.panel5.Controls.Add(this.btnGuncelle);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(40, 60);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(175, 260);
            this.panel5.TabIndex = 91;
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.ForeColor = System.Drawing.Color.Red;
            this.lblSifre.Location = new System.Drawing.Point(14, 145);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(0, 13);
            this.lblSifre.TabIndex = 88;
            this.lblSifre.Visible = false;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(14, 5);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 13);
            this.lblId.TabIndex = 87;
            this.lblId.Visible = false;
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.ForeColor = System.Drawing.Color.Red;
            this.lblMesaj.Location = new System.Drawing.Point(14, 185);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(0, 13);
            this.lblMesaj.TabIndex = 86;
            this.lblMesaj.Visible = false;
            // 
            // txtSifreTekrar
            // 
            this.txtSifreTekrar.Location = new System.Drawing.Point(17, 118);
            this.txtSifreTekrar.MaxLength = 8;
            this.txtSifreTekrar.Name = "txtSifreTekrar";
            this.txtSifreTekrar.Size = new System.Drawing.Size(143, 20);
            this.txtSifreTekrar.TabIndex = 85;
            this.txtSifreTekrar.TextChanged += new System.EventHandler(this.txtSifreTekrar_TextChanged);
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(17, 92);
            this.txtSifre.MaxLength = 8;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(143, 20);
            this.txtSifre.TabIndex = 84;
            this.txtSifre.TextChanged += new System.EventHandler(this.txtSifre_TextChanged);
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(14, 62);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(0, 13);
            this.lblSoyad.TabIndex = 78;
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(14, 34);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(0, 13);
            this.lblAd.TabIndex = 77;
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
            this.btnGuncelle.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnGuncelle.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnGuncelle.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnGuncelle.Location = new System.Drawing.Point(17, 216);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(143, 35);
            this.btnGuncelle.TabIndex = 76;
            this.btnGuncelle.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnGuncelle.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(215, 60);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(40, 260);
            this.panel4.TabIndex = 90;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(40, 260);
            this.panel3.TabIndex = 89;
            // 
            // FormKullaniciSifreDegistirme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(255, 320);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormKullaniciSifreDegistirme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şifre Değiştirme";
            this.Load += new System.EventHandler(this.FormKullaniciSifreDegistirme_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private XanderUI.XUIButton btnGuncelle;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblMesaj;
        private System.Windows.Forms.TextBox txtSifreTekrar;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblSifre;
    }
}