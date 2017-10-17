﻿using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Vrij1object : IVrijobject
    {
        public Vrij1object()
        {
            InverseSjabloonobject = new HashSet<Vrij1object>();
            MutatieVrij1object = new HashSet<MutatieVrij1object>();
            Vrij1objectDocumenten = new HashSet<Vrij1objectDocumenten>();
            Vrij1objectEmailberichten = new HashSet<Vrij1objectEmailberichten>();
            Vrij1objectLogboek = new HashSet<Vrij1objectLogboek>();
            Vrij1objectOptionalgrid = new HashSet<Vrij1objectOptionalgrid>();
        }

        public decimal Aankoopbedrag { get; set; }
        public DateTime? Aanschafdatum { get; set; }
        public Guid? Aanspreekpuntid { get; set; }
        public string Aantekeningen { get; set; }
        public int Afschrijftermijn { get; set; }
        public Guid? Archiefredenid { get; set; }
        public Guid? Artikelbestellinkid { get; set; }
        public Guid? Artikelstatusid { get; set; }
        public bool Artikelwordtobject { get; set; }
        public Guid? Bestelaanvraagid { get; set; }
        public bool Bestelbaarinssh { get; set; }
        public Guid? Bestellingid { get; set; }
        public Guid? Budgethouderid { get; set; }
        public Guid? Configuratieid { get; set; }
        public DateTime? Dataanmk { get; set; }
        public DateTime? Datumeersteonderhoud { get; set; }
        public DateTime? Datumgeplandonderhoud { get; set; }
        public DateTime? Datumlaatsteonderhoud { get; set; }
        public DateTime? Datwijzig { get; set; }
        public string Diversenonderhoud { get; set; }
        public DateTime? Garantiedatum { get; set; }
        public bool Heeftonderhoudsplan { get; set; }
        public int Huidigevoorraad { get; set; }
        public int Importtype { get; set; }
        public Guid? Installatiedoorid { get; set; }
        public string Korteomschrijving { get; set; }
        public DateTime? Leaseaanvangsdatum { get; set; }
        public string Leasecontractnummer { get; set; }
        public DateTime? Leaseeinddatum { get; set; }
        public int Leaseinfo { get; set; }
        public int Leaseperiode { get; set; }
        public decimal Leaseprijs { get; set; }
        public Guid? Leverancierid { get; set; }
        public Guid? Lokatieid { get; set; }
        public Guid? Merkid { get; set; }
        public Guid Objectid { get; set; }
        public Guid? OnderhoudDoorid { get; set; }
        public bool Onderhoudcontract { get; set; }
        public string Onderhoudnummer { get; set; }
        public decimal Onderhoudprijs { get; set; }
        public long Onderhoudresponsietijd { get; set; }
        public Guid? Onderhoudslacontractid { get; set; }
        public bool Onderhoudslagebruikt { get; set; }
        public Guid? Onderhoudsoortid { get; set; }
        public Guid? Onderhoudsplanid { get; set; }
        public DateTime? Onderhoudtot { get; set; }
        public DateTime? Onderhoudvanaf { get; set; }
        public string Ordernummer { get; set; }
        public Guid? Persoongroepid { get; set; }
        public Guid? Persoonid { get; set; }
        public int Plaats { get; set; }
        public int Plaatskeuze { get; set; }
        public string RefConfiguratie { get; set; }
        public string RefLeverancier { get; set; }
        public string RefPersoongroep { get; set; }
        public string RefPlaats1 { get; set; }
        public string RefVestiging { get; set; }
        public bool Reserveerbaaractiveerbaar { get; set; }
        public bool Reserveerbaarsecure { get; set; }
        public bool Reserveerbaarsshd { get; set; }
        public decimal Restwaarde { get; set; }
        public Guid? Sjabloonobjectid { get; set; }
        public Guid? Soortid { get; set; }
        public string Specificatie { get; set; }
        public int Status { get; set; }
        public Guid? Statusid { get; set; }
        public Guid? Stdresvbehandelaarid { get; set; }
        public Guid? Uidaanmk { get; set; }
        public Guid? Uidwijzig { get; set; }
        public Guid Unid { get; set; }
        public int Veiligvoorraad { get; set; }
        public decimal Verhuurborg { get; set; }
        public decimal Verhuurprijs { get; set; }
        public int Verhuurprijssysteem { get; set; }
        public string Verhuurtekst { get; set; }
        public decimal Verkoopprijs { get; set; }
        public DateTime? Verzekerdatum { get; set; }
        public Guid? Vestigingid { get; set; }
        public bool Vnc { get; set; }
        public string Vnchostnaam { get; set; }
        public bool Webbrowser { get; set; }
        public double Attvrijegetal1 { get; set; }
        public double Attvrijegetal2 { get; set; }
        public bool Attvrijelogisch1 { get; set; }
        public bool Attvrijelogisch2 { get; set; }
        public bool Attvrijelogisch3 { get; set; }
        public bool Attvrijelogisch4 { get; set; }
        public bool Attvrijelogisch5 { get; set; }
        public string Attvrijememo1 { get; set; }
        public string Attvrijememo2 { get; set; }
        public Guid? Attvrijeopzoek1 { get; set; }
        public Guid? Attvrijeopzoek2 { get; set; }
        public Guid? Attvrijeopzoek3 { get; set; }
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
        public string Wburl { get; set; }
        public Guid? Attentieid { get; set; }
        public int RefKleur { get; set; }
        public bool Heeftattentie { get; set; }
        public string Opmerking { get; set; }
        public DateTime? Vrijedatum1 { get; set; }
        public DateTime? Vrijedatum2 { get; set; }
        public bool Reserveerbaarkantooruren { get; set; }
        public bool Reservzichtbaarsshd { get; set; }
        public DateTime? Attvrijedatum1 { get; set; }
        public DateTime? Attvrijedatum2 { get; set; }
        public DateTime? Importdate { get; set; }
        public Guid? Objecttypeid { get; set; }
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
        public DateTime? Attvrijedatum3 { get; set; }
        public double Attvrijegetal3 { get; set; }
        public string Attvrijememo3 { get; set; }
        public DateTime? Attvrijedatum4 { get; set; }
        public double Attvrijegetal4 { get; set; }
        public string Attvrijememo4 { get; set; }
        public DateTime? Attvrijedatum5 { get; set; }
        public double Attvrijegetal5 { get; set; }
        public string Attvrijememo5 { get; set; }
        public Guid? Attvrijeopzoek4 { get; set; }
        public Guid? Attvrijeopzoek5 { get; set; }
        public string Attvrijetekst1 { get; set; }
        public string Attvrijetekst2 { get; set; }
        public string Attvrijetekst3 { get; set; }
        public string Attvrijetekst4 { get; set; }
        public string Attvrijetekst5 { get; set; }
        public bool Heeftvoorraad { get; set; }
        public string Hostnaam { get; set; }
        public string Naam { get; set; }
        public string RefLokatie { get; set; }
        public string Serienummer { get; set; }
        public string Bespokememo { get; set; }
        public string RmSpecification { get; set; }
        public string Importid { get; set; }
        public string RefMerk { get; set; }
        public string RefAanspreekpunt { get; set; }
        public string RefPersoon { get; set; }
        public string Objecttype { get; set; }
        public string RefFinbudgethouder { get; set; }
        public string RefSoort { get; set; }
        public string RefOrdernumber { get; set; }
        public int Blocktime { get; set; }
        public bool Reservablewithlocation { get; set; }
        public decimal CostsHightariff { get; set; }
        public bool ReservableOfficehoursSsd { get; set; }
        public Guid? Servicewindowid { get; set; }
        public int ServicewindowOption { get; set; }

        public Actiedoor Aanspreekpunt { get; set; }
        public Archiefreden Archiefreden { get; set; }
        public ArtikelBestelLink Artikelbestellink { get; set; }
        public Artikelstatus Artikelstatus { get; set; }
        public Attentie Attentie { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek1Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek2Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek3Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek4Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek5Navigation { get; set; }
        public Bestelaanvraag Bestelaanvraag { get; set; }
        public Bestellingen Bestelling { get; set; }
        public Budgethouder Budgethouder { get; set; }
        public Configuratie Configuratie { get; set; }
        public Actiedoor Installatiedoor { get; set; }
        public Leverancier Leverancier { get; set; }
        public Locatie Lokatie { get; set; }
        public Objectmerk Merk { get; set; }
        public Object Object { get; set; }
        public Objecttype ObjecttypeNavigation { get; set; }
        public Leverancier OnderhoudDoor { get; set; }
        public Dnocontract Onderhoudslacontract { get; set; }
        public Slacontractsoort Onderhoudsoort { get; set; }
        public Onderhoudsplan Onderhoudsplan { get; set; }
        public Persoon Persoon { get; set; }
        public Persoongroep Persoongroep { get; set; }
        public Servicewindow Servicewindow { get; set; }
        public Vrij1object Sjabloonobject { get; set; }
        public Objectsoort Soort { get; set; }
        public Objectstatus StatusNavigation { get; set; }
        public Actiedoor Stdresvbehandelaar { get; set; }
        public Gebruiker UidaanmkNavigation { get; set; }
        public Gebruiker UidwijzigNavigation { get; set; }
        public Vestiging Vestiging { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek1Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek2Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek3Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek4Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek5Navigation { get; set; }
        public ICollection<Vrij1object> InverseSjabloonobject { get; set; }
        public ICollection<MutatieVrij1object> MutatieVrij1object { get; set; }
        public ICollection<Vrij1objectDocumenten> Vrij1objectDocumenten { get; set; }
        public ICollection<Vrij1objectEmailberichten> Vrij1objectEmailberichten { get; set; }
        public ICollection<Vrij1objectLogboek> Vrij1objectLogboek { get; set; }
        public ICollection<Vrij1objectOptionalgrid> Vrij1objectOptionalgrid { get; set; }
    }
}
