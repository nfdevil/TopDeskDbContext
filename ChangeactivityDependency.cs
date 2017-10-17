using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class ChangeactivityDependency
    {
        public Guid Headid { get; set; }
        public Guid Tailid { get; set; }
        public Guid Unid { get; set; }

        public Changeactivity Head { get; set; }
        public Changeactivity Tail { get; set; }
    }
}
