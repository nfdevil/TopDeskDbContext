using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class MeetingProfacboomProjectLink
    {
        public Guid Projectid { get; set; }
        public Guid Meetingid { get; set; }
        public Guid Unid { get; set; }

        public Meeting Meeting { get; set; }
        public ProfacboomProject Project { get; set; }
    }
}
