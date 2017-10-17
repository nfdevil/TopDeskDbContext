using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class OmReeks
    {
        public OmReeks()
        {
            MutatieOmReeks = new HashSet<MutatieOmReeks>();
            OmActiviteit = new HashSet<OmActiviteit>();
            OmReeksDocumenten = new HashSet<OmReeksDocumenten>();
            OmReeksEmailberichten = new HashSet<OmReeksEmailberichten>();
            OmReeksLocatieLink = new HashSet<OmReeksLocatieLink>();
            OmReeksLogboek = new HashSet<OmReeksLogboek>();
            OmReeksMemoHistory = new HashSet<OmReeksMemoHistory>();
            OmReeksObjectLink = new HashSet<OmReeksObjectLink>();
            OmReeksVestigingLink = new HashSet<OmReeksVestigingLink>();
        }

        public Guid Unid { get; set; }
        public string Aantekeningen { get; set; }
        public Guid? Archiefredenid { get; set; }
        public Guid? Beheerderid { get; set; }
        public long Bestedetijdgepland { get; set; }
        public decimal Kostengepland { get; set; }
        public string Naam { get; set; }
        public Guid? Groeperingid { get; set; }
        public Guid? Statusid { get; set; }
        public Guid? Schemaid { get; set; }
        public DateTime? Rappeldatum { get; set; }
        public string Opmerkingen { get; set; }
        public Guid? Planningid { get; set; }
        public int Status { get; set; }
        public string Verzoek { get; set; }
        public Guid? Standaardbehandelaarid { get; set; }
        public long Standaardbestedetijdgepland { get; set; }
        public Guid? Standaardcategorieid { get; set; }
        public decimal Standaardkostengepland { get; set; }
        public Guid? Standaardsoortid { get; set; }
        public Guid? Standaardstatusid { get; set; }
        public Guid? Standaardsubcategorieid { get; set; }
        public DateTime? Vrijedatum1 { get; set; }
        public DateTime? Vrijedatum2 { get; set; }
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
        public string Standaardaantekeningen { get; set; }
        public string Actie { get; set; }
        public string RefSchemanaam { get; set; }
        public string RefGroeperingnaam { get; set; }
        public string RefActiCategorienaam { get; set; }
        public string RefActiSubcategorienaam { get; set; }
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
        public string Nummer { get; set; }
        public DateTime? Dataanmk { get; set; }
        public DateTime? Datwijzig { get; set; }
        public Guid? Uidaanmk { get; set; }
        public Guid? Uidwijzig { get; set; }
        public Guid? Standaardbudgethouderid { get; set; }
        public string Bespokememo { get; set; }
        public Guid? Standaardoperatorgroupid { get; set; }
        public int Importtype { get; set; }
        public string Importid { get; set; }
        public DateTime? Importdate { get; set; }
        public string RefActiBehandelaarnaam { get; set; }
        public string RefBeheerdernaam { get; set; }
        public string RefActiSoortnaam { get; set; }
        public string RefActiStatusnaam { get; set; }
        public string RefStatusnaam { get; set; }
        public Guid? Standaardsupplierid { get; set; }

        public Archiefreden Archiefreden { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek1Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek2Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek3Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek4Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek5Navigation { get; set; }
        public Actiedoor Beheerder { get; set; }
        public OmGroepering Groepering { get; set; }
        public Planning Planning { get; set; }
        public OmSchema Schema { get; set; }
        public Actiedoor Standaardbehandelaar { get; set; }
        public Budgethouder Standaardbudgethouder { get; set; }
        public Classificatie Standaardcategorie { get; set; }
        public Actiedoor Standaardoperatorgroup { get; set; }
        public OmSoort Standaardsoort { get; set; }
        public OmActiviteitStatus Standaardstatus { get; set; }
        public Classificatie Standaardsubcategorie { get; set; }
        public Leverancier Standaardsupplier { get; set; }
        public OmStatus StatusNavigation { get; set; }
        public Gebruiker UidaanmkNavigation { get; set; }
        public Gebruiker UidwijzigNavigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek1Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek2Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek3Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek4Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek5Navigation { get; set; }
        public ICollection<MutatieOmReeks> MutatieOmReeks { get; set; }
        public ICollection<OmActiviteit> OmActiviteit { get; set; }
        public ICollection<OmReeksDocumenten> OmReeksDocumenten { get; set; }
        public ICollection<OmReeksEmailberichten> OmReeksEmailberichten { get; set; }
        public ICollection<OmReeksLocatieLink> OmReeksLocatieLink { get; set; }
        public ICollection<OmReeksLogboek> OmReeksLogboek { get; set; }
        public ICollection<OmReeksMemoHistory> OmReeksMemoHistory { get; set; }
        public ICollection<OmReeksObjectLink> OmReeksObjectLink { get; set; }
        public ICollection<OmReeksVestigingLink> OmReeksVestigingLink { get; set; }
    }
}
