using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class ProbleemCategorie
    {
        public ProbleemCategorie()
        {
            Probleem = new HashSet<Probleem>();
        }

        public int Rang { get; set; }
        public Guid Unid { get; set; }
        public string Naam { get; set; }
        public string Bespokememo { get; set; }
        public int Archief { get; set; }

        public ICollection<Probleem> Probleem { get; set; }
    }
}
