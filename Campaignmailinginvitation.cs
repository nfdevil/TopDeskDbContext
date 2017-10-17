using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Campaignmailinginvitation
    {
        public Campaignmailinginvitation()
        {
            Campaignresponse = new HashSet<Campaignresponse>();
        }

        public Guid Unid { get; set; }
        public Guid Campaignmailingid { get; set; }
        public Guid? Persoonid { get; set; }
        public Guid? Incidentid { get; set; }
        public string Invitationhash { get; set; }
        public int Status { get; set; }
        public DateTime? Invitationdate { get; set; }

        public Campaignmailing Campaignmailing { get; set; }
        public Incident Incident { get; set; }
        public Persoon Persoon { get; set; }
        public ICollection<Campaignresponse> Campaignresponse { get; set; }
    }
}
