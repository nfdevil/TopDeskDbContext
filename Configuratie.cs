using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Configuratie
    {
        public Configuratie()
        {
            ArtikelMutatie = new HashSet<ArtikelMutatie>();
            ArtikelVoorraadLink = new HashSet<ArtikelVoorraadLink>();
            ConfiguratieConfiguratieLinkChild = new HashSet<ConfiguratieConfiguratieLink>();
            ConfiguratieConfiguratieLinkParent = new HashSet<ConfiguratieConfiguratieLink>();
            ConfiguratieDocumenten = new HashSet<ConfiguratieDocumenten>();
            ConfiguratieEmailberichten = new HashSet<ConfiguratieEmailberichten>();
            ConfiguratieLogboek = new HashSet<ConfiguratieLogboek>();
            ConfiguratieMemoHistory = new HashSet<ConfiguratieMemoHistory>();
            Hardware = new HashSet<Hardware>();
            Incident = new HashSet<Incident>();
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
            ObjConfLink = new HashSet<ObjConfLink>();
            Object = new HashSet<Object>();
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
        public string Diversen { get; set; }
        public int Gebruikerofgroepkeuze { get; set; }
        public Guid? Lokatieid { get; set; }
        public string Naam { get; set; }
        public string Nodenummer { get; set; }
        public Guid? Persoongroepid { get; set; }
        public Guid? Persoonid { get; set; }
        public string RefPlaats1 { get; set; }
        public string RefVestiging { get; set; }
        public Guid? Soortaansluitingid { get; set; }
        public string Specificatie1 { get; set; }
        public string Specificatie2 { get; set; }
        public string Specificatie3 { get; set; }
        public string Specificatie4 { get; set; }
        public int Status { get; set; }
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
        public string RefGroepnaam { get; set; }
        public DateTime? Dataanmk { get; set; }
        public DateTime? Datwijzig { get; set; }
        public DateTime? Vrijedatum1 { get; set; }
        public DateTime? Vrijedatum2 { get; set; }
        public Guid? Statusid { get; set; }
        public Guid? Budgethouderid { get; set; }
        public int Importtype { get; set; }
        public DateTime? Importdate { get; set; }
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
        public string RefLokatie { get; set; }
        public string Bespokememo { get; set; }
        public string RefGebruiker { get; set; }
        public string RefGebruikerdynanaam { get; set; }
        public string RefAfdeling { get; set; }
        public string RefBudgethouder { get; set; }

        public Archiefreden Archiefreden { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek1Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek2Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek3Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek4Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek5Navigation { get; set; }
        public Budgethouder Budgethouder { get; set; }
        public Locatie Lokatie { get; set; }
        public Persoon Persoon { get; set; }
        public Persoongroep Persoongroep { get; set; }
        public Soortaansluiting Soortaansluiting { get; set; }
        public Objectstatus StatusNavigation { get; set; }
        public Gebruiker UidaanmkNavigation { get; set; }
        public Gebruiker UidwijzigNavigation { get; set; }
        public Vestiging Vestiging { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek1Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek2Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek3Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek4Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek5Navigation { get; set; }
        public ICollection<ArtikelMutatie> ArtikelMutatie { get; set; }
        public ICollection<ArtikelVoorraadLink> ArtikelVoorraadLink { get; set; }
        public ICollection<ConfiguratieConfiguratieLink> ConfiguratieConfiguratieLinkChild { get; set; }
        public ICollection<ConfiguratieConfiguratieLink> ConfiguratieConfiguratieLinkParent { get; set; }
        public ICollection<ConfiguratieDocumenten> ConfiguratieDocumenten { get; set; }
        public ICollection<ConfiguratieEmailberichten> ConfiguratieEmailberichten { get; set; }
        public ICollection<ConfiguratieLogboek> ConfiguratieLogboek { get; set; }
        public ICollection<ConfiguratieMemoHistory> ConfiguratieMemoHistory { get; set; }
        public ICollection<Hardware> Hardware { get; set; }
        public ICollection<Incident> Incident { get; set; }
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
        public ICollection<ObjConfLink> ObjConfLink { get; set; }
        public ICollection<Object> Object { get; set; }
        public ICollection<Software> Software { get; set; }
        public ICollection<Telefonie> Telefonie { get; set; }
        public ICollection<Vrij1object> Vrij1object { get; set; }
        public ICollection<Vrij2object> Vrij2object { get; set; }
        public ICollection<Vrij3object> Vrij3object { get; set; }
        public ICollection<Vrij4object> Vrij4object { get; set; }
        public ICollection<Vrij5object> Vrij5object { get; set; }
    }
}
