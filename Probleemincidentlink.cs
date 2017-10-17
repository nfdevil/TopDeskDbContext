using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Probleemincidentlink
    {
        public Guid Unid { get; set; }
        public Guid Incidentid { get; set; }
        public Guid Probleemid { get; set; }

        public Incident Incident { get; set; }
        public Probleem Probleem { get; set; }
    }
}
