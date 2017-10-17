using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Orderrequeststatus
    {
        public Orderrequeststatus()
        {
            Bestelaanvraag = new HashSet<Bestelaanvraag>();
        }

        public Guid Unid { get; set; }
        public int Archief { get; set; }
        public int Rang { get; set; }
        public string Naam { get; set; }
        public string Bespokememo { get; set; }

        public ICollection<Bestelaanvraag> Bestelaanvraag { get; set; }
    }
}
