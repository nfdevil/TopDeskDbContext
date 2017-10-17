using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class ChangeTemplate
    {
        public ChangeTemplate()
        {
            Change = new HashSet<Change>();
            ChangeActTemplDependency = new HashSet<ChangeActTemplDependency>();
            ChangeTemplActivityLink = new HashSet<ChangeTemplActivityLink>();
            ChangeTemplateDocumenten = new HashSet<ChangeTemplateDocumenten>();
            ChangeTemplateDocuments = new HashSet<ChangeTemplateDocuments>();
            ChangeTemplateEmailberichten = new HashSet<ChangeTemplateEmailberichten>();
            ChangeTemplateLogboek = new HashSet<ChangeTemplateLogboek>();
            ChangeTemplateMemoHistory = new HashSet<ChangeTemplateMemoHistory>();
            Changetemplategrouplink = new HashSet<Changetemplategrouplink>();
        }

        public string Action { get; set; }
        public Guid? Archivereasonid { get; set; }
        public Guid? Benefitid { get; set; }
        public bool CallerBranchFilterActive { get; set; }
        public Guid? CallerBranchid { get; set; }
        public bool CallerBudgetFilterActive { get; set; }
        public Guid? CallerBudgetholderid { get; set; }
        public bool CallerDepFilterActive { get; set; }
        public Guid? CallerDepartmentid { get; set; }
        public int CallerFilterType { get; set; }
        public Guid? Categoryid { get; set; }
        public DateTime? Dataanmk { get; set; }
        public DateTime? Datwijzig { get; set; }
        public string Description { get; set; }
        public long DurationInMinutesRfc { get; set; }
        public long DurationInWorkdaysRfc { get; set; }
        public decimal Estimatedexpenses { get; set; }
        public long Estimatedtimetaken { get; set; }
        public Guid? Impactid { get; set; }
        public bool IncidentCategoryActive { get; set; }
        public int IncidentFilterType { get; set; }
        public bool IncidentSubcategoryActive { get; set; }
        public Guid? IncidentTypeid { get; set; }
        public bool IncidentTypeActive { get; set; }
        public bool Isurgent { get; set; }
        public string Metanotes { get; set; }
        public string Number { get; set; }
        public bool ObjectCardtypeFilterActive { get; set; }
        public int ObjectFilterType { get; set; }
        public bool ObjectMakeFilterActive { get; set; }
        public Guid? ObjectMakeid { get; set; }
        public bool ObjectTypeFilterActive { get; set; }
        public Guid? ObjectTypeid { get; set; }
        public Guid? Operatorid { get; set; }
        public bool RfcCategoryActive { get; set; }
        public int RfcFilterType { get; set; }
        public bool RfcImpactActive { get; set; }
        public bool RfcSubcategoryActive { get; set; }
        public bool RfcTypeActive { get; set; }
        public bool RfcUrgencyActive { get; set; }
        public string Briefdescription { get; set; }
        public int Status { get; set; }
        public Guid? Statusid { get; set; }
        public Guid? Subcategoryid { get; set; }
        public Guid? Typeid { get; set; }
        public Guid? Uidaanmk { get; set; }
        public Guid? Uidwijzig { get; set; }
        public Guid Unid { get; set; }
        public int UseCurrentOperator { get; set; }
        public bool UseInIncident { get; set; }
        public bool UseInRfc { get; set; }
        public bool Withevaluation { get; set; }
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
        public bool UseInSsd { get; set; }
        public Guid? ReqAuthpersonid { get; set; }
        public Guid? ReqAuthoperatorid { get; set; }
        public Guid? ProAuthoperatorid { get; set; }
        public Guid? ProAuthpersonid { get; set; }
        public Guid? EvalAuthoperatorid { get; set; }
        public Guid? EvalAuthpersonid { get; set; }
        public int ProDecidedby { get; set; }
        public int EvalDecidedby { get; set; }
        public string Comments { get; set; }
        public int Changetype { get; set; }
        public int UseCurrentManager { get; set; }
        public Guid? Managerid { get; set; }
        public Guid? Operatorgroupid { get; set; }
        public long DurationInWorkdaysSimple { get; set; }
        public long DurationInMinutesSimple { get; set; }
        public Guid? Priorityid { get; set; }
        public bool PrelReqApproved { get; set; }
        public bool ReqApproved { get; set; }
        public string ObjectCardtype { get; set; }
        public string Bespokememo { get; set; }
        public int Importtype { get; set; }
        public string Importid { get; set; }
        public DateTime? Importdate { get; set; }
        public bool Invisibleforcaller { get; set; }

        public Archiefreden Archivereason { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek1Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek2Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek3Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek4Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek5Navigation { get; set; }
        public Changebenefit Benefit { get; set; }
        public Vestiging CallerBranch { get; set; }
        public Budgethouder CallerBudgetholder { get; set; }
        public Afdeling CallerDepartment { get; set; }
        public Classificatie Category { get; set; }
        public Actiedoor EvalAuthoperator { get; set; }
        public Persoon EvalAuthperson { get; set; }
        public WijzigingImpact Impact { get; set; }
        public Soortmelding IncidentType { get; set; }
        public Actiedoor Manager { get; set; }
        public Objectmerk ObjectMake { get; set; }
        public Objectsoort ObjectType { get; set; }
        public Actiedoor Operator { get; set; }
        public Actiedoor Operatorgroup { get; set; }
        public ChangePriority Priority { get; set; }
        public Actiedoor ProAuthoperator { get; set; }
        public Persoon ProAuthperson { get; set; }
        public Actiedoor ReqAuthoperator { get; set; }
        public Persoon ReqAuthperson { get; set; }
        public Wijzigingstatus StatusNavigation { get; set; }
        public Classificatie Subcategory { get; set; }
        public Wbaanvraagtype Type { get; set; }
        public Gebruiker UidaanmkNavigation { get; set; }
        public Gebruiker UidwijzigNavigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek1Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek2Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek3Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek4Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek5Navigation { get; set; }
        public ICollection<Change> Change { get; set; }
        public ICollection<ChangeActTemplDependency> ChangeActTemplDependency { get; set; }
        public ICollection<ChangeTemplActivityLink> ChangeTemplActivityLink { get; set; }
        public ICollection<ChangeTemplateDocumenten> ChangeTemplateDocumenten { get; set; }
        public ICollection<ChangeTemplateDocuments> ChangeTemplateDocuments { get; set; }
        public ICollection<ChangeTemplateEmailberichten> ChangeTemplateEmailberichten { get; set; }
        public ICollection<ChangeTemplateLogboek> ChangeTemplateLogboek { get; set; }
        public ICollection<ChangeTemplateMemoHistory> ChangeTemplateMemoHistory { get; set; }
        public ICollection<Changetemplategrouplink> Changetemplategrouplink { get; set; }
    }
}
