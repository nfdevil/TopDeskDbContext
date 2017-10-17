using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class ProbleemKennissysteem
    {
        public Guid Unid { get; set; }
        public Guid Probleemid { get; set; }
        public Guid Kennisid { get; set; }

        public KennisSysteem Kennis { get; set; }
        public Probleem Probleem { get; set; }
    }
}
