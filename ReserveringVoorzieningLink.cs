using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class ReserveringVoorzieningLink
    {
        public ReserveringVoorzieningLink()
        {
            ReserveringVoorzieningLinkDocumenten = new HashSet<ReserveringVoorzieningLinkDocumenten>();
            ReserveringVoorzieningLinkEmailberichten = new HashSet<ReserveringVoorzieningLinkEmailberichten>();
            ReserveringVoorzieningLinkLogboek = new HashSet<ReserveringVoorzieningLinkLogboek>();
        }

        public Guid Unid { get; set; }
        public Guid Reserveringid { get; set; }
        public Guid Voorzieningid { get; set; }
        public Guid? Objectid { get; set; }
        public Guid? Locatieid { get; set; }
        public Guid? Behandelaarid { get; set; }
        public int Aantal { get; set; }
        public DateTime? Tijdstip { get; set; }
        public string Opmerking { get; set; }
        public decimal Prijsperstuk { get; set; }
        public bool Afgemeld { get; set; }
        public string Aantekeningen { get; set; }
        public DateTime? Dataanmk { get; set; }
        public DateTime? Datwijzig { get; set; }
        public Guid? Uidaanmk { get; set; }
        public Guid? Uidwijzig { get; set; }
        public long Tijdbesteed { get; set; }
        public int Status { get; set; }
        public int Bloktijd { get; set; }
        public int Bloktijdduur { get; set; }
        public string Bespokememo { get; set; }
        public Guid? Statusid { get; set; }
        public Guid? Vestigingid { get; set; }
        public DateTime? RefResPlannedstartdate { get; set; }
        public DateTime? RefResPlannedenddate { get; set; }
        public int RefResNumberofpersons { get; set; }
        public string RefResBriefdescription { get; set; }
        public string RefReservationName { get; set; }
        public string RefResServiceName { get; set; }
        public string RefObjectNaam { get; set; }
        public string RefLocationNaam { get; set; }
        public string RefLocationBranch { get; set; }
        public Guid? Appointmentid { get; set; }
        public string RefOperatorName { get; set; }

        public Appointment Appointment { get; set; }
        public Actiedoor Behandelaar { get; set; }
        public Locatie Locatie { get; set; }
        public Object Object { get; set; }
        public Reservering Reservering { get; set; }
        public ReserveringVoorzieningStatus StatusNavigation { get; set; }
        public Gebruiker UidaanmkNavigation { get; set; }
        public Gebruiker UidwijzigNavigation { get; set; }
        public Vestiging Vestiging { get; set; }
        public Voorziening Voorziening { get; set; }
        public ICollection<ReserveringVoorzieningLinkDocumenten> ReserveringVoorzieningLinkDocumenten { get; set; }
        public ICollection<ReserveringVoorzieningLinkEmailberichten> ReserveringVoorzieningLinkEmailberichten { get; set; }
        public ICollection<ReserveringVoorzieningLinkLogboek> ReserveringVoorzieningLinkLogboek { get; set; }
    }
}
