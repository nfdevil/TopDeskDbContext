using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class ReservationSeries
    {
        public ReservationSeries()
        {
            Reservation = new HashSet<Reservation>();
        }

        public Guid Unid { get; set; }
        public DateTime Startdate { get; set; }
        public DateTime? Enddate { get; set; }
        public int Importtype { get; set; }
        public string Importid { get; set; }
        public DateTime? Importdate { get; set; }

        public ICollection<Reservation> Reservation { get; set; }
    }
}
