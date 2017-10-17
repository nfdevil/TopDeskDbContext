using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Extraapersoon
    {
        public Extraapersoon()
        {
            Bestelaanvraag = new HashSet<Bestelaanvraag>();
            Bezoeker = new HashSet<Bezoeker>();
            Change = new HashSet<Change>();
            Incident = new HashSet<Incident>();
            Persoon = new HashSet<Persoon>();
            Reservation = new HashSet<Reservation>();
            ReservationEvent = new HashSet<ReservationEvent>();
            Reservering = new HashSet<Reservering>();
            ServicePersonALink = new HashSet<ServicePersonALink>();
        }

        public bool Heeftattentie { get; set; }
        public int Rang { get; set; }
        public Guid Unid { get; set; }
        public string Opmerking { get; set; }
        public string Bespokememo { get; set; }
        public string Naam { get; set; }
        public int Archief { get; set; }
        public int Kleur { get; set; }

        public ICollection<Bestelaanvraag> Bestelaanvraag { get; set; }
        public ICollection<Bezoeker> Bezoeker { get; set; }
        public ICollection<Change> Change { get; set; }
        public ICollection<Incident> Incident { get; set; }
        public ICollection<Persoon> Persoon { get; set; }
        public ICollection<Reservation> Reservation { get; set; }
        public ICollection<ReservationEvent> ReservationEvent { get; set; }
        public ICollection<Reservering> Reservering { get; set; }
        public ICollection<ServicePersonALink> ServicePersonALink { get; set; }
    }
}
