using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Werkdag
    {
        public Guid Unid { get; set; }
        public bool Waarde { get; set; }
        public DateTime? Datum { get; set; }
    }
}
