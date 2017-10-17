using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Bezoeker
    {
        public Bezoeker()
        {
            BezoekerDocumenten = new HashSet<BezoekerDocumenten>();
            BezoekerEmailberichten = new HashSet<BezoekerEmailberichten>();
            BezoekerLogboek = new HashSet<BezoekerLogboek>();
            BezoekerMemoHistory = new HashSet<BezoekerMemoHistory>();
            ReservationVisitorLink = new HashSet<ReservationVisitorLink>();
            ReserveringBezoekerLink = new HashSet<ReserveringBezoekerLink>();
        }

        public Guid Unid { get; set; }
        public string Naam { get; set; }
        public string Bezoekerbedrijf { get; set; }
        public string Nummerplaat { get; set; }
        public DateTime? Werkelijkeaankomst { get; set; }
        public DateTime? Werkelijkvertrek { get; set; }
        public int Status { get; set; }
        public DateTime? Dataanmk { get; set; }
        public DateTime? Datwijzig { get; set; }
        public Guid? Uidaanmk { get; set; }
        public Guid? Uidwijzig { get; set; }
        public string Commentaar { get; set; }
        public DateTime? Verwachteaankomst { get; set; }
        public DateTime? Verwachtvertrek { get; set; }
        public Guid? Persoonid { get; set; }
        public Guid? Aanmelderafdelingid { get; set; }
        public Guid? Aanmelderbudgethouderid { get; set; }
        public Guid? Aanmelderlokatieid { get; set; }
        public Guid? Aanmeldervestigingid { get; set; }
        public Guid? Extraaid { get; set; }
        public Guid? Extrabid { get; set; }
        public Guid? Extraapersoonid { get; set; }
        public Guid? Extrabpersoonid { get; set; }
        public string Aanmeldertelefoon { get; set; }
        public string Aantekeningen { get; set; }
        public string Telefoon { get; set; }
        public Guid? Passid { get; set; }
        public Guid? Parkeerplaatsid { get; set; }
        public DateTime? Vrijedatum1 { get; set; }
        public double Vrijegetal1 { get; set; }
        public bool Vrijelogisch1 { get; set; }
        public string Vrijememo1 { get; set; }
        public Guid? Vrijeopzoek1 { get; set; }
        public string Vrijetekst1 { get; set; }
        public DateTime? Vrijedatum2 { get; set; }
        public double Vrijegetal2 { get; set; }
        public bool Vrijelogisch2 { get; set; }
        public string Vrijememo2 { get; set; }
        public Guid? Vrijeopzoek2 { get; set; }
        public string Vrijetekst2 { get; set; }
        public DateTime? Vrijedatum3 { get; set; }
        public double Vrijegetal3 { get; set; }
        public bool Vrijelogisch3 { get; set; }
        public string Vrijememo3 { get; set; }
        public Guid? Vrijeopzoek3 { get; set; }
        public string Vrijetekst3 { get; set; }
        public DateTime? Vrijedatum4 { get; set; }
        public double Vrijegetal4 { get; set; }
        public bool Vrijelogisch4 { get; set; }
        public string Vrijememo4 { get; set; }
        public Guid? Vrijeopzoek4 { get; set; }
        public string Vrijetekst4 { get; set; }
        public DateTime? Vrijedatum5 { get; set; }
        public double Vrijegetal5 { get; set; }
        public bool Vrijelogisch5 { get; set; }
        public string Vrijememo5 { get; set; }
        public Guid? Vrijeopzoek5 { get; set; }
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
        public Guid? Archiefredenid { get; set; }
        public string Email { get; set; }
        public string Identiteitsnummer { get; set; }
        public string Nummer { get; set; }
        public string Korteomschrijving { get; set; }
        public Guid? Identiteitsbewijsid { get; set; }
        public string Aanmelderemail { get; set; }
        public string Importid { get; set; }
        public int Importtype { get; set; }
        public DateTime? Importdate { get; set; }
        public string Bespokememo { get; set; }
        public string Aanmeldernaam { get; set; }
        public string RefParkeerplaats { get; set; }
        public string RefPass { get; set; }
        public DateTime? Canceldate { get; set; }

        public Afdeling Aanmelderafdeling { get; set; }
        public Budgethouder Aanmelderbudgethouder { get; set; }
        public Locatie Aanmelderlokatie { get; set; }
        public Vestiging Aanmeldervestiging { get; set; }
        public Archiefreden Archiefreden { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek1Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek2Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek3Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek4Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek5Navigation { get; set; }
        public Extraa Extraa { get; set; }
        public Extraapersoon Extraapersoon { get; set; }
        public Extrab Extrab { get; set; }
        public Extrabpersoon Extrabpersoon { get; set; }
        public Identiteitsbewijs Identiteitsbewijs { get; set; }
        public Bezoekerparkeerplaats Parkeerplaats { get; set; }
        public Bezoekerpass Pass { get; set; }
        public Persoon Persoon { get; set; }
        public Gebruiker UidaanmkNavigation { get; set; }
        public Gebruiker UidwijzigNavigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek1Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek2Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek3Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek4Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek5Navigation { get; set; }
        public ICollection<BezoekerDocumenten> BezoekerDocumenten { get; set; }
        public ICollection<BezoekerEmailberichten> BezoekerEmailberichten { get; set; }
        public ICollection<BezoekerLogboek> BezoekerLogboek { get; set; }
        public ICollection<BezoekerMemoHistory> BezoekerMemoHistory { get; set; }
        public ICollection<ReservationVisitorLink> ReservationVisitorLink { get; set; }
        public ICollection<ReserveringBezoekerLink> ReserveringBezoekerLink { get; set; }
    }
}
