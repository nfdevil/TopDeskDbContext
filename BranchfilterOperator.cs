using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class BranchfilterOperator
    {
        public Guid Unid { get; set; }
        public Guid Branchfilterid { get; set; }
        public Guid Operatorid { get; set; }

        public Branchfilter Branchfilter { get; set; }
        public Actiedoor Operator { get; set; }
    }
}
