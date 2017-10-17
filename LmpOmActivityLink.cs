using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class LmpOmActivityLink
    {
        public Guid Unid { get; set; }
        public Guid Lmpactivityid { get; set; }
        public Guid Omactivityid { get; set; }

        public Lmpactivity Lmpactivity { get; set; }
        public OmActiviteit Omactivity { get; set; }
    }
}
