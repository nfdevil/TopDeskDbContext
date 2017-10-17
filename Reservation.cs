using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Reservation
    {
        public Reservation()
        {
            ReservationDocumenten = new HashSet<ReservationDocumenten>();
            ReservationEmailberichten = new HashSet<ReservationEmailberichten>();
            ReservationFacilityLink = new HashSet<ReservationFacilityLink>();
            ReservationLogboek = new HashSet<ReservationLogboek>();
            ReservationMemoHistory = new HashSet<ReservationMemoHistory>();
            ReservationPersonLink = new HashSet<ReservationPersonLink>();
            ReservationServiceLink = new HashSet<ReservationServiceLink>();
            ReservationVisitorLink = new HashSet<ReservationVisitorLink>();
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
        public Guid? Cancelreasonid { get; set; }
        public DateTime? Canceldate { get; set; }
        public Guid? Rejectreasonid { get; set; }
        public DateTime? Rejectdate { get; set; }
        public string Bespokememo { get; set; }
        public string Importid { get; set; }
        public DateTime? Importdate { get; set; }
        public int Importtype { get; set; }
        public Guid? Operatorid { get; set; }
        public Guid? Operatorgroupid { get; set; }
        public Guid? Statusid { get; set; }
        public Guid? Uidaanmk { get; set; }
        public Guid? Uidwijzig { get; set; }
        public bool Hasfacilities { get; set; }
        public int Sequencenumber { get; set; }
        public Guid? Seriesid { get; set; }
        public Guid? Patternid { get; set; }
        public decimal Totalreservationcosts { get; set; }
        public decimal Totaldeposit { get; set; }
        public decimal Totalfacilitycosts { get; set; }
        public decimal Totalservicecosts { get; set; }
        public Guid? Archivereasonid { get; set; }
        public DateTime RefStartdate { get; set; }
        public DateTime RefEnddate { get; set; }
        public DateTime? Vrijedatum1 { get; set; }
        public double Vrijegetal1 { get; set; }
        public bool Vrijelogisch1 { get; set; }
        public string Vrijememo1 { get; set; }
        public Guid? Vrijeopzoek1 { get; set; }
        public string Vrijetekst1 { get; set; }
        public DateTime? Vrijedatum2 { get; set; }
        public double Vrijegetal2 { get; set; }
        public bool Vrijelogisch2 { get; set; }
        public string Vrijememo2 { get; set; }
        public Guid? Vrijeopzoek2 { get; set; }
        public string Vrijetekst2 { get; set; }
        public DateTime? Vrijedatum3 { get; set; }
        public double Vrijegetal3 { get; set; }
        public bool Vrijelogisch3 { get; set; }
        public string Vrijememo3 { get; set; }
        public Guid? Vrijeopzoek3 { get; set; }
        public string Vrijetekst3 { get; set; }
        public DateTime? Vrijedatum4 { get; set; }
        public double Vrijegetal4 { get; set; }
        public bool Vrijelogisch4 { get; set; }
        public string Vrijememo4 { get; set; }
        public Guid? Vrijeopzoek4 { get; set; }
        public string Vrijetekst4 { get; set; }
        public DateTime? Vrijedatum5 { get; set; }
        public double Vrijegetal5 { get; set; }
        public bool Vrijelogisch5 { get; set; }
        public string Vrijememo5 { get; set; }
        public Guid? Vrijeopzoek5 { get; set; }
        public string Vrijetekst5 { get; set; }
        public DateTime? Attvrijedatum1 { get; set; }
        public double Attvrijegetal1 { get; set; }
        public bool Attvrijelogisch1 { get; set; }
        public string Attvrijememo1 { get; set; }
        public Guid? Attvrijeopzoek1 { get; set; }
        public string Attvrijetekst1 { get; set; }
        public DateTime? Attvrijedatum2 { get; set; }
        public double Attvrijegetal2 { get; set; }
        public bool Attvrijelogisch2 { get; set; }
        public string Attvrijememo2 { get; set; }
        public Guid? Attvrijeopzoek2 { get; set; }
        public string Attvrijetekst2 { get; set; }
        public DateTime? Attvrijedatum3 { get; set; }
        public double Attvrijegetal3 { get; set; }
        public bool Attvrijelogisch3 { get; set; }
        public string Attvrijememo3 { get; set; }
        public Guid? Attvrijeopzoek3 { get; set; }
        public string Attvrijetekst3 { get; set; }
        public DateTime? Attvrijedatum4 { get; set; }
        public double Attvrijegetal4 { get; set; }
        public bool Attvrijelogisch4 { get; set; }
        public string Attvrijememo4 { get; set; }
        public Guid? Attvrijeopzoek4 { get; set; }
        public string Attvrijetekst4 { get; set; }
        public DateTime? Attvrijedatum5 { get; set; }
        public double Attvrijegetal5 { get; set; }
        public bool Attvrijelogisch5 { get; set; }
        public string Attvrijememo5 { get; set; }
        public Guid? Attvrijeopzoek5 { get; set; }
        public string Attvrijetekst5 { get; set; }
        public Guid? Requesterextraaid { get; set; }
        public Guid? Requesterextrabid { get; set; }
        public bool Markedforreview { get; set; }
        public bool Hightariff { get; set; }
        public Guid? Eventid { get; set; }
        public Guid? Departmentid { get; set; }

        public Archiefreden Archivereason { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek1Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek2Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek3Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek4Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek5Navigation { get; set; }
        public Budgethouder Budgetholder { get; set; }
        public ReservationCancelReason Cancelreason { get; set; }
        public Afdeling Department { get; set; }
        public ReservationEvent Event { get; set; }
        public Actiedoor Operator { get; set; }
        public Actiedoor Operatorgroup { get; set; }
        public ReservationPattern Pattern { get; set; }
        public ReservationRejectReason Rejectreason { get; set; }
        public Persoon Requester { get; set; }
        public Vestiging Requesterbranch { get; set; }
        public Extraapersoon Requesterextraa { get; set; }
        public Extrabpersoon Requesterextrab { get; set; }
        public Vestiging Reservedforbranch { get; set; }
        public Persoon Reservedforperson { get; set; }
        public ReservationSeries Series { get; set; }
        public ReservationStatus StatusNavigation { get; set; }
        public Gebruiker UidaanmkNavigation { get; set; }
        public Gebruiker UidwijzigNavigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek1Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek2Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek3Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek4Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek5Navigation { get; set; }
        public ICollection<ReservationDocumenten> ReservationDocumenten { get; set; }
        public ICollection<ReservationEmailberichten> ReservationEmailberichten { get; set; }
        public ICollection<ReservationFacilityLink> ReservationFacilityLink { get; set; }
        public ICollection<ReservationLogboek> ReservationLogboek { get; set; }
        public ICollection<ReservationMemoHistory> ReservationMemoHistory { get; set; }
        public ICollection<ReservationPersonLink> ReservationPersonLink { get; set; }
        public ICollection<ReservationServiceLink> ReservationServiceLink { get; set; }
        public ICollection<ReservationVisitorLink> ReservationVisitorLink { get; set; }
    }
}
