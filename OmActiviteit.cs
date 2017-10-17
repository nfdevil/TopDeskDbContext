using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class OmActiviteit
    {
        public OmActiviteit()
        {
            LmpOmActivityLink = new HashSet<LmpOmActivityLink>();
            MutatieOmActiviteit = new HashSet<MutatieOmActiviteit>();
            OmActiviteitDocumenten = new HashSet<OmActiviteitDocumenten>();
            OmActiviteitEmailberichten = new HashSet<OmActiviteitEmailberichten>();
            OmActiviteitIncidentLink = new HashSet<OmActiviteitIncidentLink>();
            OmActiviteitLocatieLink = new HashSet<OmActiviteitLocatieLink>();
            OmActiviteitLogboek = new HashSet<OmActiviteitLogboek>();
            OmActiviteitMemoHistory = new HashSet<OmActiviteitMemoHistory>();
            OmActiviteitObjectLink = new HashSet<OmActiviteitObjectLink>();
            OmActiviteitVestigingLink = new HashSet<OmActiviteitVestigingLink>();
            TimeRegistrationOmActiviteit = new HashSet<TimeRegistrationOmActiviteit>();
        }

        public Guid Unid { get; set; }
        public string Aantekeningen { get; set; }
        public string Actie { get; set; }
        public bool Afgemeld { get; set; }
        public Guid? Afwijkingredenid { get; set; }
        public bool Afwijkinggeconstateerd { get; set; }
        public Guid? Archiefredenid { get; set; }
        public Guid? Behandelaarid { get; set; }
        public long Bestedetijd { get; set; }
        public long Bestedetijdgepland { get; set; }
        public Guid? Categorieid { get; set; }
        public DateTime? Datumafgemeld { get; set; }
        public DateTime Einddatumgepland { get; set; }
        public Guid? Groeperingid { get; set; }
        public decimal Kostengepland { get; set; }
        public string Naam { get; set; }
        public bool Overgeslagen { get; set; }
        public Guid? Redenoverslaanid { get; set; }
        public Guid? Reeksid { get; set; }
        public Guid? Schemaid { get; set; }
        public Guid? Soortid { get; set; }
        public DateTime Startdatumgepland { get; set; }
        public int Status { get; set; }
        public Guid? Statusid { get; set; }
        public Guid? Subcategorieid { get; set; }
        public string Verzoek { get; set; }
        public DateTime? Vrijedatum1 { get; set; }
        public DateTime? Vrijedatum2 { get; set; }
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
        public decimal Gerealiseerdekosten { get; set; }
        public long Nogteverwachtenbestedetijd { get; set; }
        public decimal Nogteverwachtenkosten { get; set; }
        public string Bestedetijdmemo { get; set; }
        public string Kostenmemo { get; set; }
        public long RefBestedetijdsverschil { get; set; }
        public long RefBestedetijdsgat { get; set; }
        public decimal RefKostenverschil { get; set; }
        public decimal RefKostengat { get; set; }
        public string RefSchemanaam { get; set; }
        public string RefGroeperingnaam { get; set; }
        public string RefCategorienaam { get; set; }
        public string RefSubcategorienaam { get; set; }
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
        public string Nummer { get; set; }
        public DateTime? Dataanmk { get; set; }
        public DateTime? Datwijzig { get; set; }
        public Guid? Uidaanmk { get; set; }
        public Guid? Uidwijzig { get; set; }
        public Guid? Budgethouderid { get; set; }
        public Guid? Operatorgroupid { get; set; }
        public string Bespokememo { get; set; }
        public int Importtype { get; set; }
        public string Importid { get; set; }
        public DateTime? Importdate { get; set; }
        public string RefSeriesnumber { get; set; }
        public string RefSeriesname { get; set; }
        public Guid? Appointmentid { get; set; }
        public string RefBehandelaarnaam { get; set; }
        public string RefStatusnaam { get; set; }
        public string RefProgresstrail { get; set; }
        public Guid? Supplierid { get; set; }

        public OmAfwijkingreden Afwijkingreden { get; set; }
        public Appointment Appointment { get; set; }
        public Archiefreden Archiefreden { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek1Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek2Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek3Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek4Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek5Navigation { get; set; }
        public Actiedoor Behandelaar { get; set; }
        public Budgethouder Budgethouder { get; set; }
        public Classificatie Categorie { get; set; }
        public OmGroepering Groepering { get; set; }
        public Actiedoor Operatorgroup { get; set; }
        public OmRedenoverslaan Redenoverslaan { get; set; }
        public OmReeks Reeks { get; set; }
        public OmSchema Schema { get; set; }
        public OmSoort Soort { get; set; }
        public OmActiviteitStatus StatusNavigation { get; set; }
        public Classificatie Subcategorie { get; set; }
        public Leverancier Supplier { get; set; }
        public Gebruiker UidaanmkNavigation { get; set; }
        public Gebruiker UidwijzigNavigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek1Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek2Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek3Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek4Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek5Navigation { get; set; }
        public ICollection<LmpOmActivityLink> LmpOmActivityLink { get; set; }
        public ICollection<MutatieOmActiviteit> MutatieOmActiviteit { get; set; }
        public ICollection<OmActiviteitDocumenten> OmActiviteitDocumenten { get; set; }
        public ICollection<OmActiviteitEmailberichten> OmActiviteitEmailberichten { get; set; }
        public ICollection<OmActiviteitIncidentLink> OmActiviteitIncidentLink { get; set; }
        public ICollection<OmActiviteitLocatieLink> OmActiviteitLocatieLink { get; set; }
        public ICollection<OmActiviteitLogboek> OmActiviteitLogboek { get; set; }
        public ICollection<OmActiviteitMemoHistory> OmActiviteitMemoHistory { get; set; }
        public ICollection<OmActiviteitObjectLink> OmActiviteitObjectLink { get; set; }
        public ICollection<OmActiviteitVestigingLink> OmActiviteitVestigingLink { get; set; }
        public ICollection<TimeRegistrationOmActiviteit> TimeRegistrationOmActiviteit { get; set; }
    }
}
