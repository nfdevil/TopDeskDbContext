using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Change
    {
        public Change()
        {
            ChangeBranchLink = new HashSet<ChangeBranchLink>();
            ChangeDocumenten = new HashSet<ChangeDocumenten>();
            ChangeEmailberichten = new HashSet<ChangeEmailberichten>();
            ChangeIncCausedbyLink = new HashSet<ChangeIncCausedbyLink>();
            ChangeIncidentLink = new HashSet<ChangeIncidentLink>();
            ChangeLogboek = new HashSet<ChangeLogboek>();
            ChangeMemoHistory = new HashSet<ChangeMemoHistory>();
            ChangeObjectLink = new HashSet<ChangeObjectLink>();
            ChangePersonLink = new HashSet<ChangePersonLink>();
            ChangeProblemCausedbyLink = new HashSet<ChangeProblemCausedbyLink>();
            ChangeProblemLink = new HashSet<ChangeProblemLink>();
            Changeactivity = new HashSet<Changeactivity>();
            Changeauthorization = new HashSet<Changeauthorization>();
            Changegrouplink = new HashSet<Changegrouplink>();
            MeetingChangeLink = new HashSet<MeetingChangeLink>();
            MutatieChange = new HashSet<MutatieChange>();
            ProfacboomprojectChangeLink = new HashSet<ProfacboomprojectChangeLink>();
            TimeRegistrationChange = new HashSet<TimeRegistrationChange>();
        }

        public Guid? Aanmelderafdelingid { get; set; }
        public Guid? Aanmelderbudgethouderid { get; set; }
        public string Aanmelderemail { get; set; }
        public Guid? Aanmelderlokatieid { get; set; }
        public string Aanmeldertelefoon { get; set; }
        public Guid? Aanmeldervestigingid { get; set; }
        public string Action { get; set; }
        public Guid? Archivereasonid { get; set; }
        public Guid? Benefitid { get; set; }
        public Guid? Branchid { get; set; }
        public string Briefdescription { get; set; }
        public int CalcTypeAuthdate { get; set; }
        public int CalcTypeFinaldate { get; set; }
        public int CalcTypeImpldate { get; set; }
        public DateTime? Calldate { get; set; }
        public Guid? Categoryid { get; set; }
        public decimal Currentplanexpenses { get; set; }
        public long Currentplantimetaken { get; set; }
        public int Changetype { get; set; }
        public bool Closed { get; set; }
        public DateTime? Closeddate { get; set; }
        public string Comments { get; set; }
        public bool Completed { get; set; }
        public DateTime? Completeddate { get; set; }
        public int Currentphase { get; set; }
        public DateTime? Dataanmk { get; set; }
        public DateTime? Datwijzig { get; set; }
        public string Description { get; set; }
        public decimal Estimateexpenses { get; set; }
        public long Estimatetimetaken { get; set; }
        public DateTime? Finaldate { get; set; }
        public Guid? EvalAuthoperatorid { get; set; }
        public Guid? EvalAuthpersonid { get; set; }
        public decimal Expenses { get; set; }
        public string Externalnumber { get; set; }
        public Guid? Extraaid { get; set; }
        public Guid? Extraapersoonid { get; set; }
        public Guid? Extrabid { get; set; }
        public Guid? Extrabpersoonid { get; set; }
        public Guid? Impactid { get; set; }
        public int Importtype { get; set; }
        public Guid? Incidentid { get; set; }
        public bool Isurgent { get; set; }
        public Guid? Locationid { get; set; }
        public Guid? Managerid { get; set; }
        public Guid? Milestoneid { get; set; }
        public string Number { get; set; }
        public Guid? Objectid { get; set; }
        public Guid? Operatorgroupid { get; set; }
        public Guid? Operatorid { get; set; }
        public decimal Originalplanexpenses { get; set; }
        public long Originalplantimetaken { get; set; }
        public Guid? Persoonid { get; set; }
        public DateTime? Plannedauthdate { get; set; }
        public DateTime? Plannedfinaldate { get; set; }
        public DateTime? Plannedimpldate { get; set; }
        public DateTime? Implementationdate { get; set; }
        public Guid? ProAuthoperatorid { get; set; }
        public Guid? ProAuthpersonid { get; set; }
        public DateTime? Rejecteddate { get; set; }
        public Guid? Rejectionreasonid { get; set; }
        public DateTime? Authorizationdate { get; set; }
        public Guid? ReqAuthoperatorid { get; set; }
        public Guid? ReqAuthpersonid { get; set; }
        public bool Started { get; set; }
        public DateTime? Starteddate { get; set; }
        public int Status { get; set; }
        public Guid? Statusid { get; set; }
        public Guid? Subcategoryid { get; set; }
        public DateTime? Submitdate { get; set; }
        public decimal SumRealizedexpenses { get; set; }
        public long SumRealizedtime { get; set; }
        public decimal SumRemainingexpenses { get; set; }
        public long SumRemainingtime { get; set; }
        public Guid? Templateid { get; set; }
        public long Timetaken { get; set; }
        public Guid? Typeid { get; set; }
        public Guid? Uidaanmk { get; set; }
        public Guid? Uidwijzig { get; set; }
        public Guid Unid { get; set; }
        public Guid? Versionid { get; set; }
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
        public int EvalDecidedby { get; set; }
        public int ProDecidedby { get; set; }
        public DateTime? Plannedstartdate { get; set; }
        public int Rejectedby { get; set; }
        public int Canceledby { get; set; }
        public Guid? Canceledbypersonid { get; set; }
        public Guid? Canceledbyoperatorid { get; set; }
        public Guid? Cancelreasonid { get; set; }
        public DateTime? Canceldate { get; set; }
        public Guid? Priorityid { get; set; }
        public bool Rejected { get; set; }
        public DateTime? ProRejecteddate { get; set; }
        public string Bespokememo { get; set; }
        public bool MayauthorizeRfc { get; set; }
        public bool MayauthorizePro { get; set; }
        public bool MayauthorizeEval { get; set; }
        public string Importid { get; set; }
        public DateTime? Importdate { get; set; }
        public int PublishType { get; set; }
        public int PublishDescriptionType { get; set; }
        public string PublishTitle { get; set; }
        public string PublishDescription { get; set; }
        public bool Savedinsecure { get; set; }
        public string RefCategoryName { get; set; }
        public string RefSubcategoryName { get; set; }
        public Guid? Appointmentid { get; set; }
        public string Aanmeldernaam { get; set; }
        public string RefOperatorname { get; set; }
        public string RefEvalAuthoperatorName { get; set; }
        public string RefProAuthoperatorName { get; set; }
        public string RefReqAuthoperatorName { get; set; }
        public string RefTypeName { get; set; }
        public string RefProgresstrail { get; set; }

        public Afdeling Aanmelderafdeling { get; set; }
        public Budgethouder Aanmelderbudgethouder { get; set; }
        public Locatie Aanmelderlokatie { get; set; }
        public Vestiging Aanmeldervestiging { get; set; }
        public Appointment Appointment { get; set; }
        public Archiefreden Archivereason { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek1Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek2Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek3Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek4Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek5Navigation { get; set; }
        public Changebenefit Benefit { get; set; }
        public Vestiging Branch { get; set; }
        public Actiedoor Canceledbyoperator { get; set; }
        public Persoon Canceledbyperson { get; set; }
        public Changecancelreason Cancelreason { get; set; }
        public Classificatie Category { get; set; }
        public Actiedoor EvalAuthoperator { get; set; }
        public Persoon EvalAuthperson { get; set; }
        public Extraa Extraa { get; set; }
        public Extraapersoon Extraapersoon { get; set; }
        public Extrab Extrab { get; set; }
        public Extrabpersoon Extrabpersoon { get; set; }
        public WijzigingImpact Impact { get; set; }
        public Incident Incident { get; set; }
        public Locatie Location { get; set; }
        public Actiedoor Manager { get; set; }
        public Changeversion Milestone { get; set; }
        public Object Object { get; set; }
        public Actiedoor Operator { get; set; }
        public Actiedoor Operatorgroup { get; set; }
        public Persoon Persoon { get; set; }
        public ChangePriority Priority { get; set; }
        public Actiedoor ProAuthoperator { get; set; }
        public Persoon ProAuthperson { get; set; }
        public Changerejectionreason Rejectionreason { get; set; }
        public Actiedoor ReqAuthoperator { get; set; }
        public Persoon ReqAuthperson { get; set; }
        public Wijzigingstatus StatusNavigation { get; set; }
        public Classificatie Subcategory { get; set; }
        public ChangeTemplate Template { get; set; }
        public Wbaanvraagtype Type { get; set; }
        public Gebruiker UidaanmkNavigation { get; set; }
        public Gebruiker UidwijzigNavigation { get; set; }
        public Changeversion Version { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek1Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek2Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek3Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek4Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek5Navigation { get; set; }
        public ICollection<ChangeBranchLink> ChangeBranchLink { get; set; }
        public ICollection<ChangeDocumenten> ChangeDocumenten { get; set; }
        public ICollection<ChangeEmailberichten> ChangeEmailberichten { get; set; }
        public ICollection<ChangeIncCausedbyLink> ChangeIncCausedbyLink { get; set; }
        public ICollection<ChangeIncidentLink> ChangeIncidentLink { get; set; }
        public ICollection<ChangeLogboek> ChangeLogboek { get; set; }
        public ICollection<ChangeMemoHistory> ChangeMemoHistory { get; set; }
        public ICollection<ChangeObjectLink> ChangeObjectLink { get; set; }
        public ICollection<ChangePersonLink> ChangePersonLink { get; set; }
        public ICollection<ChangeProblemCausedbyLink> ChangeProblemCausedbyLink { get; set; }
        public ICollection<ChangeProblemLink> ChangeProblemLink { get; set; }
        public ICollection<Changeactivity> Changeactivity { get; set; }
        public ICollection<Changeauthorization> Changeauthorization { get; set; }
        public ICollection<Changegrouplink> Changegrouplink { get; set; }
        public ICollection<MeetingChangeLink> MeetingChangeLink { get; set; }
        public ICollection<MutatieChange> MutatieChange { get; set; }
        public ICollection<ProfacboomprojectChangeLink> ProfacboomprojectChangeLink { get; set; }
        public ICollection<TimeRegistrationChange> TimeRegistrationChange { get; set; }
    }
}
