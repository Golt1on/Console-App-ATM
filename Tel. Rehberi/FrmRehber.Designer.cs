namespace Tel.Rehberi
{
    partial class FrmRehber
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
            this.dtg_rehber = new System.Windows.Forms.DataGridView();
            this.txt_telno = new System.Windows.Forms.TextBox();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.txt_sira = new System.Windows.Forms.TextBox();
            this.lbl_tel = new System.Windows.Forms.Label();
            this.lbl_soyad = new System.Windows.Forms.Label();
            this.lbl_ad = new System.Windows.Forms.Label();
            this.lbl_sira = new System.Windows.Forms.Label();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.lbl_merhaba = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_rehber)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_rehber
            // 
            this.dtg_rehber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_rehber.Location = new System.Drawing.Point(395, 12);
            this.dtg_rehber.Name = "dtg_rehber";
            this.dtg_rehber.RowHeadersWidth = 51;
            this.dtg_rehber.RowTemplate.Height = 24;
            this.dtg_rehber.Size = new System.Drawing.Size(599, 426);
            this.dtg_rehber.TabIndex = 0;
            this.dtg_rehber.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_rehber_CellContentClick);
            // 
            // txt_telno
            // 
            this.txt_telno.Location = new System.Drawing.Point(163, 204);
            this.txt_telno.Name = "txt_telno";
            this.txt_telno.Size = new System.Drawing.Size(154, 22);
            this.txt_telno.TabIndex = 19;
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(163, 176);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(154, 22);
            this.txt_soyad.TabIndex = 18;
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(163, 148);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(154, 22);
            this.txt_ad.TabIndex = 17;
            // 
            // txt_sira
            // 
            this.txt_sira.Location = new System.Drawing.Point(163, 120);
            this.txt_sira.Name = "txt_sira";
            this.txt_sira.Size = new System.Drawing.Size(154, 22);
            this.txt_sira.TabIndex = 16;
            // 
            // lbl_tel
            // 
            this.lbl_tel.AutoSize = true;
            this.lbl_tel.Location = new System.Drawing.Point(71, 207);
            this.lbl_tel.Name = "lbl_tel";
            this.lbl_tel.Size = new System.Drawing.Size(54, 16);
            this.lbl_tel.TabIndex = 15;
            this.lbl_tel.Text = "Tel. No.";
            // 
            // lbl_soyad
            // 
            this.lbl_soyad.AutoSize = true;
            this.lbl_soyad.Location = new System.Drawing.Point(70, 179);
            this.lbl_soyad.Name = "lbl_soyad";
            this.lbl_soyad.Size = new System.Drawing.Size(55, 16);
            this.lbl_soyad.TabIndex = 14;
            this.lbl_soyad.Text = "Soyisim";
            // 
            // lbl_ad
            // 
            this.lbl_ad.AutoSize = true;
            this.lbl_ad.Location = new System.Drawing.Point(72, 151);
            this.lbl_ad.Name = "lbl_ad";
            this.lbl_ad.Size = new System.Drawing.Size(31, 16);
            this.lbl_ad.TabIndex = 13;
            this.lbl_ad.Text = "İsim";
            // 
            // lbl_sira
            // 
            this.lbl_sira.AutoSize = true;
            this.lbl_sira.Location = new System.Drawing.Point(73, 123);
            this.lbl_sira.Name = "lbl_sira";
            this.lbl_sira.Size = new System.Drawing.Size(52, 16);
            this.lbl_sira.TabIndex = 12;
            this.lbl_sira.Text = "Sıra No";
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(146, 346);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(103, 49);
            this.btn_sil.TabIndex = 22;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(214, 263);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(103, 49);
            this.btn_guncelle.TabIndex = 21;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(76, 263);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(103, 49);
            this.btn_ekle.TabIndex = 20;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // lbl_merhaba
            // 
            this.lbl_merhaba.AutoSize = true;
            this.lbl_merhaba.Location = new System.Drawing.Point(160, 32);
            this.lbl_merhaba.Name = "lbl_merhaba";
            this.lbl_merhaba.Size = new System.Drawing.Size(61, 16);
            this.lbl_merhaba.TabIndex = 23;
            this.lbl_merhaba.Text = "Merhaba";
            // 
            // FrmRehber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1006, 450);
            this.Controls.Add(this.lbl_merhaba);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.txt_telno);
            this.Controls.Add(this.txt_soyad);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.txt_sira);
            this.Controls.Add(this.lbl_tel);
            this.Controls.Add(this.lbl_soyad);
            this.Controls.Add(this.lbl_ad);
            this.Controls.Add(this.lbl_sira);
            this.Controls.Add(this.dtg_rehber);
            this.Name = "FrmRehber";
            this.Text = "FrmRehber";
            this.Load += new System.EventHandler(this.FrmRehber_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_rehber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_rehber;
        private System.Windows.Forms.TextBox txt_telno;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.TextBox txt_sira;
        private System.Windows.Forms.Label lbl_tel;
        private System.Windows.Forms.Label lbl_soyad;
        private System.Windows.Forms.Label lbl_ad;
        private System.Windows.Forms.Label lbl_sira;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Label lbl_merhaba;
    }
}