using PlakApp.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace PlakApp.UI
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        PlakAppContext db = new PlakAppContext();
        private void btn_giris_Click(object sender, EventArgs e)
        {
            try
            {
                var _saler = db.Salers.Where(x => x.UserName == txt_Username.Text).Single();
                string girilenSifre = txt_Password.Text;


                if (_saler.Password == sha256_hash(girilenSifre))
                {
                    Main main = new Main();
                    main.Show();
                }
                else
                {
                    throw new Exception("Şifreniz Doğru Değildir");
                }


            }
            catch (Exception)
            {

                MessageBox.Show($"Bilgileriniz formata uygun değildir. Tekrar deneyiniz.");
            }
        }

        public string sha256_hash(string Password)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(Password)).Select(l => l.ToString("X2")));
            }
        }

        private void btn_YeniKayit_Click(object sender, EventArgs e)
        {
            signin signin = new signin();
            signin.Show();

        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
