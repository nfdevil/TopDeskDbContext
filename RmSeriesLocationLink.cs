using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class RmSeriesLocationLink
    {
        public Guid Unid { get; set; }
        public Guid Locationid { get; set; }
        public Guid RmSeriesid { get; set; }
        public int Offset { get; set; }
        public int Duration { get; set; }
        public string Bespokememo { get; set; }

        public Locatie Location { get; set; }
        public RmSeries RmSeries { get; set; }
    }
}
