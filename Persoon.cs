using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Persoon
    {
        public Persoon()
        {
            ActiedoorDocumenten = new HashSet<ActiedoorDocumenten>();
            ActiedoorLogboek = new HashSet<ActiedoorLogboek>();
            ActiedoorMemoHistory = new HashSet<ActiedoorMemoHistory>();
            Appointment = new HashSet<Appointment>();
            AppointmentDocumenten = new HashSet<AppointmentDocumenten>();
            AppointmentLogboek = new HashSet<AppointmentLogboek>();
            BestelaanvraagAanvrager = new HashSet<Bestelaanvraag>();
            BestelaanvraagDocumenten = new HashSet<BestelaanvraagDocumenten>();
            BestelaanvraagLogboek = new HashSet<BestelaanvraagLogboek>();
            BestelaanvraagPersoon = new HashSet<Bestelaanvraag>();
            BestellingenDocumenten = new HashSet<BestellingenDocumenten>();
            BestellingenLogboek = new HashSet<BestellingenLogboek>();
            BestellingenVestigingcontactpersoon = new HashSet<Bestellingen>();
            BestellingenVestigingcontactpersoonid2Navigation = new HashSet<Bestellingen>();
            Bezoeker = new HashSet<Bezoeker>();
            BezoekerDocumenten = new HashSet<BezoekerDocumenten>();
            BezoekerLogboek = new HashSet<BezoekerLogboek>();
            BezoekerMemoHistory = new HashSet<BezoekerMemoHistory>();
            BranchMeasurement = new HashSet<BranchMeasurement>();
            CampaignDocumenten = new HashSet<CampaignDocumenten>();
            CampaignLogboek = new HashSet<CampaignLogboek>();
            CampaignMemoHistory = new HashSet<CampaignMemoHistory>();
            CampaignmailingDocumenten = new HashSet<CampaignmailingDocumenten>();
            CampaignmailingLogboek = new HashSet<CampaignmailingLogboek>();
            CampaignmailingMemoHistory = new HashSet<CampaignmailingMemoHistory>();
            Campaignmailinginvitation = new HashSet<Campaignmailinginvitation>();
            ChangeActivitytemplate = new HashSet<ChangeActivitytemplate>();
            ChangeActivitytemplateDocumenten = new HashSet<ChangeActivitytemplateDocumenten>();
            ChangeActivitytemplateDocuments = new HashSet<ChangeActivitytemplateDocuments>();
            ChangeActivitytemplateLogboek = new HashSet<ChangeActivitytemplateLogboek>();
            ChangeActivitytemplateMemoHistory = new HashSet<ChangeActivitytemplateMemoHistory>();
            ChangeCanceledbyperson = new HashSet<Change>();
            ChangeDocumenten = new HashSet<ChangeDocumenten>();
            ChangeEvalAuthperson = new HashSet<Change>();
            ChangeLogboek = new HashSet<ChangeLogboek>();
            ChangeMemoHistory = new HashSet<ChangeMemoHistory>();
            ChangePersonLink = new HashSet<ChangePersonLink>();
            ChangePersoon = new HashSet<Change>();
            ChangeProAuthperson = new HashSet<Change>();
            ChangeReqAuthperson = new HashSet<Change>();
            ChangeTemplateDocumenten = new HashSet<ChangeTemplateDocumenten>();
            ChangeTemplateDocuments = new HashSet<ChangeTemplateDocuments>();
            ChangeTemplateEvalAuthperson = new HashSet<ChangeTemplate>();
            ChangeTemplateLogboek = new HashSet<ChangeTemplateLogboek>();
            ChangeTemplateMemoHistory = new HashSet<ChangeTemplateMemoHistory>();
            ChangeTemplateProAuthperson = new HashSet<ChangeTemplate>();
            ChangeTemplateReqAuthperson = new HashSet<ChangeTemplate>();
            Changeactivity = new HashSet<Changeactivity>();
            ChangeactivityDocumenten = new HashSet<ChangeactivityDocumenten>();
            ChangeactivityLogboek = new HashSet<ChangeactivityLogboek>();
            ChangeactivityMemoHistory = new HashSet<ChangeactivityMemoHistory>();
            Changeauthorization = new HashSet<Changeauthorization>();
            ChangeversionDocumenten = new HashSet<ChangeversionDocumenten>();
            ChangeversionLogboek = new HashSet<ChangeversionLogboek>();
            ChangeversionMemoHistory = new HashSet<ChangeversionMemoHistory>();
            Configuratie = new HashSet<Configuratie>();
            ConfiguratieDocumenten = new HashSet<ConfiguratieDocumenten>();
            ConfiguratieLogboek = new HashSet<ConfiguratieLogboek>();
            ConfiguratieMemoHistory = new HashSet<ConfiguratieMemoHistory>();
            DnocontractDocumenten = new HashSet<DnocontractDocumenten>();
            DnocontractLogboek = new HashSet<DnocontractLogboek>();
            DnocontractMemoHistory = new HashSet<DnocontractMemoHistory>();
            DnodienstDocumenten = new HashSet<DnodienstDocumenten>();
            DnodienstLogboek = new HashSet<DnodienstLogboek>();
            DnodienstMemoHistory = new HashSet<DnodienstMemoHistory>();
            GebruikerDocumenten = new HashSet<GebruikerDocumenten>();
            GebruikerLogboek = new HashSet<GebruikerLogboek>();
            GebruikerMemoHistory = new HashSet<GebruikerMemoHistory>();
            Hardware = new HashSet<Hardware>();
            HardwareDocumenten = new HashSet<HardwareDocumenten>();
            HardwareLogboek = new HashSet<HardwareLogboek>();
            Incident = new HashSet<Incident>();
            IncidentDocumenten = new HashSet<IncidentDocumenten>();
            IncidentLogboek = new HashSet<IncidentLogboek>();
            IncidentMemogeschiedenis = new HashSet<IncidentMemogeschiedenis>();
            Inventaris = new HashSet<Inventaris>();
            InventarisDocumenten = new HashSet<InventarisDocumenten>();
            InventarisLogboek = new HashSet<InventarisLogboek>();
            InverseManager = new HashSet<Persoon>();
            KennisSysteemDocumenten = new HashSet<KennisSysteemDocumenten>();
            Kennissysteemreactie = new HashSet<Kennissysteemreactie>();
            LeverancierDocumenten = new HashSet<LeverancierDocumenten>();
            LeverancierLogboek = new HashSet<LeverancierLogboek>();
            LeverancierMemoHistory = new HashSet<LeverancierMemoHistory>();
            LeveranciercontactpersoonDocumenten = new HashSet<LeveranciercontactpersoonDocumenten>();
            LeveranciercontactpersoonLogboek = new HashSet<LeveranciercontactpersoonLogboek>();
            LicentieDocumenten = new HashSet<LicentieDocumenten>();
            LicentieLogboek = new HashSet<LicentieLogboek>();
            LmpactivityDocumenten = new HashSet<LmpactivityDocumenten>();
            LmpactivityLogboek = new HashSet<LmpactivityLogboek>();
            LmpactivityMemoHistory = new HashSet<LmpactivityMemoHistory>();
            LmpscenarioDocumenten = new HashSet<LmpscenarioDocumenten>();
            LmpscenarioLogboek = new HashSet<LmpscenarioLogboek>();
            LmpscenarioMemoHistory = new HashSet<LmpscenarioMemoHistory>();
            LocatieDocumenten = new HashSet<LocatieDocumenten>();
            LocatieLogboek = new HashSet<LocatieLogboek>();
            LocatieMemoHistory = new HashSet<LocatieMemoHistory>();
            Mailactiebestand = new HashSet<Mailactiebestand>();
            MeetingDocumenten = new HashSet<MeetingDocumenten>();
            MeetingLogboek = new HashSet<MeetingLogboek>();
            MeetingMemoHistory = new HashSet<MeetingMemoHistory>();
            MeetingPersonLink = new HashSet<MeetingPersonLink>();
            MutatieChangeMutEvalAuthperson = new HashSet<MutatieChange>();
            MutatieChangeMutProAuthperson = new HashSet<MutatieChange>();
            MutatieChangeMutReqAuthperson = new HashSet<MutatieChange>();
            MutatieChangeactivity = new HashSet<MutatieChangeactivity>();
            MutatieConfiguratie = new HashSet<MutatieConfiguratie>();
            MutatieHardware = new HashSet<MutatieHardware>();
            MutatieInventaris = new HashSet<MutatieInventaris>();
            MutatieNetwerkcomponent = new HashSet<MutatieNetwerkcomponent>();
            MutatieSoftware = new HashSet<MutatieSoftware>();
            MutatieTelefonie = new HashSet<MutatieTelefonie>();
            MutatieVrij1object = new HashSet<MutatieVrij1object>();
            MutatieVrij2object = new HashSet<MutatieVrij2object>();
            MutatieVrij3object = new HashSet<MutatieVrij3object>();
            MutatieVrij4object = new HashSet<MutatieVrij4object>();
            MutatieVrij5object = new HashSet<MutatieVrij5object>();
            Netwerkcomponent = new HashSet<Netwerkcomponent>();
            NetwerkcomponentDocumenten = new HashSet<NetwerkcomponentDocumenten>();
            NetwerkcomponentLogboek = new HashSet<NetwerkcomponentLogboek>();
            ObjConfLink = new HashSet<ObjConfLink>();
            ObjPersoonLink = new HashSet<ObjPersoonLink>();
            Object = new HashSet<Object>();
            OmActiviteitDocumenten = new HashSet<OmActiviteitDocumenten>();
            OmActiviteitLogboek = new HashSet<OmActiviteitLogboek>();
            OmActiviteitMemoHistory = new HashSet<OmActiviteitMemoHistory>();
            OmReeksDocumenten = new HashSet<OmReeksDocumenten>();
            OmReeksLogboek = new HashSet<OmReeksLogboek>();
            OmReeksMemoHistory = new HashSet<OmReeksMemoHistory>();
            OmSchemaDocumenten = new HashSet<OmSchemaDocumenten>();
            OmSchemaLogboek = new HashSet<OmSchemaLogboek>();
            OmSchemaMemoHistory = new HashSet<OmSchemaMemoHistory>();
            OplossingenDocumenten = new HashSet<OplossingenDocumenten>();
            OplossingenLogboek = new HashSet<OplossingenLogboek>();
            PersoonDocumentenKaart = new HashSet<PersoonDocumenten>();
            PersoonDocumentenPersoon = new HashSet<PersoonDocumenten>();
            PersoonEmailberichten = new HashSet<PersoonEmailberichten>();
            PersoonIncidentLink = new HashSet<PersoonIncidentLink>();
            PersoonLogboekKaart = new HashSet<PersoonLogboek>();
            PersoonLogboekPersoon = new HashSet<PersoonLogboek>();
            PersoonMemoHistoryParent = new HashSet<PersoonMemoHistory>();
            PersoonMemoHistoryPersoon = new HashSet<PersoonMemoHistory>();
            PersoonOptionalgrid = new HashSet<PersoonOptionalgrid>();
            PersoonPicture = new HashSet<PersoonPicture>();
            Persoongroep = new HashSet<Persoongroep>();
            PersoongroepDocumenten = new HashSet<PersoongroepDocumenten>();
            PersoongroepLogboek = new HashSet<PersoongroepLogboek>();
            PersoongroepMemoHistory = new HashSet<PersoongroepMemoHistory>();
            Persoonlink = new HashSet<Persoonlink>();
            PoortDocumenten = new HashSet<PoortDocumenten>();
            PoortLogboek = new HashSet<PoortLogboek>();
            ProbleemDocumenten = new HashSet<ProbleemDocumenten>();
            ProbleemLogboek = new HashSet<ProbleemLogboek>();
            ProbleemMemogeschiedenis = new HashSet<ProbleemMemogeschiedenis>();
            ProfacboomProjectDocumenten = new HashSet<ProfacboomProjectDocumenten>();
            ProfacboomProjectLogboek = new HashSet<ProfacboomProjectLogboek>();
            ProfacboomProjectMemoHistory = new HashSet<ProfacboomProjectMemoHistory>();
            ProfacboomProjectPersonLink = new HashSet<ProfacboomProjectPersonLink>();
            ReportactionDocumenten = new HashSet<ReportactionDocumenten>();
            ReportactionLogboek = new HashSet<ReportactionLogboek>();
            ReportactionPersonLink = new HashSet<ReportactionPersonLink>();
            ReservationDocumenten = new HashSet<ReservationDocumenten>();
            ReservationEventDocumenten = new HashSet<ReservationEventDocumenten>();
            ReservationEventRequester = new HashSet<ReservationEvent>();
            ReservationEventReservedforperson = new HashSet<ReservationEvent>();
            ReservationLogboek = new HashSet<ReservationLogboek>();
            ReservationMemoHistory = new HashSet<ReservationMemoHistory>();
            ReservationPersonLink = new HashSet<ReservationPersonLink>();
            ReservationRequester = new HashSet<Reservation>();
            ReservationReservedforperson = new HashSet<Reservation>();
            Reservering = new HashSet<Reservering>();
            ReserveringDocumenten = new HashSet<ReserveringDocumenten>();
            ReserveringLogboek = new HashSet<ReserveringLogboek>();
            ReserveringPersoonLink = new HashSet<ReserveringPersoonLink>();
            ReserveringVoorzieningLinkDocumenten = new HashSet<ReserveringVoorzieningLinkDocumenten>();
            ReserveringVoorzieningLinkLogboek = new HashSet<ReserveringVoorzieningLinkLogboek>();
            ServicelevelDocumenten = new HashSet<ServicelevelDocumenten>();
            ServicelevelLogboek = new HashSet<ServicelevelLogboek>();
            ServicelevelMemoHistory = new HashSet<ServicelevelMemoHistory>();
            ServicewindowDocumenten = new HashSet<ServicewindowDocumenten>();
            ServicewindowLogboek = new HashSet<ServicewindowLogboek>();
            ServicewindowMemoHistory = new HashSet<ServicewindowMemoHistory>();
            Settings = new HashSet<Settings>();
            Software = new HashSet<Software>();
            SoftwareDocumenten = new HashSet<SoftwareDocumenten>();
            SoftwareLogboek = new HashSet<SoftwareLogboek>();
            SuppliercontactMemoHistory = new HashSet<SuppliercontactMemoHistory>();
            SurveyDocumenten = new HashSet<SurveyDocumenten>();
            SurveyLogboek = new HashSet<SurveyLogboek>();
            SurveyMemoHistory = new HashSet<SurveyMemoHistory>();
            SurveyquestionDocumenten = new HashSet<SurveyquestionDocumenten>();
            SurveyquestionLogboek = new HashSet<SurveyquestionLogboek>();
            SurveyquestionMemoHistory = new HashSet<SurveyquestionMemoHistory>();
            SystemeventsDocumenten = new HashSet<SystemeventsDocumenten>();
            SystemeventsLogboek = new HashSet<SystemeventsLogboek>();
            Telefonie = new HashSet<Telefonie>();
            TelefonieDocumenten = new HashSet<TelefonieDocumenten>();
            TelefonieLogboek = new HashSet<TelefonieLogboek>();
            VestigingDocumenten = new HashSet<VestigingDocumenten>();
            VestigingLogboek = new HashSet<VestigingLogboek>();
            VestigingMemoHistory = new HashSet<VestigingMemoHistory>();
            VestigingNavigation = new HashSet<Vestiging>();
            VoorzieningDocumenten = new HashSet<VoorzieningDocumenten>();
            VoorzieningLogboek = new HashSet<VoorzieningLogboek>();
            Vrij1object = new HashSet<Vrij1object>();
            Vrij1objectDocumenten = new HashSet<Vrij1objectDocumenten>();
            Vrij1objectLogboek = new HashSet<Vrij1objectLogboek>();
            Vrij2object = new HashSet<Vrij2object>();
            Vrij2objectDocumenten = new HashSet<Vrij2objectDocumenten>();
            Vrij2objectLogboek = new HashSet<Vrij2objectLogboek>();
            Vrij3object = new HashSet<Vrij3object>();
            Vrij3objectDocumenten = new HashSet<Vrij3objectDocumenten>();
            Vrij3objectLogboek = new HashSet<Vrij3objectLogboek>();
            Vrij4object = new HashSet<Vrij4object>();
            Vrij4objectDocumenten = new HashSet<Vrij4objectDocumenten>();
            Vrij4objectLogboek = new HashSet<Vrij4objectLogboek>();
            Vrij5object = new HashSet<Vrij5object>();
            Vrij5objectDocumenten = new HashSet<Vrij5objectDocumenten>();
            Vrij5objectLogboek = new HashSet<Vrij5objectLogboek>();
        }

        public string Aantekeningen { get; set; }
        public string Adresmemo { get; set; }
        public bool Afdelingbekijken { get; set; }
        public Guid? Afdelingid { get; set; }
        public Guid? Archiefredenid { get; set; }
        public Guid? Attentieid { get; set; }
        public bool Budgethouderbekijken { get; set; }
        public Guid? Budgethouderid { get; set; }
        public string Diversen { get; set; }
        public int Externtoegevoegd { get; set; }
        public string Fax { get; set; }
        public int Geslacht { get; set; }
        public bool Heeftattentie { get; set; }
        public string Importid { get; set; }
        public int Importtype { get; set; }
        public string Kamer { get; set; }
        public Guid? Landid { get; set; }
        public Guid? Lokatieid { get; set; }
        public string Mobiel { get; set; }
        public string Opmerking { get; set; }
        public string Personeelsnr { get; set; }
        public string Plaats { get; set; }
        public string Postcode { get; set; }
        public string Privefax { get; set; }
        public string Privemobieltel { get; set; }
        public string Privetel1 { get; set; }
        public string Privetel2 { get; set; }
        public int RefKleur { get; set; }
        public string RefPlaats1 { get; set; }
        public string RefVestiging { get; set; }
        public int Status { get; set; }
        public string Straat { get; set; }
        public int Tasstatus { get; set; }
        public string Telefoon { get; set; }
        public string Tussenvoegsel { get; set; }
        public Guid? Uidaanmk { get; set; }
        public Guid? Uidwijzig { get; set; }
        public Guid Unid { get; set; }
        public bool Vestigingbekijken { get; set; }
        public Guid? Vestigingid { get; set; }
        public string Voorletters { get; set; }
        public string Voornaam { get; set; }
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
        public string Email { get; set; }
        public string Priveemail { get; set; }
        public DateTime? Dataanmk { get; set; }
        public DateTime? Datwijzig { get; set; }
        public DateTime? Geboortedatum { get; set; }
        public DateTime? Vrijedatum1 { get; set; }
        public DateTime? Vrijedatum2 { get; set; }
        public string Achternaam { get; set; }
        public bool Ismanager { get; set; }
        public Guid? Managerid { get; set; }
        public string Personeeli { get; set; }
        public Guid? Extraapersoonid { get; set; }
        public Guid? Extrabpersoonid { get; set; }
        public DateTime? Importdate { get; set; }
        public string RefAanhefformeel { get; set; }
        public string RefAanhefinformeel { get; set; }
        public bool Dochtervestigingbekijken { get; set; }
        public string Tasloginnaam { get; set; }
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
        public string RefLocatie { get; set; }
        public string Huisnummer { get; set; }
        public string Bespokememo { get; set; }
        public bool MayAuthorizeBudgetholder { get; set; }
        public bool MayAuthorizeDepartment { get; set; }
        public bool MayAuthorizeSite { get; set; }
        public bool MayAuthorizeSubsidiarySites { get; set; }
        public bool MayAuthorizeAll { get; set; }
        public string Titel { get; set; }
        public string SocialSecurityNumber { get; set; }
        public string Afdelingvrijenaam { get; set; }
        public string Functie { get; set; }
        public string Loginnaammainframe { get; set; }
        public string Loginnaamnetwerk { get; set; }
        public string RefDynanaam { get; set; }
        public string RefAfdeling { get; set; }
        public string RefBudgethouder { get; set; }
        public string County { get; set; }
        public string MaidenName { get; set; }
        public Guid? LanguageId { get; set; }
        public Guid? IdTypeId { get; set; }
        public string IdNumber { get; set; }
        public DateTime? IdIssueDate { get; set; }
        public DateTime? IdExpiryDate { get; set; }
        public string IdIssuePlace { get; set; }
        public Guid? IdIssueCountryId { get; set; }
        public string BankAccount { get; set; }
        public string BirthPlace { get; set; }
        public Guid? OriginCountryId { get; set; }
        public Guid? NationalityId { get; set; }
        public string EmergencyContactName { get; set; }
        public string EmergencyContactRelation { get; set; }
        public string EmergencyContactPhone { get; set; }
        public DateTime? HireDate { get; set; }
        public DateTime? ServiceDate { get; set; }
        public DateTime? ContractStartDate { get; set; }
        public DateTime? ContractExpiryDate { get; set; }
        public DateTime? EndProbationPeriod { get; set; }
        public Guid? ContractTypeId { get; set; }
        public int? ContractHours { get; set; }
        public Guid? SalaryScaleId { get; set; }
        public decimal GrossSalary { get; set; }
        public int? VacationDays { get; set; }
        public Guid? CollectiveAgreementId { get; set; }
        public string PensionRegistrationNumber { get; set; }
        public Guid? HighestEducationId { get; set; }
        public bool HasTravelAllowance { get; set; }
        public Guid? TravelAllowanceTypeId { get; set; }
        public decimal TravelAllowance { get; set; }
        public int? WorkDistance { get; set; }
        public bool HasLeaseCar { get; set; }
        public decimal LeaseCarBudget { get; set; }
        public string ExpenseAllowance { get; set; }
        public string RepresentationAllowance { get; set; }
        public string HotelAllowance { get; set; }
        public string OtherBenefits { get; set; }
        public string Taspasshash { get; set; }

        public Afdeling Afdeling { get; set; }
        public Archiefreden Archiefreden { get; set; }
        public Attentie Attentie { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek1Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek2Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek3Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek4Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek5Navigation { get; set; }
        public Budgethouder Budgethouder { get; set; }
        public Collectiveagreement CollectiveAgreement { get; set; }
        public Contracttype ContractType { get; set; }
        public Extraapersoon Extraapersoon { get; set; }
        public Extrabpersoon Extrabpersoon { get; set; }
        public Highesteducation HighestEducation { get; set; }
        public Land IdIssueCountry { get; set; }
        public Idtype IdType { get; set; }
        public Land Land { get; set; }
        public Kennistaal Language { get; set; }
        public Locatie Lokatie { get; set; }
        public Persoon Manager { get; set; }
        public Nationality Nationality { get; set; }
        public Land OriginCountry { get; set; }
        public Salaryscale SalaryScale { get; set; }
        public Travelallowancetype TravelAllowanceType { get; set; }
        public Gebruiker UidaanmkNavigation { get; set; }
        public Gebruiker UidwijzigNavigation { get; set; }
        public Vestiging Vestiging { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek1Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek2Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek3Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek4Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek5Navigation { get; set; }
        public ICollection<ActiedoorDocumenten> ActiedoorDocumenten { get; set; }
        public ICollection<ActiedoorLogboek> ActiedoorLogboek { get; set; }
        public ICollection<ActiedoorMemoHistory> ActiedoorMemoHistory { get; set; }
        public ICollection<Appointment> Appointment { get; set; }
        public ICollection<AppointmentDocumenten> AppointmentDocumenten { get; set; }
        public ICollection<AppointmentLogboek> AppointmentLogboek { get; set; }
        public ICollection<Bestelaanvraag> BestelaanvraagAanvrager { get; set; }
        public ICollection<BestelaanvraagDocumenten> BestelaanvraagDocumenten { get; set; }
        public ICollection<BestelaanvraagLogboek> BestelaanvraagLogboek { get; set; }
        public ICollection<Bestelaanvraag> BestelaanvraagPersoon { get; set; }
        public ICollection<BestellingenDocumenten> BestellingenDocumenten { get; set; }
        public ICollection<BestellingenLogboek> BestellingenLogboek { get; set; }
        public ICollection<Bestellingen> BestellingenVestigingcontactpersoon { get; set; }
        public ICollection<Bestellingen> BestellingenVestigingcontactpersoonid2Navigation { get; set; }
        public ICollection<Bezoeker> Bezoeker { get; set; }
        public ICollection<BezoekerDocumenten> BezoekerDocumenten { get; set; }
        public ICollection<BezoekerLogboek> BezoekerLogboek { get; set; }
        public ICollection<BezoekerMemoHistory> BezoekerMemoHistory { get; set; }
        public ICollection<BranchMeasurement> BranchMeasurement { get; set; }
        public ICollection<CampaignDocumenten> CampaignDocumenten { get; set; }
        public ICollection<CampaignLogboek> CampaignLogboek { get; set; }
        public ICollection<CampaignMemoHistory> CampaignMemoHistory { get; set; }
        public ICollection<CampaignmailingDocumenten> CampaignmailingDocumenten { get; set; }
        public ICollection<CampaignmailingLogboek> CampaignmailingLogboek { get; set; }
        public ICollection<CampaignmailingMemoHistory> CampaignmailingMemoHistory { get; set; }
        public ICollection<Campaignmailinginvitation> Campaignmailinginvitation { get; set; }
        public ICollection<ChangeActivitytemplate> ChangeActivitytemplate { get; set; }
        public ICollection<ChangeActivitytemplateDocumenten> ChangeActivitytemplateDocumenten { get; set; }
        public ICollection<ChangeActivitytemplateDocuments> ChangeActivitytemplateDocuments { get; set; }
        public ICollection<ChangeActivitytemplateLogboek> ChangeActivitytemplateLogboek { get; set; }
        public ICollection<ChangeActivitytemplateMemoHistory> ChangeActivitytemplateMemoHistory { get; set; }
        public ICollection<Change> ChangeCanceledbyperson { get; set; }
        public ICollection<ChangeDocumenten> ChangeDocumenten { get; set; }
        public ICollection<Change> ChangeEvalAuthperson { get; set; }
        public ICollection<ChangeLogboek> ChangeLogboek { get; set; }
        public ICollection<ChangeMemoHistory> ChangeMemoHistory { get; set; }
        public ICollection<ChangePersonLink> ChangePersonLink { get; set; }
        public ICollection<Change> ChangePersoon { get; set; }
        public ICollection<Change> ChangeProAuthperson { get; set; }
        public ICollection<Change> ChangeReqAuthperson { get; set; }
        public ICollection<ChangeTemplateDocumenten> ChangeTemplateDocumenten { get; set; }
        public ICollection<ChangeTemplateDocuments> ChangeTemplateDocuments { get; set; }
        public ICollection<ChangeTemplate> ChangeTemplateEvalAuthperson { get; set; }
        public ICollection<ChangeTemplateLogboek> ChangeTemplateLogboek { get; set; }
        public ICollection<ChangeTemplateMemoHistory> ChangeTemplateMemoHistory { get; set; }
        public ICollection<ChangeTemplate> ChangeTemplateProAuthperson { get; set; }
        public ICollection<ChangeTemplate> ChangeTemplateReqAuthperson { get; set; }
        public ICollection<Changeactivity> Changeactivity { get; set; }
        public ICollection<ChangeactivityDocumenten> ChangeactivityDocumenten { get; set; }
        public ICollection<ChangeactivityLogboek> ChangeactivityLogboek { get; set; }
        public ICollection<ChangeactivityMemoHistory> ChangeactivityMemoHistory { get; set; }
        public ICollection<Changeauthorization> Changeauthorization { get; set; }
        public ICollection<ChangeversionDocumenten> ChangeversionDocumenten { get; set; }
        public ICollection<ChangeversionLogboek> ChangeversionLogboek { get; set; }
        public ICollection<ChangeversionMemoHistory> ChangeversionMemoHistory { get; set; }
        public ICollection<Configuratie> Configuratie { get; set; }
        public ICollection<ConfiguratieDocumenten> ConfiguratieDocumenten { get; set; }
        public ICollection<ConfiguratieLogboek> ConfiguratieLogboek { get; set; }
        public ICollection<ConfiguratieMemoHistory> ConfiguratieMemoHistory { get; set; }
        public ICollection<DnocontractDocumenten> DnocontractDocumenten { get; set; }
        public ICollection<DnocontractLogboek> DnocontractLogboek { get; set; }
        public ICollection<DnocontractMemoHistory> DnocontractMemoHistory { get; set; }
        public ICollection<DnodienstDocumenten> DnodienstDocumenten { get; set; }
        public ICollection<DnodienstLogboek> DnodienstLogboek { get; set; }
        public ICollection<DnodienstMemoHistory> DnodienstMemoHistory { get; set; }
        public ICollection<GebruikerDocumenten> GebruikerDocumenten { get; set; }
        public ICollection<GebruikerLogboek> GebruikerLogboek { get; set; }
        public ICollection<GebruikerMemoHistory> GebruikerMemoHistory { get; set; }
        public ICollection<Hardware> Hardware { get; set; }
        public ICollection<HardwareDocumenten> HardwareDocumenten { get; set; }
        public ICollection<HardwareLogboek> HardwareLogboek { get; set; }
        public ICollection<Incident> Incident { get; set; }
        public ICollection<IncidentDocumenten> IncidentDocumenten { get; set; }
        public ICollection<IncidentLogboek> IncidentLogboek { get; set; }
        public ICollection<IncidentMemogeschiedenis> IncidentMemogeschiedenis { get; set; }
        public ICollection<Inventaris> Inventaris { get; set; }
        public ICollection<InventarisDocumenten> InventarisDocumenten { get; set; }
        public ICollection<InventarisLogboek> InventarisLogboek { get; set; }
        public ICollection<Persoon> InverseManager { get; set; }
        public ICollection<KennisSysteemDocumenten> KennisSysteemDocumenten { get; set; }
        public ICollection<Kennissysteemreactie> Kennissysteemreactie { get; set; }
        public ICollection<LeverancierDocumenten> LeverancierDocumenten { get; set; }
        public ICollection<LeverancierLogboek> LeverancierLogboek { get; set; }
        public ICollection<LeverancierMemoHistory> LeverancierMemoHistory { get; set; }
        public ICollection<LeveranciercontactpersoonDocumenten> LeveranciercontactpersoonDocumenten { get; set; }
        public ICollection<LeveranciercontactpersoonLogboek> LeveranciercontactpersoonLogboek { get; set; }
        public ICollection<LicentieDocumenten> LicentieDocumenten { get; set; }
        public ICollection<LicentieLogboek> LicentieLogboek { get; set; }
        public ICollection<LmpactivityDocumenten> LmpactivityDocumenten { get; set; }
        public ICollection<LmpactivityLogboek> LmpactivityLogboek { get; set; }
        public ICollection<LmpactivityMemoHistory> LmpactivityMemoHistory { get; set; }
        public ICollection<LmpscenarioDocumenten> LmpscenarioDocumenten { get; set; }
        public ICollection<LmpscenarioLogboek> LmpscenarioLogboek { get; set; }
        public ICollection<LmpscenarioMemoHistory> LmpscenarioMemoHistory { get; set; }
        public ICollection<LocatieDocumenten> LocatieDocumenten { get; set; }
        public ICollection<LocatieLogboek> LocatieLogboek { get; set; }
        public ICollection<LocatieMemoHistory> LocatieMemoHistory { get; set; }
        public ICollection<Mailactiebestand> Mailactiebestand { get; set; }
        public ICollection<MeetingDocumenten> MeetingDocumenten { get; set; }
        public ICollection<MeetingLogboek> MeetingLogboek { get; set; }
        public ICollection<MeetingMemoHistory> MeetingMemoHistory { get; set; }
        public ICollection<MeetingPersonLink> MeetingPersonLink { get; set; }
        public ICollection<MutatieChange> MutatieChangeMutEvalAuthperson { get; set; }
        public ICollection<MutatieChange> MutatieChangeMutProAuthperson { get; set; }
        public ICollection<MutatieChange> MutatieChangeMutReqAuthperson { get; set; }
        public ICollection<MutatieChangeactivity> MutatieChangeactivity { get; set; }
        public ICollection<MutatieConfiguratie> MutatieConfiguratie { get; set; }
        public ICollection<MutatieHardware> MutatieHardware { get; set; }
        public ICollection<MutatieInventaris> MutatieInventaris { get; set; }
        public ICollection<MutatieNetwerkcomponent> MutatieNetwerkcomponent { get; set; }
        public ICollection<MutatieSoftware> MutatieSoftware { get; set; }
        public ICollection<MutatieTelefonie> MutatieTelefonie { get; set; }
        public ICollection<MutatieVrij1object> MutatieVrij1object { get; set; }
        public ICollection<MutatieVrij2object> MutatieVrij2object { get; set; }
        public ICollection<MutatieVrij3object> MutatieVrij3object { get; set; }
        public ICollection<MutatieVrij4object> MutatieVrij4object { get; set; }
        public ICollection<MutatieVrij5object> MutatieVrij5object { get; set; }
        public ICollection<Netwerkcomponent> Netwerkcomponent { get; set; }
        public ICollection<NetwerkcomponentDocumenten> NetwerkcomponentDocumenten { get; set; }
        public ICollection<NetwerkcomponentLogboek> NetwerkcomponentLogboek { get; set; }
        public ICollection<ObjConfLink> ObjConfLink { get; set; }
        public ICollection<ObjPersoonLink> ObjPersoonLink { get; set; }
        public ICollection<Object> Object { get; set; }
        public ICollection<OmActiviteitDocumenten> OmActiviteitDocumenten { get; set; }
        public ICollection<OmActiviteitLogboek> OmActiviteitLogboek { get; set; }
        public ICollection<OmActiviteitMemoHistory> OmActiviteitMemoHistory { get; set; }
        public ICollection<OmReeksDocumenten> OmReeksDocumenten { get; set; }
        public ICollection<OmReeksLogboek> OmReeksLogboek { get; set; }
        public ICollection<OmReeksMemoHistory> OmReeksMemoHistory { get; set; }
        public ICollection<OmSchemaDocumenten> OmSchemaDocumenten { get; set; }
        public ICollection<OmSchemaLogboek> OmSchemaLogboek { get; set; }
        public ICollection<OmSchemaMemoHistory> OmSchemaMemoHistory { get; set; }
        public ICollection<OplossingenDocumenten> OplossingenDocumenten { get; set; }
        public ICollection<OplossingenLogboek> OplossingenLogboek { get; set; }
        public ICollection<PersoonDocumenten> PersoonDocumentenKaart { get; set; }
        public ICollection<PersoonDocumenten> PersoonDocumentenPersoon { get; set; }
        public ICollection<PersoonEmailberichten> PersoonEmailberichten { get; set; }
        public ICollection<PersoonIncidentLink> PersoonIncidentLink { get; set; }
        public ICollection<PersoonLogboek> PersoonLogboekKaart { get; set; }
        public ICollection<PersoonLogboek> PersoonLogboekPersoon { get; set; }
        public ICollection<PersoonMemoHistory> PersoonMemoHistoryParent { get; set; }
        public ICollection<PersoonMemoHistory> PersoonMemoHistoryPersoon { get; set; }
        public ICollection<PersoonOptionalgrid> PersoonOptionalgrid { get; set; }
        public ICollection<PersoonPicture> PersoonPicture { get; set; }
        public ICollection<Persoongroep> Persoongroep { get; set; }
        public ICollection<PersoongroepDocumenten> PersoongroepDocumenten { get; set; }
        public ICollection<PersoongroepLogboek> PersoongroepLogboek { get; set; }
        public ICollection<PersoongroepMemoHistory> PersoongroepMemoHistory { get; set; }
        public ICollection<Persoonlink> Persoonlink { get; set; }
        public ICollection<PoortDocumenten> PoortDocumenten { get; set; }
        public ICollection<PoortLogboek> PoortLogboek { get; set; }
        public ICollection<ProbleemDocumenten> ProbleemDocumenten { get; set; }
        public ICollection<ProbleemLogboek> ProbleemLogboek { get; set; }
        public ICollection<ProbleemMemogeschiedenis> ProbleemMemogeschiedenis { get; set; }
        public ICollection<ProfacboomProjectDocumenten> ProfacboomProjectDocumenten { get; set; }
        public ICollection<ProfacboomProjectLogboek> ProfacboomProjectLogboek { get; set; }
        public ICollection<ProfacboomProjectMemoHistory> ProfacboomProjectMemoHistory { get; set; }
        public ICollection<ProfacboomProjectPersonLink> ProfacboomProjectPersonLink { get; set; }
        public ICollection<ReportactionDocumenten> ReportactionDocumenten { get; set; }
        public ICollection<ReportactionLogboek> ReportactionLogboek { get; set; }
        public ICollection<ReportactionPersonLink> ReportactionPersonLink { get; set; }
        public ICollection<ReservationDocumenten> ReservationDocumenten { get; set; }
        public ICollection<ReservationEventDocumenten> ReservationEventDocumenten { get; set; }
        public ICollection<ReservationEvent> ReservationEventRequester { get; set; }
        public ICollection<ReservationEvent> ReservationEventReservedforperson { get; set; }
        public ICollection<ReservationLogboek> ReservationLogboek { get; set; }
        public ICollection<ReservationMemoHistory> ReservationMemoHistory { get; set; }
        public ICollection<ReservationPersonLink> ReservationPersonLink { get; set; }
        public ICollection<Reservation> ReservationRequester { get; set; }
        public ICollection<Reservation> ReservationReservedforperson { get; set; }
        public ICollection<Reservering> Reservering { get; set; }
        public ICollection<ReserveringDocumenten> ReserveringDocumenten { get; set; }
        public ICollection<ReserveringLogboek> ReserveringLogboek { get; set; }
        public ICollection<ReserveringPersoonLink> ReserveringPersoonLink { get; set; }
        public ICollection<ReserveringVoorzieningLinkDocumenten> ReserveringVoorzieningLinkDocumenten { get; set; }
        public ICollection<ReserveringVoorzieningLinkLogboek> ReserveringVoorzieningLinkLogboek { get; set; }
        public ICollection<ServicelevelDocumenten> ServicelevelDocumenten { get; set; }
        public ICollection<ServicelevelLogboek> ServicelevelLogboek { get; set; }
        public ICollection<ServicelevelMemoHistory> ServicelevelMemoHistory { get; set; }
        public ICollection<ServicewindowDocumenten> ServicewindowDocumenten { get; set; }
        public ICollection<ServicewindowLogboek> ServicewindowLogboek { get; set; }
        public ICollection<ServicewindowMemoHistory> ServicewindowMemoHistory { get; set; }
        public ICollection<Settings> Settings { get; set; }
        public ICollection<Software> Software { get; set; }
        public ICollection<SoftwareDocumenten> SoftwareDocumenten { get; set; }
        public ICollection<SoftwareLogboek> SoftwareLogboek { get; set; }
        public ICollection<SuppliercontactMemoHistory> SuppliercontactMemoHistory { get; set; }
        public ICollection<SurveyDocumenten> SurveyDocumenten { get; set; }
        public ICollection<SurveyLogboek> SurveyLogboek { get; set; }
        public ICollection<SurveyMemoHistory> SurveyMemoHistory { get; set; }
        public ICollection<SurveyquestionDocumenten> SurveyquestionDocumenten { get; set; }
        public ICollection<SurveyquestionLogboek> SurveyquestionLogboek { get; set; }
        public ICollection<SurveyquestionMemoHistory> SurveyquestionMemoHistory { get; set; }
        public ICollection<SystemeventsDocumenten> SystemeventsDocumenten { get; set; }
        public ICollection<SystemeventsLogboek> SystemeventsLogboek { get; set; }
        public ICollection<Telefonie> Telefonie { get; set; }
        public ICollection<TelefonieDocumenten> TelefonieDocumenten { get; set; }
        public ICollection<TelefonieLogboek> TelefonieLogboek { get; set; }
        public ICollection<VestigingDocumenten> VestigingDocumenten { get; set; }
        public ICollection<VestigingLogboek> VestigingLogboek { get; set; }
        public ICollection<VestigingMemoHistory> VestigingMemoHistory { get; set; }
        public ICollection<Vestiging> VestigingNavigation { get; set; }
        public ICollection<VoorzieningDocumenten> VoorzieningDocumenten { get; set; }
        public ICollection<VoorzieningLogboek> VoorzieningLogboek { get; set; }
        public ICollection<Vrij1object> Vrij1object { get; set; }
        public ICollection<Vrij1objectDocumenten> Vrij1objectDocumenten { get; set; }
        public ICollection<Vrij1objectLogboek> Vrij1objectLogboek { get; set; }
        public ICollection<Vrij2object> Vrij2object { get; set; }
        public ICollection<Vrij2objectDocumenten> Vrij2objectDocumenten { get; set; }
        public ICollection<Vrij2objectLogboek> Vrij2objectLogboek { get; set; }
        public ICollection<Vrij3object> Vrij3object { get; set; }
        public ICollection<Vrij3objectDocumenten> Vrij3objectDocumenten { get; set; }
        public ICollection<Vrij3objectLogboek> Vrij3objectLogboek { get; set; }
        public ICollection<Vrij4object> Vrij4object { get; set; }
        public ICollection<Vrij4objectDocumenten> Vrij4objectDocumenten { get; set; }
        public ICollection<Vrij4objectLogboek> Vrij4objectLogboek { get; set; }
        public ICollection<Vrij5object> Vrij5object { get; set; }
        public ICollection<Vrij5objectDocumenten> Vrij5objectDocumenten { get; set; }
        public ICollection<Vrij5objectLogboek> Vrij5objectLogboek { get; set; }
    }
}
