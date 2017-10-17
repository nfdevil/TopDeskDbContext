using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Recht
    {
        public Recht()
        {
            Soort = new HashSet<Soort>();
        }

        public int Achterkleur { get; set; }
        public int Archief { get; set; }
        public string Naam { get; set; }
        public int Rang { get; set; }
        public int Superv { get; set; }
        public int Type { get; set; }
        public string Typen { get; set; }
        public Guid Unid { get; set; }
        public string Bespokememo { get; set; }

        public ICollection<Soort> Soort { get; set; }
    }
}
