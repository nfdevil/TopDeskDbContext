using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Dnocontract
    {
        public Dnocontract()
        {
            DnocontractDocumenten = new HashSet<DnocontractDocumenten>();
            DnocontractEmailberichten = new HashSet<DnocontractEmailberichten>();
            DnocontractLogboek = new HashSet<DnocontractLogboek>();
            DnocontractMemoHistory = new HashSet<DnocontractMemoHistory>();
            DnocontractVestigingLink = new HashSet<DnocontractVestigingLink>();
            DnodienstDnocontract = new HashSet<Dnodienst>();
            DnodienstUnderpinningcontract = new HashSet<Dnodienst>();
            Dnolink = new HashSet<Dnolink>();
            Hardware = new HashSet<Hardware>();
            Incident = new HashSet<Incident>();
            Inventaris = new HashSet<Inventaris>();
            MutatieDnocontract = new HashSet<MutatieDnocontract>();
            MutatieDnodienst = new HashSet<MutatieDnodienst>();
            Netwerkcomponent = new HashSet<Netwerkcomponent>();
            Software = new HashSet<Software>();
            Telefonie = new HashSet<Telefonie>();
            Vrij1object = new HashSet<Vrij1object>();
            Vrij2object = new HashSet<Vrij2object>();
            Vrij3object = new HashSet<Vrij3object>();
            Vrij4object = new HashSet<Vrij4object>();
            Vrij5object = new HashSet<Vrij5object>();
        }

        public string Aantekeningen { get; set; }
        public Guid? Archiefredenid { get; set; }
        public Guid? Budgethouderid { get; set; }
        public Guid? Leverancierid { get; set; }
        public string Naam { get; set; }
        public string Omschrijving { get; set; }
        public int Status { get; set; }
        public string Toelichting { get; set; }
        public Guid? Uidaanmk { get; set; }
        public Guid? Uidwijzig { get; set; }
        public Guid Unid { get; set; }
        public Guid? Vestigingid { get; set; }
        public int Volgnummer { get; set; }
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
        public int Vestigingofbudgethouder { get; set; }
        public DateTime? Aanvangsdatum { get; set; }
        public DateTime? Dataanmk { get; set; }
        public DateTime? Datwijzig { get; set; }
        public DateTime? Einddatum { get; set; }
        public DateTime? Rappeldatum { get; set; }
        public DateTime? Vrijedatum1 { get; set; }
        public DateTime? Vrijedatum2 { get; set; }
        public decimal Kosten { get; set; }
        public decimal Kostencumulatief { get; set; }
        public Guid? Extraaid { get; set; }
        public Guid? Extrabid { get; set; }
        public Guid? Afdelingid { get; set; }
        public double Kostenfactor { get; set; }
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
        public Guid? Behandelaarid { get; set; }
        public Guid? Soortid { get; set; }
        public Guid? Categorieid { get; set; }
        public Guid? Subcategorieid { get; set; }
        public bool Verlengd { get; set; }
        public Guid? Periodeverlengingid { get; set; }
        public string Getekenddoor { get; set; }
        public DateTime? Getekendop { get; set; }
        public string Archiefnummer { get; set; }
        public Guid? Contractstatusid { get; set; }
        public Guid? Contractbudgethouderid { get; set; }
        public decimal Periodekosten { get; set; }
        public Guid? Periodeid { get; set; }
        public DateTime? Opzegdatum { get; set; }
        public string RefLeverancier { get; set; }
        public string Importid { get; set; }
        public int Costcalculationtype { get; set; }
        public string Bespokememo { get; set; }
        public int Importtype { get; set; }
        public DateTime? Importdate { get; set; }

        public Afdeling Afdeling { get; set; }
        public Archiefreden Archiefreden { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek1Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek2Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek3Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek4Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek5Navigation { get; set; }
        public Actiedoor Behandelaar { get; set; }
        public Budgethouder Budgethouder { get; set; }
        public Classificatie Categorie { get; set; }
        public Budgethouder Contractbudgethouder { get; set; }
        public Dnocontractstatus Contractstatus { get; set; }
        public Extraa Extraa { get; set; }
        public Extrab Extrab { get; set; }
        public Leverancier Leverancier { get; set; }
        public Dnocontractperiode Periode { get; set; }
        public Dnocontractverlengperiode Periodeverlenging { get; set; }
        public Dnocontractsoort Soort { get; set; }
        public Classificatie Subcategorie { get; set; }
        public Gebruiker UidaanmkNavigation { get; set; }
        public Gebruiker UidwijzigNavigation { get; set; }
        public Vestiging Vestiging { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek1Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek2Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek3Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek4Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek5Navigation { get; set; }
        public ICollection<DnocontractDocumenten> DnocontractDocumenten { get; set; }
        public ICollection<DnocontractEmailberichten> DnocontractEmailberichten { get; set; }
        public ICollection<DnocontractLogboek> DnocontractLogboek { get; set; }
        public ICollection<DnocontractMemoHistory> DnocontractMemoHistory { get; set; }
        public ICollection<DnocontractVestigingLink> DnocontractVestigingLink { get; set; }
        public ICollection<Dnodienst> DnodienstDnocontract { get; set; }
        public ICollection<Dnodienst> DnodienstUnderpinningcontract { get; set; }
        public ICollection<Dnolink> Dnolink { get; set; }
        public ICollection<Hardware> Hardware { get; set; }
        public ICollection<Incident> Incident { get; set; }
        public ICollection<Inventaris> Inventaris { get; set; }
        public ICollection<MutatieDnocontract> MutatieDnocontract { get; set; }
        public ICollection<MutatieDnodienst> MutatieDnodienst { get; set; }
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
