using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Oplossingsmethode
    {
        public Oplossingsmethode()
        {
            Incident = new HashSet<Incident>();
            Oplossingen = new HashSet<Oplossingen>();
        }

        public int Rang { get; set; }
        public Guid Unid { get; set; }
        public string Bespokememo { get; set; }
        public string Naam { get; set; }
        public int Archief { get; set; }

        public ICollection<Incident> Incident { get; set; }
        public ICollection<Oplossingen> Oplossingen { get; set; }
    }
}
