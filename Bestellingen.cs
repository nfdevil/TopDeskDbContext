using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Bestellingen
    {
        public Bestellingen()
        {
            ArtikelBestelLink = new HashSet<ArtikelBestelLink>();
            BestelaanvraagBestellingenLink = new HashSet<BestelaanvraagBestellingenLink>();
            BestellingenDocumenten = new HashSet<BestellingenDocumenten>();
            BestellingenEmailberichten = new HashSet<BestellingenEmailberichten>();
            BestellingenLogboek = new HashSet<BestellingenLogboek>();
            Changeactivityorderlink = new HashSet<Changeactivityorderlink>();
            Hardware = new HashSet<Hardware>();
            Inventaris = new HashSet<Inventaris>();
            Licentie = new HashSet<Licentie>();
            MutatieBestellingen = new HashSet<MutatieBestellingen>();
            Netwerkcomponent = new HashSet<Netwerkcomponent>();
            Software = new HashSet<Software>();
            Telefonie = new HashSet<Telefonie>();
            Vrij1object = new HashSet<Vrij1object>();
            Vrij2object = new HashSet<Vrij2object>();
            Vrij3object = new HashSet<Vrij3object>();
            Vrij4object = new HashSet<Vrij4object>();
            Vrij5object = new HashSet<Vrij5object>();
        }

        public int Aantal { get; set; }
        public string Aantekeningen { get; set; }
        public string Adresmemo1 { get; set; }
        public string Adresmemo2 { get; set; }
        public Guid? Afmeldautorisatieid { get; set; }
        public Guid? Archiefredenid { get; set; }
        public Guid? Behandelaarid { get; set; }
        public Guid? Bestelaanvraagid { get; set; }
        public Guid? Bestelafmeldid { get; set; }
        public Guid? Bestelautorisatieid { get; set; }
        public Guid? Contactpersoonid { get; set; }
        public string Inkoopmemo { get; set; }
        public bool Kortinginstellen { get; set; }
        public double Kortingprocent { get; set; }
        public int Kortingsoort { get; set; }
        public Guid? Landid1 { get; set; }
        public Guid? Landid2 { get; set; }
        public string LeverancierDebiteurennummer { get; set; }
        public string LeverancierFactuurnummer { get; set; }
        public string LeverancierSpecificatie { get; set; }
        public Guid? Leverancierid { get; set; }
        public string Naam { get; set; }
        public string Offertenr { get; set; }
        public string Ordernr { get; set; }
        public string Plaats1 { get; set; }
        public string Plaats2 { get; set; }
        public string Postcode1 { get; set; }
        public string Postcode2 { get; set; }
        public string RefLeverancier { get; set; }
        public int Status { get; set; }
        public Guid? Statusid { get; set; }
        public string Straat1 { get; set; }
        public string Straat2 { get; set; }
        public Guid? Uidaanmk { get; set; }
        public Guid? Uidwijzig { get; set; }
        public Guid Unid { get; set; }
        public string Vervoerder { get; set; }
        public Guid? Verzendkostenbtwsoortid { get; set; }
        public string VestigingFax { get; set; }
        public string VestigingSpecificatie { get; set; }
        public string VestigingTelefoon { get; set; }
        public Guid? Vestigingcontactpersoonid { get; set; }
        public Guid? Vestigingid { get; set; }
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
        public string VestigingTelefoon2 { get; set; }
        public string RefVestiging2 { get; set; }
        public string VestigingDebiteurennummer2 { get; set; }
        public string RefVestiging { get; set; }
        public string VestigingSpecificatie2 { get; set; }
        public string Internbestelnr { get; set; }
        public Guid? Vestigingcontactpersoonid2 { get; set; }
        public string VestigingFax2 { get; set; }
        public string VestigingDebiteurennummer { get; set; }
        public string VestigingEmail { get; set; }
        public string VestigingWebsite { get; set; }
        public string VestigingEmail2 { get; set; }
        public string VestigingWebsite2 { get; set; }
        public DateTime? Besteldatum { get; set; }
        public DateTime? Dataanmk { get; set; }
        public DateTime? Datwijzig { get; set; }
        public DateTime? Geplandebesteldatum { get; set; }
        public DateTime? Ordernrdatum { get; set; }
        public DateTime? Verwachtdatum { get; set; }
        public DateTime? Vrijedatum1 { get; set; }
        public DateTime? Vrijedatum2 { get; set; }
        public decimal KaleArtikelenPrijs { get; set; }
        public decimal Korting { get; set; }
        public decimal Totaalberekendekorting { get; set; }
        public decimal Totaalbtw { get; set; }
        public decimal Totaalkosten { get; set; }
        public decimal Totaalkosteninclusiefbtw { get; set; }
        public decimal Verzendkosten { get; set; }
        public Guid? Vestigingid2 { get; set; }
        public Guid? Budgethouderid { get; set; }
        public DateTime? Afmelddatum { get; set; }
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
        public string Actie { get; set; }
        public string Importid { get; set; }
        public string Huisnummer1 { get; set; }
        public string Huisnummer2 { get; set; }
        public string Bespokememo { get; set; }
        public int Importtype { get; set; }
        public DateTime? Importdate { get; set; }
        public string RefAutorisator { get; set; }
        public string RefBestelstatus { get; set; }
        public string County1 { get; set; }
        public string County2 { get; set; }

        public Actiedoor Afmeldautorisatie { get; set; }
        public Archiefreden Archiefreden { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek1Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek2Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek3Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek4Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek5Navigation { get; set; }
        public Actiedoor Behandelaar { get; set; }
        public Bestelreden Bestelaanvraag { get; set; }
        public Bestelreden Bestelafmeld { get; set; }
        public Actiedoor Bestelautorisatie { get; set; }
        public Budgethouder Budgethouder { get; set; }
        public Leveranciercontactpersoon Contactpersoon { get; set; }
        public Land Landid1Navigation { get; set; }
        public Land Landid2Navigation { get; set; }
        public Leverancier Leverancier { get; set; }
        public Bestelstatus StatusNavigation { get; set; }
        public Gebruiker UidaanmkNavigation { get; set; }
        public Gebruiker UidwijzigNavigation { get; set; }
        public Btw Verzendkostenbtwsoort { get; set; }
        public Vestiging Vestiging { get; set; }
        public Persoon Vestigingcontactpersoon { get; set; }
        public Persoon Vestigingcontactpersoonid2Navigation { get; set; }
        public Vestiging Vestigingid2Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek1Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek2Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek3Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek4Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek5Navigation { get; set; }
        public ICollection<ArtikelBestelLink> ArtikelBestelLink { get; set; }
        public ICollection<BestelaanvraagBestellingenLink> BestelaanvraagBestellingenLink { get; set; }
        public ICollection<BestellingenDocumenten> BestellingenDocumenten { get; set; }
        public ICollection<BestellingenEmailberichten> BestellingenEmailberichten { get; set; }
        public ICollection<BestellingenLogboek> BestellingenLogboek { get; set; }
        public ICollection<Changeactivityorderlink> Changeactivityorderlink { get; set; }
        public ICollection<Hardware> Hardware { get; set; }
        public ICollection<Inventaris> Inventaris { get; set; }
        public ICollection<Licentie> Licentie { get; set; }
        public ICollection<MutatieBestellingen> MutatieBestellingen { get; set; }
        public ICollection<Netwerkcomponent> Netwerkcomponent { get; set; }
        public ICollection<Software> Software { get; set; }
        public ICollection<Telefonie> Telefonie { get; set; }
        public ICollection<Vrij1object> Vrij1object { get; set; }
        public ICollection<Vrij2object> Vrij2object { get; set; }
        public ICollection<Vrij3object> Vrij3object { get; set; }
        public ICollection<Vrij4object> Vrij4object { get; set; }
        public ICollection<Vrij5object> Vrij5object { get; set; }
    }
}
