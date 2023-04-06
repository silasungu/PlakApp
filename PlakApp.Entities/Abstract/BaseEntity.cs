using PlakApp.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlakApp.Entities.Abstract
{
    public abstract class BaseEntity : IBaseEntity
    {
        public Guid ID { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
