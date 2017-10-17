using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class IncidentEmailberichten
    {
        public Guid Unid { get; set; }
        public Guid Emailid { get; set; }
        public Guid Kaartid { get; set; }

        public Emailbericht Email { get; set; }
        public Incident Kaart { get; set; }
    }
}
