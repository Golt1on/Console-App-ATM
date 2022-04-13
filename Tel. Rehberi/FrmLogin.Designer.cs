namespace Tel.Rehberi
{
    partial class FrmLogin
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
            this.lbl_giris = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_pw = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.mtxt_pw = new System.Windows.Forms.MaskedTextBox();
            this.btn_giris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_giris
            // 
            this.lbl_giris.AutoSize = true;
            this.lbl_giris.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_giris.Location = new System.Drawing.Point(111, 81);
            this.lbl_giris.Name = "lbl_giris";
            this.lbl_giris.Size = new System.Drawing.Size(212, 32);
            this.lbl_giris.TabIndex = 0;
            this.lbl_giris.Text = "GİRİŞ EKRANI";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(109, 140);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(79, 16);
            this.lbl_id.TabIndex = 1;
            this.lbl_id.Text = "Kullanıcı Adı";
            // 
            // lbl_pw
            // 
            this.lbl_pw.AutoSize = true;
            this.lbl_pw.Location = new System.Drawing.Point(109, 187);
            this.lbl_pw.Name = "lbl_pw";
            this.lbl_pw.Size = new System.Drawing.Size(34, 16);
            this.lbl_pw.TabIndex = 2;
            this.lbl_pw.Text = "Şifre";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(202, 137);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(121, 22);
            this.txt_id.TabIndex = 3;
            // 
            // mtxt_pw
            // 
            this.mtxt_pw.Location = new System.Drawing.Point(202, 183);
            this.mtxt_pw.Name = "mtxt_pw";
            this.mtxt_pw.PasswordChar = '*';
            this.mtxt_pw.Size = new System.Drawing.Size(121, 22);
            this.mtxt_pw.TabIndex = 4;
            // 
            // btn_giris
            // 
            this.btn_giris.Location = new System.Drawing.Point(175, 242);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(96, 40);
            this.btn_giris.TabIndex = 5;
            this.btn_giris.Text = "Giriş Yap";
            this.btn_giris.UseVisualStyleBackColor = true;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(439, 356);
            this.Controls.Add(this.btn_giris);
            this.Controls.Add(this.mtxt_pw);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lbl_pw);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.lbl_giris);
            this.Name = "FrmLogin";
            this.Text = "FrmLogin";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_giris;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_pw;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.MaskedTextBox mtxt_pw;
        private System.Windows.Forms.Button btn_giris;
    }
}

