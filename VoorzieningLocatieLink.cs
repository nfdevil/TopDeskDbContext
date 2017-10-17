using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class VoorzieningLocatieLink
    {
        public Guid Unid { get; set; }
        public Guid? Voorzieningid { get; set; }
        public Guid? Locatieid { get; set; }
        public bool Standaard { get; set; }
        public string Bespokememo { get; set; }

        public Locatie Locatie { get; set; }
        public Voorziening Voorziening { get; set; }
    }
}
