using PlakApp.Bll.Concrete;
using PlakApp.DataAccess;
using PlakApp.Entities.Concrete;

namespace PlakApp.UI
{
    public partial class signin : Form
    {
        public signin()
        {
            InitializeComponent();
        }
        

        private void signin_Load(object sender, EventArgs e)
        {
          
        }

        private void btn_Kaydol_Click(object sender, EventArgs e)
        {
            PlakAppContext db = new PlakAppContext();
            SalerRepository salerRepository = new SalerRepository();
            Saler _newSaler = new Saler();

            try
            {

                var kullanicilar = db.Salers.Where(x => x.UserName == txt_UserNameKayit.Text).SingleOrDefault();

                if (kullanicilar is null)
                {
                    _newSaler.UserName = txt_UserNameKayit.Text;

                    if (txt_PasswordKayit.Text == txt_AgainPassword.Text)
                    {
                        _newSaler.Password = txt_PasswordKayit.Text;
                        

                    }

                    else
                    {
                        throw new Exception("Þifreler farklý ");
                    }
                }
                else
                {
                    throw new Exception("Daha önce kayýt olunmuþ. Lütfen giriþ yapýnýz.");
                }

                
                MessageBox.Show("Kayýt Tamamlandý.");
                this.Close();
            }

            catch (Exception ex)
            {

                MessageBox.Show($"{ex.Message}");
            }


        }

        private void btn_Loginegit_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
        }
    }

        
    

    
}