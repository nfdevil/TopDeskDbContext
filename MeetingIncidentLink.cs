using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class MeetingIncidentLink
    {
        public Guid Incidentid { get; set; }
        public Guid Meetingid { get; set; }
        public Guid Unid { get; set; }

        public Incident Incident { get; set; }
        public Meeting Meeting { get; set; }
    }
}
