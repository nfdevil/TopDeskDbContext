using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Voorzieningsoort
    {
        public Voorzieningsoort()
        {
            Voorziening = new HashSet<Voorziening>();
        }

        public Guid Unid { get; set; }
        public int Rang { get; set; }
        public string Naam { get; set; }
        public string Bespokememo { get; set; }
        public int Archief { get; set; }

        public ICollection<Voorziening> Voorziening { get; set; }
    }
}
