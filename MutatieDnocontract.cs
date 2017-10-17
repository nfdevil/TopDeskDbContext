using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class MutatieDnocontract
    {
        public Guid Unid { get; set; }
        public Guid Parentid { get; set; }
        public int MutStatus { get; set; }
        public DateTime Datwijzig { get; set; }
        public Guid? Uidwijzig { get; set; }
        public Guid? MutBehandelaarid { get; set; }
        public Guid? MutBehandelaaridRid { get; set; }
        public bool MutBehandelaaridAct { get; set; }
        public Guid? MutContractstatusid { get; set; }
        public Guid? MutContractstatusidRid { get; set; }
        public bool MutContractstatusidAct { get; set; }
        public int Importtype { get; set; }
        public string Importid { get; set; }
        public DateTime? Importdate { get; set; }

        public Actiedoor MutBehandelaar { get; set; }
        public Mutatiereden MutBehandelaaridR { get; set; }
        public Dnocontractstatus MutContractstatus { get; set; }
        public Mutatiereden MutContractstatusidR { get; set; }
        public Dnocontract Parent { get; set; }
        public Gebruiker UidwijzigNavigation { get; set; }
    }
}
