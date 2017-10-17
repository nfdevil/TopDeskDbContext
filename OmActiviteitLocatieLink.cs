using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class OmActiviteitLocatieLink
    {
        public Guid Unid { get; set; }
        public Guid OmActiviteitid { get; set; }
        public Guid Locatieid { get; set; }

        public Locatie Locatie { get; set; }
        public OmActiviteit OmActiviteit { get; set; }
    }
}
