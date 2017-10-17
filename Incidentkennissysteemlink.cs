using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Incidentkennissysteemlink
    {
        public Guid Unid { get; set; }
        public Guid Incidentid { get; set; }
        public Guid Kennisid { get; set; }
        public int Importtype { get; set; }
        public string Importid { get; set; }
        public DateTime? Importdate { get; set; }

        public Incident Incident { get; set; }
        public KennisSysteem Kennis { get; set; }
    }
}
