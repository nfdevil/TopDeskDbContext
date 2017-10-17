using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class OmActiviteitObjectLink
    {
        public Guid Unid { get; set; }
        public Guid OmActiviteitid { get; set; }
        public Guid Objectid { get; set; }

        public Object Object { get; set; }
        public OmActiviteit OmActiviteit { get; set; }
    }
}
