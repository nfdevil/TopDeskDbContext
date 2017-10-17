using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class ReservationServiceLink
    {
        public ReservationServiceLink()
        {
            ReservationServiceLinkEmailberichten = new HashSet<ReservationServiceLinkEmailberichten>();
        }

        public Guid Unid { get; set; }
        public Guid Reservationid { get; set; }
        public Guid Serviceid { get; set; }
        public DateTime? Dataanmk { get; set; }
        public DateTime? Datwijzig { get; set; }
        public int Status { get; set; }
        public string Bespokememo { get; set; }
        public Guid? Uidaanmk { get; set; }
        public Guid? Uidwijzig { get; set; }
        public string Importid { get; set; }
        public DateTime? Importdate { get; set; }
        public int Importtype { get; set; }
        public int? Amount { get; set; }
        public string Notes { get; set; }
        public Guid? Locationid { get; set; }
        public Guid? Reservedobjectid { get; set; }
        public Guid? Reservedlocationid { get; set; }
        public DateTime? Deliverytime { get; set; }
        public int Deliverytimetype { get; set; }
        public Guid? Operatorid { get; set; }
        public decimal Totalcosts { get; set; }
        public bool Closed { get; set; }
        public Guid? Appointmentid { get; set; }
        public int Exceptionalservice { get; set; }
        public int Sequencenumber { get; set; }
        public DateTime? Closeddate { get; set; }

        public Appointment Appointment { get; set; }
        public Locatie Location { get; set; }
        public Actiedoor Operator { get; set; }
        public Reservation Reservation { get; set; }
        public ReservationFacilityLink Reservedlocation { get; set; }
        public ReservationFacilityLink Reservedobject { get; set; }
        public Dnodienst Service { get; set; }
        public Gebruiker UidaanmkNavigation { get; set; }
        public Gebruiker UidwijzigNavigation { get; set; }
        public ICollection<ReservationServiceLinkEmailberichten> ReservationServiceLinkEmailberichten { get; set; }
    }
}
