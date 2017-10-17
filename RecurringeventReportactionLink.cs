using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class RecurringeventReportactionLink
    {
        public Guid Unid { get; set; }
        public Guid Recurringeventid { get; set; }
        public Guid Reportactionid { get; set; }

        public Recurringevent Recurringevent { get; set; }
        public Reportaction Reportaction { get; set; }
    }
}
