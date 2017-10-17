using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Lmpworktype
    {
        public Lmpworktype()
        {
            Lmpactivity = new HashSet<Lmpactivity>();
            Lmpindex = new HashSet<Lmpindex>();
        }

        public Guid Unid { get; set; }
        public int Archief { get; set; }
        public int Rang { get; set; }
        public string Naam { get; set; }
        public string Bespokememo { get; set; }

        public ICollection<Lmpactivity> Lmpactivity { get; set; }
        public ICollection<Lmpindex> Lmpindex { get; set; }
    }
}
