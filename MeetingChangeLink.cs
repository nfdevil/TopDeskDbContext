using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class MeetingChangeLink
    {
        public Guid Changeid { get; set; }
        public Guid Meetingid { get; set; }
        public Guid Unid { get; set; }

        public Change Change { get; set; }
        public Meeting Meeting { get; set; }
    }
}
