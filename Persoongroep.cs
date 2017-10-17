using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Persoongroep
    {
        public Persoongroep()
        {
            Configuratie = new HashSet<Configuratie>();
            Hardware = new HashSet<Hardware>();
            Inventaris = new HashSet<Inventaris>();
            MutatieConfiguratie = new HashSet<MutatieConfiguratie>();
            MutatieHardware = new HashSet<MutatieHardware>();
            MutatieInventaris = new HashSet<MutatieInventaris>();
            MutatieNetwerkcomponent = new HashSet<MutatieNetwerkcomponent>();
            MutatieSoftware = new HashSet<MutatieSoftware>();
            MutatieTelefonie = new HashSet<MutatieTelefonie>();
            MutatieVrij1object = new HashSet<MutatieVrij1object>();
            MutatieVrij2object = new HashSet<MutatieVrij2object>();
            MutatieVrij3object = new HashSet<MutatieVrij3object>();
            MutatieVrij4object = new HashSet<MutatieVrij4object>();
            MutatieVrij5object = new HashSet<MutatieVrij5object>();
            Netwerkcomponent = new HashSet<Netwerkcomponent>();
            ObjConfLinkGroep = new HashSet<ObjConfLink>();
            ObjConfLinkRefPersoongroep = new HashSet<ObjConfLink>();
            ObjPersoongroepLink = new HashSet<ObjPersoongroepLink>();
            ObjectRefGroep = new HashSet<Object>();
            ObjectRefPersoongroepNavigation = new HashSet<Object>();
            PersoongroepDocumenten = new HashSet<PersoongroepDocumenten>();
            PersoongroepEmailberichten = new HashSet<PersoongroepEmailberichten>();
            PersoongroepLogboek = new HashSet<PersoongroepLogboek>();
            PersoongroepMemoHistory = new HashSet<PersoongroepMemoHistory>();
            Persoonlink = new HashSet<Persoonlink>();
            SoftwareGroep = new HashSet<Software>();
            SoftwarePersoongroep = new HashSet<Software>();
            Telefonie = new HashSet<Telefonie>();
            Vrij1object = new HashSet<Vrij1object>();
            Vrij2object = new HashSet<Vrij2object>();
            Vrij3object = new HashSet<Vrij3object>();
            Vrij4object = new HashSet<Vrij4object>();
            Vrij5object = new HashSet<Vrij5object>();
        }

        public Guid? Aanspreekpersoonid { get; set; }
        public string Aantekeningen { get; set; }
        public Guid? Afdelingid { get; set; }
        public Guid? Archiefredenid { get; set; }
        public Guid? Budgethouderid { get; set; }
        public string Diversen { get; set; }
        public string Fax { get; set; }
        public Guid? Lokatieid { get; set; }
        public string Personeeli { get; set; }
        public string RefPlaats1 { get; set; }
        public string RefVestiging { get; set; }
        public int Status { get; set; }
        public string Telefoon { get; set; }
        public Guid? Uidaanmk { get; set; }
        public Guid? Uidwijzig { get; set; }
        public Guid Unid { get; set; }
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
        public string Naam { get; set; }
        public string Email { get; set; }
        public DateTime? Dataanmk { get; set; }
        public DateTime? Datwijzig { get; set; }
        public DateTime? Vrijedatum1 { get; set; }
        public DateTime? Vrijedatum2 { get; set; }
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
        public int Importtype { get; set; }
        public DateTime? Importdate { get; set; }
        public string Bespokememo { get; set; }
        public string RefAfdeling { get; set; }
        public string RefBudgethouder { get; set; }

        public Persoon Aanspreekpersoon { get; set; }
        public Afdeling Afdeling { get; set; }
        public Archiefreden Archiefreden { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek1Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek2Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek3Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek4Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek5Navigation { get; set; }
        public Budgethouder Budgethouder { get; set; }
        public Locatie Lokatie { get; set; }
        public Gebruiker UidaanmkNavigation { get; set; }
        public Gebruiker UidwijzigNavigation { get; set; }
        public Vestiging Vestiging { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek1Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek2Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek3Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek4Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek5Navigation { get; set; }
        public ICollection<Configuratie> Configuratie { get; set; }
        public ICollection<Hardware> Hardware { get; set; }
        public ICollection<Inventaris> Inventaris { get; set; }
        public ICollection<MutatieConfiguratie> MutatieConfiguratie { get; set; }
        public ICollection<MutatieHardware> MutatieHardware { get; set; }
        public ICollection<MutatieInventaris> MutatieInventaris { get; set; }
        public ICollection<MutatieNetwerkcomponent> MutatieNetwerkcomponent { get; set; }
        public ICollection<MutatieSoftware> MutatieSoftware { get; set; }
        public ICollection<MutatieTelefonie> MutatieTelefonie { get; set; }
        public ICollection<MutatieVrij1object> MutatieVrij1object { get; set; }
        public ICollection<MutatieVrij2object> MutatieVrij2object { get; set; }
        public ICollection<MutatieVrij3object> MutatieVrij3object { get; set; }
        public ICollection<MutatieVrij4object> MutatieVrij4object { get; set; }
        public ICollection<MutatieVrij5object> MutatieVrij5object { get; set; }
        public ICollection<Netwerkcomponent> Netwerkcomponent { get; set; }
        public ICollection<ObjConfLink> ObjConfLinkGroep { get; set; }
        public ICollection<ObjConfLink> ObjConfLinkRefPersoongroep { get; set; }
        public ICollection<ObjPersoongroepLink> ObjPersoongroepLink { get; set; }
        public ICollection<Object> ObjectRefGroep { get; set; }
        public ICollection<Object> ObjectRefPersoongroepNavigation { get; set; }
        public ICollection<PersoongroepDocumenten> PersoongroepDocumenten { get; set; }
        public ICollection<PersoongroepEmailberichten> PersoongroepEmailberichten { get; set; }
        public ICollection<PersoongroepLogboek> PersoongroepLogboek { get; set; }
        public ICollection<PersoongroepMemoHistory> PersoongroepMemoHistory { get; set; }
        public ICollection<Persoonlink> Persoonlink { get; set; }
        public ICollection<Software> SoftwareGroep { get; set; }
        public ICollection<Software> SoftwarePersoongroep { get; set; }
        public ICollection<Telefonie> Telefonie { get; set; }
        public ICollection<Vrij1object> Vrij1object { get; set; }
        public ICollection<Vrij2object> Vrij2object { get; set; }
        public ICollection<Vrij3object> Vrij3object { get; set; }
        public ICollection<Vrij4object> Vrij4object { get; set; }
        public ICollection<Vrij5object> Vrij5object { get; set; }
    }
}
