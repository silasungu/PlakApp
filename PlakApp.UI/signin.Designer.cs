namespace PlakApp.UI
{
    partial class signin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_UserNameKayit = new System.Windows.Forms.TextBox();
            this.txt_PasswordKayit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_AgainPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Kaydol = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Loginegit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // txt_UserNameKayit
            // 
            this.txt_UserNameKayit.Location = new System.Drawing.Point(66, 92);
            this.txt_UserNameKayit.Name = "txt_UserNameKayit";
            this.txt_UserNameKayit.Size = new System.Drawing.Size(313, 31);
            this.txt_UserNameKayit.TabIndex = 1;
            // 
            // txt_PasswordKayit
            // 
            this.txt_PasswordKayit.Location = new System.Drawing.Point(66, 175);
            this.txt_PasswordKayit.Name = "txt_PasswordKayit";
            this.txt_PasswordKayit.Size = new System.Drawing.Size(313, 31);
            this.txt_PasswordKayit.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre";
            // 
            // txt_AgainPassword
            // 
            this.txt_AgainPassword.Location = new System.Drawing.Point(81, 260);
            this.txt_AgainPassword.Name = "txt_AgainPassword";
            this.txt_AgainPassword.Size = new System.Drawing.Size(313, 31);
            this.txt_AgainPassword.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Şifre Tekrar";
            // 
            // btn_Kaydol
            // 
            this.btn_Kaydol.Location = new System.Drawing.Point(130, 308);
            this.btn_Kaydol.Name = "btn_Kaydol";
            this.btn_Kaydol.Size = new System.Drawing.Size(179, 34);
            this.btn_Kaydol.TabIndex = 6;
            this.btn_Kaydol.Text = "Kayıt Ol";
            this.btn_Kaydol.UseVisualStyleBackColor = true;
            this.btn_Kaydol.Click += new System.EventHandler(this.btn_Kaydol_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(14, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 36);
            this.label4.TabIndex = 7;
            this.label4.Text = "Yeni Yönetici Kayıt";
            // 
            // btn_Loginegit
            // 
            this.btn_Loginegit.Location = new System.Drawing.Point(108, 370);
            this.btn_Loginegit.Name = "btn_Loginegit";
            this.btn_Loginegit.Size = new System.Drawing.Size(238, 34);
            this.btn_Loginegit.TabIndex = 8;
            this.btn_Loginegit.Text = "Kullanıcıya giriş yap";
            this.btn_Loginegit.UseVisualStyleBackColor = true;
            this.btn_Loginegit.Click += new System.EventHandler(this.btn_Loginegit_Click);
            // 
            // signin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 450);
            this.Controls.Add(this.btn_Loginegit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Kaydol);
            this.Controls.Add(this.txt_AgainPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_PasswordKayit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_UserNameKayit);
            this.Controls.Add(this.label1);
            this.Name = "signin";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.signin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txt_UserNameKayit;
        private TextBox txt_PasswordKayit;
        private Label label2;
        private TextBox txt_AgainPassword;
        private Label label3;
        private Button btn_Kaydol;
        private Label label4;
        private Button btn_Loginegit;
    }
}