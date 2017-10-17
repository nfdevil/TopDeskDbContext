using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class ReportactionPersonLink
    {
        public Guid Unid { get; set; }
        public Guid Reportactionid { get; set; }
        public Guid Persoonid { get; set; }

        public Persoon Persoon { get; set; }
        public Reportaction Reportaction { get; set; }
    }
}
