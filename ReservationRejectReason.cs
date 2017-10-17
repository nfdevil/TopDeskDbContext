using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class ReservationRejectReason
    {
        public ReservationRejectReason()
        {
            Reservation = new HashSet<Reservation>();
        }

        public Guid Unid { get; set; }
        public string Naam { get; set; }
        public int Archief { get; set; }
        public int Rang { get; set; }
        public string Bespokememo { get; set; }

        public ICollection<Reservation> Reservation { get; set; }
    }
}
