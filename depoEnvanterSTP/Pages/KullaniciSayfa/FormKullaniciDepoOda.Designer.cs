namespace depoEnvanterSTP.Pages.KullaniciSayfa
{
    partial class FormKullaniciDepoOda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKullaniciDepoOda));
            this.dgOda = new System.Windows.Forms.DataGridView();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.btnListele = new XanderUI.XUISuperButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgOda)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgOda
            // 
            this.dgOda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgOda.Location = new System.Drawing.Point(75, 118);
            this.dgOda.Name = "dgOda";
            this.dgOda.Size = new System.Drawing.Size(531, 277);
            this.dgOda.TabIndex = 83;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.lblMesaj);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(75, 395);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(531, 40);
            this.panel7.TabIndex = 82;
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
            // panel6
            // 
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.txtArama);
            this.panel6.Controls.Add(this.btnListele);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(75, 60);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(531, 58);
            this.panel6.TabIndex = 81;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(332, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Arama";
            this.label3.Visible = false;
            // 
            // txtArama
            // 
            this.txtArama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtArama.Location = new System.Drawing.Point(274, 28);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(160, 21);
            this.txtArama.TabIndex = 0;
            this.txtArama.Visible = false;
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
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
            this.btnListele.Location = new System.Drawing.Point(6, 9);
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
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(606, 60);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(75, 375);
            this.panel4.TabIndex = 79;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(75, 375);
            this.panel3.TabIndex = 78;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(681, 40);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(681, 20);
            this.panel2.TabIndex = 9;
            // 
            // FormKullaniciDepoOda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(681, 435);
            this.Controls.Add(this.dgOda);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormKullaniciDepoOda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Depo Oda";
            ((System.ComponentModel.ISupportInitialize)(this.dgOda)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgOda;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblMesaj;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtArama;
        private XanderUI.XUISuperButton btnListele;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}