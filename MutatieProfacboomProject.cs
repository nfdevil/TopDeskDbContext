using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class MutatieProfacboomProject
    {
        public int Bestedetijd { get; set; }
        public Guid? MutBehandelaarid { get; set; }
        public int MutStatus { get; set; }
        public Guid? MutStatusid { get; set; }
        public Guid? Parentid { get; set; }
        public Guid? Uidwijzig { get; set; }
        public Guid Unid { get; set; }
        public DateTime? Datwijzig { get; set; }
        public bool MutBehandelaaridAct { get; set; }
        public Guid? MutBehandelaaridRid { get; set; }
        public bool MutStatusidAct { get; set; }
        public Guid? MutStatusidRid { get; set; }
        public int Importtype { get; set; }
        public string Importid { get; set; }
        public DateTime? Importdate { get; set; }
        public Guid? MutOperatorgroupid { get; set; }
        public bool MutOperatorgroupidAct { get; set; }
        public Guid? MutOperatorgroupidRid { get; set; }
        public decimal MutCurrentplanexpenses { get; set; }
        public bool MutCurrentplanexpensesAct { get; set; }
        public Guid? MutCurrentplanexpensesRid { get; set; }
        public long MutCurrentplantimetaken { get; set; }
        public bool MutCurrentplantimetakenAct { get; set; }
        public Guid? MutCurrentplantimetakenRid { get; set; }
        public decimal MutEstimateexpenses { get; set; }
        public bool MutEstimateexpensesAct { get; set; }
        public Guid? MutEstimateexpensesRid { get; set; }
        public long MutEstimatetimetaken { get; set; }
        public bool MutEstimatetimetakenAct { get; set; }
        public Guid? MutEstimatetimetakenRid { get; set; }
        public Guid? MutMilestoneid { get; set; }
        public bool MutMilestoneidAct { get; set; }
        public Guid? MutMilestoneidRid { get; set; }
        public long MutOriginalplantimetaken { get; set; }
        public bool MutOriginalplantimetakenAct { get; set; }
        public Guid? MutOriginalplantimetakenRid { get; set; }
        public decimal MutOriginalplanexpenses { get; set; }
        public bool MutOriginalplanexpensesAct { get; set; }
        public Guid? MutOriginalplanexpensesRid { get; set; }
        public DateTime? MutPlannedfinaldate { get; set; }
        public bool MutPlannedfinaldateAct { get; set; }
        public Guid? MutPlannedfinaldateRid { get; set; }
        public DateTime? MutResolveddate { get; set; }
        public bool MutResolveddateAct { get; set; }
        public Guid? MutResolveddateRid { get; set; }
        public DateTime? MutSkippeddate { get; set; }
        public bool MutSkippeddateAct { get; set; }
        public Guid? MutSkippeddateRid { get; set; }
        public DateTime? MutStarteddate { get; set; }
        public bool MutStarteddateAct { get; set; }
        public Guid? MutStarteddateRid { get; set; }
        public Guid? MutVersionid { get; set; }
        public bool MutVersionidAct { get; set; }
        public Guid? MutVersionidRid { get; set; }
        public DateTime? MutPlannedstartdate { get; set; }
        public bool MutPlannedstartdateAct { get; set; }
        public Guid? MutPlannedstartdateRid { get; set; }

        public Actiedoor MutBehandelaar { get; set; }
        public Mutatiereden MutBehandelaaridR { get; set; }
        public Mutatiereden MutCurrentplanexpensesR { get; set; }
        public Mutatiereden MutCurrentplantimetakenR { get; set; }
        public Mutatiereden MutEstimateexpensesR { get; set; }
        public Mutatiereden MutEstimatetimetakenR { get; set; }
        public Changeversion MutMilestone { get; set; }
        public Mutatiereden MutMilestoneidR { get; set; }
        public Actiedoor MutOperatorgroup { get; set; }
        public Mutatiereden MutOperatorgroupidR { get; set; }
        public Mutatiereden MutOriginalplanexpensesR { get; set; }
        public Mutatiereden MutOriginalplantimetakenR { get; set; }
        public Mutatiereden MutPlannedfinaldateR { get; set; }
        public Mutatiereden MutPlannedstartdateR { get; set; }
        public Mutatiereden MutResolveddateR { get; set; }
        public Mutatiereden MutSkippeddateR { get; set; }
        public Mutatiereden MutStarteddateR { get; set; }
        public Projectstatus MutStatusNavigation { get; set; }
        public Mutatiereden MutStatusidR { get; set; }
        public Changeversion MutVersion { get; set; }
        public Mutatiereden MutVersionidR { get; set; }
        public ProfacboomProject Parent { get; set; }
        public Gebruiker UidwijzigNavigation { get; set; }
    }
}
