using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Incident
    {
        public Incident()
        {
            BestelaanvraagIncidentLink = new HashSet<BestelaanvraagIncidentLink>();
            Campaignmailinginvitation = new HashSet<Campaignmailinginvitation>();
            Change = new HashSet<Change>();
            ChangeIncCausedbyLink = new HashSet<ChangeIncCausedbyLink>();
            ChangeIncidentLink = new HashSet<ChangeIncidentLink>();
            IncidentDocumenten = new HashSet<IncidentDocumenten>();
            IncidentEmailberichten = new HashSet<IncidentEmailberichten>();
            IncidentLogboek = new HashSet<IncidentLogboek>();
            IncidentMemogeschiedenis = new HashSet<IncidentMemogeschiedenis>();
            Incidentkennissysteemlink = new HashSet<Incidentkennissysteemlink>();
            InverseIncidentNavigation = new HashSet<Incident>();
            InverseMajorincident = new HashSet<Incident>();
            KostendeclaratieArtikel = new HashSet<KostendeclaratieArtikel>();
            KostendeclaratieObject = new HashSet<KostendeclaratieObject>();
            MeetingIncidentLink = new HashSet<MeetingIncidentLink>();
            MutatieIncident = new HashSet<MutatieIncident>();
            ObjIncidentLink = new HashSet<ObjIncidentLink>();
            OmActiviteitIncidentLink = new HashSet<OmActiviteitIncidentLink>();
            PersoonIncidentLink = new HashSet<PersoonIncidentLink>();
            Probleemincidentlink = new HashSet<Probleemincidentlink>();
            ProfacboomProjectIncidentLink = new HashSet<ProfacboomProjectIncidentLink>();
            TimeRegistrationIncident = new HashSet<TimeRegistrationIncident>();
        }

        public Guid? Aanmelderafdelingid { get; set; }
        public Guid? Aanmelderbudgethouderid { get; set; }
        public Guid? Aanmelderlokatieid { get; set; }
        public string Aanmeldertelefoon { get; set; }
        public Guid? Aanmeldervestigingid { get; set; }
        public string Actie { get; set; }
        public Guid? Actiedoorid { get; set; }
        public bool Afgemeld { get; set; }
        public Guid? Afhandelingstatusid { get; set; }
        public Guid? Archiefredenid { get; set; }
        public bool Bewaakt { get; set; }
        public Guid? Configuratieid { get; set; }
        public Guid? Configuratieobjectid { get; set; }
        public int Deelactievolgnummer { get; set; }
        public Guid? Deescalatieredenid { get; set; }
        public bool Dnogebruikt { get; set; }
        public Guid? Dnoid { get; set; }
        public Guid? Doorlooptijdid { get; set; }
        public int Emailstatus { get; set; }
        public Guid? Escalatieredenid { get; set; }
        public bool Gedeescaleerd { get; set; }
        public bool Geescaleerd { get; set; }
        public bool Gereed { get; set; }
        public Guid? Impactid { get; set; }
        public Guid? IncidentDomeinid { get; set; }
        public Guid? IncidentSpecid { get; set; }
        public Guid? Incidentid { get; set; }
        public Guid? Lijn1actiedoorid { get; set; }
        public Guid? Oplosmethodeid { get; set; }
        public Guid? Persoonid { get; set; }
        public string RefConfiguratie { get; set; }
        public Guid? RefDnocontractid { get; set; }
        public Guid? RefDnodienstid { get; set; }
        public string RefDomein { get; set; }
        public string RefPersnr { get; set; }
        public string RefSpecificatie { get; set; }
        public string RefVestiging { get; set; }
        public Guid? Soortbinnenkomstid { get; set; }
        public Guid? Soortmeldingid { get; set; }
        public int Status { get; set; }
        public Guid? Uidaanmk { get; set; }
        public Guid? Uidwijzig { get; set; }
        public Guid Unid { get; set; }
        public string Verzoek { get; set; }
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
        public string RefDebnummer { get; set; }
        public DateTime? Dataanmk { get; set; }
        public DateTime? Datumaangemeld { get; set; }
        public DateTime? Datumafgemeld { get; set; }
        public DateTime? Datumafspraak { get; set; }
        public DateTime? Datumgereed { get; set; }
        public DateTime? Datwijzig { get; set; }
        public DateTime? Vrijedatum1 { get; set; }
        public DateTime? Vrijedatum2 { get; set; }
        public long Lijn1tijdbesteed { get; set; }
        public decimal Onkosten { get; set; }
        public long Tijdbesteed { get; set; }
        public decimal Totaleonkosten { get; set; }
        public long Totaletijd { get; set; }
        public long Verwtijdbesteed { get; set; }
        public long Minutendoorlooptijd { get; set; }
        public Guid? Extraaid { get; set; }
        public Guid? Extrabid { get; set; }
        public int Dnostatus { get; set; }
        public string Korteomschrijving { get; set; }
        public DateTime? Datumafspraaksla { get; set; }
        public Guid? Oplossingid { get; set; }
        public Guid? Locatieid { get; set; }
        public Guid? Vestigingid { get; set; }
        public int Betreftkeuze { get; set; }
        public Guid? Operatorid { get; set; }
        public string Naam { get; set; }
        public Guid? Extraapersoonid { get; set; }
        public Guid? Extrabpersoonid { get; set; }
        public bool Ismajorincident { get; set; }
        public Guid? Majorincidentid { get; set; }
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
        public Guid Servicewindowid { get; set; }
        public decimal KostenArtikelen { get; set; }
        public decimal KostenObjecten { get; set; }
        public string Externnummer { get; set; }
        public string Aanmelderemail { get; set; }
        public string RefObject { get; set; }
        public bool Onhold { get; set; }
        public long Onholdduration { get; set; }
        public Guid? Operatorgroupid { get; set; }
        public Guid? Escalationoperatorid { get; set; }
        public DateTime? Onholddatum { get; set; }
        public Guid? Urgencyid { get; set; }
        public Guid? Priorityid { get; set; }
        public string Bespokememo { get; set; }
        public int Importtype { get; set; }
        public Guid? Supplierid { get; set; }
        public string Importid { get; set; }
        public DateTime? Importdate { get; set; }
        public bool Savedinsecure { get; set; }
        public int RefMainIncidentStatus { get; set; }
        public string RefMainIncidentBf { get; set; }
        public string RefMainIncidentName { get; set; }
        public Guid? Appointmentid { get; set; }
        public string Aanmeldernaam { get; set; }
        public string RefEscalationoperator { get; set; }
        public string RefOperatordynanaam { get; set; }
        public string RefOperatorgroup { get; set; }
        public long Resolvedduration { get; set; }
        public long Adjusteddurationonhold { get; set; }
        public long Adjusteddurationresolved { get; set; }
        public string RefImpact { get; set; }
        public string RefSoortmelding { get; set; }
        public string RefStatus { get; set; }
        public Guid? RefServicelevelid { get; set; }
        public Guid? Supplierserviceid { get; set; }
        public string RefProgresstrail { get; set; }

        public Afdeling Aanmelderafdeling { get; set; }
        public Budgethouder Aanmelderbudgethouder { get; set; }
        public Locatie Aanmelderlokatie { get; set; }
        public Vestiging Aanmeldervestiging { get; set; }
        public Actiedoor Actiedoor { get; set; }
        public Afhandelingstatus Afhandelingstatus { get; set; }
        public Appointment Appointment { get; set; }
        public Archiefreden Archiefreden { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek1Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek2Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek3Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek4Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek5Navigation { get; set; }
        public Configuratie Configuratie { get; set; }
        public Object Configuratieobject { get; set; }
        public Escalatiereden Deescalatiereden { get; set; }
        public Dnolink Dno { get; set; }
        public Doorlooptijd Doorlooptijd { get; set; }
        public Escalatiereden Escalatiereden { get; set; }
        public Actiedoor Escalationoperator { get; set; }
        public Extraa Extraa { get; set; }
        public Extraapersoon Extraapersoon { get; set; }
        public Extrab Extrab { get; set; }
        public Extrabpersoon Extrabpersoon { get; set; }
        public Impact Impact { get; set; }
        public Classificatie IncidentDomein { get; set; }
        public Incident IncidentNavigation { get; set; }
        public Classificatie IncidentSpec { get; set; }
        public Actiedoor Lijn1actiedoor { get; set; }
        public Locatie Locatie { get; set; }
        public Incident Majorincident { get; set; }
        public Actiedoor Operator { get; set; }
        public Actiedoor Operatorgroup { get; set; }
        public Oplossingsmethode Oplosmethode { get; set; }
        public Oplossingen Oplossing { get; set; }
        public Persoon Persoon { get; set; }
        public Priority Priority { get; set; }
        public Dnocontract RefDnocontract { get; set; }
        public Dnodienst RefDnodienst { get; set; }
        public Servicelevel RefServicelevel { get; set; }
        public Servicewindow Servicewindow { get; set; }
        public Soortbinnenkomst Soortbinnenkomst { get; set; }
        public Soortmelding Soortmelding { get; set; }
        public Leverancier Supplier { get; set; }
        public Dnodienst Supplierservice { get; set; }
        public Gebruiker UidaanmkNavigation { get; set; }
        public Gebruiker UidwijzigNavigation { get; set; }
        public Urgency Urgency { get; set; }
        public Vestiging Vestiging { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek1Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek2Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek3Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek4Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek5Navigation { get; set; }
        public ICollection<BestelaanvraagIncidentLink> BestelaanvraagIncidentLink { get; set; }
        public ICollection<Campaignmailinginvitation> Campaignmailinginvitation { get; set; }
        public ICollection<Change> Change { get; set; }
        public ICollection<ChangeIncCausedbyLink> ChangeIncCausedbyLink { get; set; }
        public ICollection<ChangeIncidentLink> ChangeIncidentLink { get; set; }
        public ICollection<IncidentDocumenten> IncidentDocumenten { get; set; }
        public ICollection<IncidentEmailberichten> IncidentEmailberichten { get; set; }
        public ICollection<IncidentLogboek> IncidentLogboek { get; set; }
        public ICollection<IncidentMemogeschiedenis> IncidentMemogeschiedenis { get; set; }
        public ICollection<Incidentkennissysteemlink> Incidentkennissysteemlink { get; set; }
        public ICollection<Incident> InverseIncidentNavigation { get; set; }
        public ICollection<Incident> InverseMajorincident { get; set; }
        public ICollection<KostendeclaratieArtikel> KostendeclaratieArtikel { get; set; }
        public ICollection<KostendeclaratieObject> KostendeclaratieObject { get; set; }
        public ICollection<MeetingIncidentLink> MeetingIncidentLink { get; set; }
        public ICollection<MutatieIncident> MutatieIncident { get; set; }
        public ICollection<ObjIncidentLink> ObjIncidentLink { get; set; }
        public ICollection<OmActiviteitIncidentLink> OmActiviteitIncidentLink { get; set; }
        public ICollection<PersoonIncidentLink> PersoonIncidentLink { get; set; }
        public ICollection<Probleemincidentlink> Probleemincidentlink { get; set; }
        public ICollection<ProfacboomProjectIncidentLink> ProfacboomProjectIncidentLink { get; set; }
        public ICollection<TimeRegistrationIncident> TimeRegistrationIncident { get; set; }
    }
}
