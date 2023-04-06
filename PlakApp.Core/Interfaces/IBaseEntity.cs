using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlakApp.Core.Interfaces
{
    public interface IBaseEntity
    {
        Guid ID { get; set; }
    }
}
