using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Collectiveagreement
    {
        public Collectiveagreement()
        {
            Persoon = new HashSet<Persoon>();
        }

        public Guid Unid { get; set; }
        public string Naam { get; set; }
        public int Archief { get; set; }
        public int Rang { get; set; }
        public string Bespokememo { get; set; }

        public ICollection<Persoon> Persoon { get; set; }
    }
}
