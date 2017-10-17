using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Vestiging
    {
        public Vestiging()
        {
            Actiedoor = new HashSet<Actiedoor>();
            Appointment = new HashSet<Appointment>();
            Bestelaanvraag = new HashSet<Bestelaanvraag>();
            BestellingenVestiging = new HashSet<Bestellingen>();
            BestellingenVestigingid2Navigation = new HashSet<Bestellingen>();
            Bezoeker = new HashSet<Bezoeker>();
            BranchMeasurement = new HashSet<BranchMeasurement>();
            BranchfilterBranches = new HashSet<BranchfilterBranches>();
            Branchfiltercache = new HashSet<Branchfiltercache>();
            BuildingZone = new HashSet<BuildingZone>();
            ChangeAanmeldervestiging = new HashSet<Change>();
            ChangeBranch = new HashSet<Change>();
            ChangeBranchLink = new HashSet<ChangeBranchLink>();
            ChangeTemplate = new HashSet<ChangeTemplate>();
            Configuratie = new HashSet<Configuratie>();
            Dnocontract = new HashSet<Dnocontract>();
            DnocontractVestigingLink = new HashSet<DnocontractVestigingLink>();
            Dnolink = new HashSet<Dnolink>();
            Hardware = new HashSet<Hardware>();
            IncidentAanmeldervestiging = new HashSet<Incident>();
            IncidentVestiging = new HashSet<Incident>();
            Inventaris = new HashSet<Inventaris>();
            InverseOudervestiging = new HashSet<Vestiging>();
            InverseRefHoofdvestiging = new HashSet<Vestiging>();
            KennisVestigingOperCond = new HashSet<KennisVestigingOperCond>();
            KennisVestigingPublicCond = new HashSet<KennisVestigingPublicCond>();
            KennissysteemVestigingLink = new HashSet<KennissysteemVestigingLink>();
            Leverancier = new HashSet<Leverancier>();
            Lmpactivity = new HashSet<Lmpactivity>();
            Locatie = new HashSet<Locatie>();
            MailimportChange = new HashSet<MailimportChange>();
            MailimportIncident = new HashSet<MailimportIncident>();
            Meeting = new HashSet<Meeting>();
            MutatieHardware = new HashSet<MutatieHardware>();
            MutatieInventaris = new HashSet<MutatieInventaris>();
            MutatieNetwerkcomponent = new HashSet<MutatieNetwerkcomponent>();
            MutatieSoftware = new HashSet<MutatieSoftware>();
            MutatieTelefonie = new HashSet<MutatieTelefonie>();
            MutatieVestiging = new HashSet<MutatieVestiging>();
            MutatieVrij1object = new HashSet<MutatieVrij1object>();
            MutatieVrij2object = new HashSet<MutatieVrij2object>();
            MutatieVrij3object = new HashSet<MutatieVrij3object>();
            MutatieVrij4object = new HashSet<MutatieVrij4object>();
            MutatieVrij5object = new HashSet<MutatieVrij5object>();
            Netwerkcomponent = new HashSet<Netwerkcomponent>();
            ObjVestigingLink = new HashSet<ObjVestigingLink>();
            Object = new HashSet<Object>();
            OmActiviteitVestigingLink = new HashSet<OmActiviteitVestigingLink>();
            OmReeksVestigingLink = new HashSet<OmReeksVestigingLink>();
            Persoon = new HashSet<Persoon>();
            Persoongroep = new HashSet<Persoongroep>();
            ReservationEventRequesterbranch = new HashSet<ReservationEvent>();
            ReservationEventReservedforbranch = new HashSet<ReservationEvent>();
            ReservationRequesterbranch = new HashSet<Reservation>();
            ReservationReservedforbranch = new HashSet<Reservation>();
            Reservering = new HashSet<Reservering>();
            ReserveringVoorzieningLink = new HashSet<ReserveringVoorzieningLink>();
            RmSeriesServiceLink = new HashSet<RmSeriesServiceLink>();
            ServiceBranchLink = new HashSet<ServiceBranchLink>();
            Software = new HashSet<Software>();
            Telefonie = new HashSet<Telefonie>();
            VestigingDocumenten = new HashSet<VestigingDocumenten>();
            VestigingEmailberichten = new HashSet<VestigingEmailberichten>();
            VestigingLogboek = new HashSet<VestigingLogboek>();
            VestigingMemoHistory = new HashSet<VestigingMemoHistory>();
            VestigingOptionalgrid = new HashSet<VestigingOptionalgrid>();
            VestigingPicture = new HashSet<VestigingPicture>();
            VoorzieningVestigingLink = new HashSet<VoorzieningVestigingLink>();
            Vrij1object = new HashSet<Vrij1object>();
            Vrij2object = new HashSet<Vrij2object>();
            Vrij3object = new HashSet<Vrij3object>();
            Vrij4object = new HashSet<Vrij4object>();
            Vrij5object = new HashSet<Vrij5object>();
        }

        public string Aantekeningen { get; set; }
        public string Adresmemo1 { get; set; }
        public string Adresmemo2 { get; set; }
        public Guid? Archiefredenid { get; set; }
        public Guid? Attentieid { get; set; }
        public string Debiteurennummer { get; set; }
        public string Diversen { get; set; }
        public string Fax { get; set; }
        public bool Heeftattentie { get; set; }
        public Guid? Landid1 { get; set; }
        public Guid? Landid2 { get; set; }
        public string Lidmaatschapsnummer { get; set; }
        public string Naam { get; set; }
        public string Opmerking { get; set; }
        public Guid? Oudervestigingid { get; set; }
        public string Plaats1 { get; set; }
        public string Plaats2 { get; set; }
        public string Postcode1 { get; set; }
        public string Postcode2 { get; set; }
        public Guid? RefHoofdvestigingid { get; set; }
        public int RefKleur { get; set; }
        public string Specificatie { get; set; }
        public int Status { get; set; }
        public string Straat1 { get; set; }
        public string Straat2 { get; set; }
        public string Telefoon { get; set; }
        public string Telefoonbbs { get; set; }
        public Guid? Uidaanmk { get; set; }
        public Guid? Uidwijzig { get; set; }
        public Guid Unid { get; set; }
        public int Vestigingsoort { get; set; }
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
        public int Importtype { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public DateTime? Dataanmk { get; set; }
        public DateTime? Datwijzig { get; set; }
        public DateTime? Vrijedatum1 { get; set; }
        public DateTime? Vrijedatum2 { get; set; }
        public Guid? Extraaid { get; set; }
        public Guid? Extrabid { get; set; }
        public string Timezone { get; set; }
        public string Btwnummer { get; set; }
        public DateTime? Importdate { get; set; }
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
        public Guid? Swid { get; set; }
        public int SwOption { get; set; }
        public string Huisnummer1 { get; set; }
        public string Huisnummer2 { get; set; }
        public string Bespokememo { get; set; }
        public string Importid { get; set; }
        public string County1 { get; set; }
        public string County2 { get; set; }
        public bool UseOtherLdapServerPublic { get; set; }
        public bool UseOtherLdapServerSecure { get; set; }
        public Guid? OtherLdapServerPublic { get; set; }
        public Guid? OtherLdapServerSecure { get; set; }
        public double? SurfaceAreaM2 { get; set; }
        public double? VolumeM3 { get; set; }
        public string Registryreference { get; set; }
        public string Ownername { get; set; }
        public string Ownertelephone { get; set; }
        public string Ownermobilephone { get; set; }
        public string Owneremail { get; set; }
        public int? Yearofconstruction { get; set; }
        public int? Yearofacquisition { get; set; }
        public decimal? Priceofacquisition { get; set; }
        public decimal? Totalcostofacquisition { get; set; }
        public decimal? Propertyvaluation { get; set; }
        public decimal? Residualvalue { get; set; }
        public decimal? Annualdepreciation { get; set; }
        public int? Depreciationperiod { get; set; }
        public decimal? Foreclosurevalue { get; set; }
        public DateTime? Foreclosurevaluesurveydate { get; set; }
        public decimal? Marketvalue { get; set; }
        public DateTime? Marketvaluesurveydate { get; set; }
        public decimal? Rentalvalue { get; set; }
        public DateTime? Rentalvaluesurveydate { get; set; }
        public decimal? Rebuildingvalue { get; set; }
        public DateTime? Rebuildingvaluesurveydate { get; set; }
        public decimal? Landvalue { get; set; }
        public DateTime? Landvaluesurveydate { get; set; }
        public DateTime? Environmentalimpactmeasurementdate { get; set; }
        public DateTime? Energyperformancemeasurementdate { get; set; }
        public Guid? DesignationId { get; set; }
        public Guid? HistoricalSiteId { get; set; }
        public Guid? EnergyPerformanceId { get; set; }
        public Guid? EnvironmentalImpactId { get; set; }
        public Guid? BuildingLevelEpcId { get; set; }
        public Guid? Accountmanagerid { get; set; }
        public Guid? Contactid { get; set; }

        public Actiedoor Accountmanager { get; set; }
        public Archiefreden Archiefreden { get; set; }
        public Attentie Attentie { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek1Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek2Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek3Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek4Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek5Navigation { get; set; }
        public BuildingLevelEpc BuildingLevelEpc { get; set; }
        public Persoon Contact { get; set; }
        public BranchDesignation Designation { get; set; }
        public EnergyPerformance EnergyPerformance { get; set; }
        public EnvironmentalImpact EnvironmentalImpact { get; set; }
        public Extraa Extraa { get; set; }
        public Extrab Extrab { get; set; }
        public HistoricalSite HistoricalSite { get; set; }
        public Land Landid1Navigation { get; set; }
        public Land Landid2Navigation { get; set; }
        public Ldapsettings OtherLdapServerPublicNavigation { get; set; }
        public Ldapsettings OtherLdapServerSecureNavigation { get; set; }
        public Vestiging Oudervestiging { get; set; }
        public Vestiging RefHoofdvestiging { get; set; }
        public Servicewindow Sw { get; set; }
        public Gebruiker UidaanmkNavigation { get; set; }
        public Gebruiker UidwijzigNavigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek1Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek2Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek3Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek4Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek5Navigation { get; set; }
        public ICollection<Actiedoor> Actiedoor { get; set; }
        public ICollection<Appointment> Appointment { get; set; }
        public ICollection<Bestelaanvraag> Bestelaanvraag { get; set; }
        public ICollection<Bestellingen> BestellingenVestiging { get; set; }
        public ICollection<Bestellingen> BestellingenVestigingid2Navigation { get; set; }
        public ICollection<Bezoeker> Bezoeker { get; set; }
        public ICollection<BranchMeasurement> BranchMeasurement { get; set; }
        public ICollection<BranchfilterBranches> BranchfilterBranches { get; set; }
        public ICollection<Branchfiltercache> Branchfiltercache { get; set; }
        public ICollection<BuildingZone> BuildingZone { get; set; }
        public ICollection<Change> ChangeAanmeldervestiging { get; set; }
        public ICollection<Change> ChangeBranch { get; set; }
        public ICollection<ChangeBranchLink> ChangeBranchLink { get; set; }
        public ICollection<ChangeTemplate> ChangeTemplate { get; set; }
        public ICollection<Configuratie> Configuratie { get; set; }
        public ICollection<Dnocontract> Dnocontract { get; set; }
        public ICollection<DnocontractVestigingLink> DnocontractVestigingLink { get; set; }
        public ICollection<Dnolink> Dnolink { get; set; }
        public ICollection<Hardware> Hardware { get; set; }
        public ICollection<Incident> IncidentAanmeldervestiging { get; set; }
        public ICollection<Incident> IncidentVestiging { get; set; }
        public ICollection<Inventaris> Inventaris { get; set; }
        public ICollection<Vestiging> InverseOudervestiging { get; set; }
        public ICollection<Vestiging> InverseRefHoofdvestiging { get; set; }
        public ICollection<KennisVestigingOperCond> KennisVestigingOperCond { get; set; }
        public ICollection<KennisVestigingPublicCond> KennisVestigingPublicCond { get; set; }
        public ICollection<KennissysteemVestigingLink> KennissysteemVestigingLink { get; set; }
        public ICollection<Leverancier> Leverancier { get; set; }
        public ICollection<Lmpactivity> Lmpactivity { get; set; }
        public ICollection<Locatie> Locatie { get; set; }
        public ICollection<MailimportChange> MailimportChange { get; set; }
        public ICollection<MailimportIncident> MailimportIncident { get; set; }
        public ICollection<Meeting> Meeting { get; set; }
        public ICollection<MutatieHardware> MutatieHardware { get; set; }
        public ICollection<MutatieInventaris> MutatieInventaris { get; set; }
        public ICollection<MutatieNetwerkcomponent> MutatieNetwerkcomponent { get; set; }
        public ICollection<MutatieSoftware> MutatieSoftware { get; set; }
        public ICollection<MutatieTelefonie> MutatieTelefonie { get; set; }
        public ICollection<MutatieVestiging> MutatieVestiging { get; set; }
        public ICollection<MutatieVrij1object> MutatieVrij1object { get; set; }
        public ICollection<MutatieVrij2object> MutatieVrij2object { get; set; }
        public ICollection<MutatieVrij3object> MutatieVrij3object { get; set; }
        public ICollection<MutatieVrij4object> MutatieVrij4object { get; set; }
        public ICollection<MutatieVrij5object> MutatieVrij5object { get; set; }
        public ICollection<Netwerkcomponent> Netwerkcomponent { get; set; }
        public ICollection<ObjVestigingLink> ObjVestigingLink { get; set; }
        public ICollection<Object> Object { get; set; }
        public ICollection<OmActiviteitVestigingLink> OmActiviteitVestigingLink { get; set; }
        public ICollection<OmReeksVestigingLink> OmReeksVestigingLink { get; set; }
        public ICollection<Persoon> Persoon { get; set; }
        public ICollection<Persoongroep> Persoongroep { get; set; }
        public ICollection<ReservationEvent> ReservationEventRequesterbranch { get; set; }
        public ICollection<ReservationEvent> ReservationEventReservedforbranch { get; set; }
        public ICollection<Reservation> ReservationRequesterbranch { get; set; }
        public ICollection<Reservation> ReservationReservedforbranch { get; set; }
        public ICollection<Reservering> Reservering { get; set; }
        public ICollection<ReserveringVoorzieningLink> ReserveringVoorzieningLink { get; set; }
        public ICollection<RmSeriesServiceLink> RmSeriesServiceLink { get; set; }
        public ICollection<ServiceBranchLink> ServiceBranchLink { get; set; }
        public ICollection<Software> Software { get; set; }
        public ICollection<Telefonie> Telefonie { get; set; }
        public ICollection<VestigingDocumenten> VestigingDocumenten { get; set; }
        public ICollection<VestigingEmailberichten> VestigingEmailberichten { get; set; }
        public ICollection<VestigingLogboek> VestigingLogboek { get; set; }
        public ICollection<VestigingMemoHistory> VestigingMemoHistory { get; set; }
        public ICollection<VestigingOptionalgrid> VestigingOptionalgrid { get; set; }
        public ICollection<VestigingPicture> VestigingPicture { get; set; }
        public ICollection<VoorzieningVestigingLink> VoorzieningVestigingLink { get; set; }
        public ICollection<Vrij1object> Vrij1object { get; set; }
        public ICollection<Vrij2object> Vrij2object { get; set; }
        public ICollection<Vrij3object> Vrij3object { get; set; }
        public ICollection<Vrij4object> Vrij4object { get; set; }
        public ICollection<Vrij5object> Vrij5object { get; set; }
    }
}
