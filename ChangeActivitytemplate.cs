using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class ChangeActivitytemplate
    {
        public ChangeActivitytemplate()
        {
            ChangeActTemplDependencyHead = new HashSet<ChangeActTemplDependency>();
            ChangeActTemplDependencyTail = new HashSet<ChangeActTemplDependency>();
            ChangeActivitytemplateDocumenten = new HashSet<ChangeActivitytemplateDocumenten>();
            ChangeActivitytemplateDocuments = new HashSet<ChangeActivitytemplateDocuments>();
            ChangeActivitytemplateEmailberichten = new HashSet<ChangeActivitytemplateEmailberichten>();
            ChangeActivitytemplateLogboek = new HashSet<ChangeActivitytemplateLogboek>();
            ChangeActivitytemplateMemoHistory = new HashSet<ChangeActivitytemplateMemoHistory>();
            ChangeTemplActivityLink = new HashSet<ChangeTemplActivityLink>();
            Changeactivity = new HashSet<Changeactivity>();
        }

        public string Action { get; set; }
        public Guid? Archivereasonid { get; set; }
        public string Briefdescription { get; set; }
        public Guid? Categoryid { get; set; }
        public DateTime? Dataanmk { get; set; }
        public DateTime? Datwijzig { get; set; }
        public string Description { get; set; }
        public long DurationInMinutes { get; set; }
        public long DurationInWorkdays { get; set; }
        public decimal Estimatedexpenses { get; set; }
        public long Estimatedtimetaken { get; set; }
        public int Planningfixed { get; set; }
        public string Metanotes { get; set; }
        public string Number { get; set; }
        public Guid? Operatorgroupid { get; set; }
        public Guid? Operatorid { get; set; }
        public bool Optional { get; set; }
        public int Status { get; set; }
        public Guid? Subcategoryid { get; set; }
        public Guid? Uidaanmk { get; set; }
        public Guid? Uidwijzig { get; set; }
        public Guid Unid { get; set; }
        public bool Useforactivity { get; set; }
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
        public string Comments { get; set; }
        public int Decidedby { get; set; }
        public Guid? Decidedbypersonid { get; set; }
        public string Bespokememo { get; set; }
        public int Changephase { get; set; }
        public Guid? Activitystatusid { get; set; }
        public bool UsingCurrentOperator { get; set; }
        public int Importtype { get; set; }
        public string Importid { get; set; }
        public DateTime? Importdate { get; set; }
        public bool Invisibleforcaller { get; set; }
        public bool Displayincalendar { get; set; }

        public ChangeactivityStatus Activitystatus { get; set; }
        public Archiefreden Archivereason { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek1Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek2Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek3Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek4Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek5Navigation { get; set; }
        public Classificatie Category { get; set; }
        public Persoon Decidedbyperson { get; set; }
        public Actiedoor Operator { get; set; }
        public Actiedoor Operatorgroup { get; set; }
        public Classificatie Subcategory { get; set; }
        public Gebruiker UidaanmkNavigation { get; set; }
        public Gebruiker UidwijzigNavigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek1Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek2Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek3Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek4Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek5Navigation { get; set; }
        public ICollection<ChangeActTemplDependency> ChangeActTemplDependencyHead { get; set; }
        public ICollection<ChangeActTemplDependency> ChangeActTemplDependencyTail { get; set; }
        public ICollection<ChangeActivitytemplateDocumenten> ChangeActivitytemplateDocumenten { get; set; }
        public ICollection<ChangeActivitytemplateDocuments> ChangeActivitytemplateDocuments { get; set; }
        public ICollection<ChangeActivitytemplateEmailberichten> ChangeActivitytemplateEmailberichten { get; set; }
        public ICollection<ChangeActivitytemplateLogboek> ChangeActivitytemplateLogboek { get; set; }
        public ICollection<ChangeActivitytemplateMemoHistory> ChangeActivitytemplateMemoHistory { get; set; }
        public ICollection<ChangeTemplActivityLink> ChangeTemplActivityLink { get; set; }
        public ICollection<Changeactivity> Changeactivity { get; set; }
    }
}
