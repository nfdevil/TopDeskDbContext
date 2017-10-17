using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Extrab
    {
        public Extrab()
        {
            Bestelaanvraag = new HashSet<Bestelaanvraag>();
            Bezoeker = new HashSet<Bezoeker>();
            Change = new HashSet<Change>();
            Dnocontract = new HashSet<Dnocontract>();
            Dnodienst = new HashSet<Dnodienst>();
            Incident = new HashSet<Incident>();
            MutatieVestiging = new HashSet<MutatieVestiging>();
            Reservering = new HashSet<Reservering>();
            Vestiging = new HashSet<Vestiging>();
        }

        public Guid Unid { get; set; }
        public int Archief { get; set; }
        public bool Heeftattentie { get; set; }
        public string Opmerking { get; set; }
        public string Bespokememo { get; set; }
        public string Naam { get; set; }
        public int Kleur { get; set; }
        public int Rang { get; set; }

        public ICollection<Bestelaanvraag> Bestelaanvraag { get; set; }
        public ICollection<Bezoeker> Bezoeker { get; set; }
        public ICollection<Change> Change { get; set; }
        public ICollection<Dnocontract> Dnocontract { get; set; }
        public ICollection<Dnodienst> Dnodienst { get; set; }
        public ICollection<Incident> Incident { get; set; }
        public ICollection<MutatieVestiging> MutatieVestiging { get; set; }
        public ICollection<Reservering> Reservering { get; set; }
        public ICollection<Vestiging> Vestiging { get; set; }
    }
}
