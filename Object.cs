using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Object
    {
        public Object()
        {
            ArtikelBestelLink = new HashSet<ArtikelBestelLink>();
            ArtikelLeverancierLink = new HashSet<ArtikelLeverancierLink>();
            ArtikelMutatie = new HashSet<ArtikelMutatie>();
            ArtikelVoorraadLink = new HashSet<ArtikelVoorraadLink>();
            BestelaanvraagArtikelLink = new HashSet<BestelaanvraagArtikelLink>();
            Change = new HashSet<Change>();
            ChangeObjectLink = new HashSet<ChangeObjectLink>();
            ChangeactivityObjectLink = new HashSet<ChangeactivityObjectLink>();
            Dnoobjectlink = new HashSet<Dnoobjectlink>();
            Hardware = new HashSet<Hardware>();
            Incident = new HashSet<Incident>();
            Inventaris = new HashSet<Inventaris>();
            KostendeclaratieObject = new HashSet<KostendeclaratieObject>();
            Lmpactivity = new HashSet<Lmpactivity>();
            Netwerkcomponent = new HashSet<Netwerkcomponent>();
            ObjConfLink = new HashSet<ObjConfLink>();
            ObjIncidentLink = new HashSet<ObjIncidentLink>();
            ObjPersoonLink = new HashSet<ObjPersoonLink>();
            ObjPersoongroepLink = new HashSet<ObjPersoongroepLink>();
            ObjProblemLink = new HashSet<ObjProblemLink>();
            ObjVestigingLink = new HashSet<ObjVestigingLink>();
            ObjectObjectLinkChild = new HashSet<ObjectObjectLink>();
            ObjectObjectLinkParent = new HashSet<ObjectObjectLink>();
            ObjectPicture = new HashSet<ObjectPicture>();
            OmActiviteitObjectLink = new HashSet<OmActiviteitObjectLink>();
            OmReeksObjectLink = new HashSet<OmReeksObjectLink>();
            Poort = new HashSet<Poort>();
            Reparatie = new HashSet<Reparatie>();
            ReservationFacilityLink = new HashSet<ReservationFacilityLink>();
            ReserveringObjectLink = new HashSet<ReserveringObjectLink>();
            ReserveringVoorzieningLink = new HashSet<ReserveringVoorzieningLink>();
            RmSeriesObjectLink = new HashSet<RmSeriesObjectLink>();
            RmSeriesServiceLink = new HashSet<RmSeriesServiceLink>();
            Software = new HashSet<Software>();
            Telefonie = new HashSet<Telefonie>();
            Topsisgroup = new HashSet<Topsisgroup>();
            VoorzieningObjectLink = new HashSet<VoorzieningObjectLink>();
            Vrij1object = new HashSet<Vrij1object>();
            Vrij2object = new HashSet<Vrij2object>();
            Vrij3object = new HashSet<Vrij3object>();
            Vrij4object = new HashSet<Vrij4object>();
            Vrij5object = new HashSet<Vrij5object>();
        }

        public Guid? RefAanspreekpuntid { get; set; }
        public Guid? RefArtikelstatusid { get; set; }
        public bool RefArtikelwordtobject { get; set; }
        public Guid? RefBudgethouderid { get; set; }
        public string RefConfignaam { get; set; }
        public Guid? RefConfiguratieid { get; set; }
        public Guid? RefGroepid { get; set; }
        public int RefHuidigevoorraad { get; set; }
        public string RefKorteomschrijving { get; set; }
        public string RefLeverancier { get; set; }
        public Guid? RefLeverancierid { get; set; }
        public Guid? RefLicentiesoortid { get; set; }
        public Guid? RefLokatieid { get; set; }
        public Guid? RefMerkid { get; set; }
        public Guid? RefPersoongroepid { get; set; }
        public Guid? RefPersoonid { get; set; }
        public string RefPlaats { get; set; }
        public int RefPlaatskeuze { get; set; }
        public Guid? RefSoortid { get; set; }
        public int RefStatus { get; set; }
        public int RefVeiligvoorraad { get; set; }
        public int RefVerhuurprijssysteem { get; set; }
        public string RefVerhuurtekst { get; set; }
        public string RefVestiging { get; set; }
        public Guid? RefVestigingid { get; set; }
        public int Status { get; set; }
        public Guid? Statusid { get; set; }
        public string Type { get; set; }
        public Guid Unid { get; set; }
        public string RefOrdernummer { get; set; }
        public string RefLeasecontractnummer { get; set; }
        public int RefLeaseperiode { get; set; }
        public int RefObjectplaats { get; set; }
        public string RefPersoongroep { get; set; }
        public DateTime? RefAanschafdatum { get; set; }
        public DateTime? RefLeaseaanvangsdatum { get; set; }
        public DateTime? RefLeaseeinddatum { get; set; }
        public decimal RefAankoopbedrag { get; set; }
        public decimal RefLeaseprijs { get; set; }
        public decimal RefRestwaarde { get; set; }
        public decimal RefVerhuurborg { get; set; }
        public decimal RefVerhuurprijs { get; set; }
        public string RefHostnaam { get; set; }
        public string RefIpadres { get; set; }
        public string RefSpecificatie { get; set; }
        public decimal RefVerkoopprijs { get; set; }
        public bool RefBestelbaarinssh { get; set; }
        public bool RefReserveerbaaractiveerbaar { get; set; }
        public bool RefReserveerbaarsecure { get; set; }
        public bool RefReserveerbaarsshd { get; set; }
        public Guid? RefStdresvbehandelaarid { get; set; }
        public Guid? RefAttentieid { get; set; }
        public int RefKleur { get; set; }
        public bool RefHeeftattentie { get; set; }
        public string RefOpmerking { get; set; }
        public bool RefReserveerbaarkantooruren { get; set; }
        public bool RefReservzichtbaarsshd { get; set; }
        public Guid? RefTypeid { get; set; }
        public bool RefHeeftvoorraad { get; set; }
        public string RefNaam { get; set; }
        public string Importid { get; set; }
        public string RefLokatie { get; set; }
        public string RefSerienummer { get; set; }
        public string Bespokememo { get; set; }
        public string RefRmSpecification { get; set; }
        public int Importtype { get; set; }
        public DateTime? Importdate { get; set; }
        public string RefMerk { get; set; }
        public string RefGebruiker { get; set; }
        public string RefPersoon { get; set; }
        public string RefArtikelstatus { get; set; }
        public string RefSoort { get; set; }
        public string RefType { get; set; }
        public DateTime? Dataanmk { get; set; }
        public DateTime? Datwijzig { get; set; }
        public Guid? Uidaanmk { get; set; }
        public Guid? Uidwijzig { get; set; }
        public Guid? RefArchiefredenid { get; set; }
        public int? RefLeaseinfo { get; set; }
        public int RefBlocktime { get; set; }
        public bool RefReservablewithlocation { get; set; }
        public decimal RefCostsHightariff { get; set; }
        public bool RefReservableOfficehoursSsd { get; set; }
        public Guid? RefServicewindowid { get; set; }
        public int RefServicewindowOption { get; set; }

        public Actiedoor RefAanspreekpunt { get; set; }
        public Archiefreden RefArchiefreden { get; set; }
        public Artikelstatus RefArtikelstatusNavigation { get; set; }
        public Attentie RefAttentie { get; set; }
        public Budgethouder RefBudgethouder { get; set; }
        public Configuratie RefConfiguratie { get; set; }
        public Persoongroep RefGroep { get; set; }
        public Leverancier RefLeverancierNavigation { get; set; }
        public Licentiesoort RefLicentiesoort { get; set; }
        public Locatie RefLokatieNavigation { get; set; }
        public Objectmerk RefMerkNavigation { get; set; }
        public Persoon RefPersoonNavigation { get; set; }
        public Persoongroep RefPersoongroepNavigation { get; set; }
        public Servicewindow RefServicewindow { get; set; }
        public Objectsoort RefSoortNavigation { get; set; }
        public Actiedoor RefStdresvbehandelaar { get; set; }
        public Objecttype RefTypeNavigation { get; set; }
        public Vestiging RefVestigingNavigation { get; set; }
        public Objectstatus StatusNavigation { get; set; }
        public Gebruiker UidaanmkNavigation { get; set; }
        public Gebruiker UidwijzigNavigation { get; set; }
        public ICollection<ArtikelBestelLink> ArtikelBestelLink { get; set; }
        public ICollection<ArtikelLeverancierLink> ArtikelLeverancierLink { get; set; }
        public ICollection<ArtikelMutatie> ArtikelMutatie { get; set; }
        public ICollection<ArtikelVoorraadLink> ArtikelVoorraadLink { get; set; }
        public ICollection<BestelaanvraagArtikelLink> BestelaanvraagArtikelLink { get; set; }
        public ICollection<Change> Change { get; set; }
        public ICollection<ChangeObjectLink> ChangeObjectLink { get; set; }
        public ICollection<ChangeactivityObjectLink> ChangeactivityObjectLink { get; set; }
        public ICollection<Dnoobjectlink> Dnoobjectlink { get; set; }
        public ICollection<Hardware> Hardware { get; set; }
        public ICollection<Incident> Incident { get; set; }
        public ICollection<Inventaris> Inventaris { get; set; }
        public ICollection<KostendeclaratieObject> KostendeclaratieObject { get; set; }
        public ICollection<Lmpactivity> Lmpactivity { get; set; }
        public ICollection<Netwerkcomponent> Netwerkcomponent { get; set; }
        public ICollection<ObjConfLink> ObjConfLink { get; set; }
        public ICollection<ObjIncidentLink> ObjIncidentLink { get; set; }
        public ICollection<ObjPersoonLink> ObjPersoonLink { get; set; }
        public ICollection<ObjPersoongroepLink> ObjPersoongroepLink { get; set; }
        public ICollection<ObjProblemLink> ObjProblemLink { get; set; }
        public ICollection<ObjVestigingLink> ObjVestigingLink { get; set; }
        public ICollection<ObjectObjectLink> ObjectObjectLinkChild { get; set; }
        public ICollection<ObjectObjectLink> ObjectObjectLinkParent { get; set; }
        public ICollection<ObjectPicture> ObjectPicture { get; set; }
        public ICollection<OmActiviteitObjectLink> OmActiviteitObjectLink { get; set; }
        public ICollection<OmReeksObjectLink> OmReeksObjectLink { get; set; }
        public ICollection<Poort> Poort { get; set; }
        public ICollection<Reparatie> Reparatie { get; set; }
        public ICollection<ReservationFacilityLink> ReservationFacilityLink { get; set; }
        public ICollection<ReserveringObjectLink> ReserveringObjectLink { get; set; }
        public ICollection<ReserveringVoorzieningLink> ReserveringVoorzieningLink { get; set; }
        public ICollection<RmSeriesObjectLink> RmSeriesObjectLink { get; set; }
        public ICollection<RmSeriesServiceLink> RmSeriesServiceLink { get; set; }
        public ICollection<Software> Software { get; set; }
        public ICollection<Telefonie> Telefonie { get; set; }
        public ICollection<Topsisgroup> Topsisgroup { get; set; }
        public ICollection<VoorzieningObjectLink> VoorzieningObjectLink { get; set; }
        public ICollection<Vrij1object> Vrij1object { get; set; }
        public ICollection<Vrij2object> Vrij2object { get; set; }
        public ICollection<Vrij3object> Vrij3object { get; set; }
        public ICollection<Vrij4object> Vrij4object { get; set; }
        public ICollection<Vrij5object> Vrij5object { get; set; }
    }
}
