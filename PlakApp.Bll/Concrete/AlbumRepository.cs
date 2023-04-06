using PlakApp.Core.Interfaces;
using PlakApp.DataAccess;
using PlakApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlakApp.Bll.Concrete
{
    public class AlbumRepository : IRepository<Album>
    {
        PlakAppContext db = new PlakAppContext();
        public void Ekle(Album item)
        {

            db.Albums.Add(item);
            db.SaveChanges();
        }

        public List<Album> GetByAll()
        {
            return db.Albums.ToList();
        }

        public Album GetByID(Guid id)
        {
            return db.Albums.Find(id);
        }

        public void Guncelle(Album item)
        {
            db.Albums.Add(item);
            db.SaveChanges();
        }

        public void Sil(Album item)
        {
            db.Albums.Remove(item);
            db.SaveChanges();
        }
    }
}
