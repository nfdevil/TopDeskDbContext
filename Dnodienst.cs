using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Dnodienst
    {
        public Dnodienst()
        {
            DnodienstDocumenten = new HashSet<DnodienstDocumenten>();
            DnodienstEmailberichten = new HashSet<DnodienstEmailberichten>();
            DnodienstLogboek = new HashSet<DnodienstLogboek>();
            DnodienstMemoHistory = new HashSet<DnodienstMemoHistory>();
            DnodienstPicture = new HashSet<DnodienstPicture>();
            Dnolink = new HashSet<Dnolink>();
            Dnolocationlink = new HashSet<Dnolocationlink>();
            Dnoobjectlink = new HashSet<Dnoobjectlink>();
            IncidentRefDnodienst = new HashSet<Incident>();
            IncidentSupplierservice = new HashSet<Incident>();
            InverseUnderpinningdienst = new HashSet<Dnodienst>();
            MutatieDnodienstMutUnderpinningdienst = new HashSet<MutatieDnodienst>();
            MutatieDnodienstParent = new HashSet<MutatieDnodienst>();
            ReservationServiceLink = new HashSet<ReservationServiceLink>();
            ServiceBranchLink = new HashSet<ServiceBranchLink>();
            ServiceBudgetholderLink = new HashSet<ServiceBudgetholderLink>();
            ServiceDepartmentLink = new HashSet<ServiceDepartmentLink>();
            ServicePersonALink = new HashSet<ServicePersonALink>();
            ServicePersonBLink = new HashSet<ServicePersonBLink>();
            ServiceSsdformLink = new HashSet<ServiceSsdformLink>();
            ServicelevelServiceLink = new HashSet<ServicelevelServiceLink>();
        }

        public string Aantekeningen { get; set; }
        public Guid? Archiefredenid { get; set; }
        public Guid? Dnocontractid { get; set; }
        public Guid? Dnodienstsoortid { get; set; }
        public Guid? Doorlooptijdlijn1id { get; set; }
        public Guid? Doorlooptijdlijn2id { get; set; }
        public bool Isgebruikt { get; set; }
        public string Naam { get; set; }
        public int Status { get; set; }
        public string Toelichting { get; set; }
        public Guid? Uidaanmk { get; set; }
        public Guid? Uidwijzig { get; set; }
        public Guid? Underpinningcontractid { get; set; }
        public Guid? Underpinningdienstid { get; set; }
        public Guid Unid { get; set; }
        public int Volgnummer { get; set; }
        public double Vrijegetal1 { get; set; }
        public double Vrijegetal2 { get; set; }
        public bool Vrijelogisch1 { get; set; }
        public bool Vrijelogisch2 { get; set; }
        public bool Vrijelogisch3 { get; set; }
        public bool Vrijelogisch4 { get; set; }
        public bool Vrijelogisch5 { get; set; }
        public string Vrijememo1 { get; set; }
        public string Vrijememo2 { get; set; }
        public Guid? Vrijeopzoek1 { get; set; }
        public Guid? Vrijeopzoek2 { get; set; }
        public Guid? Vrijeopzoek3 { get; set; }
        public bool Algemeenbudgethouder { get; set; }
        public bool Algemeenvestiging { get; set; }
        public bool Algemeenalgemeen { get; set; }
        public string Omschrijving { get; set; }
        public DateTime? Aanvangsdatum { get; set; }
        public DateTime? Dataanmk { get; set; }
        public DateTime? Datwijzig { get; set; }
        public DateTime? Einddatum { get; set; }
        public DateTime? Vrijedatum1 { get; set; }
        public DateTime? Vrijedatum2 { get; set; }
        public decimal Kosten { get; set; }
        public Guid? Domeinid { get; set; }
        public Guid? Specificatieid { get; set; }
        public Guid? Soortmeldingid { get; set; }
        public Guid? Extraaid { get; set; }
        public Guid? Extrabid { get; set; }
        public Guid? Selectionid { get; set; }
        public Guid? Incidentselectionid { get; set; }
        public bool Algemeenextraa { get; set; }
        public bool Algemeenextrab { get; set; }
        public bool Algemeenafdeling { get; set; }
        public DateTime? Vrijedatum3 { get; set; }
        public double Vrijegetal3 { get; set; }
        public string Vrijememo3 { get; set; }
        public DateTime? Vrijedatum4 { get; set; }
        public double Vrijegetal4 { get; set; }
        public string Vrijememo4 { get; set; }
        public DateTime? Vrijedatum5 { get; set; }
        public double Vrijegetal5 { get; set; }
        public string Vrijememo5 { get; set; }
        public Guid? Vrijeopzoek4 { get; set; }
        public Guid? Vrijeopzoek5 { get; set; }
        public string Vrijetekst1 { get; set; }
        public string Vrijetekst2 { get; set; }
        public string Vrijetekst3 { get; set; }
        public string Vrijetekst4 { get; set; }
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
        public string Importid { get; set; }
        public string Bespokememo { get; set; }
        public int Importtype { get; set; }
        public DateTime? Importdate { get; set; }
        public string RefDienstsoort { get; set; }
        public Guid? Defaultfirstlineoperatorid { get; set; }
        public Guid? Defaultsecondlineoperatorid { get; set; }
        public string Action { get; set; }
        public bool Objectfilter { get; set; }
        public bool Fieldfilter { get; set; }
        public bool Dependsonunderpinning { get; set; }
        public string RefProgresstrail { get; set; }
        public bool Published { get; set; }
        public string Termsofsupply { get; set; }
        public int Targetgroup { get; set; }
        public bool Reservable { get; set; }
        public bool Reservablessd { get; set; }
        public int Defaultdeliverytime { get; set; }
        public Guid? Defaultreservationsoperatorid { get; set; }
        public int Defaultamounttype { get; set; }
        public decimal Costs { get; set; }
        public int? Editdaysupfront { get; set; }
        public int? Editdaysupfronttime { get; set; }
        public int? Edithoursupfront { get; set; }
        public int Edituntiltype { get; set; }
        public bool ReservableSeparately { get; set; }
        public bool Availableforincidents { get; set; }
        public bool Availableforreservations { get; set; }
        public Guid? Managerid { get; set; }
        public int Reservableforfilter { get; set; }
        public decimal CostsHightariff { get; set; }
        public Guid? Servicewindowid { get; set; }
        public int ServicewindowOption { get; set; }

        public Archiefreden Archiefreden { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek1Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek2Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek3Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek4Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek5Navigation { get; set; }
        public Actiedoor Defaultfirstlineoperator { get; set; }
        public Actiedoor Defaultreservationsoperator { get; set; }
        public Actiedoor Defaultsecondlineoperator { get; set; }
        public Dnocontract Dnocontract { get; set; }
        public Dnodienstsoort Dnodienstsoort { get; set; }
        public Classificatie Domein { get; set; }
        public Doorlooptijd Doorlooptijdlijn1 { get; set; }
        public Doorlooptijd Doorlooptijdlijn2 { get; set; }
        public Extraa Extraa { get; set; }
        public Extrab Extrab { get; set; }
        public Selvast Incidentselection { get; set; }
        public Actiedoor Manager { get; set; }
        public Selvast Selection { get; set; }
        public Servicewindow Servicewindow { get; set; }
        public Soortmelding Soortmelding { get; set; }
        public Classificatie Specificatie { get; set; }
        public Gebruiker UidaanmkNavigation { get; set; }
        public Gebruiker UidwijzigNavigation { get; set; }
        public Dnocontract Underpinningcontract { get; set; }
        public Dnodienst Underpinningdienst { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek1Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek2Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek3Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek4Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek5Navigation { get; set; }
        public ICollection<DnodienstDocumenten> DnodienstDocumenten { get; set; }
        public ICollection<DnodienstEmailberichten> DnodienstEmailberichten { get; set; }
        public ICollection<DnodienstLogboek> DnodienstLogboek { get; set; }
        public ICollection<DnodienstMemoHistory> DnodienstMemoHistory { get; set; }
        public ICollection<DnodienstPicture> DnodienstPicture { get; set; }
        public ICollection<Dnolink> Dnolink { get; set; }
        public ICollection<Dnolocationlink> Dnolocationlink { get; set; }
        public ICollection<Dnoobjectlink> Dnoobjectlink { get; set; }
        public ICollection<Incident> IncidentRefDnodienst { get; set; }
        public ICollection<Incident> IncidentSupplierservice { get; set; }
        public ICollection<Dnodienst> InverseUnderpinningdienst { get; set; }
        public ICollection<MutatieDnodienst> MutatieDnodienstMutUnderpinningdienst { get; set; }
        public ICollection<MutatieDnodienst> MutatieDnodienstParent { get; set; }
        public ICollection<ReservationServiceLink> ReservationServiceLink { get; set; }
        public ICollection<ServiceBranchLink> ServiceBranchLink { get; set; }
        public ICollection<ServiceBudgetholderLink> ServiceBudgetholderLink { get; set; }
        public ICollection<ServiceDepartmentLink> ServiceDepartmentLink { get; set; }
        public ICollection<ServicePersonALink> ServicePersonALink { get; set; }
        public ICollection<ServicePersonBLink> ServicePersonBLink { get; set; }
        public ICollection<ServiceSsdformLink> ServiceSsdformLink { get; set; }
        public ICollection<ServicelevelServiceLink> ServicelevelServiceLink { get; set; }
    }
}
