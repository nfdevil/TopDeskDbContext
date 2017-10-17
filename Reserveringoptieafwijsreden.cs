using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Reserveringoptieafwijsreden
    {
        public Reserveringoptieafwijsreden()
        {
            Reservering = new HashSet<Reservering>();
        }

        public int Rang { get; set; }
        public Guid Unid { get; set; }
        public string Naam { get; set; }
        public string Bespokememo { get; set; }
        public int Archief { get; set; }

        public ICollection<Reservering> Reservering { get; set; }
    }
}
