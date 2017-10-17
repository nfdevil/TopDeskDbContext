using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class PlanningMultidate
    {
        public Guid Unid { get; set; }
        public Guid Planningid { get; set; }
        public DateTime Date { get; set; }

        public Planning Planning { get; set; }
    }
}
