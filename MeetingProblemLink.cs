using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class MeetingProblemLink
    {
        public Guid Meetingid { get; set; }
        public Guid Problemid { get; set; }
        public Guid Unid { get; set; }

        public Meeting Meeting { get; set; }
        public Probleem Problem { get; set; }
    }
}
