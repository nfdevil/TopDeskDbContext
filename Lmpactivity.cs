using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Lmpactivity
    {
        public Lmpactivity()
        {
            LmpOmActivityLink = new HashSet<LmpOmActivityLink>();
            LmpactivityDocumenten = new HashSet<LmpactivityDocumenten>();
            LmpactivityEmailberichten = new HashSet<LmpactivityEmailberichten>();
            LmpactivityLogboek = new HashSet<LmpactivityLogboek>();
            LmpactivityMemoHistory = new HashSet<LmpactivityMemoHistory>();
            Lmplink = new HashSet<Lmplink>();
        }

        public Guid Unid { get; set; }
        public Guid? Archiefredenid { get; set; }
        public Guid? Codeid { get; set; }
        public Guid? Subcodeid { get; set; }
        public Guid? Typeid { get; set; }
        public Guid? Branchid { get; set; }
        public Guid? Locationid { get; set; }
        public Guid? Budgetholderid { get; set; }
        public Guid? Objectid { get; set; }
        public string Request { get; set; }
        public string Remarks { get; set; }
        public Guid? Operatorid { get; set; }
        public string Specifiedlocation { get; set; }
        public Guid? Statusid { get; set; }
        public DateTime? Dataanmk { get; set; }
        public DateTime? Datwijzig { get; set; }
        public Guid? Uidaanmk { get; set; }
        public Guid? Uidwijzig { get; set; }
        public string Aantekeningen { get; set; }
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
        public int Status { get; set; }
        public string Importid { get; set; }
        public int Importtype { get; set; }
        public DateTime? Importdate { get; set; }
        public string Bespokememo { get; set; }
        public Guid? Worktypeid { get; set; }
        public string Name { get; set; }
        public string RefProgresstrail { get; set; }

        public Archiefreden Archiefreden { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek1Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek2Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek3Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek4Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek5Navigation { get; set; }
        public Vestiging Branch { get; set; }
        public Budgethouder Budgetholder { get; set; }
        public Lmpcode Code { get; set; }
        public Locatie Location { get; set; }
        public Object Object { get; set; }
        public Actiedoor Operator { get; set; }
        public Lmpactivitystatus StatusNavigation { get; set; }
        public Lmpsubcode Subcode { get; set; }
        public Lmptype Type { get; set; }
        public Gebruiker UidaanmkNavigation { get; set; }
        public Gebruiker UidwijzigNavigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek1Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek2Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek3Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek4Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek5Navigation { get; set; }
        public Lmpworktype Worktype { get; set; }
        public ICollection<LmpOmActivityLink> LmpOmActivityLink { get; set; }
        public ICollection<LmpactivityDocumenten> LmpactivityDocumenten { get; set; }
        public ICollection<LmpactivityEmailberichten> LmpactivityEmailberichten { get; set; }
        public ICollection<LmpactivityLogboek> LmpactivityLogboek { get; set; }
        public ICollection<LmpactivityMemoHistory> LmpactivityMemoHistory { get; set; }
        public ICollection<Lmplink> Lmplink { get; set; }
    }
}
