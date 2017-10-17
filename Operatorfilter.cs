using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Operatorfilter
    {
        public Operatorfilter()
        {
            OperatorfilterGroup = new HashSet<OperatorfilterGroup>();
            OperatorfilterOperator = new HashSet<OperatorfilterOperator>();
        }

        public Guid Unid { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public bool Shownooperator { get; set; }
        public int Status { get; set; }
        public Guid? Uidaanmk { get; set; }
        public Guid? Uidwijzig { get; set; }
        public DateTime? Dataanmk { get; set; }
        public DateTime? Datwijzig { get; set; }
        public int Userscope { get; set; }
        public bool Allowshowallgroups { get; set; }
        public bool Showowngroups { get; set; }
        public bool Showothergroups { get; set; }
        public bool Showotheroperatorsingroups { get; set; }

        public Gebruiker UidaanmkNavigation { get; set; }
        public Gebruiker UidwijzigNavigation { get; set; }
        public ICollection<OperatorfilterGroup> OperatorfilterGroup { get; set; }
        public ICollection<OperatorfilterOperator> OperatorfilterOperator { get; set; }
    }
}
