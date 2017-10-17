using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Leverancier
    {
        public Leverancier()
        {
            ArtikelLeverancierLink = new HashSet<ArtikelLeverancierLink>();
            ArtikelMutatie = new HashSet<ArtikelMutatie>();
            BestelaanvraagArtikelLink = new HashSet<BestelaanvraagArtikelLink>();
            BestellingenNavigation = new HashSet<Bestellingen>();
            ClassificatieFirstlinesupplierNavigation = new HashSet<Classificatie>();
            ClassificatieSecondlinesupplierNavigation = new HashSet<Classificatie>();
            Dnocontract = new HashSet<Dnocontract>();
            HardwareLeverancier = new HashSet<Hardware>();
            HardwareOnderhoudDoor = new HashSet<Hardware>();
            Incident = new HashSet<Incident>();
            InventarisLeverancier = new HashSet<Inventaris>();
            InventarisOnderhoudDoor = new HashSet<Inventaris>();
            LeverancierDocumenten = new HashSet<LeverancierDocumenten>();
            LeverancierEmailberichten = new HashSet<LeverancierEmailberichten>();
            LeverancierLogboek = new HashSet<LeverancierLogboek>();
            LeverancierMemoHistory = new HashSet<LeverancierMemoHistory>();
            Leveranciercontactpersoon = new HashSet<Leveranciercontactpersoon>();
            LicentieLeverancier = new HashSet<Licentie>();
            LicentieOnderhoudDoor = new HashSet<Licentie>();
            MutatieIncident = new HashSet<MutatieIncident>();
            MutatieOmActiviteit = new HashSet<MutatieOmActiviteit>();
            NetwerkcomponentLeverancier = new HashSet<Netwerkcomponent>();
            NetwerkcomponentOnderhoudDoor = new HashSet<Netwerkcomponent>();
            Object = new HashSet<Object>();
            OmActiviteit = new HashSet<OmActiviteit>();
            OmReeks = new HashSet<OmReeks>();
            OplossingenFirstlinesupplier = new HashSet<Oplossingen>();
            OplossingenSecondlinesupplier = new HashSet<Oplossingen>();
            Patch = new HashSet<Patch>();
            Reparatie = new HashSet<Reparatie>();
            Ruimteonderhoud = new HashSet<Ruimteonderhoud>();
            SoftwareLeverancier = new HashSet<Software>();
            SoftwareOnderhoudDoor = new HashSet<Software>();
            TelefonieLeverancier = new HashSet<Telefonie>();
            TelefonieOnderhoudDoor = new HashSet<Telefonie>();
            TelefonieService = new HashSet<Telefonie>();
            Vrij1objectLeverancier = new HashSet<Vrij1object>();
            Vrij1objectOnderhoudDoor = new HashSet<Vrij1object>();
            Vrij2objectLeverancier = new HashSet<Vrij2object>();
            Vrij2objectOnderhoudDoor = new HashSet<Vrij2object>();
            Vrij3objectLeverancier = new HashSet<Vrij3object>();
            Vrij3objectOnderhoudDoor = new HashSet<Vrij3object>();
            Vrij4objectLeverancier = new HashSet<Vrij4object>();
            Vrij4objectOnderhoudDoor = new HashSet<Vrij4object>();
            Vrij5objectLeverancier = new HashSet<Vrij5object>();
            Vrij5objectOnderhoudDoor = new HashSet<Vrij5object>();
        }

        public string Aantekeningen { get; set; }
        public string Adresmemo1 { get; set; }
        public string Adresmemo2 { get; set; }
        public Guid? Archiefredenid { get; set; }
        public bool Bestellingen { get; set; }
        public string Besteltekst { get; set; }
        public int Bestelvolgnr { get; set; }
        public string Debiteurennummer { get; set; }
        public string Diversen { get; set; }
        public string Fax { get; set; }
        public Guid? Landid1 { get; set; }
        public Guid? Landid2 { get; set; }
        public string Naam { get; set; }
        public string Plaats1 { get; set; }
        public string Plaats2 { get; set; }
        public string Postcode1 { get; set; }
        public string Postcode2 { get; set; }
        public string Specificatie { get; set; }
        public Guid? Standaardaflevervestigingid { get; set; }
        public double Standaardkortingprocent { get; set; }
        public int Standaardkortingsoort { get; set; }
        public int Status { get; set; }
        public string Straat1 { get; set; }
        public string Straat2 { get; set; }
        public string Telefoon { get; set; }
        public string Telefoonbbs { get; set; }
        public Guid? Uidaanmk { get; set; }
        public Guid? Uidwijzig { get; set; }
        public Guid Unid { get; set; }
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
        public string Bestelcode { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public DateTime? Dataanmk { get; set; }
        public DateTime? Datwijzig { get; set; }
        public DateTime? Vrijedatum1 { get; set; }
        public DateTime? Vrijedatum2 { get; set; }
        public decimal Standaardkorting { get; set; }
        public decimal Standaardverzendkosten { get; set; }
        public Guid? Standaardverzendkostenbtwsrtid { get; set; }
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
        public string Huisnummer1 { get; set; }
        public string Huisnummer2 { get; set; }
        public string Bespokememo { get; set; }
        public bool Firstlinesupplier { get; set; }
        public bool Secondlinesupplier { get; set; }
        public string Importid { get; set; }
        public string County1 { get; set; }
        public string County2 { get; set; }
        public Guid? Maincontactid { get; set; }
        public bool Omactivitysupplier { get; set; }

        public Archiefreden Archiefreden { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek1Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek2Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek3Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek4Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek5Navigation { get; set; }
        public Land Landid1Navigation { get; set; }
        public Land Landid2Navigation { get; set; }
        public Leveranciercontactpersoon Maincontact { get; set; }
        public Vestiging Standaardaflevervestiging { get; set; }
        public Btw Standaardverzendkostenbtwsrt { get; set; }
        public Gebruiker UidaanmkNavigation { get; set; }
        public Gebruiker UidwijzigNavigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek1Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek2Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek3Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek4Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek5Navigation { get; set; }
        public ICollection<ArtikelLeverancierLink> ArtikelLeverancierLink { get; set; }
        public ICollection<ArtikelMutatie> ArtikelMutatie { get; set; }
        public ICollection<BestelaanvraagArtikelLink> BestelaanvraagArtikelLink { get; set; }
        public ICollection<Bestellingen> BestellingenNavigation { get; set; }
        public ICollection<Classificatie> ClassificatieFirstlinesupplierNavigation { get; set; }
        public ICollection<Classificatie> ClassificatieSecondlinesupplierNavigation { get; set; }
        public ICollection<Dnocontract> Dnocontract { get; set; }
        public ICollection<Hardware> HardwareLeverancier { get; set; }
        public ICollection<Hardware> HardwareOnderhoudDoor { get; set; }
        public ICollection<Incident> Incident { get; set; }
        public ICollection<Inventaris> InventarisLeverancier { get; set; }
        public ICollection<Inventaris> InventarisOnderhoudDoor { get; set; }
        public ICollection<LeverancierDocumenten> LeverancierDocumenten { get; set; }
        public ICollection<LeverancierEmailberichten> LeverancierEmailberichten { get; set; }
        public ICollection<LeverancierLogboek> LeverancierLogboek { get; set; }
        public ICollection<LeverancierMemoHistory> LeverancierMemoHistory { get; set; }
        public ICollection<Leveranciercontactpersoon> Leveranciercontactpersoon { get; set; }
        public ICollection<Licentie> LicentieLeverancier { get; set; }
        public ICollection<Licentie> LicentieOnderhoudDoor { get; set; }
        public ICollection<MutatieIncident> MutatieIncident { get; set; }
        public ICollection<MutatieOmActiviteit> MutatieOmActiviteit { get; set; }
        public ICollection<Netwerkcomponent> NetwerkcomponentLeverancier { get; set; }
        public ICollection<Netwerkcomponent> NetwerkcomponentOnderhoudDoor { get; set; }
        public ICollection<Object> Object { get; set; }
        public ICollection<OmActiviteit> OmActiviteit { get; set; }
        public ICollection<OmReeks> OmReeks { get; set; }
        public ICollection<Oplossingen> OplossingenFirstlinesupplier { get; set; }
        public ICollection<Oplossingen> OplossingenSecondlinesupplier { get; set; }
        public ICollection<Patch> Patch { get; set; }
        public ICollection<Reparatie> Reparatie { get; set; }
        public ICollection<Ruimteonderhoud> Ruimteonderhoud { get; set; }
        public ICollection<Software> SoftwareLeverancier { get; set; }
        public ICollection<Software> SoftwareOnderhoudDoor { get; set; }
        public ICollection<Telefonie> TelefonieLeverancier { get; set; }
        public ICollection<Telefonie> TelefonieOnderhoudDoor { get; set; }
        public ICollection<Telefonie> TelefonieService { get; set; }
        public ICollection<Vrij1object> Vrij1objectLeverancier { get; set; }
        public ICollection<Vrij1object> Vrij1objectOnderhoudDoor { get; set; }
        public ICollection<Vrij2object> Vrij2objectLeverancier { get; set; }
        public ICollection<Vrij2object> Vrij2objectOnderhoudDoor { get; set; }
        public ICollection<Vrij3object> Vrij3objectLeverancier { get; set; }
        public ICollection<Vrij3object> Vrij3objectOnderhoudDoor { get; set; }
        public ICollection<Vrij4object> Vrij4objectLeverancier { get; set; }
        public ICollection<Vrij4object> Vrij4objectOnderhoudDoor { get; set; }
        public ICollection<Vrij5object> Vrij5objectLeverancier { get; set; }
        public ICollection<Vrij5object> Vrij5objectOnderhoudDoor { get; set; }
    }
}
