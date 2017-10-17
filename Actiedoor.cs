using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Actiedoor
    {
        public Actiedoor()
        {
            ActiedoorDocumenten = new HashSet<ActiedoorDocumenten>();
            ActiedoorEmailberichten = new HashSet<ActiedoorEmailberichten>();
            ActiedoorLogboek = new HashSet<ActiedoorLogboek>();
            ActiedoorMemoHistory = new HashSet<ActiedoorMemoHistory>();
            ActiedoorOptionalgrid = new HashSet<ActiedoorOptionalgrid>();
            ActiedoorPicture = new HashSet<ActiedoorPicture>();
            ActiedoorlinkActiedoor = new HashSet<Actiedoorlink>();
            ActiedoorlinkActiedoorgroep = new HashSet<Actiedoorlink>();
            Appliedshift = new HashSet<Appliedshift>();
            Appointment = new HashSet<Appointment>();
            Availabilitycheck = new HashSet<Availabilitycheck>();
            Bestelaanvraag = new HashSet<Bestelaanvraag>();
            BestellingenAfmeldautorisatie = new HashSet<Bestellingen>();
            BestellingenBehandelaar = new HashSet<Bestellingen>();
            BestellingenBestelautorisatie = new HashSet<Bestellingen>();
            BranchfilterOperator = new HashSet<BranchfilterOperator>();
            CategoryfilterOperator = new HashSet<CategoryfilterOperator>();
            ChangeActivitytemplateOperator = new HashSet<ChangeActivitytemplate>();
            ChangeActivitytemplateOperatorgroup = new HashSet<ChangeActivitytemplate>();
            ChangeCanceledbyoperator = new HashSet<Change>();
            ChangeEvalAuthoperator = new HashSet<Change>();
            ChangeManager = new HashSet<Change>();
            ChangeOperator = new HashSet<Change>();
            ChangeOperatorgroup = new HashSet<Change>();
            ChangeProAuthoperator = new HashSet<Change>();
            ChangeReqAuthoperator = new HashSet<Change>();
            ChangeTemplateEvalAuthoperator = new HashSet<ChangeTemplate>();
            ChangeTemplateManager = new HashSet<ChangeTemplate>();
            ChangeTemplateOperator = new HashSet<ChangeTemplate>();
            ChangeTemplateOperatorgroup = new HashSet<ChangeTemplate>();
            ChangeTemplateProAuthoperator = new HashSet<ChangeTemplate>();
            ChangeTemplateReqAuthoperator = new HashSet<ChangeTemplate>();
            ChangeactivityOperator = new HashSet<Changeactivity>();
            ChangeactivityOperatorgroup = new HashSet<Changeactivity>();
            Changeauthorization = new HashSet<Changeauthorization>();
            Changeversion = new HashSet<Changeversion>();
            ClassificatieChangeactivityNavigation = new HashSet<Classificatie>();
            ClassificatieChangeauthactivityNavigation = new HashSet<Classificatie>();
            ClassificatieChangecoordinatorNavigation = new HashSet<Classificatie>();
            ClassificatieLijn1actiedoor = new HashSet<Classificatie>();
            ClassificatieLijn2actiedoor = new HashSet<Classificatie>();
            ClassificatieProjectcoordinator = new HashSet<Classificatie>();
            ClassificatieProjectoperator = new HashSet<Classificatie>();
            ClassificatieSimplechangeNavigation = new HashSet<Classificatie>();
            ConversationsHide = new HashSet<ConversationsHide>();
            ConversationsLike = new HashSet<ConversationsLike>();
            ConversationsPost = new HashSet<ConversationsPost>();
            Dnocontract = new HashSet<Dnocontract>();
            DnodienstDefaultfirstlineoperator = new HashSet<Dnodienst>();
            DnodienstDefaultreservationsoperator = new HashSet<Dnodienst>();
            DnodienstDefaultsecondlineoperator = new HashSet<Dnodienst>();
            DnodienstManager = new HashSet<Dnodienst>();
            HardwareAanspreekpunt = new HashSet<Hardware>();
            HardwareInstallatiedoor = new HashSet<Hardware>();
            HardwareStdresvbehandelaar = new HashSet<Hardware>();
            IncidentActiedoor = new HashSet<Incident>();
            IncidentEscalationoperator = new HashSet<Incident>();
            IncidentLijn1actiedoor = new HashSet<Incident>();
            IncidentOperator = new HashSet<Incident>();
            IncidentOperatorgroup = new HashSet<Incident>();
            InventarisAanspreekpunt = new HashSet<Inventaris>();
            InventarisInstallatiedoor = new HashSet<Inventaris>();
            InventarisStdresvbehandelaar = new HashSet<Inventaris>();
            InverseAanspreekactiedoor = new HashSet<Actiedoor>();
            KennisSysteem = new HashSet<KennisSysteem>();
            Lmpactivity = new HashSet<Lmpactivity>();
            Lmpscenario = new HashSet<Lmpscenario>();
            LocatieActiedoorLink = new HashSet<LocatieActiedoorLink>();
            MailimportChange = new HashSet<MailimportChange>();
            MailimportIncident = new HashSet<MailimportIncident>();
            Meeting = new HashSet<Meeting>();
            MutatieBestelaanvraag = new HashSet<MutatieBestelaanvraag>();
            MutatieBestellingenMutBehandelaar = new HashSet<MutatieBestellingen>();
            MutatieBestellingenMutBestelautorisatie = new HashSet<MutatieBestellingen>();
            MutatieChangeMutEvalAuthoperator = new HashSet<MutatieChange>();
            MutatieChangeMutManager = new HashSet<MutatieChange>();
            MutatieChangeMutOperator = new HashSet<MutatieChange>();
            MutatieChangeMutProAuthoperator = new HashSet<MutatieChange>();
            MutatieChangeMutReqAuthoperator = new HashSet<MutatieChange>();
            MutatieChangeactivityMutOperator = new HashSet<MutatieChangeactivity>();
            MutatieChangeactivityMutOperatorgroup = new HashSet<MutatieChangeactivity>();
            MutatieChangeversion = new HashSet<MutatieChangeversion>();
            MutatieDnocontract = new HashSet<MutatieDnocontract>();
            MutatieIncidentMutOperator = new HashSet<MutatieIncident>();
            MutatieIncidentMutOperatorgroup = new HashSet<MutatieIncident>();
            MutatieOmActiviteitMutBehandelaar = new HashSet<MutatieOmActiviteit>();
            MutatieOmActiviteitMutOperatorgroup = new HashSet<MutatieOmActiviteit>();
            MutatieOmReeks = new HashSet<MutatieOmReeks>();
            MutatieOmSchema = new HashSet<MutatieOmSchema>();
            MutatieProbleemMutActiedoor = new HashSet<MutatieProbleem>();
            MutatieProbleemMutActiedoorbf = new HashSet<MutatieProbleem>();
            MutatieProbleemMutBeheerderbf = new HashSet<MutatieProbleem>();
            MutatieProbleemMutOperatorgroup = new HashSet<MutatieProbleem>();
            MutatieProbleemMutOperatorgroupbf = new HashSet<MutatieProbleem>();
            MutatieProbleemMutVerantwoordelijke = new HashSet<MutatieProbleem>();
            MutatieProfacboomProjectMutBehandelaar = new HashSet<MutatieProfacboomProject>();
            MutatieProfacboomProjectMutOperatorgroup = new HashSet<MutatieProfacboomProject>();
            MutatieReservering = new HashSet<MutatieReservering>();
            NetwerkcomponentAanspreekpunt = new HashSet<Netwerkcomponent>();
            NetwerkcomponentInstallatiedoor = new HashSet<Netwerkcomponent>();
            NetwerkcomponentStdresvbehandelaar = new HashSet<Netwerkcomponent>();
            ObjectRefAanspreekpunt = new HashSet<Object>();
            ObjectRefStdresvbehandelaar = new HashSet<Object>();
            OmActiviteitBehandelaar = new HashSet<OmActiviteit>();
            OmActiviteitOperatorgroup = new HashSet<OmActiviteit>();
            OmReeksBeheerder = new HashSet<OmReeks>();
            OmReeksStandaardbehandelaar = new HashSet<OmReeks>();
            OmReeksStandaardoperatorgroup = new HashSet<OmReeks>();
            OmSchema = new HashSet<OmSchema>();
            OperatorPermissiongroup = new HashSet<OperatorPermissiongroup>();
            OperatorfilterGroup = new HashSet<OperatorfilterGroup>();
            OperatorfilterOperator = new HashSet<OperatorfilterOperator>();
            Operatorfiltercache = new HashSet<Operatorfiltercache>();
            OplossingenActiedoorlijn1 = new HashSet<Oplossingen>();
            OplossingenActiedoorlijn2 = new HashSet<Oplossingen>();
            Planboardgroupstate = new HashSet<Planboardgroupstate>();
            ProbleemActiedoor = new HashSet<Probleem>();
            ProbleemActiedoorbf = new HashSet<Probleem>();
            ProbleemBeheerderbf = new HashSet<Probleem>();
            ProbleemOperatorgroup = new HashSet<Probleem>();
            ProbleemOperatorgroupbf = new HashSet<Probleem>();
            ProbleemVerantwoordelijke = new HashSet<Probleem>();
            ProfacboomProjectBehandelaar = new HashSet<ProfacboomProject>();
            ProfacboomProjectOperatorgroup = new HashSet<ProfacboomProject>();
            ReportactionOperatorLink = new HashSet<ReportactionOperatorLink>();
            ReservationEventOperator = new HashSet<ReservationEvent>();
            ReservationEventOperatorgroup = new HashSet<ReservationEvent>();
            ReservationOperator = new HashSet<Reservation>();
            ReservationOperatorgroup = new HashSet<Reservation>();
            ReservationServiceLink = new HashSet<ReservationServiceLink>();
            Reservering = new HashSet<Reservering>();
            ReserveringVoorzieningLink = new HashSet<ReserveringVoorzieningLink>();
            RmSeriesServiceLink = new HashSet<RmSeriesServiceLink>();
            Schedule = new HashSet<Schedule>();
            Shiftoperatorgrouplink = new HashSet<Shiftoperatorgrouplink>();
            SoftwareAanspreekpunt = new HashSet<Software>();
            SoftwareInstallatiedoor = new HashSet<Software>();
            SoftwareStdresvbehandelaar = new HashSet<Software>();
            Taskroleoperatorgrouplink = new HashSet<Taskroleoperatorgrouplink>();
            TelefonieAanspreekpunt = new HashSet<Telefonie>();
            TelefonieInstallatiedoor = new HashSet<Telefonie>();
            TelefonieStdresvbehandelaar = new HashSet<Telefonie>();
            TimeRegistrationChangeOperator = new HashSet<TimeRegistrationChange>();
            TimeRegistrationChangeOperatorgroup = new HashSet<TimeRegistrationChange>();
            TimeRegistrationChangeactivityOperator = new HashSet<TimeRegistrationChangeactivity>();
            TimeRegistrationChangeactivityOperatorgroup = new HashSet<TimeRegistrationChangeactivity>();
            TimeRegistrationIncidentOperator = new HashSet<TimeRegistrationIncident>();
            TimeRegistrationIncidentOperatorgroup = new HashSet<TimeRegistrationIncident>();
            TimeRegistrationOmActiviteitOperator = new HashSet<TimeRegistrationOmActiviteit>();
            TimeRegistrationOmActiviteitOperatorgroup = new HashSet<TimeRegistrationOmActiviteit>();
            TimeRegistrationProbleemOperator = new HashSet<TimeRegistrationProbleem>();
            TimeRegistrationProbleemOperatorgroup = new HashSet<TimeRegistrationProbleem>();
            TimeRegistrationProfacboomProjectOperator = new HashSet<TimeRegistrationProfacboomProject>();
            TimeRegistrationProfacboomProjectOperatorgroup = new HashSet<TimeRegistrationProfacboomProject>();
            VestigingNavigation = new HashSet<Vestiging>();
            Voorziening = new HashSet<Voorziening>();
            Vrij1objectAanspreekpunt = new HashSet<Vrij1object>();
            Vrij1objectInstallatiedoor = new HashSet<Vrij1object>();
            Vrij1objectStdresvbehandelaar = new HashSet<Vrij1object>();
            Vrij2objectAanspreekpunt = new HashSet<Vrij2object>();
            Vrij2objectInstallatiedoor = new HashSet<Vrij2object>();
            Vrij2objectStdresvbehandelaar = new HashSet<Vrij2object>();
            Vrij3objectAanspreekpunt = new HashSet<Vrij3object>();
            Vrij3objectInstallatiedoor = new HashSet<Vrij3object>();
            Vrij3objectStdresvbehandelaar = new HashSet<Vrij3object>();
            Vrij4objectAanspreekpunt = new HashSet<Vrij4object>();
            Vrij4objectInstallatiedoor = new HashSet<Vrij4object>();
            Vrij4objectStdresvbehandelaar = new HashSet<Vrij4object>();
            Vrij5objectAanspreekpunt = new HashSet<Vrij5object>();
            Vrij5objectInstallatiedoor = new HashSet<Vrij5object>();
            Vrij5objectStdresvbehandelaar = new HashSet<Vrij5object>();
        }

        public Guid? Aanspreekactiedoorid { get; set; }
        public string Aantekeningen { get; set; }
        public bool Activiteitbehandelaar { get; set; }
        public string Adresmemo { get; set; }
        public Guid? Afdelingid { get; set; }
        public Guid? Archiefredenid { get; set; }
        public Guid? Attentieid { get; set; }
        public Guid? Budgethouderid { get; set; }
        public string Diversen { get; set; }
        public bool Externepartij { get; set; }
        public string Fax { get; set; }
        public int Geslacht { get; set; }
        public bool Heeftattentie { get; set; }
        public string Importid { get; set; }
        public int Importtype { get; set; }
        public bool Installatie { get; set; }
        public Guid? Landid { get; set; }
        public bool Lijn1beheerder { get; set; }
        public bool Lijn2beheerder { get; set; }
        public Guid? Loginnaamtopdeskid { get; set; }
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
        public bool Probleembeheerder { get; set; }
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
        public Guid? Vestigingid { get; set; }
        public string Voorletters { get; set; }
        public string Voornaam { get; set; }
        public bool Voorraadbeheerder { get; set; }
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
        public bool Wijzigingsbeheerder { get; set; }
        public string Naam { get; set; }
        public string Email { get; set; }
        public string Priveemail { get; set; }
        public DateTime? Dataanmk { get; set; }
        public DateTime? Datwijzig { get; set; }
        public DateTime? Geboortedatum { get; set; }
        public DateTime? Vrijedatum1 { get; set; }
        public DateTime? Vrijedatum2 { get; set; }
        public decimal Uurprijs { get; set; }
        public string Achternaam { get; set; }
        public bool Accountmanager { get; set; }
        public bool Reserveringbeheerder { get; set; }
        public bool Operationeelbeheerder { get; set; }
        public bool Operationeelbehandelaar { get; set; }
        public bool Probleembehandelaar { get; set; }
        public string RefAanhefformeel { get; set; }
        public string RefAanhefinformeel { get; set; }
        public bool Projectbeheerder { get; set; }
        public bool Projectactiviteitbehandelaar { get; set; }
        public DateTime? Importdate { get; set; }
        public string Personeeli { get; set; }
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
        public bool Slacontractbeheerder { get; set; }
        public bool Voorzieningbehandelaar { get; set; }
        public bool Kennissysteembeheerder { get; set; }
        public bool Lmpscenariobeheerder { get; set; }
        public bool Lmpactiviteitbeheerder { get; set; }
        public bool Simplechangeoperator { get; set; }
        public string Huisnummer { get; set; }
        public bool Changeauthorizer { get; set; }
        public bool Rfcauthorizer { get; set; }
        public string Bespokememo { get; set; }
        public string SocialSecurityNumber { get; set; }
        public bool Visibleonplanboard { get; set; }
        public string Functie { get; set; }
        public string ExchangeAccount { get; set; }
        public string Loginnaammainframe { get; set; }
        public string Loginnaamnetwerk { get; set; }
        public string Tasloginnaam { get; set; }
        public bool Sv { get; set; }
        public bool Maginloggen { get; set; }
        public string Titel { get; set; }
        public string RefDynanaam { get; set; }
        public string RefAfdeling { get; set; }
        public string RefBudgethouder { get; set; }
        public string County { get; set; }
        public string MaidenName { get; set; }
        public Guid? LanguageId { get; set; }
        public string Taspasshash { get; set; }

        public Actiedoor Aanspreekactiedoor { get; set; }
        public Afdeling Afdeling { get; set; }
        public Archiefreden Archiefreden { get; set; }
        public Attentie Attentie { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek1Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek2Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek3Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek4Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek5Navigation { get; set; }
        public Budgethouder Budgethouder { get; set; }
        public Land Land { get; set; }
        public Kennistaal Language { get; set; }
        public Gebruiker Loginnaamtopdesk { get; set; }
        public Locatie Lokatie { get; set; }
        public Gebruiker UidaanmkNavigation { get; set; }
        public Gebruiker UidwijzigNavigation { get; set; }
        public Vestiging Vestiging { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek1Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek2Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek3Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek4Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek5Navigation { get; set; }
        public ICollection<ActiedoorDocumenten> ActiedoorDocumenten { get; set; }
        public ICollection<ActiedoorEmailberichten> ActiedoorEmailberichten { get; set; }
        public ICollection<ActiedoorLogboek> ActiedoorLogboek { get; set; }
        public ICollection<ActiedoorMemoHistory> ActiedoorMemoHistory { get; set; }
        public ICollection<ActiedoorOptionalgrid> ActiedoorOptionalgrid { get; set; }
        public ICollection<ActiedoorPicture> ActiedoorPicture { get; set; }
        public ICollection<Actiedoorlink> ActiedoorlinkActiedoor { get; set; }
        public ICollection<Actiedoorlink> ActiedoorlinkActiedoorgroep { get; set; }
        public ICollection<Appliedshift> Appliedshift { get; set; }
        public ICollection<Appointment> Appointment { get; set; }
        public ICollection<Availabilitycheck> Availabilitycheck { get; set; }
        public ICollection<Bestelaanvraag> Bestelaanvraag { get; set; }
        public ICollection<Bestellingen> BestellingenAfmeldautorisatie { get; set; }
        public ICollection<Bestellingen> BestellingenBehandelaar { get; set; }
        public ICollection<Bestellingen> BestellingenBestelautorisatie { get; set; }
        public ICollection<BranchfilterOperator> BranchfilterOperator { get; set; }
        public ICollection<CategoryfilterOperator> CategoryfilterOperator { get; set; }
        public ICollection<ChangeActivitytemplate> ChangeActivitytemplateOperator { get; set; }
        public ICollection<ChangeActivitytemplate> ChangeActivitytemplateOperatorgroup { get; set; }
        public ICollection<Change> ChangeCanceledbyoperator { get; set; }
        public ICollection<Change> ChangeEvalAuthoperator { get; set; }
        public ICollection<Change> ChangeManager { get; set; }
        public ICollection<Change> ChangeOperator { get; set; }
        public ICollection<Change> ChangeOperatorgroup { get; set; }
        public ICollection<Change> ChangeProAuthoperator { get; set; }
        public ICollection<Change> ChangeReqAuthoperator { get; set; }
        public ICollection<ChangeTemplate> ChangeTemplateEvalAuthoperator { get; set; }
        public ICollection<ChangeTemplate> ChangeTemplateManager { get; set; }
        public ICollection<ChangeTemplate> ChangeTemplateOperator { get; set; }
        public ICollection<ChangeTemplate> ChangeTemplateOperatorgroup { get; set; }
        public ICollection<ChangeTemplate> ChangeTemplateProAuthoperator { get; set; }
        public ICollection<ChangeTemplate> ChangeTemplateReqAuthoperator { get; set; }
        public ICollection<Changeactivity> ChangeactivityOperator { get; set; }
        public ICollection<Changeactivity> ChangeactivityOperatorgroup { get; set; }
        public ICollection<Changeauthorization> Changeauthorization { get; set; }
        public ICollection<Changeversion> Changeversion { get; set; }
        public ICollection<Classificatie> ClassificatieChangeactivityNavigation { get; set; }
        public ICollection<Classificatie> ClassificatieChangeauthactivityNavigation { get; set; }
        public ICollection<Classificatie> ClassificatieChangecoordinatorNavigation { get; set; }
        public ICollection<Classificatie> ClassificatieLijn1actiedoor { get; set; }
        public ICollection<Classificatie> ClassificatieLijn2actiedoor { get; set; }
        public ICollection<Classificatie> ClassificatieProjectcoordinator { get; set; }
        public ICollection<Classificatie> ClassificatieProjectoperator { get; set; }
        public ICollection<Classificatie> ClassificatieSimplechangeNavigation { get; set; }
        public ICollection<ConversationsHide> ConversationsHide { get; set; }
        public ICollection<ConversationsLike> ConversationsLike { get; set; }
        public ICollection<ConversationsPost> ConversationsPost { get; set; }
        public ICollection<Dnocontract> Dnocontract { get; set; }
        public ICollection<Dnodienst> DnodienstDefaultfirstlineoperator { get; set; }
        public ICollection<Dnodienst> DnodienstDefaultreservationsoperator { get; set; }
        public ICollection<Dnodienst> DnodienstDefaultsecondlineoperator { get; set; }
        public ICollection<Dnodienst> DnodienstManager { get; set; }
        public ICollection<Hardware> HardwareAanspreekpunt { get; set; }
        public ICollection<Hardware> HardwareInstallatiedoor { get; set; }
        public ICollection<Hardware> HardwareStdresvbehandelaar { get; set; }
        public ICollection<Incident> IncidentActiedoor { get; set; }
        public ICollection<Incident> IncidentEscalationoperator { get; set; }
        public ICollection<Incident> IncidentLijn1actiedoor { get; set; }
        public ICollection<Incident> IncidentOperator { get; set; }
        public ICollection<Incident> IncidentOperatorgroup { get; set; }
        public ICollection<Inventaris> InventarisAanspreekpunt { get; set; }
        public ICollection<Inventaris> InventarisInstallatiedoor { get; set; }
        public ICollection<Inventaris> InventarisStdresvbehandelaar { get; set; }
        public ICollection<Actiedoor> InverseAanspreekactiedoor { get; set; }
        public ICollection<KennisSysteem> KennisSysteem { get; set; }
        public ICollection<Lmpactivity> Lmpactivity { get; set; }
        public ICollection<Lmpscenario> Lmpscenario { get; set; }
        public ICollection<LocatieActiedoorLink> LocatieActiedoorLink { get; set; }
        public ICollection<MailimportChange> MailimportChange { get; set; }
        public ICollection<MailimportIncident> MailimportIncident { get; set; }
        public ICollection<Meeting> Meeting { get; set; }
        public ICollection<MutatieBestelaanvraag> MutatieBestelaanvraag { get; set; }
        public ICollection<MutatieBestellingen> MutatieBestellingenMutBehandelaar { get; set; }
        public ICollection<MutatieBestellingen> MutatieBestellingenMutBestelautorisatie { get; set; }
        public ICollection<MutatieChange> MutatieChangeMutEvalAuthoperator { get; set; }
        public ICollection<MutatieChange> MutatieChangeMutManager { get; set; }
        public ICollection<MutatieChange> MutatieChangeMutOperator { get; set; }
        public ICollection<MutatieChange> MutatieChangeMutProAuthoperator { get; set; }
        public ICollection<MutatieChange> MutatieChangeMutReqAuthoperator { get; set; }
        public ICollection<MutatieChangeactivity> MutatieChangeactivityMutOperator { get; set; }
        public ICollection<MutatieChangeactivity> MutatieChangeactivityMutOperatorgroup { get; set; }
        public ICollection<MutatieChangeversion> MutatieChangeversion { get; set; }
        public ICollection<MutatieDnocontract> MutatieDnocontract { get; set; }
        public ICollection<MutatieIncident> MutatieIncidentMutOperator { get; set; }
        public ICollection<MutatieIncident> MutatieIncidentMutOperatorgroup { get; set; }
        public ICollection<MutatieOmActiviteit> MutatieOmActiviteitMutBehandelaar { get; set; }
        public ICollection<MutatieOmActiviteit> MutatieOmActiviteitMutOperatorgroup { get; set; }
        public ICollection<MutatieOmReeks> MutatieOmReeks { get; set; }
        public ICollection<MutatieOmSchema> MutatieOmSchema { get; set; }
        public ICollection<MutatieProbleem> MutatieProbleemMutActiedoor { get; set; }
        public ICollection<MutatieProbleem> MutatieProbleemMutActiedoorbf { get; set; }
        public ICollection<MutatieProbleem> MutatieProbleemMutBeheerderbf { get; set; }
        public ICollection<MutatieProbleem> MutatieProbleemMutOperatorgroup { get; set; }
        public ICollection<MutatieProbleem> MutatieProbleemMutOperatorgroupbf { get; set; }
        public ICollection<MutatieProbleem> MutatieProbleemMutVerantwoordelijke { get; set; }
        public ICollection<MutatieProfacboomProject> MutatieProfacboomProjectMutBehandelaar { get; set; }
        public ICollection<MutatieProfacboomProject> MutatieProfacboomProjectMutOperatorgroup { get; set; }
        public ICollection<MutatieReservering> MutatieReservering { get; set; }
        public ICollection<Netwerkcomponent> NetwerkcomponentAanspreekpunt { get; set; }
        public ICollection<Netwerkcomponent> NetwerkcomponentInstallatiedoor { get; set; }
        public ICollection<Netwerkcomponent> NetwerkcomponentStdresvbehandelaar { get; set; }
        public ICollection<Object> ObjectRefAanspreekpunt { get; set; }
        public ICollection<Object> ObjectRefStdresvbehandelaar { get; set; }
        public ICollection<OmActiviteit> OmActiviteitBehandelaar { get; set; }
        public ICollection<OmActiviteit> OmActiviteitOperatorgroup { get; set; }
        public ICollection<OmReeks> OmReeksBeheerder { get; set; }
        public ICollection<OmReeks> OmReeksStandaardbehandelaar { get; set; }
        public ICollection<OmReeks> OmReeksStandaardoperatorgroup { get; set; }
        public ICollection<OmSchema> OmSchema { get; set; }
        public ICollection<OperatorPermissiongroup> OperatorPermissiongroup { get; set; }
        public ICollection<OperatorfilterGroup> OperatorfilterGroup { get; set; }
        public ICollection<OperatorfilterOperator> OperatorfilterOperator { get; set; }
        public ICollection<Operatorfiltercache> Operatorfiltercache { get; set; }
        public ICollection<Oplossingen> OplossingenActiedoorlijn1 { get; set; }
        public ICollection<Oplossingen> OplossingenActiedoorlijn2 { get; set; }
        public ICollection<Planboardgroupstate> Planboardgroupstate { get; set; }
        public ICollection<Probleem> ProbleemActiedoor { get; set; }
        public ICollection<Probleem> ProbleemActiedoorbf { get; set; }
        public ICollection<Probleem> ProbleemBeheerderbf { get; set; }
        public ICollection<Probleem> ProbleemOperatorgroup { get; set; }
        public ICollection<Probleem> ProbleemOperatorgroupbf { get; set; }
        public ICollection<Probleem> ProbleemVerantwoordelijke { get; set; }
        public ICollection<ProfacboomProject> ProfacboomProjectBehandelaar { get; set; }
        public ICollection<ProfacboomProject> ProfacboomProjectOperatorgroup { get; set; }
        public ICollection<ReportactionOperatorLink> ReportactionOperatorLink { get; set; }
        public ICollection<ReservationEvent> ReservationEventOperator { get; set; }
        public ICollection<ReservationEvent> ReservationEventOperatorgroup { get; set; }
        public ICollection<Reservation> ReservationOperator { get; set; }
        public ICollection<Reservation> ReservationOperatorgroup { get; set; }
        public ICollection<ReservationServiceLink> ReservationServiceLink { get; set; }
        public ICollection<Reservering> Reservering { get; set; }
        public ICollection<ReserveringVoorzieningLink> ReserveringVoorzieningLink { get; set; }
        public ICollection<RmSeriesServiceLink> RmSeriesServiceLink { get; set; }
        public ICollection<Schedule> Schedule { get; set; }
        public ICollection<Shiftoperatorgrouplink> Shiftoperatorgrouplink { get; set; }
        public ICollection<Software> SoftwareAanspreekpunt { get; set; }
        public ICollection<Software> SoftwareInstallatiedoor { get; set; }
        public ICollection<Software> SoftwareStdresvbehandelaar { get; set; }
        public ICollection<Taskroleoperatorgrouplink> Taskroleoperatorgrouplink { get; set; }
        public ICollection<Telefonie> TelefonieAanspreekpunt { get; set; }
        public ICollection<Telefonie> TelefonieInstallatiedoor { get; set; }
        public ICollection<Telefonie> TelefonieStdresvbehandelaar { get; set; }
        public ICollection<TimeRegistrationChange> TimeRegistrationChangeOperator { get; set; }
        public ICollection<TimeRegistrationChange> TimeRegistrationChangeOperatorgroup { get; set; }
        public ICollection<TimeRegistrationChangeactivity> TimeRegistrationChangeactivityOperator { get; set; }
        public ICollection<TimeRegistrationChangeactivity> TimeRegistrationChangeactivityOperatorgroup { get; set; }
        public ICollection<TimeRegistrationIncident> TimeRegistrationIncidentOperator { get; set; }
        public ICollection<TimeRegistrationIncident> TimeRegistrationIncidentOperatorgroup { get; set; }
        public ICollection<TimeRegistrationOmActiviteit> TimeRegistrationOmActiviteitOperator { get; set; }
        public ICollection<TimeRegistrationOmActiviteit> TimeRegistrationOmActiviteitOperatorgroup { get; set; }
        public ICollection<TimeRegistrationProbleem> TimeRegistrationProbleemOperator { get; set; }
        public ICollection<TimeRegistrationProbleem> TimeRegistrationProbleemOperatorgroup { get; set; }
        public ICollection<TimeRegistrationProfacboomProject> TimeRegistrationProfacboomProjectOperator { get; set; }
        public ICollection<TimeRegistrationProfacboomProject> TimeRegistrationProfacboomProjectOperatorgroup { get; set; }
        public ICollection<Vestiging> VestigingNavigation { get; set; }
        public ICollection<Voorziening> Voorziening { get; set; }
        public ICollection<Vrij1object> Vrij1objectAanspreekpunt { get; set; }
        public ICollection<Vrij1object> Vrij1objectInstallatiedoor { get; set; }
        public ICollection<Vrij1object> Vrij1objectStdresvbehandelaar { get; set; }
        public ICollection<Vrij2object> Vrij2objectAanspreekpunt { get; set; }
        public ICollection<Vrij2object> Vrij2objectInstallatiedoor { get; set; }
        public ICollection<Vrij2object> Vrij2objectStdresvbehandelaar { get; set; }
        public ICollection<Vrij3object> Vrij3objectAanspreekpunt { get; set; }
        public ICollection<Vrij3object> Vrij3objectInstallatiedoor { get; set; }
        public ICollection<Vrij3object> Vrij3objectStdresvbehandelaar { get; set; }
        public ICollection<Vrij4object> Vrij4objectAanspreekpunt { get; set; }
        public ICollection<Vrij4object> Vrij4objectInstallatiedoor { get; set; }
        public ICollection<Vrij4object> Vrij4objectStdresvbehandelaar { get; set; }
        public ICollection<Vrij5object> Vrij5objectAanspreekpunt { get; set; }
        public ICollection<Vrij5object> Vrij5objectInstallatiedoor { get; set; }
        public ICollection<Vrij5object> Vrij5objectStdresvbehandelaar { get; set; }
    }
}
