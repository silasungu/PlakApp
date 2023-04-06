namespace PlakApp.UI
{
    partial class Main
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
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.btn_DuranAlbum = new System.Windows.Forms.Button();
            this.btn_SatıstaAlbum = new System.Windows.Forms.Button();
            this.btn_indirimli = new System.Windows.Forms.Button();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Singer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Discount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtp_AlbumDate = new System.Windows.Forms.DateTimePicker();
            this.cb_bitti = new System.Windows.Forms.CheckBox();
            this.btn_Listele = new System.Windows.Forms.Button();
            this.dgw_Listele = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Listele)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Albüm Adı";
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.Location = new System.Drawing.Point(43, 497);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(231, 36);
            this.btn_Ekle.TabIndex = 2;
            this.btn_Ekle.Text = "Ekle";
            this.btn_Ekle.UseVisualStyleBackColor = true;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // btn_Sil
            // 
            this.btn_Sil.Location = new System.Drawing.Point(43, 549);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(231, 36);
            this.btn_Sil.TabIndex = 3;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.UseVisualStyleBackColor = true;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.Location = new System.Drawing.Point(43, 600);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(231, 36);
            this.btn_Guncelle.TabIndex = 4;
            this.btn_Guncelle.Text = "Güncelle";
            this.btn_Guncelle.UseVisualStyleBackColor = true;
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click);
            // 
            // btn_DuranAlbum
            // 
            this.btn_DuranAlbum.Location = new System.Drawing.Point(889, 99);
            this.btn_DuranAlbum.Name = "btn_DuranAlbum";
            this.btn_DuranAlbum.Size = new System.Drawing.Size(295, 48);
            this.btn_DuranAlbum.TabIndex = 6;
            this.btn_DuranAlbum.Text = "Satışı Duran Albümler";
            this.btn_DuranAlbum.UseVisualStyleBackColor = true;
            this.btn_DuranAlbum.Click += new System.EventHandler(this.btn_DuranAlbum_Click);
            // 
            // btn_SatıstaAlbum
            // 
            this.btn_SatıstaAlbum.Location = new System.Drawing.Point(892, 172);
            this.btn_SatıstaAlbum.Name = "btn_SatıstaAlbum";
            this.btn_SatıstaAlbum.Size = new System.Drawing.Size(295, 48);
            this.btn_SatıstaAlbum.TabIndex = 7;
            this.btn_SatıstaAlbum.Text = "Satıştaki Albümler";
            this.btn_SatıstaAlbum.UseVisualStyleBackColor = true;
            this.btn_SatıstaAlbum.Click += new System.EventHandler(this.btn_SatıstaAlbum_Click);
            // 
            // btn_indirimli
            // 
            this.btn_indirimli.Location = new System.Drawing.Point(892, 259);
            this.btn_indirimli.Name = "btn_indirimli";
            this.btn_indirimli.Size = new System.Drawing.Size(295, 48);
            this.btn_indirimli.TabIndex = 9;
            this.btn_indirimli.Text = "İndirimli Albümler";
            this.btn_indirimli.UseVisualStyleBackColor = true;
            this.btn_indirimli.Click += new System.EventHandler(this.btn_indirimli_Click);
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(26, 57);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(271, 31);
            this.txt_Name.TabIndex = 11;
            // 
            // txt_Singer
            // 
            this.txt_Singer.Location = new System.Drawing.Point(26, 134);
            this.txt_Singer.Name = "txt_Singer";
            this.txt_Singer.Size = new System.Drawing.Size(271, 31);
            this.txt_Singer.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Sanatçı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Çıkış Tarihi";
            // 
            // txt_Price
            // 
            this.txt_Price.Location = new System.Drawing.Point(26, 291);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(271, 31);
            this.txt_Price.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Fiyatı";
            // 
            // txt_Discount
            // 
            this.txt_Discount.Location = new System.Drawing.Point(26, 368);
            this.txt_Discount.Name = "txt_Discount";
            this.txt_Discount.Size = new System.Drawing.Size(271, 31);
            this.txt_Discount.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "İndirim Oranı";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 418);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 25);
            this.label6.TabIndex = 20;
            this.label6.Text = "Satış Durumu";
            // 
            // dtp_AlbumDate
            // 
            this.dtp_AlbumDate.Location = new System.Drawing.Point(26, 214);
            this.dtp_AlbumDate.Name = "dtp_AlbumDate";
            this.dtp_AlbumDate.Size = new System.Drawing.Size(300, 31);
            this.dtp_AlbumDate.TabIndex = 22;
            // 
            // cb_bitti
            // 
            this.cb_bitti.AutoSize = true;
            this.cb_bitti.Location = new System.Drawing.Point(43, 446);
            this.cb_bitti.Name = "cb_bitti";
            this.cb_bitti.Size = new System.Drawing.Size(100, 29);
            this.cb_bitti.TabIndex = 24;
            this.cb_bitti.Text = "Tükendi";
            this.cb_bitti.UseVisualStyleBackColor = true;
            // 
            // btn_Listele
            // 
            this.btn_Listele.Location = new System.Drawing.Point(902, 483);
            this.btn_Listele.Name = "btn_Listele";
            this.btn_Listele.Size = new System.Drawing.Size(255, 73);
            this.btn_Listele.TabIndex = 25;
            this.btn_Listele.Text = "Listele";
            this.btn_Listele.UseVisualStyleBackColor = true;
            this.btn_Listele.Click += new System.EventHandler(this.btn_Listele_Click);
            // 
            // dgw_Listele
            // 
            this.dgw_Listele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_Listele.Location = new System.Drawing.Point(354, 25);
            this.dgw_Listele.Name = "dgw_Listele";
            this.dgw_Listele.RowHeadersWidth = 62;
            this.dgw_Listele.RowTemplate.Height = 33;
            this.dgw_Listele.Size = new System.Drawing.Size(471, 597);
            this.dgw_Listele.TabIndex = 26;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 658);
            this.Controls.Add(this.dgw_Listele);
            this.Controls.Add(this.btn_Listele);
            this.Controls.Add(this.cb_bitti);
            this.Controls.Add(this.dtp_AlbumDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Discount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Price);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Singer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.btn_indirimli);
            this.Controls.Add(this.btn_SatıstaAlbum);
            this.Controls.Add(this.btn_DuranAlbum);
            this.Controls.Add(this.btn_Guncelle);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Listele)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btn_Ekle;
        private Button btn_Sil;
        private Button btn_Guncelle;
        private Button btn_DuranAlbum;
        private Button btn_SatıstaAlbum;
        private Button btn_indirimli;
        private TextBox txt_Name;
        private TextBox txt_Singer;
        private Label label2;
        private Label label3;
        private TextBox txt_Price;
        private Label label4;
        private TextBox txt_Discount;
        private Label label5;
        private Label label6;
        private DateTimePicker dtp_AlbumDate;
        private CheckBox cb_bitti;
        private Button btn_Listele;
        private DataGridView dgw_Listele;
    }
}