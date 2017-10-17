using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Verhuurcategorie
    {
        public Verhuurcategorie()
        {
            MutatieReservering = new HashSet<MutatieReservering>();
            Reservering = new HashSet<Reservering>();
        }

        public int Korting { get; set; }
        public int Rang { get; set; }
        public Guid Unid { get; set; }
        public string Naam { get; set; }
        public string Bespokememo { get; set; }
        public int Archief { get; set; }

        public ICollection<MutatieReservering> MutatieReservering { get; set; }
        public ICollection<Reservering> Reservering { get; set; }
    }
}
