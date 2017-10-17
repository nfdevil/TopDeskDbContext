using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class OmActiviteitIncidentLink
    {
        public Guid Unid { get; set; }
        public Guid OmActiviteitid { get; set; }
        public Guid Incidentid { get; set; }

        public Incident Incident { get; set; }
        public OmActiviteit OmActiviteit { get; set; }
    }
}
