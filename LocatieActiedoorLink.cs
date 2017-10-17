using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class LocatieActiedoorLink
    {
        public Guid Unid { get; set; }
        public Guid Actiedoorid { get; set; }
        public Guid Locatieid { get; set; }

        public Actiedoor Actiedoor { get; set; }
        public Locatie Locatie { get; set; }
    }
}
