using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Bestelaanvraag
    {
        public Bestelaanvraag()
        {
            BestelaanvraagArtikelLink = new HashSet<BestelaanvraagArtikelLink>();
            BestelaanvraagBestellingenLink = new HashSet<BestelaanvraagBestellingenLink>();
            BestelaanvraagDocumenten = new HashSet<BestelaanvraagDocumenten>();
            BestelaanvraagEmailberichten = new HashSet<BestelaanvraagEmailberichten>();
            BestelaanvraagIncidentLink = new HashSet<BestelaanvraagIncidentLink>();
            BestelaanvraagLogboek = new HashSet<BestelaanvraagLogboek>();
            ChangeActOrderreqLink = new HashSet<ChangeActOrderreqLink>();
            Hardware = new HashSet<Hardware>();
            Inventaris = new HashSet<Inventaris>();
            MutatieBestelaanvraag = new HashSet<MutatieBestelaanvraag>();
            Netwerkcomponent = new HashSet<Netwerkcomponent>();
            Software = new HashSet<Software>();
            Telefonie = new HashSet<Telefonie>();
            Vrij1object = new HashSet<Vrij1object>();
            Vrij2object = new HashSet<Vrij2object>();
            Vrij3object = new HashSet<Vrij3object>();
            Vrij4object = new HashSet<Vrij4object>();
            Vrij5object = new HashSet<Vrij5object>();
        }

        public Guid? Aanmelderafdelingid { get; set; }
        public Guid? Aanmelderbudgethouderid { get; set; }
        public Guid? Aanmelderlokatieid { get; set; }
        public string Aanmelderplaats1 { get; set; }
        public string Aanmeldertelefoon { get; set; }
        public string Aanmeldervestiging { get; set; }
        public Guid? Aanmeldervestigingid { get; set; }
        public Guid? Aanvragerid { get; set; }
        public Guid? Archiefredenid { get; set; }
        public Guid? Behandelaarid { get; set; }
        public string Naam { get; set; }
        public string Opmerkingen { get; set; }
        public Guid? Persoonid { get; set; }
        public string RefPersnr { get; set; }
        public int Status { get; set; }
        public Guid? Uidaanmk { get; set; }
        public Guid? Uidwijzig { get; set; }
        public Guid Unid { get; set; }
        public DateTime? Dataanmk { get; set; }
        public DateTime? Datwijzig { get; set; }
        public DateTime? Rappeldatum { get; set; }
        public Guid? Extraaid { get; set; }
        public Guid? Extrabid { get; set; }
        public DateTime? Aanvraagdatum { get; set; }
        public DateTime? Gewensteleverdatum { get; set; }
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
        public DateTime? Vrijedatum1 { get; set; }
        public DateTime? Vrijedatum2 { get; set; }
        public string Actie { get; set; }
        public DateTime? Afwijsdatum { get; set; }
        public DateTime? Afhandeldatum { get; set; }
        public Guid? Extraapersoonid { get; set; }
        public Guid? Extrabpersoonid { get; set; }
        public string Aantekeningen { get; set; }
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
        public string Aanmelderemail { get; set; }
        public string RefLocatie { get; set; }
        public string Bespokememo { get; set; }
        public Guid? Statusid { get; set; }
        public string Aanmeldernaam { get; set; }
        public string RefAanvragerdynanaam { get; set; }
        public string RefAfdeling { get; set; }
        public string RefBudgethouder { get; set; }
        public int Importtype { get; set; }
        public string Importid { get; set; }
        public DateTime? Importdate { get; set; }

        public Afdeling Aanmelderafdeling { get; set; }
        public Budgethouder Aanmelderbudgethouder { get; set; }
        public Locatie Aanmelderlokatie { get; set; }
        public Vestiging AanmeldervestigingNavigation { get; set; }
        public Persoon Aanvrager { get; set; }
        public Archiefreden Archiefreden { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek1Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek2Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek3Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek4Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek5Navigation { get; set; }
        public Actiedoor Behandelaar { get; set; }
        public Extraa Extraa { get; set; }
        public Extraapersoon Extraapersoon { get; set; }
        public Extrab Extrab { get; set; }
        public Extrabpersoon Extrabpersoon { get; set; }
        public Persoon Persoon { get; set; }
        public Orderrequeststatus StatusNavigation { get; set; }
        public Gebruiker UidaanmkNavigation { get; set; }
        public Gebruiker UidwijzigNavigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek1Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek2Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek3Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek4Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek5Navigation { get; set; }
        public ICollection<BestelaanvraagArtikelLink> BestelaanvraagArtikelLink { get; set; }
        public ICollection<BestelaanvraagBestellingenLink> BestelaanvraagBestellingenLink { get; set; }
        public ICollection<BestelaanvraagDocumenten> BestelaanvraagDocumenten { get; set; }
        public ICollection<BestelaanvraagEmailberichten> BestelaanvraagEmailberichten { get; set; }
        public ICollection<BestelaanvraagIncidentLink> BestelaanvraagIncidentLink { get; set; }
        public ICollection<BestelaanvraagLogboek> BestelaanvraagLogboek { get; set; }
        public ICollection<ChangeActOrderreqLink> ChangeActOrderreqLink { get; set; }
        public ICollection<Hardware> Hardware { get; set; }
        public ICollection<Inventaris> Inventaris { get; set; }
        public ICollection<MutatieBestelaanvraag> MutatieBestelaanvraag { get; set; }
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
