using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Btw
    {
        public Btw()
        {
            ArtikelBestelLink = new HashSet<ArtikelBestelLink>();
            ArtikelLeverancierLink = new HashSet<ArtikelLeverancierLink>();
            Bestellingen = new HashSet<Bestellingen>();
            Leverancier = new HashSet<Leverancier>();
        }

        public double Percentage { get; set; }
        public int Rang { get; set; }
        public Guid Unid { get; set; }
        public string Naam { get; set; }
        public string Bespokememo { get; set; }
        public int Archief { get; set; }

        public ICollection<ArtikelBestelLink> ArtikelBestelLink { get; set; }
        public ICollection<ArtikelLeverancierLink> ArtikelLeverancierLink { get; set; }
        public ICollection<Bestellingen> Bestellingen { get; set; }
        public ICollection<Leverancier> Leverancier { get; set; }
    }
}
