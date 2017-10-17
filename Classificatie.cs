using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Classificatie
    {
        public Classificatie()
        {
            CategoryfilterCategory = new HashSet<CategoryfilterCategory>();
            Categoryfiltercache = new HashSet<Categoryfiltercache>();
            ChangeActivitytemplateCategory = new HashSet<ChangeActivitytemplate>();
            ChangeActivitytemplateSubcategory = new HashSet<ChangeActivitytemplate>();
            ChangeCategory = new HashSet<Change>();
            ChangeSubcategory = new HashSet<Change>();
            ChangeTemplateCategory = new HashSet<ChangeTemplate>();
            ChangeTemplateSubcategory = new HashSet<ChangeTemplate>();
            ChangeactivityCategory = new HashSet<Changeactivity>();
            ChangeactivitySubcategory = new HashSet<Changeactivity>();
            ClassificatieTranslation = new HashSet<ClassificatieTranslation>();
            DnocontractCategorie = new HashSet<Dnocontract>();
            DnocontractSubcategorie = new HashSet<Dnocontract>();
            DnodienstDomein = new HashSet<Dnodienst>();
            DnodienstSpecificatie = new HashSet<Dnodienst>();
            DnolinkRefDomein = new HashSet<Dnolink>();
            DnolinkRefSpecificatie = new HashSet<Dnolink>();
            IncidentIncidentDomein = new HashSet<Incident>();
            IncidentIncidentSpec = new HashSet<Incident>();
            InverseParent = new HashSet<Classificatie>();
            MailimportChangeCategory = new HashSet<MailimportChange>();
            MailimportChangeSubcategory = new HashSet<MailimportChange>();
            MailimportIncidentCategory = new HashSet<MailimportIncident>();
            MailimportIncidentSubcategory = new HashSet<MailimportIncident>();
            MutatieDnodienstMutDomein = new HashSet<MutatieDnodienst>();
            MutatieDnodienstMutSpecificatie = new HashSet<MutatieDnodienst>();
            OmActiviteitCategorie = new HashSet<OmActiviteit>();
            OmActiviteitSubcategorie = new HashSet<OmActiviteit>();
            OmReeksStandaardcategorie = new HashSet<OmReeks>();
            OmReeksStandaardsubcategorie = new HashSet<OmReeks>();
            OplossingenCategory = new HashSet<Oplossingen>();
            OplossingenSubcategory = new HashSet<Oplossingen>();
            ProbleemDomein = new HashSet<Probleem>();
            ProbleemDomeinprobleem = new HashSet<Probleem>();
            ProbleemSpecificatie = new HashSet<Probleem>();
            ProbleemSpecificatieprobleem = new HashSet<Probleem>();
            ProfacboomProjectCategory = new HashSet<ProfacboomProject>();
            ProfacboomProjectSubcategory = new HashSet<ProfacboomProject>();
        }

        public string Aantekeningen { get; set; }
        public bool Incidentbeheer { get; set; }
        public Guid? Lijn1actiedoorid { get; set; }
        public Guid? Lijn2actiedoorid { get; set; }
        public string Naam { get; set; }
        public Guid? Parentid { get; set; }
        public bool Probleembeheer { get; set; }
        public int Rang { get; set; }
        public int Status { get; set; }
        public string Steekwoorden { get; set; }
        public Guid? Uidaanmk { get; set; }
        public Guid? Uidwijzig { get; set; }
        public Guid Unid { get; set; }
        public DateTime? Dataanmk { get; set; }
        public DateTime? Datwijzig { get; set; }
        public bool Operationeelbeheer { get; set; }
        public bool Dnocontract { get; set; }
        public string Importid { get; set; }
        public bool Changemanagement { get; set; }
        public Guid? Changecoordinator { get; set; }
        public Guid? Simplechange { get; set; }
        public Guid? Changeactivity { get; set; }
        public Guid? Changeauthactivity { get; set; }
        public string Bespokememo { get; set; }
        public int Importtype { get; set; }
        public DateTime? Importdate { get; set; }
        public bool Projectmanagement { get; set; }
        public Guid? Projectcoordinatorid { get; set; }
        public Guid? Projectoperatorid { get; set; }
        public Guid? Firstlinesupplier { get; set; }
        public Guid? Secondlinesupplier { get; set; }

        public Actiedoor ChangeactivityNavigation { get; set; }
        public Actiedoor ChangeauthactivityNavigation { get; set; }
        public Actiedoor ChangecoordinatorNavigation { get; set; }
        public Leverancier FirstlinesupplierNavigation { get; set; }
        public Actiedoor Lijn1actiedoor { get; set; }
        public Actiedoor Lijn2actiedoor { get; set; }
        public Classificatie Parent { get; set; }
        public Actiedoor Projectcoordinator { get; set; }
        public Actiedoor Projectoperator { get; set; }
        public Leverancier SecondlinesupplierNavigation { get; set; }
        public Actiedoor SimplechangeNavigation { get; set; }
        public Gebruiker UidaanmkNavigation { get; set; }
        public Gebruiker UidwijzigNavigation { get; set; }
        public ICollection<CategoryfilterCategory> CategoryfilterCategory { get; set; }
        public ICollection<Categoryfiltercache> Categoryfiltercache { get; set; }
        public ICollection<ChangeActivitytemplate> ChangeActivitytemplateCategory { get; set; }
        public ICollection<ChangeActivitytemplate> ChangeActivitytemplateSubcategory { get; set; }
        public ICollection<Change> ChangeCategory { get; set; }
        public ICollection<Change> ChangeSubcategory { get; set; }
        public ICollection<ChangeTemplate> ChangeTemplateCategory { get; set; }
        public ICollection<ChangeTemplate> ChangeTemplateSubcategory { get; set; }
        public ICollection<Changeactivity> ChangeactivityCategory { get; set; }
        public ICollection<Changeactivity> ChangeactivitySubcategory { get; set; }
        public ICollection<ClassificatieTranslation> ClassificatieTranslation { get; set; }
        public ICollection<Dnocontract> DnocontractCategorie { get; set; }
        public ICollection<Dnocontract> DnocontractSubcategorie { get; set; }
        public ICollection<Dnodienst> DnodienstDomein { get; set; }
        public ICollection<Dnodienst> DnodienstSpecificatie { get; set; }
        public ICollection<Dnolink> DnolinkRefDomein { get; set; }
        public ICollection<Dnolink> DnolinkRefSpecificatie { get; set; }
        public ICollection<Incident> IncidentIncidentDomein { get; set; }
        public ICollection<Incident> IncidentIncidentSpec { get; set; }
        public ICollection<Classificatie> InverseParent { get; set; }
        public ICollection<MailimportChange> MailimportChangeCategory { get; set; }
        public ICollection<MailimportChange> MailimportChangeSubcategory { get; set; }
        public ICollection<MailimportIncident> MailimportIncidentCategory { get; set; }
        public ICollection<MailimportIncident> MailimportIncidentSubcategory { get; set; }
        public ICollection<MutatieDnodienst> MutatieDnodienstMutDomein { get; set; }
        public ICollection<MutatieDnodienst> MutatieDnodienstMutSpecificatie { get; set; }
        public ICollection<OmActiviteit> OmActiviteitCategorie { get; set; }
        public ICollection<OmActiviteit> OmActiviteitSubcategorie { get; set; }
        public ICollection<OmReeks> OmReeksStandaardcategorie { get; set; }
        public ICollection<OmReeks> OmReeksStandaardsubcategorie { get; set; }
        public ICollection<Oplossingen> OplossingenCategory { get; set; }
        public ICollection<Oplossingen> OplossingenSubcategory { get; set; }
        public ICollection<Probleem> ProbleemDomein { get; set; }
        public ICollection<Probleem> ProbleemDomeinprobleem { get; set; }
        public ICollection<Probleem> ProbleemSpecificatie { get; set; }
        public ICollection<Probleem> ProbleemSpecificatieprobleem { get; set; }
        public ICollection<ProfacboomProject> ProfacboomProjectCategory { get; set; }
        public ICollection<ProfacboomProject> ProfacboomProjectSubcategory { get; set; }
    }
}
