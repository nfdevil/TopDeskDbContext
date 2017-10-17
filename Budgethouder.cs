using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Budgethouder
    {
        public Budgethouder()
        {
            Actiedoor = new HashSet<Actiedoor>();
            ArtikelMutatie = new HashSet<ArtikelMutatie>();
            Bestelaanvraag = new HashSet<Bestelaanvraag>();
            Bestellingen = new HashSet<Bestellingen>();
            Bezoeker = new HashSet<Bezoeker>();
            Change = new HashSet<Change>();
            ChangeTemplate = new HashSet<ChangeTemplate>();
            Configuratie = new HashSet<Configuratie>();
            DnocontractBudgethouder = new HashSet<Dnocontract>();
            DnocontractContractbudgethouder = new HashSet<Dnocontract>();
            Dnolink = new HashSet<Dnolink>();
            Hardware = new HashSet<Hardware>();
            Incident = new HashSet<Incident>();
            Inventaris = new HashSet<Inventaris>();
            Licentie = new HashSet<Licentie>();
            Lmpactivity = new HashSet<Lmpactivity>();
            Locatie = new HashSet<Locatie>();
            Netwerkcomponent = new HashSet<Netwerkcomponent>();
            Object = new HashSet<Object>();
            OmActiviteit = new HashSet<OmActiviteit>();
            OmReeks = new HashSet<OmReeks>();
            Persoon = new HashSet<Persoon>();
            Persoongroep = new HashSet<Persoongroep>();
            Reservation = new HashSet<Reservation>();
            ReservationEvent = new HashSet<ReservationEvent>();
            Reservering = new HashSet<Reservering>();
            ServiceBudgetholderLink = new HashSet<ServiceBudgetholderLink>();
            Software = new HashSet<Software>();
            Telefonie = new HashSet<Telefonie>();
            Vrij1object = new HashSet<Vrij1object>();
            Vrij2object = new HashSet<Vrij2object>();
            Vrij3object = new HashSet<Vrij3object>();
            Vrij4object = new HashSet<Vrij4object>();
            Vrij5object = new HashSet<Vrij5object>();
        }

        public int Rang { get; set; }
        public Guid Unid { get; set; }
        public string Bespokememo { get; set; }
        public string Naam { get; set; }
        public int Archief { get; set; }

        public ICollection<Actiedoor> Actiedoor { get; set; }
        public ICollection<ArtikelMutatie> ArtikelMutatie { get; set; }
        public ICollection<Bestelaanvraag> Bestelaanvraag { get; set; }
        public ICollection<Bestellingen> Bestellingen { get; set; }
        public ICollection<Bezoeker> Bezoeker { get; set; }
        public ICollection<Change> Change { get; set; }
        public ICollection<ChangeTemplate> ChangeTemplate { get; set; }
        public ICollection<Configuratie> Configuratie { get; set; }
        public ICollection<Dnocontract> DnocontractBudgethouder { get; set; }
        public ICollection<Dnocontract> DnocontractContractbudgethouder { get; set; }
        public ICollection<Dnolink> Dnolink { get; set; }
        public ICollection<Hardware> Hardware { get; set; }
        public ICollection<Incident> Incident { get; set; }
        public ICollection<Inventaris> Inventaris { get; set; }
        public ICollection<Licentie> Licentie { get; set; }
        public ICollection<Lmpactivity> Lmpactivity { get; set; }
        public ICollection<Locatie> Locatie { get; set; }
        public ICollection<Netwerkcomponent> Netwerkcomponent { get; set; }
        public ICollection<Object> Object { get; set; }
        public ICollection<OmActiviteit> OmActiviteit { get; set; }
        public ICollection<OmReeks> OmReeks { get; set; }
        public ICollection<Persoon> Persoon { get; set; }
        public ICollection<Persoongroep> Persoongroep { get; set; }
        public ICollection<Reservation> Reservation { get; set; }
        public ICollection<ReservationEvent> ReservationEvent { get; set; }
        public ICollection<Reservering> Reservering { get; set; }
        public ICollection<ServiceBudgetholderLink> ServiceBudgetholderLink { get; set; }
        public ICollection<Software> Software { get; set; }
        public ICollection<Telefonie> Telefonie { get; set; }
        public ICollection<Vrij1object> Vrij1object { get; set; }
        public ICollection<Vrij2object> Vrij2object { get; set; }
        public ICollection<Vrij3object> Vrij3object { get; set; }
        public ICollection<Vrij4object> Vrij4object { get; set; }
        public ICollection<Vrij5object> Vrij5object { get; set; }
    }
}
