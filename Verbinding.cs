using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Verbinding
    {
        public Guid? Poort1id { get; set; }
        public Guid? Poort2id { get; set; }
        public Guid Unid { get; set; }

        public Poort Poort1 { get; set; }
        public Poort Poort2 { get; set; }
    }
}
