using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25._04._2019.Entity
{
    public class Qruplar
    {
        public int Id { get; set; }

        public string QrupAdi { get; set; }
        public string Qeyd { get; set; }
        public Filial Filiali { get; set; }
        public XidmetNovu Xidmetnovu { get; set; }
        public Seviyye Seviyye { get; set; }
    }
}
