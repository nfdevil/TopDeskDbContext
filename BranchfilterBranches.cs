using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class BranchfilterBranches
    {
        public Guid Unid { get; set; }
        public Guid Branchfilterid { get; set; }
        public Guid Branchid { get; set; }

        public Vestiging Branch { get; set; }
        public Branchfilter Branchfilter { get; set; }
    }
}
