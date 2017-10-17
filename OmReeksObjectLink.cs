using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class OmReeksObjectLink
    {
        public Guid Unid { get; set; }
        public Guid OmReeksid { get; set; }
        public Guid Objectid { get; set; }

        public Object Object { get; set; }
        public OmReeks OmReeks { get; set; }
    }
}
