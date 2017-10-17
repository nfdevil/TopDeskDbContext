using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class MeetingPersonLink
    {
        public Guid Meetingid { get; set; }
        public Guid Personid { get; set; }
        public Guid Unid { get; set; }

        public Meeting Meeting { get; set; }
        public Persoon Person { get; set; }
    }
}
