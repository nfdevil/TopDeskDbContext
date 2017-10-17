using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class RmSeriesStatus
    {
        public RmSeriesStatus()
        {
            RmSeries = new HashSet<RmSeries>();
        }

        public Guid Unid { get; set; }
        public string Naam { get; set; }
        public int Archief { get; set; }
        public int Rang { get; set; }
        public string Bespokememo { get; set; }

        public ICollection<RmSeries> RmSeries { get; set; }
    }
}
