using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Poorttype
    {
        public Poorttype()
        {
            Poort = new HashSet<Poort>();
        }

        public int Archief { get; set; }
        public string Naam { get; set; }
        public int Rang { get; set; }
        public Guid Unid { get; set; }

        public ICollection<Poort> Poort { get; set; }
    }
}
