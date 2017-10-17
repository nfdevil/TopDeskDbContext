using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Bestelstatus
    {
        public Bestelstatus()
        {
            Bestellingen = new HashSet<Bestellingen>();
            MutatieBestellingen = new HashSet<MutatieBestellingen>();
        }

        public int Rang { get; set; }
        public Guid Unid { get; set; }
        public string Naam { get; set; }
        public string Bespokememo { get; set; }
        public int Archief { get; set; }

        public ICollection<Bestellingen> Bestellingen { get; set; }
        public ICollection<MutatieBestellingen> MutatieBestellingen { get; set; }
    }
}
