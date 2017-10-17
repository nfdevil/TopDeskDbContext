using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Reservering
    {
        public Reservering()
        {
            MutatieReservering = new HashSet<MutatieReservering>();
            ReserveringBezoekerLink = new HashSet<ReserveringBezoekerLink>();
            ReserveringDocumenten = new HashSet<ReserveringDocumenten>();
            ReserveringEmailberichten = new HashSet<ReserveringEmailberichten>();
            ReserveringLocatieLink = new HashSet<ReserveringLocatieLink>();
            ReserveringLogboek = new HashSet<ReserveringLogboek>();
            ReserveringObjectLink = new HashSet<ReserveringObjectLink>();
            ReserveringPersoonLink = new HashSet<ReserveringPersoonLink>();
            ReserveringVoorzieningLink = new HashSet<ReserveringVoorzieningLink>();
        }

        public Guid Unid { get; set; }
        public Guid? Aanmelderafdelingid { get; set; }
        public Guid? Aanmelderbudgethouderid { get; set; }
        public Guid? Aanmelderlokatieid { get; set; }
        public string Aanmelderplaats1 { get; set; }
        public string Aanmeldertelefoon { get; set; }
        public string Aanmeldervestiging { get; set; }
        public Guid? Aanmeldervestigingid { get; set; }
        public string Aantekeningen { get; set; }
        public string Afsprakenlevering { get; set; }
        public string Afsprakenteruggave { get; set; }
        public Guid? Archiefredenid { get; set; }
        public Guid? Beheerderid { get; set; }
        public bool Betaald { get; set; }
        public decimal Borg { get; set; }
        public bool Borgbetaald { get; set; }
        public bool Borgteruggegeven { get; set; }
        public Guid? Categorieid { get; set; }
        public DateTime? Dataanmk { get; set; }
        public DateTime? Datwijzig { get; set; }
        public string Diversen { get; set; }
        public bool Gefactureerd { get; set; }
        public DateTime? Einddatum { get; set; }
        public DateTime? Einddatumgepland { get; set; }
        public decimal Extrakostengepland { get; set; }
        public decimal Extrakostenwerkelijk { get; set; }
        public decimal Kortinggepland { get; set; }
        public decimal Kortingwerkelijk { get; set; }
        public decimal Kostengepland { get; set; }
        public decimal Kostenwerkelijk { get; set; }
        public string Naam { get; set; }
        public Guid? Persoonid { get; set; }
        public DateTime? Startdatum { get; set; }
        public DateTime? Startdatumgepland { get; set; }
        public int Status { get; set; }
        public Guid? Statusid { get; set; }
        public Guid? Uidaanmk { get; set; }
        public Guid? Uidwijzig { get; set; }
        public bool Uitnaam { get; set; }
        public string Uitnaamemail { get; set; }
        public string Uitnaamnaam { get; set; }
        public string Uitnaamspecificatie { get; set; }
        public string Uitnaamtelefoon { get; set; }
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
        public Guid? Extraaid { get; set; }
        public Guid? Extrabid { get; set; }
        public string Actie { get; set; }
        public DateTime? Vrijedatum1 { get; set; }
        public DateTime? Vrijedatum2 { get; set; }
        public Guid? Extraapersoonid { get; set; }
        public Guid? Extrabpersoonid { get; set; }
        public string Opmerkingen { get; set; }
        public string Korteomschrijving { get; set; }
        public string RefPersoneelsnr { get; set; }
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
        public int Aantalpersonen { get; set; }
        public DateTime? Annuleerdatum { get; set; }
        public Guid? Annuleerredenid { get; set; }
        public Guid? Optieafwijsredenid { get; set; }
        public string Aanmelderemail { get; set; }
        public DateTime Startdatumgeplandblok { get; set; }
        public DateTime Einddatumgeplandblok { get; set; }
        public string Importid { get; set; }
        public string Bespokememo { get; set; }
        public Guid? RmSeriesid { get; set; }
        public int Importtype { get; set; }
        public DateTime? Importdate { get; set; }
        public string Aanmeldernaam { get; set; }
        public string RefBeheerder { get; set; }
        public string RefAfdeling { get; set; }
        public string RefBudgethouder { get; set; }
        public string RefCategorie { get; set; }
        public string RefStatus { get; set; }

        public Afdeling Aanmelderafdeling { get; set; }
        public Budgethouder Aanmelderbudgethouder { get; set; }
        public Locatie Aanmelderlokatie { get; set; }
        public Vestiging AanmeldervestigingNavigation { get; set; }
        public Reserveringannuleerreden Annuleerreden { get; set; }
        public Archiefreden Archiefreden { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek1Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek2Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek3Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek4Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek5Navigation { get; set; }
        public Actiedoor Beheerder { get; set; }
        public Verhuurcategorie Categorie { get; set; }
        public Extraa Extraa { get; set; }
        public Extraapersoon Extraapersoon { get; set; }
        public Extrab Extrab { get; set; }
        public Extrabpersoon Extrabpersoon { get; set; }
        public Reserveringoptieafwijsreden Optieafwijsreden { get; set; }
        public Persoon Persoon { get; set; }
        public RmSeries RmSeries { get; set; }
        public Verhuurstatus StatusNavigation { get; set; }
        public Gebruiker UidaanmkNavigation { get; set; }
        public Gebruiker UidwijzigNavigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek1Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek2Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek3Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek4Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek5Navigation { get; set; }
        public ICollection<MutatieReservering> MutatieReservering { get; set; }
        public ICollection<ReserveringBezoekerLink> ReserveringBezoekerLink { get; set; }
        public ICollection<ReserveringDocumenten> ReserveringDocumenten { get; set; }
        public ICollection<ReserveringEmailberichten> ReserveringEmailberichten { get; set; }
        public ICollection<ReserveringLocatieLink> ReserveringLocatieLink { get; set; }
        public ICollection<ReserveringLogboek> ReserveringLogboek { get; set; }
        public ICollection<ReserveringObjectLink> ReserveringObjectLink { get; set; }
        public ICollection<ReserveringPersoonLink> ReserveringPersoonLink { get; set; }
        public ICollection<ReserveringVoorzieningLink> ReserveringVoorzieningLink { get; set; }
    }
}
