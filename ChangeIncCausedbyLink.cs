using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class ChangeIncCausedbyLink
    {
        public Guid Changeid { get; set; }
        public Guid Incidentid { get; set; }
        public Guid Unid { get; set; }

        public Change Change { get; set; }
        public Incident Incident { get; set; }
    }
}
