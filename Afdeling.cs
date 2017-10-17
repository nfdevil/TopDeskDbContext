using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Afdeling
    {
        public Afdeling()
        {
            Actiedoor = new HashSet<Actiedoor>();
            Bestelaanvraag = new HashSet<Bestelaanvraag>();
            Bezoeker = new HashSet<Bezoeker>();
            Change = new HashSet<Change>();
            ChangeTemplate = new HashSet<ChangeTemplate>();
            Dnocontract = new HashSet<Dnocontract>();
            Incident = new HashSet<Incident>();
            Persoon = new HashSet<Persoon>();
            Persoongroep = new HashSet<Persoongroep>();
            Reservation = new HashSet<Reservation>();
            ReservationEvent = new HashSet<ReservationEvent>();
            Reservering = new HashSet<Reservering>();
            ServiceDepartmentLink = new HashSet<ServiceDepartmentLink>();
        }

        public int Rang { get; set; }
        public Guid Unid { get; set; }
        public string Bespokememo { get; set; }
        public string Naam { get; set; }
        public int Archief { get; set; }

        public ICollection<Actiedoor> Actiedoor { get; set; }
        public ICollection<Bestelaanvraag> Bestelaanvraag { get; set; }
        public ICollection<Bezoeker> Bezoeker { get; set; }
        public ICollection<Change> Change { get; set; }
        public ICollection<ChangeTemplate> ChangeTemplate { get; set; }
        public ICollection<Dnocontract> Dnocontract { get; set; }
        public ICollection<Incident> Incident { get; set; }
        public ICollection<Persoon> Persoon { get; set; }
        public ICollection<Persoongroep> Persoongroep { get; set; }
        public ICollection<Reservation> Reservation { get; set; }
        public ICollection<ReservationEvent> ReservationEvent { get; set; }
        public ICollection<Reservering> Reservering { get; set; }
        public ICollection<ServiceDepartmentLink> ServiceDepartmentLink { get; set; }
    }
}
