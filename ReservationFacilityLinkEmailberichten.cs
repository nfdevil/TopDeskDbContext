using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class ReservationFacilityLinkEmailberichten
    {
        public Guid Unid { get; set; }
        public Guid Kaartid { get; set; }
        public Guid Emailid { get; set; }
        public string Bespokememo { get; set; }

        public Emailbericht Email { get; set; }
        public ReservationFacilityLink Kaart { get; set; }
    }
}
