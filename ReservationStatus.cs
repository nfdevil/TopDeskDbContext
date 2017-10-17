using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class ReservationStatus
    {
        public ReservationStatus()
        {
            Reservation = new HashSet<Reservation>();
            ReservationEvent = new HashSet<ReservationEvent>();
        }

        public Guid Unid { get; set; }
        public string Naam { get; set; }
        public int Archief { get; set; }
        public int Rang { get; set; }
        public string Bespokememo { get; set; }

        public ICollection<Reservation> Reservation { get; set; }
        public ICollection<ReservationEvent> ReservationEvent { get; set; }
    }
}
