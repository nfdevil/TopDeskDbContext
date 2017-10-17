using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Systemevents
    {
        public Systemevents()
        {
            SystemeventsDocumenten = new HashSet<SystemeventsDocumenten>();
            SystemeventsEmailberichten = new HashSet<SystemeventsEmailberichten>();
            SystemeventsLogboek = new HashSet<SystemeventsLogboek>();
        }

        public string Log { get; set; }
        public int Category { get; set; }
        public DateTime Systemeventdate { get; set; }
        public Guid Unid { get; set; }

        public ICollection<SystemeventsDocumenten> SystemeventsDocumenten { get; set; }
        public ICollection<SystemeventsEmailberichten> SystemeventsEmailberichten { get; set; }
        public ICollection<SystemeventsLogboek> SystemeventsLogboek { get; set; }
    }
}
