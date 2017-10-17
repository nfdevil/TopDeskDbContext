using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class VoorzieningVestigingLink
    {
        public Guid Voorzieningid { get; set; }
        public Guid Vestigingid { get; set; }
        public Guid Unid { get; set; }

        public Vestiging Vestiging { get; set; }
        public Voorziening Voorziening { get; set; }
    }
}
