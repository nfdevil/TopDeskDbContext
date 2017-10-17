using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class ReservationPersonLink
    {
        public Guid Unid { get; set; }
        public Guid Reservationid { get; set; }
        public Guid Personid { get; set; }
        public string Bespokememo { get; set; }

        public Persoon Person { get; set; }
        public Reservation Reservation { get; set; }
    }
}
