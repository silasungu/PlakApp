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
    public class SalerRepository : IRepository<Saler>
    {
        PlakAppContext db = new PlakAppContext();
        public void Ekle(Saler item)
        {
            db.Salers.Add(item);
            db.SaveChanges();
        }

        public List<Saler> GetByAll()
        {
            return db.Salers.ToList();
        }

        public Saler GetByID(Guid id)
        {
            return db.Salers.Find(id);
        }

        public void Guncelle(Saler item)
        {
            db.Salers.Add(item);
            db.SaveChanges();
        }

        public void Sil(Saler item)
        {
            db.Salers.Remove(item);
            db.SaveChanges();
        }
    }
}
