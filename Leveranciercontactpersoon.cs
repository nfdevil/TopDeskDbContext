using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Leveranciercontactpersoon
    {
        public Leveranciercontactpersoon()
        {
            Bestellingen = new HashSet<Bestellingen>();
            Leverancier = new HashSet<Leverancier>();
            LeveranciercontactpersoonDocumenten = new HashSet<LeveranciercontactpersoonDocumenten>();
            LeveranciercontactpersoonEmailberichten = new HashSet<LeveranciercontactpersoonEmailberichten>();
            LeveranciercontactpersoonLogboek = new HashSet<LeveranciercontactpersoonLogboek>();
            SuppliercontactMemoHistory = new HashSet<SuppliercontactMemoHistory>();
        }

        public string Aantekeningen { get; set; }
        public Guid? Archiefredenid { get; set; }
        public string Diversen { get; set; }
        public string Fax { get; set; }
        public int Geslacht { get; set; }
        public Guid? Leverancierid { get; set; }
        public string Mobiel { get; set; }
        public string Personeeli { get; set; }
        public string RefLeverancier { get; set; }
        public int Status { get; set; }
        public string Telefoon { get; set; }
        public string Titel { get; set; }
        public string Tussenvoegsel { get; set; }
        public Guid? Uidaanmk { get; set; }
        public Guid? Uidwijzig { get; set; }
        public Guid Unid { get; set; }
        public string Voorletters { get; set; }
        public string Voornaam { get; set; }
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
        public DateTime? Dataanmk { get; set; }
        public DateTime? Datwijzig { get; set; }
        public DateTime? Vrijedatum1 { get; set; }
        public DateTime? Vrijedatum2 { get; set; }
        public string Achternaam { get; set; }
        public string RefAanhefformeel { get; set; }
        public string RefAanhefinformeel { get; set; }
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
        public string Bespokememo { get; set; }
        public DateTime? Importdate { get; set; }
        public string Importid { get; set; }
        public string Functie { get; set; }
        public string RefDynanaam { get; set; }

        public Archiefreden Archiefreden { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek1Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek2Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek3Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek4Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek5Navigation { get; set; }
        public Leverancier LeverancierNavigation { get; set; }
        public Gebruiker UidaanmkNavigation { get; set; }
        public Gebruiker UidwijzigNavigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek1Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek2Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek3Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek4Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek5Navigation { get; set; }
        public ICollection<Bestellingen> Bestellingen { get; set; }
        public ICollection<Leverancier> Leverancier { get; set; }
        public ICollection<LeveranciercontactpersoonDocumenten> LeveranciercontactpersoonDocumenten { get; set; }
        public ICollection<LeveranciercontactpersoonEmailberichten> LeveranciercontactpersoonEmailberichten { get; set; }
        public ICollection<LeveranciercontactpersoonLogboek> LeveranciercontactpersoonLogboek { get; set; }
        public ICollection<SuppliercontactMemoHistory> SuppliercontactMemoHistory { get; set; }
    }
}
