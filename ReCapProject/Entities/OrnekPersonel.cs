using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class OrnekPersonel:IEntity
    {
        public int PersonelId { get; set; }
        public string  PesonelAdi { get; set; }
        public string PersonelSoyadi { get; set; }
    }
}
