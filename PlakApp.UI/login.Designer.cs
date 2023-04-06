namespace PlakApp.UI
{
    partial class login
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_giris = new System.Windows.Forms.Button();
            this.btn_YeniKayit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // txt_Username
            // 
            this.txt_Username.Location = new System.Drawing.Point(111, 106);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(324, 31);
            this.txt_Username.TabIndex = 1;
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(111, 196);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(324, 31);
            this.txt_Password.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre";
            // 
            // btn_giris
            // 
            this.btn_giris.Location = new System.Drawing.Point(177, 262);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(165, 47);
            this.btn_giris.TabIndex = 4;
            this.btn_giris.Text = "Giriş Yap";
            this.btn_giris.UseVisualStyleBackColor = true;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // btn_YeniKayit
            // 
            this.btn_YeniKayit.Location = new System.Drawing.Point(161, 348);
            this.btn_YeniKayit.Name = "btn_YeniKayit";
            this.btn_YeniKayit.Size = new System.Drawing.Size(220, 40);
            this.btn_YeniKayit.TabIndex = 5;
            this.btn_YeniKayit.Text = "Yeni Kayıt Oluştur";
            this.btn_YeniKayit.UseVisualStyleBackColor = true;
            this.btn_YeniKayit.Click += new System.EventHandler(this.btn_YeniKayit_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 489);
            this.Controls.Add(this.btn_YeniKayit);
            this.Controls.Add(this.btn_giris);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.label1);
            this.Name = "login";
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txt_Username;
        private TextBox txt_Password;
        private Label label2;
        private Button btn_giris;
        private Button btn_YeniKayit;
    }
}