using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Recurringevent
    {
        public Recurringevent()
        {
            RecurringeventReportactionLink = new HashSet<RecurringeventReportactionLink>();
        }

        public Guid Unid { get; set; }
        public string Eventname { get; set; }
        public int Interval { get; set; }
        public DateTime Nextrun { get; set; }
        public bool Active { get; set; }
        public DateTime? Dataanmk { get; set; }
        public DateTime? Datwijzig { get; set; }
        public Guid? Uidaanmk { get; set; }
        public Guid? Uidwijzig { get; set; }
        public int Status { get; set; }
        public Guid? Archiefredenid { get; set; }

        public Archiefreden Archiefreden { get; set; }
        public Gebruiker UidaanmkNavigation { get; set; }
        public Gebruiker UidwijzigNavigation { get; set; }
        public ICollection<RecurringeventReportactionLink> RecurringeventReportactionLink { get; set; }
    }
}
