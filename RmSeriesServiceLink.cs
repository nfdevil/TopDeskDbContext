using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class RmSeriesServiceLink
    {
        public Guid Unid { get; set; }
        public Guid RmSeriesid { get; set; }
        public Guid Serviceid { get; set; }
        public int Offset { get; set; }
        public int Amount { get; set; }
        public Guid? Objectid { get; set; }
        public Guid? Locationid { get; set; }
        public int BlocktimeDuration { get; set; }
        public Guid? Branchid { get; set; }
        public string Bespokememo { get; set; }
        public string Comments { get; set; }
        public Guid? Operatorid { get; set; }

        public Vestiging Branch { get; set; }
        public Locatie Location { get; set; }
        public Object Object { get; set; }
        public Actiedoor Operator { get; set; }
        public RmSeries RmSeries { get; set; }
        public Voorziening Service { get; set; }
    }
}
