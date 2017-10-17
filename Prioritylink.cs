using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Prioritylink
    {
        public Guid Unid { get; set; }
        public Guid Impactid { get; set; }
        public Guid Urgencyid { get; set; }
        public Guid Priorityid { get; set; }

        public Impact Impact { get; set; }
        public Priority Priority { get; set; }
        public Urgency Urgency { get; set; }
    }
}
