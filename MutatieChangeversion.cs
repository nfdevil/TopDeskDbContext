using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class MutatieChangeversion
    {
        public DateTime? Datwijzig { get; set; }
        public DateTime? MutFreezedate { get; set; }
        public bool MutFreezedateAct { get; set; }
        public Guid? MutFreezedateRid { get; set; }
        public Guid? MutOperatorid { get; set; }
        public bool MutOperatoridAct { get; set; }
        public Guid? MutOperatoridRid { get; set; }
        public int MutStatus { get; set; }
        public Guid? MutStatusid { get; set; }
        public bool MutStatusidAct { get; set; }
        public Guid? MutStatusidRid { get; set; }
        public Guid? Parentid { get; set; }
        public Guid? Uidwijzig { get; set; }
        public Guid Unid { get; set; }
        public DateTime? MutPlannedimpldate { get; set; }
        public bool MutPlannedimpldateAct { get; set; }
        public Guid? MutPlannedimpldateRid { get; set; }
        public int Importtype { get; set; }
        public string Importid { get; set; }
        public DateTime? Importdate { get; set; }

        public Mutatiereden MutFreezedateR { get; set; }
        public Actiedoor MutOperator { get; set; }
        public Mutatiereden MutOperatoridR { get; set; }
        public Mutatiereden MutPlannedimpldateR { get; set; }
        public Wijzigingstatus MutStatusNavigation { get; set; }
        public Mutatiereden MutStatusidR { get; set; }
        public Changeversion Parent { get; set; }
        public Gebruiker UidwijzigNavigation { get; set; }
    }
}
