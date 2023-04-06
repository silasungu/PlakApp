using PlakApp.Core.Interfaces;
using PlakApp.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlakApp.Entities.Concrete
{
    public class Album : BaseEntity
    {
        
        public string Name { get; set; }
        public string Singer { get; set; }
        public DateTime AlbumDate { get; set; }
        public double Price { get; set; }
        public bool IsContinued { get; set; }
        public int Discount { get; set; }
       
    }
}
