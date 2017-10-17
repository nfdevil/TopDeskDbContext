using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class ReportactionOperatorLink
    {
        public Guid Unid { get; set; }
        public Guid Reportactionid { get; set; }
        public Guid Actiedoorid { get; set; }

        public Actiedoor Actiedoor { get; set; }
        public Reportaction Reportaction { get; set; }
    }
}
