using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Changeactivityorderlink
    {
        public Guid Activityid { get; set; }
        public Guid Orderid { get; set; }
        public Guid Unid { get; set; }

        public Changeactivity Activity { get; set; }
        public Bestellingen Order { get; set; }
    }
}
