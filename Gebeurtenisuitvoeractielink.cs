using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Gebeurtenisuitvoeractielink
    {
        public Guid Unid { get; set; }
        public Guid Actieid { get; set; }
        public Guid Gebeurtenisid { get; set; }

        public Uitvoeractie Actie { get; set; }
        public Gebeurtenis Gebeurtenis { get; set; }
    }
}
