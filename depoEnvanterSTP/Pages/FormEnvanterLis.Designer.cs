namespace depoEnvanterSTP.Pages
{
    partial class FormEnvanterLis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEnvanterLis));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.lblMesaj2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgEnvanter = new System.Windows.Forms.DataGridView();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnExcel = new XanderUI.XUIButton();
            this.btnGüncelle = new XanderUI.XUIButton();
            this.btnGoruntule = new XanderUI.XUIButton();
            this.lblArama = new System.Windows.Forms.Label();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.btnGenelListele = new XanderUI.XUISuperButton();
            this.btnSil = new XanderUI.XUIButton();
            this.btnEkle = new XanderUI.XUIButton();
            this.btnListele = new XanderUI.XUISuperButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cbOda = new System.Windows.Forms.ComboBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblId = new System.Windows.Forms.Label();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEnvanter)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1079, 20);
            this.panel2.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1079, 40);
            this.panel1.TabIndex = 8;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.lblMesaj);
            this.panel7.Controls.Add(this.lblMesaj2);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(25, 583);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1029, 40);
            this.panel7.TabIndex = 79;
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.ForeColor = System.Drawing.Color.Red;
            this.lblMesaj.Location = new System.Drawing.Point(111, 18);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(0, 13);
            this.lblMesaj.TabIndex = 141;
            this.lblMesaj.Visible = false;
            // 
            // lblMesaj2
            // 
            this.lblMesaj2.AutoSize = true;
            this.lblMesaj2.ForeColor = System.Drawing.Color.Red;
            this.lblMesaj2.Location = new System.Drawing.Point(654, 18);
            this.lblMesaj2.Name = "lblMesaj2";
            this.lblMesaj2.Size = new System.Drawing.Size(0, 13);
            this.lblMesaj2.TabIndex = 140;
            this.lblMesaj2.Visible = false;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1054, 60);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(25, 563);
            this.panel4.TabIndex = 78;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(25, 563);
            this.panel3.TabIndex = 77;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgEnvanter);
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(25, 60);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1029, 523);
            this.panel5.TabIndex = 80;
            // 
            // dgEnvanter
            // 
            this.dgEnvanter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEnvanter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgEnvanter.Location = new System.Drawing.Point(0, 97);
            this.dgEnvanter.Name = "dgEnvanter";
            this.dgEnvanter.Size = new System.Drawing.Size(1019, 426);
            this.dgEnvanter.TabIndex = 89;
            this.dgEnvanter.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgEnvanter_RowHeaderMouseClick);
            this.dgEnvanter.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgEnvanter_RowHeaderMouseDoubleClick);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnExcel);
            this.panel8.Controls.Add(this.btnGüncelle);
            this.panel8.Controls.Add(this.btnGoruntule);
            this.panel8.Controls.Add(this.lblArama);
            this.panel8.Controls.Add(this.txtArama);
            this.panel8.Controls.Add(this.btnGenelListele);
            this.panel8.Controls.Add(this.btnSil);
            this.panel8.Controls.Add(this.btnEkle);
            this.panel8.Controls.Add(this.btnListele);
            this.panel8.Controls.Add(this.label2);
            this.panel8.Controls.Add(this.cbOda);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1019, 97);
            this.panel8.TabIndex = 88;
            // 
            // btnExcel
            // 
            this.btnExcel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnExcel.ButtonImage = global::depoEnvanterSTP.Properties.Resources.technology;
            this.btnExcel.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnExcel.ButtonText = "Excel Yazdır";
            this.btnExcel.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnExcel.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnExcel.CornerRadius = 5;
            this.btnExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnExcel.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnExcel.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnExcel.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnExcel.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnExcel.Location = new System.Drawing.Point(203, 53);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(136, 38);
            this.btnExcel.TabIndex = 144;
            this.btnExcel.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnExcel.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnGüncelle.ButtonImage = global::depoEnvanterSTP.Properties.Resources.refresh;
            this.btnGüncelle.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnGüncelle.ButtonText = "Güncelle";
            this.btnGüncelle.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnGüncelle.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnGüncelle.CornerRadius = 5;
            this.btnGüncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnGüncelle.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnGüncelle.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnGüncelle.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnGüncelle.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnGüncelle.Location = new System.Drawing.Point(572, 53);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(104, 38);
            this.btnGüncelle.TabIndex = 143;
            this.btnGüncelle.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnGüncelle.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // btnGoruntule
            // 
            this.btnGoruntule.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnGoruntule.ButtonImage = global::depoEnvanterSTP.Properties.Resources.information;
            this.btnGoruntule.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnGoruntule.ButtonText = "Görüntüle";
            this.btnGoruntule.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnGoruntule.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnGoruntule.CornerRadius = 5;
            this.btnGoruntule.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnGoruntule.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnGoruntule.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnGoruntule.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnGoruntule.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnGoruntule.Location = new System.Drawing.Point(407, 53);
            this.btnGoruntule.Name = "btnGoruntule";
            this.btnGoruntule.Size = new System.Drawing.Size(104, 38);
            this.btnGoruntule.TabIndex = 142;
            this.btnGoruntule.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnGoruntule.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnGoruntule.Click += new System.EventHandler(this.btnGoruntule_Click);
            // 
            // lblArama
            // 
            this.lblArama.AutoSize = true;
            this.lblArama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblArama.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblArama.Location = new System.Drawing.Point(826, 22);
            this.lblArama.Name = "lblArama";
            this.lblArama.Size = new System.Drawing.Size(49, 17);
            this.lblArama.TabIndex = 140;
            this.lblArama.Text = "Arama";
            // 
            // txtArama
            // 
            this.txtArama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtArama.Location = new System.Drawing.Point(727, 49);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(250, 23);
            this.txtArama.TabIndex = 139;
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            // 
            // btnGenelListele
            // 
            this.btnGenelListele.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(202)))), ((int)(((byte)(142)))));
            this.btnGenelListele.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnGenelListele.ButtonImage")));
            this.btnGenelListele.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btnGenelListele.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btnGenelListele.ButtonText = "Genel Listele";
            this.btnGenelListele.CornerRadius = 5;
            this.btnGenelListele.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnGenelListele.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.btnGenelListele.HoverTextColor = System.Drawing.Color.White;
            this.btnGenelListele.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btnGenelListele.Location = new System.Drawing.Point(203, 9);
            this.btnGenelListele.Name = "btnGenelListele";
            this.btnGenelListele.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnGenelListele.SelectedTextColor = System.Drawing.Color.White;
            this.btnGenelListele.Size = new System.Drawing.Size(136, 38);
            this.btnGenelListele.SuperSelected = false;
            this.btnGenelListele.TabIndex = 138;
            this.btnGenelListele.TextColor = System.Drawing.Color.White;
            this.btnGenelListele.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnGenelListele.Click += new System.EventHandler(this.btnGenelListele_Click);
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
            this.btnSil.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnSil.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnSil.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnSil.Location = new System.Drawing.Point(572, 9);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(104, 38);
            this.btnSil.TabIndex = 136;
            this.btnSil.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnSil.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
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
            this.btnEkle.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnEkle.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnEkle.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnEkle.Location = new System.Drawing.Point(407, 9);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(104, 38);
            this.btnEkle.TabIndex = 135;
            this.btnEkle.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnEkle.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnListele
            // 
            this.btnListele.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.btnListele.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnListele.ButtonImage")));
            this.btnListele.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btnListele.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btnListele.ButtonText = "Listele";
            this.btnListele.CornerRadius = 5;
            this.btnListele.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnListele.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.btnListele.HoverTextColor = System.Drawing.Color.White;
            this.btnListele.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btnListele.Location = new System.Drawing.Point(6, 53);
            this.btnListele.Name = "btnListele";
            this.btnListele.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnListele.SelectedTextColor = System.Drawing.Color.White;
            this.btnListele.Size = new System.Drawing.Size(169, 28);
            this.btnListele.SuperSelected = false;
            this.btnListele.TabIndex = 134;
            this.btnListele.TextColor = System.Drawing.Color.White;
            this.btnListele.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 133;
            this.label2.Text = "Oda Adı";
            // 
            // cbOda
            // 
            this.cbOda.BackColor = System.Drawing.Color.White;
            this.cbOda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOda.FormattingEnabled = true;
            this.cbOda.Location = new System.Drawing.Point(6, 22);
            this.cbOda.Name = "cbOda";
            this.cbOda.Size = new System.Drawing.Size(169, 21);
            this.cbOda.TabIndex = 132;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lblId);
            this.panel6.Controls.Add(this.pbImage);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(1019, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 523);
            this.panel6.TabIndex = 87;
            this.panel6.Visible = false;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(241, 9);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 13);
            this.lblId.TabIndex = 139;
            this.lblId.Visible = false;
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(244, 34);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(37, 38);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 110;
            this.pbImage.TabStop = false;
            // 
            // FormEnvanterLis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1079, 623);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEnvanterLis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Envanter Listesi";
            this.Load += new System.EventHandler(this.FormEnvanterLis_Load);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgEnvanter)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dgEnvanter;
        private System.Windows.Forms.Panel panel8;
        private XanderUI.XUISuperButton btnGenelListele;
        private XanderUI.XUIButton btnSil;
        private XanderUI.XUIButton btnEkle;
        private XanderUI.XUISuperButton btnListele;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbOda;
        private System.Windows.Forms.Label lblArama;
        private System.Windows.Forms.TextBox txtArama;
        private XanderUI.XUIButton btnGoruntule;
        private XanderUI.XUIButton btnGüncelle;
        private System.Windows.Forms.Label lblMesaj2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Label lblMesaj;
        private XanderUI.XUIButton btnExcel;
    }
}