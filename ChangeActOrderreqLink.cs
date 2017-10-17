using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class ChangeActOrderreqLink
    {
        public Guid Activityid { get; set; }
        public Guid Orderrequestid { get; set; }
        public Guid Unid { get; set; }

        public Changeactivity Activity { get; set; }
        public Bestelaanvraag Orderrequest { get; set; }
    }
}
