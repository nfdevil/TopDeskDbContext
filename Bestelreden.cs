using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Bestelreden
    {
        public Bestelreden()
        {
            BestellingenBestelaanvraag = new HashSet<Bestellingen>();
            BestellingenBestelafmeld = new HashSet<Bestellingen>();
        }

        public int Rang { get; set; }
        public int Soort { get; set; }
        public Guid Unid { get; set; }
        public string Naam { get; set; }
        public string Bespokememo { get; set; }
        public int Archief { get; set; }

        public ICollection<Bestellingen> BestellingenBestelaanvraag { get; set; }
        public ICollection<Bestellingen> BestellingenBestelafmeld { get; set; }
    }
}
