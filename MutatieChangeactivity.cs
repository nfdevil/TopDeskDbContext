using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class MutatieChangeactivity
    {
        public long Bestedetijd { get; set; }
        public DateTime? Datwijzig { get; set; }
        public DateTime? MutApproveddate { get; set; }
        public bool MutApproveddateAct { get; set; }
        public Guid? MutApproveddateRid { get; set; }
        public Guid? MutDecidedbypersonid { get; set; }
        public bool MutDecidedbypersonidAct { get; set; }
        public Guid? MutDecidedbypersonidRid { get; set; }
        public Guid? MutMilestoneid { get; set; }
        public bool MutMilestoneidAct { get; set; }
        public Guid? MutMilestoneidRid { get; set; }
        public Guid? MutOperatorgroupid { get; set; }
        public bool MutOperatorgroupidAct { get; set; }
        public Guid? MutOperatorgroupidRid { get; set; }
        public Guid? MutOperatorid { get; set; }
        public bool MutOperatoridAct { get; set; }
        public Guid? MutOperatoridRid { get; set; }
        public DateTime? MutRejecteddate { get; set; }
        public bool MutRejecteddateAct { get; set; }
        public Guid? MutRejecteddateRid { get; set; }
        public Guid? MutRejectionreasonid { get; set; }
        public bool MutRejectionreasonidAct { get; set; }
        public Guid? MutRejectionreasonidRid { get; set; }
        public DateTime? MutResolveddate { get; set; }
        public bool MutResolveddateAct { get; set; }
        public Guid? MutResolveddateRid { get; set; }
        public DateTime? MutSkippeddate { get; set; }
        public bool MutSkippeddateAct { get; set; }
        public Guid? MutSkippeddateRid { get; set; }
        public int MutStatus { get; set; }
        public Guid? Parentid { get; set; }
        public Guid Unid { get; set; }
        public Guid? MutActivitystatusid { get; set; }
        public bool MutActivitystatusidAct { get; set; }
        public Guid? MutActivitystatusidRid { get; set; }
        public Guid? Uidwijzig { get; set; }
        public int Importtype { get; set; }
        public string Importid { get; set; }
        public DateTime? Importdate { get; set; }

        public ChangeactivityStatus MutActivitystatus { get; set; }
        public Mutatiereden MutActivitystatusidR { get; set; }
        public Mutatiereden MutApproveddateR { get; set; }
        public Persoon MutDecidedbyperson { get; set; }
        public Mutatiereden MutDecidedbypersonidR { get; set; }
        public Changeversion MutMilestone { get; set; }
        public Mutatiereden MutMilestoneidR { get; set; }
        public Actiedoor MutOperator { get; set; }
        public Actiedoor MutOperatorgroup { get; set; }
        public Mutatiereden MutOperatorgroupidR { get; set; }
        public Mutatiereden MutOperatoridR { get; set; }
        public Mutatiereden MutRejecteddateR { get; set; }
        public ChangeactivityRejectionreason MutRejectionreason { get; set; }
        public Mutatiereden MutRejectionreasonidR { get; set; }
        public Mutatiereden MutResolveddateR { get; set; }
        public Mutatiereden MutSkippeddateR { get; set; }
        public Changeactivity Parent { get; set; }
        public Gebruiker UidwijzigNavigation { get; set; }
    }
}
