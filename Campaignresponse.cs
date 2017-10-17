using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Campaignresponse
    {
        public Guid Unid { get; set; }
        public string Openanswer { get; set; }
        public Guid Campaignmailinginvitationid { get; set; }
        public Guid? Surveyquestionid { get; set; }
        public Guid? Surveyanswerid { get; set; }

        public Campaignmailinginvitation Campaignmailinginvitation { get; set; }
        public Surveyanswer Surveyanswer { get; set; }
        public Surveyquestion Surveyquestion { get; set; }
    }
}
