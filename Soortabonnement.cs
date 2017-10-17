using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Soortabonnement
    {
        public Soortabonnement()
        {
            Telefonie = new HashSet<Telefonie>();
        }

        public int Rang { get; set; }
        public Guid Unid { get; set; }
        public string Naam { get; set; }
        public string Bespokememo { get; set; }
        public int Archief { get; set; }

        public ICollection<Telefonie> Telefonie { get; set; }
    }
}
