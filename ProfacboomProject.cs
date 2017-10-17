using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class ProfacboomProject
    {
        public ProfacboomProject()
        {
            InverseParent = new HashSet<ProfacboomProject>();
            InverseProjectbeheer = new HashSet<ProfacboomProject>();
            MeetingProfacboomProjectLink = new HashSet<MeetingProfacboomProjectLink>();
            MutatieProfacboomProject = new HashSet<MutatieProfacboomProject>();
            ProfacboomProjectDocumenten = new HashSet<ProfacboomProjectDocumenten>();
            ProfacboomProjectEmailberichten = new HashSet<ProfacboomProjectEmailberichten>();
            ProfacboomProjectIncidentLink = new HashSet<ProfacboomProjectIncidentLink>();
            ProfacboomProjectLogboek = new HashSet<ProfacboomProjectLogboek>();
            ProfacboomProjectMemoHistory = new HashSet<ProfacboomProjectMemoHistory>();
            ProfacboomProjectPersonLink = new HashSet<ProfacboomProjectPersonLink>();
            ProfacboomProjectProblemLink = new HashSet<ProfacboomProjectProblemLink>();
            ProfacboomProjectafhankelijkhedenKop = new HashSet<ProfacboomProjectafhankelijkheden>();
            ProfacboomProjectafhankelijkhedenStaart = new HashSet<ProfacboomProjectafhankelijkheden>();
            ProfacboomprojectChangeLink = new HashSet<ProfacboomprojectChangeLink>();
            ProjectdocumentkoppelProject = new HashSet<ProjectdocumentkoppelProject>();
            TimeRegistrationProfacboomProject = new HashSet<TimeRegistrationProfacboomProject>();
        }

        public Guid? Archiefredenid { get; set; }
        public Guid? Behandelaarid { get; set; }
        public int Doorlooptijdinwerkdagen { get; set; }
        public bool Ismijlpaal { get; set; }
        public Guid? Parentid { get; set; }
        public Guid? Projectbeheerid { get; set; }
        public int Rang { get; set; }
        public string RefFasenaam { get; set; }
        public string RefProjectnaam { get; set; }
        public bool Starten { get; set; }
        public int Status { get; set; }
        public Guid? Statusid { get; set; }
        public Guid? Typeid { get; set; }
        public Guid? Uidaanmk { get; set; }
        public Guid? Uidwijzig { get; set; }
        public Guid Unid { get; set; }
        public bool Verwachtedoorlooptijdconstant { get; set; }
        public int Verwachtedoorlooptijdeenheid { get; set; }
        public int Verwachtedoorlooptijdteller { get; set; }
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
        public string Nummer { get; set; }
        public string RefProjectnummer { get; set; }
        public string RefFasenummer { get; set; }
        public string Bespokememo { get; set; }
        public int Importtype { get; set; }
        public Guid? Operatorgroupid { get; set; }
        public Guid? Versionid { get; set; }
        public Guid? Milestoneid { get; set; }
        public int Planningfixed { get; set; }
        public bool Skipped { get; set; }
        public bool Resolved { get; set; }
        public DateTime? Skippeddate { get; set; }
        public DateTime? Resolveddate { get; set; }
        public Guid? Skippedreasonid { get; set; }
        public bool Started { get; set; }
        public DateTime? Starteddate { get; set; }
        public long Currentplantimetaken { get; set; }
        public long Estimatetimetaken { get; set; }
        public long Expectedtimetaken { get; set; }
        public long Originalplantimetaken { get; set; }
        public long SumRealizedtime { get; set; }
        public long SumRemainingtime { get; set; }
        public long Timetaken { get; set; }
        public decimal Expenses { get; set; }
        public decimal Currentplanexpenses { get; set; }
        public decimal Estimateexpenses { get; set; }
        public decimal Expectedexpenses { get; set; }
        public decimal Originalplanexpenses { get; set; }
        public decimal Realizedexpenses { get; set; }
        public decimal SumRealizedexpenses { get; set; }
        public decimal SumRemainingexpenses { get; set; }
        public string Comments { get; set; }
        public DateTime? Plannedfinaldate { get; set; }
        public DateTime? Plannedstartdate { get; set; }
        public string Briefdescription { get; set; }
        public string Action { get; set; }
        public string Request { get; set; }
        public string Notes { get; set; }
        public Guid? Categoryid { get; set; }
        public Guid? Subcategoryid { get; set; }
        public bool Monitored { get; set; }
        public Guid? Appointmentid { get; set; }
        public string RefBehandelaar { get; set; }
        public string RefCategorie { get; set; }
        public string RefStatus { get; set; }
        public string RefProgresstrail { get; set; }
        public string Importid { get; set; }
        public DateTime? Importdate { get; set; }

        public Appointment Appointment { get; set; }
        public Archiefreden Archiefreden { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek1Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek2Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek3Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek4Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek5Navigation { get; set; }
        public Actiedoor Behandelaar { get; set; }
        public Classificatie Category { get; set; }
        public Changeversion Milestone { get; set; }
        public Actiedoor Operatorgroup { get; set; }
        public ProfacboomProject Parent { get; set; }
        public ProfacboomProject Projectbeheer { get; set; }
        public ChangeactivitySkippedreason Skippedreason { get; set; }
        public Projectstatus StatusNavigation { get; set; }
        public Classificatie Subcategory { get; set; }
        public Projectaanvraagtype Type { get; set; }
        public Gebruiker UidaanmkNavigation { get; set; }
        public Gebruiker UidwijzigNavigation { get; set; }
        public Changeversion Version { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek1Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek2Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek3Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek4Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek5Navigation { get; set; }
        public ICollection<ProfacboomProject> InverseParent { get; set; }
        public ICollection<ProfacboomProject> InverseProjectbeheer { get; set; }
        public ICollection<MeetingProfacboomProjectLink> MeetingProfacboomProjectLink { get; set; }
        public ICollection<MutatieProfacboomProject> MutatieProfacboomProject { get; set; }
        public ICollection<ProfacboomProjectDocumenten> ProfacboomProjectDocumenten { get; set; }
        public ICollection<ProfacboomProjectEmailberichten> ProfacboomProjectEmailberichten { get; set; }
        public ICollection<ProfacboomProjectIncidentLink> ProfacboomProjectIncidentLink { get; set; }
        public ICollection<ProfacboomProjectLogboek> ProfacboomProjectLogboek { get; set; }
        public ICollection<ProfacboomProjectMemoHistory> ProfacboomProjectMemoHistory { get; set; }
        public ICollection<ProfacboomProjectPersonLink> ProfacboomProjectPersonLink { get; set; }
        public ICollection<ProfacboomProjectProblemLink> ProfacboomProjectProblemLink { get; set; }
        public ICollection<ProfacboomProjectafhankelijkheden> ProfacboomProjectafhankelijkhedenKop { get; set; }
        public ICollection<ProfacboomProjectafhankelijkheden> ProfacboomProjectafhankelijkhedenStaart { get; set; }
        public ICollection<ProfacboomprojectChangeLink> ProfacboomprojectChangeLink { get; set; }
        public ICollection<ProjectdocumentkoppelProject> ProjectdocumentkoppelProject { get; set; }
        public ICollection<TimeRegistrationProfacboomProject> TimeRegistrationProfacboomProject { get; set; }
    }
}
