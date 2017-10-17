using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Lmpcode
    {
        public Lmpcode()
        {
            Lmpactivity = new HashSet<Lmpactivity>();
            Lmpsubcode = new HashSet<Lmpsubcode>();
        }

        public Guid Unid { get; set; }
        public int Rang { get; set; }
        public string Code { get; set; }
        public string Naam { get; set; }
        public int Archief { get; set; }
        public string Bespokememo { get; set; }

        public ICollection<Lmpactivity> Lmpactivity { get; set; }
        public ICollection<Lmpsubcode> Lmpsubcode { get; set; }
    }
}
