using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Land
    {
        public Land()
        {
            Actiedoor = new HashSet<Actiedoor>();
            BestellingenLandid1Navigation = new HashSet<Bestellingen>();
            BestellingenLandid2Navigation = new HashSet<Bestellingen>();
            LeverancierLandid1Navigation = new HashSet<Leverancier>();
            LeverancierLandid2Navigation = new HashSet<Leverancier>();
            PersoonIdIssueCountry = new HashSet<Persoon>();
            PersoonLand = new HashSet<Persoon>();
            PersoonOriginCountry = new HashSet<Persoon>();
            VestigingLandid1Navigation = new HashSet<Vestiging>();
            VestigingLandid2Navigation = new HashSet<Vestiging>();
        }

        public int Rang { get; set; }
        public Guid Unid { get; set; }
        public string Naam { get; set; }
        public string Bespokememo { get; set; }
        public int Archief { get; set; }
        public string Guicode { get; set; }

        public ICollection<Actiedoor> Actiedoor { get; set; }
        public ICollection<Bestellingen> BestellingenLandid1Navigation { get; set; }
        public ICollection<Bestellingen> BestellingenLandid2Navigation { get; set; }
        public ICollection<Leverancier> LeverancierLandid1Navigation { get; set; }
        public ICollection<Leverancier> LeverancierLandid2Navigation { get; set; }
        public ICollection<Persoon> PersoonIdIssueCountry { get; set; }
        public ICollection<Persoon> PersoonLand { get; set; }
        public ICollection<Persoon> PersoonOriginCountry { get; set; }
        public ICollection<Vestiging> VestigingLandid1Navigation { get; set; }
        public ICollection<Vestiging> VestigingLandid2Navigation { get; set; }
    }
}
