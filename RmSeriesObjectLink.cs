using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class RmSeriesObjectLink
    {
        public Guid Unid { get; set; }
        public Guid Objectid { get; set; }
        public Guid RmSeriesid { get; set; }
        public int Offset { get; set; }
        public int Duration { get; set; }
        public string Bespokememo { get; set; }

        public Object Object { get; set; }
        public RmSeries RmSeries { get; set; }
    }
}
