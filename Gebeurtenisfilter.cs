using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Gebeurtenisfilter
    {
        public Guid? Gebeurtenisid { get; set; }
        public Guid Unid { get; set; }
        public string Filtercode { get; set; }
        public string Filterwaarde { get; set; }

        public Gebeurtenis Gebeurtenis { get; set; }
    }
}
