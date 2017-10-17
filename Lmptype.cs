using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Lmptype
    {
        public Lmptype()
        {
            Lmpactivity = new HashSet<Lmpactivity>();
        }

        public Guid Unid { get; set; }
        public int Rang { get; set; }
        public int Archief { get; set; }
        public string Naam { get; set; }
        public string Bespokememo { get; set; }

        public ICollection<Lmpactivity> Lmpactivity { get; set; }
    }
}
