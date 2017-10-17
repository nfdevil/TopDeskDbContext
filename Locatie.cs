using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Locatie
    {
        public Locatie()
        {
            Actiedoor = new HashSet<Actiedoor>();
            Bestelaanvraag = new HashSet<Bestelaanvraag>();
            Bezoeker = new HashSet<Bezoeker>();
            ChangeAanmelderlokatie = new HashSet<Change>();
            ChangeLocation = new HashSet<Change>();
            Configuratie = new HashSet<Configuratie>();
            Dnolocationlink = new HashSet<Dnolocationlink>();
            Hardware = new HashSet<Hardware>();
            IncidentAanmelderlokatie = new HashSet<Incident>();
            IncidentLocatie = new HashSet<Incident>();
            Inventaris = new HashSet<Inventaris>();
            InverseMajorlocation = new HashSet<Locatie>();
            Lmpactivity = new HashSet<Lmpactivity>();
            LocatieActiedoorLink = new HashSet<LocatieActiedoorLink>();
            LocatieDocumenten = new HashSet<LocatieDocumenten>();
            LocatieEmailberichten = new HashSet<LocatieEmailberichten>();
            LocatieLogboek = new HashSet<LocatieLogboek>();
            LocatieMemoHistory = new HashSet<LocatieMemoHistory>();
            LocatieOptionalgrid = new HashSet<LocatieOptionalgrid>();
            LocatiePicture = new HashSet<LocatiePicture>();
            LocatieRuimteopstellingLink = new HashSet<LocatieRuimteopstellingLink>();
            Meeting = new HashSet<Meeting>();
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
            ObjVestigingLink = new HashSet<ObjVestigingLink>();
            Object = new HashSet<Object>();
            OmActiviteitLocatieLink = new HashSet<OmActiviteitLocatieLink>();
            OmReeksLocatieLink = new HashSet<OmReeksLocatieLink>();
            Persoon = new HashSet<Persoon>();
            Persoongroep = new HashSet<Persoongroep>();
            ReservationFacilityLink = new HashSet<ReservationFacilityLink>();
            ReservationServiceLink = new HashSet<ReservationServiceLink>();
            Reservering = new HashSet<Reservering>();
            ReserveringLocatieLink = new HashSet<ReserveringLocatieLink>();
            ReserveringVoorzieningLink = new HashSet<ReserveringVoorzieningLink>();
            RmSeriesLocationLink = new HashSet<RmSeriesLocationLink>();
            RmSeriesServiceLink = new HashSet<RmSeriesServiceLink>();
            Ruimteonderhoud = new HashSet<Ruimteonderhoud>();
            Software = new HashSet<Software>();
            Telefonie = new HashSet<Telefonie>();
            VoorzieningLocatieLink = new HashSet<VoorzieningLocatieLink>();
            Vrij1object = new HashSet<Vrij1object>();
            Vrij2object = new HashSet<Vrij2object>();
            Vrij3object = new HashSet<Vrij3object>();
            Vrij4object = new HashSet<Vrij4object>();
            Vrij5object = new HashSet<Vrij5object>();
        }

        public string RefPlaats1 { get; set; }
        public string RefVestiging { get; set; }
        public int Status { get; set; }
        public Guid Unid { get; set; }
        public Guid? Vestigingid { get; set; }
        public DateTime? Dataanmk { get; set; }
        public DateTime? Datwijzig { get; set; }
        public Guid? Uidaanmk { get; set; }
        public Guid? Uidwijzig { get; set; }
        public bool Reserveerbaaractiveerbaar { get; set; }
        public bool Reserveerbaarsecure { get; set; }
        public bool Reserveerbaarsshd { get; set; }
        public string Ruimteid { get; set; }
        public Guid? Gebruiksfunctieid { get; set; }
        public Guid? Ruimtetypeid { get; set; }
        public string Specificatie { get; set; }
        public Guid? Budgethouderid { get; set; }
        public double Vloeroppervlakte { get; set; }
        public Guid? Vloerbedekking { get; set; }
        public double Glasoppervlakte { get; set; }
        public Guid? Glasmateriaal { get; set; }
        public double Wandoppervlakte { get; set; }
        public Guid? Wandbedekking { get; set; }
        public Guid? Statusid { get; set; }
        public int Capaciteit { get; set; }
        public int MaxCapaciteit { get; set; }
        public bool Opstellingwijzigbaar { get; set; }
        public double Lengte { get; set; }
        public double Breedte { get; set; }
        public double Hoogte { get; set; }
        public double VloeroppBruto { get; set; }
        public double VloeroppNetto { get; set; }
        public double VloeroppTarra { get; set; }
        public double Gebruiksoppervlakte { get; set; }
        public double Verhuurbaaroppervlakte { get; set; }
        public double GemeenschRuimte { get; set; }
        public double VerkeersruimteHor { get; set; }
        public double VerkeersruimteVert { get; set; }
        public double InhoudBruto { get; set; }
        public double InhoudNetto { get; set; }
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
        public decimal Verhuurborg { get; set; }
        public decimal Verhuurprijs { get; set; }
        public int Verhuurprijssysteem { get; set; }
        public string Verhuurtekst { get; set; }
        public string Aantekeningen { get; set; }
        public DateTime? Vrijedatum1 { get; set; }
        public DateTime? Vrijedatum2 { get; set; }
        public bool Reserveerbaarkantooruren { get; set; }
        public Guid? Archiefredenid { get; set; }
        public bool Reservzichtbaarsshd { get; set; }
        public double Plafondoppervlakte { get; set; }
        public Guid? Plafondbedekking { get; set; }
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
        public string Naam { get; set; }
        public string Bespokememo { get; set; }
        public string RmSpecification { get; set; }
        public int Importtype { get; set; }
        public DateTime? Importdate { get; set; }
        public int Blocktime { get; set; }
        public bool Ismajorlocation { get; set; }
        public Guid? Majorlocationid { get; set; }
        public decimal CostsHightariff { get; set; }
        public bool ReservableOfficehoursSsd { get; set; }
        public Guid? Servicewindowid { get; set; }
        public int ServicewindowOption { get; set; }
        public Guid? Zoneid { get; set; }

        public Archiefreden Archiefreden { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek1Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek2Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek3Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek4Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek5Navigation { get; set; }
        public Budgethouder Budgethouder { get; set; }
        public Ruimtegebruiksfunctie Gebruiksfunctie { get; set; }
        public Ruimtemateriaalglas GlasmateriaalNavigation { get; set; }
        public Locatie Majorlocation { get; set; }
        public Ruimtemateriaalplafond PlafondbedekkingNavigation { get; set; }
        public Ruimtetype Ruimtetype { get; set; }
        public Servicewindow Servicewindow { get; set; }
        public Ruimtestatus StatusNavigation { get; set; }
        public Gebruiker UidaanmkNavigation { get; set; }
        public Gebruiker UidwijzigNavigation { get; set; }
        public Vestiging Vestiging { get; set; }
        public Ruimtemateriaalvloer VloerbedekkingNavigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek1Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek2Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek3Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek4Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek5Navigation { get; set; }
        public Ruimtemateriaalwand WandbedekkingNavigation { get; set; }
        public BuildingZone Zone { get; set; }
        public ICollection<Actiedoor> Actiedoor { get; set; }
        public ICollection<Bestelaanvraag> Bestelaanvraag { get; set; }
        public ICollection<Bezoeker> Bezoeker { get; set; }
        public ICollection<Change> ChangeAanmelderlokatie { get; set; }
        public ICollection<Change> ChangeLocation { get; set; }
        public ICollection<Configuratie> Configuratie { get; set; }
        public ICollection<Dnolocationlink> Dnolocationlink { get; set; }
        public ICollection<Hardware> Hardware { get; set; }
        public ICollection<Incident> IncidentAanmelderlokatie { get; set; }
        public ICollection<Incident> IncidentLocatie { get; set; }
        public ICollection<Inventaris> Inventaris { get; set; }
        public ICollection<Locatie> InverseMajorlocation { get; set; }
        public ICollection<Lmpactivity> Lmpactivity { get; set; }
        public ICollection<LocatieActiedoorLink> LocatieActiedoorLink { get; set; }
        public ICollection<LocatieDocumenten> LocatieDocumenten { get; set; }
        public ICollection<LocatieEmailberichten> LocatieEmailberichten { get; set; }
        public ICollection<LocatieLogboek> LocatieLogboek { get; set; }
        public ICollection<LocatieMemoHistory> LocatieMemoHistory { get; set; }
        public ICollection<LocatieOptionalgrid> LocatieOptionalgrid { get; set; }
        public ICollection<LocatiePicture> LocatiePicture { get; set; }
        public ICollection<LocatieRuimteopstellingLink> LocatieRuimteopstellingLink { get; set; }
        public ICollection<Meeting> Meeting { get; set; }
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
        public ICollection<ObjVestigingLink> ObjVestigingLink { get; set; }
        public ICollection<Object> Object { get; set; }
        public ICollection<OmActiviteitLocatieLink> OmActiviteitLocatieLink { get; set; }
        public ICollection<OmReeksLocatieLink> OmReeksLocatieLink { get; set; }
        public ICollection<Persoon> Persoon { get; set; }
        public ICollection<Persoongroep> Persoongroep { get; set; }
        public ICollection<ReservationFacilityLink> ReservationFacilityLink { get; set; }
        public ICollection<ReservationServiceLink> ReservationServiceLink { get; set; }
        public ICollection<Reservering> Reservering { get; set; }
        public ICollection<ReserveringLocatieLink> ReserveringLocatieLink { get; set; }
        public ICollection<ReserveringVoorzieningLink> ReserveringVoorzieningLink { get; set; }
        public ICollection<RmSeriesLocationLink> RmSeriesLocationLink { get; set; }
        public ICollection<RmSeriesServiceLink> RmSeriesServiceLink { get; set; }
        public ICollection<Ruimteonderhoud> Ruimteonderhoud { get; set; }
        public ICollection<Software> Software { get; set; }
        public ICollection<Telefonie> Telefonie { get; set; }
        public ICollection<VoorzieningLocatieLink> VoorzieningLocatieLink { get; set; }
        public ICollection<Vrij1object> Vrij1object { get; set; }
        public ICollection<Vrij2object> Vrij2object { get; set; }
        public ICollection<Vrij3object> Vrij3object { get; set; }
        public ICollection<Vrij4object> Vrij4object { get; set; }
        public ICollection<Vrij5object> Vrij5object { get; set; }
    }
}
