using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class ProfacboomProjectIncidentLink
    {
        public Guid Projectitemid { get; set; }
        public Guid Incidentid { get; set; }
        public Guid Unid { get; set; }

        public Incident Incident { get; set; }
        public ProfacboomProject Projectitem { get; set; }
    }
}
