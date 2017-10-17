using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class ReservationEvent
    {
        public ReservationEvent()
        {
            Reservation = new HashSet<Reservation>();
            ReservationEventDocumenten = new HashSet<ReservationEventDocumenten>();
            ReservationEventEmailberichten = new HashSet<ReservationEventEmailberichten>();
        }

        public Guid Unid { get; set; }
        public DateTime? Dataanmk { get; set; }
        public DateTime? Datwijzig { get; set; }
        public int Status { get; set; }
        public string Number { get; set; }
        public Guid? Requesterid { get; set; }
        public Guid? Requesterbranchid { get; set; }
        public string Requestername { get; set; }
        public string Requesteremail { get; set; }
        public string Requestertelephone { get; set; }
        public Guid? Budgetholderid { get; set; }
        public string Briefdescription { get; set; }
        public string Comments { get; set; }
        public Guid? Reservedforpersonid { get; set; }
        public Guid? Reservedforbranchid { get; set; }
        public string Reservedforname { get; set; }
        public string Reservedforemail { get; set; }
        public string Reservedfortelephone { get; set; }
        public int Numberofpersons { get; set; }
        public string Bespokememo { get; set; }
        public string Importid { get; set; }
        public DateTime? Importdate { get; set; }
        public int Importtype { get; set; }
        public Guid? Statusid { get; set; }
        public Guid? Uidaanmk { get; set; }
        public Guid? Uidwijzig { get; set; }
        public int Sequencenumber { get; set; }
        public Guid? Requesterextraaid { get; set; }
        public Guid? Requesterextrabid { get; set; }
        public Guid? Operatorid { get; set; }
        public Guid? Operatorgroupid { get; set; }
        public DateTime? Startdate { get; set; }
        public DateTime? Enddate { get; set; }
        public Guid? Departmentid { get; set; }

        public Budgethouder Budgetholder { get; set; }
        public Afdeling Department { get; set; }
        public Actiedoor Operator { get; set; }
        public Actiedoor Operatorgroup { get; set; }
        public Persoon Requester { get; set; }
        public Vestiging Requesterbranch { get; set; }
        public Extraapersoon Requesterextraa { get; set; }
        public Extrabpersoon Requesterextrab { get; set; }
        public Vestiging Reservedforbranch { get; set; }
        public Persoon Reservedforperson { get; set; }
        public ReservationStatus StatusNavigation { get; set; }
        public Gebruiker UidaanmkNavigation { get; set; }
        public Gebruiker UidwijzigNavigation { get; set; }
        public ICollection<Reservation> Reservation { get; set; }
        public ICollection<ReservationEventDocumenten> ReservationEventDocumenten { get; set; }
        public ICollection<ReservationEventEmailberichten> ReservationEventEmailberichten { get; set; }
    }
}
