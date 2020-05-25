namespace depoEnvanterSTP.Pages
{
    partial class FormDepoOda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDepoOda));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOdaAdi = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.btnListele = new XanderUI.XUISuperButton();
            this.btnGuncelle = new XanderUI.XUIButton();
            this.btnSil = new XanderUI.XUIButton();
            this.btnEkle = new XanderUI.XUIButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.dgOda = new System.Windows.Forms.DataGridView();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOda)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(688, 20);
            this.panel2.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(688, 40);
            this.panel1.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(648, 60);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(40, 332);
            this.panel4.TabIndex = 72;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(40, 332);
            this.panel3.TabIndex = 71;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.txtOdaAdi);
            this.panel5.Controls.Add(this.lblId);
            this.panel5.Controls.Add(this.btnListele);
            this.panel5.Controls.Add(this.btnGuncelle);
            this.panel5.Controls.Add(this.btnSil);
            this.panel5.Controls.Add(this.btnEkle);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(40, 60);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(194, 332);
            this.panel5.TabIndex = 74;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(16, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 80;
            this.label2.Text = "Oda Adı";
            // 
            // txtOdaAdi
            // 
            this.txtOdaAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtOdaAdi.Location = new System.Drawing.Point(16, 65);
            this.txtOdaAdi.Name = "txtOdaAdi";
            this.txtOdaAdi.Size = new System.Drawing.Size(167, 21);
            this.txtOdaAdi.TabIndex = 79;
            this.txtOdaAdi.TextChanged += new System.EventHandler(this.txtOdaAdi_TextChanged);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(16, 9);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 13);
            this.lblId.TabIndex = 78;
            this.lblId.Visible = false;
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
            this.btnListele.Location = new System.Drawing.Point(16, 282);
            this.btnListele.Name = "btnListele";
            this.btnListele.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnListele.SelectedTextColor = System.Drawing.Color.White;
            this.btnListele.Size = new System.Drawing.Size(167, 40);
            this.btnListele.SuperSelected = false;
            this.btnListele.TabIndex = 77;
            this.btnListele.TextColor = System.Drawing.Color.White;
            this.btnListele.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
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
            this.btnGuncelle.Location = new System.Drawing.Point(16, 233);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(167, 31);
            this.btnGuncelle.TabIndex = 76;
            this.btnGuncelle.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnGuncelle.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnGuncelle.Visible = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
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
            this.btnSil.Location = new System.Drawing.Point(16, 179);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(167, 31);
            this.btnSil.TabIndex = 75;
            this.btnSil.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnSil.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSil.Visible = false;
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
            this.btnEkle.Location = new System.Drawing.Point(16, 126);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(167, 31);
            this.btnEkle.TabIndex = 74;
            this.btnEkle.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnEkle.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnEkle.Visible = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.txtArama);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(234, 60);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(414, 40);
            this.panel6.TabIndex = 75;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(48, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Arama";
            this.label3.Visible = false;
            // 
            // txtArama
            // 
            this.txtArama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtArama.Location = new System.Drawing.Point(100, 9);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(164, 21);
            this.txtArama.TabIndex = 0;
            this.txtArama.Visible = false;
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.lblMesaj);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(234, 352);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(414, 40);
            this.panel7.TabIndex = 76;
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.ForeColor = System.Drawing.Color.Red;
            this.lblMesaj.Location = new System.Drawing.Point(33, 15);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(0, 13);
            this.lblMesaj.TabIndex = 0;
            this.lblMesaj.Visible = false;
            // 
            // dgOda
            // 
            this.dgOda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgOda.Location = new System.Drawing.Point(234, 100);
            this.dgOda.Name = "dgOda";
            this.dgOda.Size = new System.Drawing.Size(414, 252);
            this.dgOda.TabIndex = 77;
            this.dgOda.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgOda_RowHeaderMouseClick_1);
            // 
            // FormDepoOda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(688, 392);
            this.Controls.Add(this.dgOda);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDepoOda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Depo Oda";
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private XanderUI.XUIButton btnGuncelle;
        private XanderUI.XUIButton btnSil;
        private XanderUI.XUIButton btnEkle;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private XanderUI.XUISuperButton btnListele;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblMesaj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOdaAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.DataGridView dgOda;
    }
}