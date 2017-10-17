using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Opslagmedium
    {
        public Opslagmedium()
        {
            Software = new HashSet<Software>();
        }

        public int Rang { get; set; }
        public Guid Unid { get; set; }
        public string Naam { get; set; }
        public string Bespokememo { get; set; }
        public int Archief { get; set; }

        public ICollection<Software> Software { get; set; }
    }
}
