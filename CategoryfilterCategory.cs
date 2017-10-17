using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class CategoryfilterCategory
    {
        public Guid Unid { get; set; }
        public Guid Categoryfilterid { get; set; }
        public Guid Categoryid { get; set; }

        public Classificatie Category { get; set; }
        public Categoryfilter Categoryfilter { get; set; }
    }
}
