using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class CategoryfilterOperator
    {
        public Guid Unid { get; set; }
        public Guid Categoryfilterid { get; set; }
        public Guid Operatorid { get; set; }

        public Categoryfilter Categoryfilter { get; set; }
        public Actiedoor Operator { get; set; }
    }
}
