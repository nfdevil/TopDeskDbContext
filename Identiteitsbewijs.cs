using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Identiteitsbewijs
    {
        public Identiteitsbewijs()
        {
            Bezoeker = new HashSet<Bezoeker>();
        }

        public int Archief { get; set; }
        public int Rang { get; set; }
        public Guid Unid { get; set; }
        public string Naam { get; set; }
        public string Bespokememo { get; set; }

        public ICollection<Bezoeker> Bezoeker { get; set; }
    }
}
