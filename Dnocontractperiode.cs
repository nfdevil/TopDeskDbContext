using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Dnocontractperiode
    {
        public Dnocontractperiode()
        {
            Dnocontract = new HashSet<Dnocontract>();
        }

        public Guid Unid { get; set; }
        public int Archief { get; set; }
        public int Rang { get; set; }
        public string Naam { get; set; }
        public string Bespokememo { get; set; }

        public ICollection<Dnocontract> Dnocontract { get; set; }
    }
}
