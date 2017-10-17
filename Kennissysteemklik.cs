using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Kennissysteemklik
    {
        public Guid? Kennisid { get; set; }
        public Guid Unid { get; set; }
        public DateTime? Tijdstip { get; set; }
        public bool Ispublic { get; set; }

        public KennisSysteem Kennis { get; set; }
    }
}
