using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class ChangePrioritylink
    {
        public Guid Unid { get; set; }
        public Guid Impactid { get; set; }
        public Guid Benefitid { get; set; }
        public Guid Priorityid { get; set; }

        public Changebenefit Benefit { get; set; }
        public WijzigingImpact Impact { get; set; }
        public ChangePriority Priority { get; set; }
    }
}
