using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class MeetingVersionLink
    {
        public Guid Versionid { get; set; }
        public Guid Meetingid { get; set; }
        public Guid Unid { get; set; }

        public Meeting Meeting { get; set; }
        public Changeversion Version { get; set; }
    }
}
