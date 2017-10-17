using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class OmReeksLocatieLink
    {
        public Guid Unid { get; set; }
        public Guid OmReeksid { get; set; }
        public Guid Locatieid { get; set; }

        public Locatie Locatie { get; set; }
        public OmReeks OmReeks { get; set; }
    }
}
