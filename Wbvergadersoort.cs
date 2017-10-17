using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Wbvergadersoort
    {
        public Wbvergadersoort()
        {
            Meeting = new HashSet<Meeting>();
        }

        public int Rang { get; set; }
        public Guid Unid { get; set; }
        public string Naam { get; set; }
        public string Bespokememo { get; set; }
        public int Archief { get; set; }

        public ICollection<Meeting> Meeting { get; set; }
    }
}
