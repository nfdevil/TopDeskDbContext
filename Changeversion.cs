using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Changeversion
    {
        public Changeversion()
        {
            ChangeMilestone = new HashSet<Change>();
            ChangeVersion = new HashSet<Change>();
            Changeactivity = new HashSet<Changeactivity>();
            ChangeversionDocumenten = new HashSet<ChangeversionDocumenten>();
            ChangeversionEmailberichten = new HashSet<ChangeversionEmailberichten>();
            ChangeversionLogboek = new HashSet<ChangeversionLogboek>();
            ChangeversionMemoHistory = new HashSet<ChangeversionMemoHistory>();
            InverseParent = new HashSet<Changeversion>();
            MeetingVersionLink = new HashSet<MeetingVersionLink>();
            MutatieChangeMutMilestone = new HashSet<MutatieChange>();
            MutatieChangeMutVersion = new HashSet<MutatieChange>();
            MutatieChangeactivity = new HashSet<MutatieChangeactivity>();
            MutatieChangeversion = new HashSet<MutatieChangeversion>();
            MutatieProfacboomProjectMutMilestone = new HashSet<MutatieProfacboomProject>();
            MutatieProfacboomProjectMutVersion = new HashSet<MutatieProfacboomProject>();
            ProfacboomProjectMilestone = new HashSet<ProfacboomProject>();
            ProfacboomProjectVersion = new HashSet<ProfacboomProject>();
        }

        public string Action { get; set; }
        public Guid? Archivereasonid { get; set; }
        public Guid? Benefitid { get; set; }
        public string Briefdescription { get; set; }
        public DateTime? Dataanmk { get; set; }
        public DateTime? Datwijzig { get; set; }
        public string Description { get; set; }
        public DateTime? Freezedate { get; set; }
        public Guid? Impactid { get; set; }
        public string Importid { get; set; }
        public DateTime? Implementationdate { get; set; }
        public bool Implemented { get; set; }
        public string Notes { get; set; }
        public Guid? Operatorid { get; set; }
        public Guid? Parentid { get; set; }
        public DateTime? Plannedimpldate { get; set; }
        public Guid? Priorityid { get; set; }
        public int Status { get; set; }
        public Guid? Statusid { get; set; }
        public Guid? Typeid { get; set; }
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
        public string Bespokememo { get; set; }
        public int Importtype { get; set; }
        public DateTime? Importdate { get; set; }
        public int PublishType { get; set; }
        public int PublishDescriptionType { get; set; }
        public string PublishTitle { get; set; }
        public string PublishDescription { get; set; }
        public string RefProgresstrail { get; set; }

        public Archiefreden Archivereason { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek1Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek2Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek3Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek4Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek5Navigation { get; set; }
        public Changebenefit Benefit { get; set; }
        public WijzigingImpact Impact { get; set; }
        public Actiedoor Operator { get; set; }
        public Changeversion Parent { get; set; }
        public ChangePriority Priority { get; set; }
        public Wijzigingstatus StatusNavigation { get; set; }
        public Wbaanvraagtype Type { get; set; }
        public Gebruiker UidaanmkNavigation { get; set; }
        public Gebruiker UidwijzigNavigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek1Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek2Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek3Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek4Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek5Navigation { get; set; }
        public ICollection<Change> ChangeMilestone { get; set; }
        public ICollection<Change> ChangeVersion { get; set; }
        public ICollection<Changeactivity> Changeactivity { get; set; }
        public ICollection<ChangeversionDocumenten> ChangeversionDocumenten { get; set; }
        public ICollection<ChangeversionEmailberichten> ChangeversionEmailberichten { get; set; }
        public ICollection<ChangeversionLogboek> ChangeversionLogboek { get; set; }
        public ICollection<ChangeversionMemoHistory> ChangeversionMemoHistory { get; set; }
        public ICollection<Changeversion> InverseParent { get; set; }
        public ICollection<MeetingVersionLink> MeetingVersionLink { get; set; }
        public ICollection<MutatieChange> MutatieChangeMutMilestone { get; set; }
        public ICollection<MutatieChange> MutatieChangeMutVersion { get; set; }
        public ICollection<MutatieChangeactivity> MutatieChangeactivity { get; set; }
        public ICollection<MutatieChangeversion> MutatieChangeversion { get; set; }
        public ICollection<MutatieProfacboomProject> MutatieProfacboomProjectMutMilestone { get; set; }
        public ICollection<MutatieProfacboomProject> MutatieProfacboomProjectMutVersion { get; set; }
        public ICollection<ProfacboomProject> ProfacboomProjectMilestone { get; set; }
        public ICollection<ProfacboomProject> ProfacboomProjectVersion { get; set; }
    }
}
