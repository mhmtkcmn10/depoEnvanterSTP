namespace depoEnvanterSTP
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnGoruntule = new XanderUI.XUIButton();
            this.btnGuncelle = new XanderUI.XUIButton();
            this.btnSil = new XanderUI.XUIButton();
            this.btnEkle = new XanderUI.XUIButton();
            this.btnListele = new XanderUI.XUISuperButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cbOda = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
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
            this.btnGoruntule.Location = new System.Drawing.Point(390, 81);
            this.btnGoruntule.Name = "btnGoruntule";
            this.btnGoruntule.Size = new System.Drawing.Size(117, 38);
            this.btnGoruntule.TabIndex = 85;
            this.btnGoruntule.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnGoruntule.Vertical_Alignment = System.Drawing.StringAlignment.Center;
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
            this.btnGuncelle.Location = new System.Drawing.Point(267, 81);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(117, 38);
            this.btnGuncelle.TabIndex = 84;
            this.btnGuncelle.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnGuncelle.Vertical_Alignment = System.Drawing.StringAlignment.Center;
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
            this.btnSil.Location = new System.Drawing.Point(144, 81);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(117, 38);
            this.btnSil.TabIndex = 83;
            this.btnSil.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnSil.Vertical_Alignment = System.Drawing.StringAlignment.Center;
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
            this.btnEkle.Location = new System.Drawing.Point(21, 81);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(117, 38);
            this.btnEkle.TabIndex = 82;
            this.btnEkle.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnEkle.Vertical_Alignment = System.Drawing.StringAlignment.Center;
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
            this.btnListele.Location = new System.Drawing.Point(34, 46);
            this.btnListele.Name = "btnListele";
            this.btnListele.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnListele.SelectedTextColor = System.Drawing.Color.White;
            this.btnListele.Size = new System.Drawing.Size(169, 29);
            this.btnListele.SuperSelected = false;
            this.btnListele.TabIndex = 81;
            this.btnListele.TextColor = System.Drawing.Color.White;
            this.btnListele.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 80;
            this.label2.Text = "Oda Adı";
            // 
            // cbOda
            // 
            this.cbOda.FormattingEnabled = true;
            this.cbOda.Location = new System.Drawing.Point(82, 12);
            this.cbOda.Name = "cbOda";
            this.cbOda.Size = new System.Drawing.Size(121, 21);
            this.cbOda.TabIndex = 79;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 502);
            this.Controls.Add(this.btnGoruntule);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbOda);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XanderUI.XUIButton btnGoruntule;
        private XanderUI.XUIButton btnGuncelle;
        private XanderUI.XUIButton btnSil;
        private XanderUI.XUIButton btnEkle;
        private XanderUI.XUISuperButton btnListele;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbOda;
    }
}

