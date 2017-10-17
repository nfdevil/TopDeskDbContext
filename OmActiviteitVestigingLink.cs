using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class OmActiviteitVestigingLink
    {
        public Guid Unid { get; set; }
        public Guid OmActiviteitid { get; set; }
        public Guid Vestigingid { get; set; }

        public OmActiviteit OmActiviteit { get; set; }
        public Vestiging Vestiging { get; set; }
    }
}
