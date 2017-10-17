using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class MeetingChangeactivityLink
    {
        public Guid Changeactivityid { get; set; }
        public Guid Meetingid { get; set; }
        public Guid Unid { get; set; }

        public Changeactivity Changeactivity { get; set; }
        public Meeting Meeting { get; set; }
    }
}
