using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class ReservationFacilityLink
    {
        public ReservationFacilityLink()
        {
            ReservationFacilityLinkEmailberichten = new HashSet<ReservationFacilityLinkEmailberichten>();
            ReservationServiceLinkReservedlocation = new HashSet<ReservationServiceLink>();
            ReservationServiceLinkReservedobject = new HashSet<ReservationServiceLink>();
        }

        public Guid Unid { get; set; }
        public DateTime? Dataanmk { get; set; }
        public DateTime? Datwijzig { get; set; }
        public int Status { get; set; }
        public string Bespokememo { get; set; }
        public Guid? Uidaanmk { get; set; }
        public Guid? Uidwijzig { get; set; }
        public Guid Reservationid { get; set; }
        public Guid? Locationid { get; set; }
        public Guid? Objectid { get; set; }
        public DateTime Startdate { get; set; }
        public DateTime Enddate { get; set; }
        public DateTime Startdateblock { get; set; }
        public DateTime Enddateblock { get; set; }
        public DateTime? Issuedate { get; set; }
        public DateTime? Renderdate { get; set; }
        public string Importid { get; set; }
        public DateTime? Importdate { get; set; }
        public int Importtype { get; set; }
        public decimal Totalcosts { get; set; }
        public decimal Deposit { get; set; }
        public int Sequencenumber { get; set; }

        public Locatie Location { get; set; }
        public Object Object { get; set; }
        public Reservation Reservation { get; set; }
        public Gebruiker UidaanmkNavigation { get; set; }
        public Gebruiker UidwijzigNavigation { get; set; }
        public ICollection<ReservationFacilityLinkEmailberichten> ReservationFacilityLinkEmailberichten { get; set; }
        public ICollection<ReservationServiceLink> ReservationServiceLinkReservedlocation { get; set; }
        public ICollection<ReservationServiceLink> ReservationServiceLinkReservedobject { get; set; }
    }
}
