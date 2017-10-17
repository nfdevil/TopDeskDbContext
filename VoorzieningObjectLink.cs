using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class VoorzieningObjectLink
    {
        public Guid Unid { get; set; }
        public Guid? Voorzieningid { get; set; }
        public Guid? Objectid { get; set; }
        public bool Standaard { get; set; }
        public string Bespokememo { get; set; }

        public Object Object { get; set; }
        public Voorziening Voorziening { get; set; }
    }
}
