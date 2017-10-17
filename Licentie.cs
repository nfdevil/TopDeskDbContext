using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Licentie
    {
        public Licentie()
        {
            LicentieDocumenten = new HashSet<LicentieDocumenten>();
            LicentieEmailberichten = new HashSet<LicentieEmailberichten>();
            LicentieLogboek = new HashSet<LicentieLogboek>();
        }

        public int Aantal { get; set; }
        public string Aantekeningen { get; set; }
        public int Afschrijftermijn { get; set; }
        public Guid? Archiefredenid { get; set; }
        public Guid? Leverancierid { get; set; }
        public Guid? OnderhoudDoorid { get; set; }
        public bool Onderhoudcontract { get; set; }
        public string Onderhoudnummer { get; set; }
        public Guid? Onderhoudsoortid { get; set; }
        public string RefLeverancier { get; set; }
        public Guid? Softwareid { get; set; }
        public Guid? Soortlicentieid { get; set; }
        public int Status { get; set; }
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
        public DateTime? Aanschafdatum { get; set; }
        public DateTime? Dataanmk { get; set; }
        public DateTime? Datwijzig { get; set; }
        public DateTime? Garantiedatum { get; set; }
        public DateTime? Onderhoudtot { get; set; }
        public DateTime? Onderhoudvanaf { get; set; }
        public DateTime? Vrijedatum1 { get; set; }
        public DateTime? Vrijedatum2 { get; set; }
        public decimal Aankoopbedrag { get; set; }
        public decimal Onderhoudprijs { get; set; }
        public long Onderhoudresponsietijd { get; set; }
        public decimal Prijs { get; set; }
        public decimal Restwaarde { get; set; }
        public DateTime? Einddatum { get; set; }
        public Guid? Bestellingid { get; set; }
        public Guid? Budgethouderid { get; set; }
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
        public int Importtype { get; set; }
        public DateTime? Importdate { get; set; }
        public string RefSoortlicentie { get; set; }

        public Archiefreden Archiefreden { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek1Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek2Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek3Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek4Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek5Navigation { get; set; }
        public Bestellingen Bestelling { get; set; }
        public Budgethouder Budgethouder { get; set; }
        public Leverancier Leverancier { get; set; }
        public Leverancier OnderhoudDoor { get; set; }
        public Slacontractsoort Onderhoudsoort { get; set; }
        public Software Software { get; set; }
        public Licentiesoort Soortlicentie { get; set; }
        public Gebruiker UidaanmkNavigation { get; set; }
        public Gebruiker UidwijzigNavigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek1Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek2Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek3Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek4Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek5Navigation { get; set; }
        public ICollection<LicentieDocumenten> LicentieDocumenten { get; set; }
        public ICollection<LicentieEmailberichten> LicentieEmailberichten { get; set; }
        public ICollection<LicentieLogboek> LicentieLogboek { get; set; }
    }
}
