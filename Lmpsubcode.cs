using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Lmpsubcode
    {
        public Lmpsubcode()
        {
            Lmpactivity = new HashSet<Lmpactivity>();
        }

        public Guid Unid { get; set; }
        public int Rang { get; set; }
        public string Code { get; set; }
        public string Naam { get; set; }
        public int Archief { get; set; }
        public Guid Lmpcodeid { get; set; }
        public string Bespokememo { get; set; }

        public Lmpcode Lmpcode { get; set; }
        public ICollection<Lmpactivity> Lmpactivity { get; set; }
    }
}
