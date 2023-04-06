using PlakApp.Bll.Concrete;
using PlakApp.DataAccess;
using PlakApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PlakApp.UI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        Saler newSaler;
        AlbumRepository albumRepository = new AlbumRepository();
        PlakAppContext db = new PlakAppContext();
        public Main(Saler yeniGirenSaler) 
        {
            newSaler = yeniGirenSaler;
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            try
            {
                Album _newAlbum = new Album();
                if (txt_Name.Text != " ")
                {
                    _newAlbum.Name = txt_Name.Text;

                }

                else
                {
                    throw new Exception("Bir albüm adı giriniz.");
                }

                if (txt_Singer.Text != " ")
                {
                    _newAlbum.Singer = txt_Singer.Text;

                }
                else
                {
                    throw new Exception("Bir sanatçı giriniz.");
                }

                _newAlbum.AlbumDate = dtp_AlbumDate.Value;
               

                if (txt_Price.Text != " ")
                {
                    _newAlbum.Price = Convert.ToInt32(txt_Price.Text);
                }
                else
                {
                    throw new Exception("Fiyat giriniz.");
                }

                if (txt_Discount.Text != " ")
                {
                    _newAlbum.Discount = Convert.ToInt32(txt_Discount.Text);
                }
                else
                {
                    throw new Exception("İndirim oranı boş bırakılamaz");
                }

                if (cb_bitti.Checked)
                {
                    _newAlbum.IsContinued = false;
                }

                else
                {
                    _newAlbum.IsContinued = true;
                }

                albumRepository.Ekle(_newAlbum);
                Listele();
            }
            catch (Exception)
            {
                MessageBox.Show("Değerler boş bırakılamaz...Fiyat ve indirim oranı için sadece sayısal değer giriniz!");


            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_Listele_Click(object sender, EventArgs e)
        {
            Listele();
        }
        public void Listele()
        {
            dgw_Listele.DataSource = albumRepository.GetByAll();
        }

        private void btn_indirimli_Click(object sender, EventArgs e)
        {
            var ındirimliAlbumler = db.Albums.Where(x => x.Discount != 0 || x.Discount != null).OrderByDescending(x => x.Discount).Select(x => new { x.Name, x.Singer, x.Discount });

            dgw_Listele.DataSource = ındirimliAlbumler.ToList();
            
        }

        private void btn_DuranAlbum_Click(object sender, EventArgs e)
        {
            var satisiDurmusAlbumler = db.Albums.Where(x => x.IsContinued == false).Select(x => new { x.Name, x.Singer, x.IsContinued });
            dgw_Listele.DataSource = satisiDurmusAlbumler.ToList();

        }

        private void btn_SatıstaAlbum_Click(object sender, EventArgs e)
        {
            var satisiDevamEdenAlbumler = db.Albums.Where(x => x.IsContinued == true).Select(x => new { x.Name, x.Singer, x.IsContinued });
            dgw_Listele.DataSource = satisiDevamEdenAlbumler.ToList();
        }

        

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            Guid _seciliID = (Guid)(dgw_Listele.SelectedRows[0].Cells[6].Value);
            Album _silinecekAlbum = db.Albums.Find(_seciliID);
            albumRepository.Sil(_silinecekAlbum);

            Listele();
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            Guid _seciliID = (Guid)(dgw_Listele.SelectedRows[0].Cells[6].Value);
            Album _guncellenecekAlbum = db.Albums.Find(_seciliID);

            _guncellenecekAlbum.Name = txt_Name.Text;
            _guncellenecekAlbum.Singer = txt_Singer.Text;
            _guncellenecekAlbum.AlbumDate = dtp_AlbumDate.Value;
            _guncellenecekAlbum.Price = Convert.ToInt32(txt_Price.Text);
            _guncellenecekAlbum.Discount = Convert.ToInt32(txt_Discount.Text);

            if (cb_bitti.Checked)
            {
                _guncellenecekAlbum.IsContinued = false;
            }

            else
            {
                _guncellenecekAlbum.IsContinued = true;
            }


            albumRepository.Guncelle(_guncellenecekAlbum);
            Listele();
        }
    }
}
