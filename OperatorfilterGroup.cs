using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class OperatorfilterGroup
    {
        public Guid Unid { get; set; }
        public Guid Operatorfilterid { get; set; }
        public Guid Groupid { get; set; }

        public Actiedoor Group { get; set; }
        public Operatorfilter Operatorfilter { get; set; }
    }
}
