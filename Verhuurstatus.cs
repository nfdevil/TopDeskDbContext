using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Verhuurstatus
    {
        public Verhuurstatus()
        {
            MutatieReservering = new HashSet<MutatieReservering>();
            Reservering = new HashSet<Reservering>();
        }

        public int Rang { get; set; }
        public Guid Unid { get; set; }
        public string Naam { get; set; }
        public string Bespokememo { get; set; }
        public int Archief { get; set; }

        public ICollection<MutatieReservering> MutatieReservering { get; set; }
        public ICollection<Reservering> Reservering { get; set; }
    }
}
