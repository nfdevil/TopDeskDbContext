using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Servicewindow
    {
        public Servicewindow()
        {
            Dnodienst = new HashSet<Dnodienst>();
            Hardware = new HashSet<Hardware>();
            Incident = new HashSet<Incident>();
            Inventaris = new HashSet<Inventaris>();
            Locatie = new HashSet<Locatie>();
            Netwerkcomponent = new HashSet<Netwerkcomponent>();
            Object = new HashSet<Object>();
            Servicelevel = new HashSet<Servicelevel>();
            ServicewindowDocumenten = new HashSet<ServicewindowDocumenten>();
            ServicewindowEmailberichten = new HashSet<ServicewindowEmailberichten>();
            ServicewindowLogboek = new HashSet<ServicewindowLogboek>();
            ServicewindowMemoHistory = new HashSet<ServicewindowMemoHistory>();
            Software = new HashSet<Software>();
            SwUitzonderingen = new HashSet<SwUitzonderingen>();
            Telefonie = new HashSet<Telefonie>();
            Vestiging = new HashSet<Vestiging>();
            Vrij1object = new HashSet<Vrij1object>();
            Vrij2object = new HashSet<Vrij2object>();
            Vrij3object = new HashSet<Vrij3object>();
            Vrij4object = new HashSet<Vrij4object>();
            Vrij5object = new HashSet<Vrij5object>();
        }

        public Guid Unid { get; set; }
        public DateTime? Dataanmk { get; set; }
        public DateTime? Datwijzig { get; set; }
        public Guid? Uidaanmk { get; set; }
        public Guid? Uidwijzig { get; set; }
        public int Status { get; set; }
        public Guid? Archiefredenid { get; set; }
        public string Aantekeningen { get; set; }
        public string Naam { get; set; }
        public string Toelichting { get; set; }
        public Guid? Statusid { get; set; }
        public bool Moworkday { get; set; }
        public long Moopen { get; set; }
        public long Moclose { get; set; }
        public bool Tuworkday { get; set; }
        public long Tuopen { get; set; }
        public long Tuclose { get; set; }
        public bool Weworkday { get; set; }
        public long Weopen { get; set; }
        public long Weclose { get; set; }
        public bool Thworkday { get; set; }
        public long Thopen { get; set; }
        public long Thclose { get; set; }
        public bool Frworkday { get; set; }
        public long Fropen { get; set; }
        public long Frclose { get; set; }
        public bool Saworkday { get; set; }
        public long Saopen { get; set; }
        public long Saclose { get; set; }
        public bool Suworkday { get; set; }
        public long Suopen { get; set; }
        public long Suclose { get; set; }
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
        public string Bespokememo { get; set; }
        public int Importtype { get; set; }
        public int TimezonePerspective { get; set; }
        public string Importid { get; set; }
        public DateTime? Importdate { get; set; }

        public Archiefreden Archiefreden { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek1Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek2Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek3Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek4Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek5Navigation { get; set; }
        public SwStatus StatusNavigation { get; set; }
        public Gebruiker UidaanmkNavigation { get; set; }
        public Gebruiker UidwijzigNavigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek1Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek2Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek3Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek4Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek5Navigation { get; set; }
        public ICollection<Dnodienst> Dnodienst { get; set; }
        public ICollection<Hardware> Hardware { get; set; }
        public ICollection<Incident> Incident { get; set; }
        public ICollection<Inventaris> Inventaris { get; set; }
        public ICollection<Locatie> Locatie { get; set; }
        public ICollection<Netwerkcomponent> Netwerkcomponent { get; set; }
        public ICollection<Object> Object { get; set; }
        public ICollection<Servicelevel> Servicelevel { get; set; }
        public ICollection<ServicewindowDocumenten> ServicewindowDocumenten { get; set; }
        public ICollection<ServicewindowEmailberichten> ServicewindowEmailberichten { get; set; }
        public ICollection<ServicewindowLogboek> ServicewindowLogboek { get; set; }
        public ICollection<ServicewindowMemoHistory> ServicewindowMemoHistory { get; set; }
        public ICollection<Software> Software { get; set; }
        public ICollection<SwUitzonderingen> SwUitzonderingen { get; set; }
        public ICollection<Telefonie> Telefonie { get; set; }
        public ICollection<Vestiging> Vestiging { get; set; }
        public ICollection<Vrij1object> Vrij1object { get; set; }
        public ICollection<Vrij2object> Vrij2object { get; set; }
        public ICollection<Vrij3object> Vrij3object { get; set; }
        public ICollection<Vrij4object> Vrij4object { get; set; }
        public ICollection<Vrij5object> Vrij5object { get; set; }
    }
}
