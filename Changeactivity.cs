using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Changeactivity
    {
        public Changeactivity()
        {
            ChangeActOrderreqLink = new HashSet<ChangeActOrderreqLink>();
            ChangeactivityDependencyHead = new HashSet<ChangeactivityDependency>();
            ChangeactivityDependencyTail = new HashSet<ChangeactivityDependency>();
            ChangeactivityDocumenten = new HashSet<ChangeactivityDocumenten>();
            ChangeactivityEmailberichten = new HashSet<ChangeactivityEmailberichten>();
            ChangeactivityLogboek = new HashSet<ChangeactivityLogboek>();
            ChangeactivityMemoHistory = new HashSet<ChangeactivityMemoHistory>();
            ChangeactivityObjectLink = new HashSet<ChangeactivityObjectLink>();
            Changeactivityorderlink = new HashSet<Changeactivityorderlink>();
            MeetingChangeactivityLink = new HashSet<MeetingChangeactivityLink>();
            MutatieChangeactivity = new HashSet<MutatieChangeactivity>();
            TimeRegistrationChangeactivity = new HashSet<TimeRegistrationChangeactivity>();
        }

        public string Action { get; set; }
        public Guid? Activitytemplateid { get; set; }
        public bool Approved { get; set; }
        public DateTime? Approveddate { get; set; }
        public Guid? Archivereasonid { get; set; }
        public string Briefdescription { get; set; }
        public Guid? Categoryid { get; set; }
        public Guid Changeid { get; set; }
        public string Comments { get; set; }
        public decimal Currentplanexpenses { get; set; }
        public long Currentplantimetaken { get; set; }
        public DateTime? Dataanmk { get; set; }
        public DateTime? Datwijzig { get; set; }
        public int Decidedby { get; set; }
        public Guid? Decidedbypersonid { get; set; }
        public decimal Expectedexpenses { get; set; }
        public long Expectedtimetaken { get; set; }
        public decimal Expenses { get; set; }
        public Guid? Groupid { get; set; }
        public int Importtype { get; set; }
        public Guid? Milestoneid { get; set; }
        public string Number { get; set; }
        public Guid? Operatorgroupid { get; set; }
        public Guid? Operatorid { get; set; }
        public decimal Originalplanexpenses { get; set; }
        public long Originalplantimetaken { get; set; }
        public int Changephase { get; set; }
        public DateTime? Plannedfinaldate { get; set; }
        public DateTime? Plannedstartdate { get; set; }
        public int Planningfixed { get; set; }
        public decimal Realizedexpenses { get; set; }
        public bool Rejected { get; set; }
        public DateTime? Rejecteddate { get; set; }
        public Guid? Rejectionreasonid { get; set; }
        public string Description { get; set; }
        public bool Resolved { get; set; }
        public DateTime? Resolveddate { get; set; }
        public bool Skipped { get; set; }
        public DateTime? Skippeddate { get; set; }
        public Guid? Skippedreasonid { get; set; }
        public bool Started { get; set; }
        public DateTime? Starteddate { get; set; }
        public int Status { get; set; }
        public Guid? Subcategoryid { get; set; }
        public long Timetaken { get; set; }
        public Guid? Uidaanmk { get; set; }
        public Guid? Uidwijzig { get; set; }
        public Guid Unid { get; set; }
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
        public long DurationInWorkdays { get; set; }
        public long DurationInMinutes { get; set; }
        public string Bespokememo { get; set; }
        public Guid? Activitystatusid { get; set; }
        public bool Maystart { get; set; }
        public string Importid { get; set; }
        public DateTime? Importdate { get; set; }
        public bool Monitored { get; set; }
        public string RefChangeBriefDescription { get; set; }
        public string RefChangeNumber { get; set; }
        public Guid? Appointmentid { get; set; }
        public bool Displayincalendar { get; set; }
        public string RefOperatorName { get; set; }
        public string RefProgresstrail { get; set; }

        public ChangeactivityStatus Activitystatus { get; set; }
        public ChangeActivitytemplate Activitytemplate { get; set; }
        public Appointment Appointment { get; set; }
        public Archiefreden Archivereason { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek1Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek2Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek3Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek4Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek5Navigation { get; set; }
        public Classificatie Category { get; set; }
        public Change Change { get; set; }
        public Persoon Decidedbyperson { get; set; }
        public ChangeGroup Group { get; set; }
        public Changeversion Milestone { get; set; }
        public Actiedoor Operator { get; set; }
        public Actiedoor Operatorgroup { get; set; }
        public ChangeactivityRejectionreason Rejectionreason { get; set; }
        public ChangeactivitySkippedreason Skippedreason { get; set; }
        public Classificatie Subcategory { get; set; }
        public Gebruiker UidaanmkNavigation { get; set; }
        public Gebruiker UidwijzigNavigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek1Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek2Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek3Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek4Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek5Navigation { get; set; }
        public ICollection<ChangeActOrderreqLink> ChangeActOrderreqLink { get; set; }
        public ICollection<ChangeactivityDependency> ChangeactivityDependencyHead { get; set; }
        public ICollection<ChangeactivityDependency> ChangeactivityDependencyTail { get; set; }
        public ICollection<ChangeactivityDocumenten> ChangeactivityDocumenten { get; set; }
        public ICollection<ChangeactivityEmailberichten> ChangeactivityEmailberichten { get; set; }
        public ICollection<ChangeactivityLogboek> ChangeactivityLogboek { get; set; }
        public ICollection<ChangeactivityMemoHistory> ChangeactivityMemoHistory { get; set; }
        public ICollection<ChangeactivityObjectLink> ChangeactivityObjectLink { get; set; }
        public ICollection<Changeactivityorderlink> Changeactivityorderlink { get; set; }
        public ICollection<MeetingChangeactivityLink> MeetingChangeactivityLink { get; set; }
        public ICollection<MutatieChangeactivity> MutatieChangeactivity { get; set; }
        public ICollection<TimeRegistrationChangeactivity> TimeRegistrationChangeactivity { get; set; }
    }
}
