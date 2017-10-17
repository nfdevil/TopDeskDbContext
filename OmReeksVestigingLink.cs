using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class OmReeksVestigingLink
    {
        public Guid Unid { get; set; }
        public Guid OmReeksid { get; set; }
        public Guid Vestigingid { get; set; }

        public OmReeks OmReeks { get; set; }
        public Vestiging Vestiging { get; set; }
    }
}
