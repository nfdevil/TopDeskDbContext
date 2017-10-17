using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Branchfilter
    {
        public Branchfilter()
        {
            BranchfilterBranches = new HashSet<BranchfilterBranches>();
            BranchfilterOperator = new HashSet<BranchfilterOperator>();
        }

        public Guid Unid { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public bool Allowescalate { get; set; }
        public int Branchtype { get; set; }
        public bool Head2sub { get; set; }
        public bool Sub2sub { get; set; }
        public bool Sub2head { get; set; }
        public int Status { get; set; }
        public Guid? Uidaanmk { get; set; }
        public Guid? Uidwijzig { get; set; }
        public DateTime? Dataanmk { get; set; }
        public DateTime? Datwijzig { get; set; }
        public int Userscope { get; set; }
        public bool Shownobranch { get; set; }

        public Gebruiker UidaanmkNavigation { get; set; }
        public Gebruiker UidwijzigNavigation { get; set; }
        public ICollection<BranchfilterBranches> BranchfilterBranches { get; set; }
        public ICollection<BranchfilterOperator> BranchfilterOperator { get; set; }
    }
}
