using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class ReservationPattern
    {
        public ReservationPattern()
        {
            Reservation = new HashSet<Reservation>();
        }

        public Guid Unid { get; set; }
        public string Period { get; set; }
        public int Interval { get; set; }
        public bool Monday { get; set; }
        public bool Tuesday { get; set; }
        public bool Wednesday { get; set; }
        public bool Thursday { get; set; }
        public bool Friday { get; set; }
        public bool Saturday { get; set; }
        public bool Sunday { get; set; }
        public bool Monthlyusesdaynumber { get; set; }
        public string Bespokememo { get; set; }
        public DateTime? Importdate { get; set; }
        public string Importid { get; set; }
        public int Importtype { get; set; }

        public ICollection<Reservation> Reservation { get; set; }
    }
}
