using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class OperatorfilterOperator
    {
        public Guid Unid { get; set; }
        public Guid Operatorfilterid { get; set; }
        public Guid Operatorid { get; set; }

        public Actiedoor Operator { get; set; }
        public Operatorfilter Operatorfilter { get; set; }
    }
}
