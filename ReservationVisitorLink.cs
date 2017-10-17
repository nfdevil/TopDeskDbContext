using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class ReservationVisitorLink
    {
        public Guid Unid { get; set; }
        public Guid Reservationid { get; set; }
        public Guid Visitorid { get; set; }
        public string Bespokememo { get; set; }

        public Reservation Reservation { get; set; }
        public Bezoeker Visitor { get; set; }
    }
}
