using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Dnodienstsoort
    {
        public Dnodienstsoort()
        {
            Dnodienst = new HashSet<Dnodienst>();
            MutatieDnodienst = new HashSet<MutatieDnodienst>();
        }

        public int Rang { get; set; }
        public Guid Unid { get; set; }
        public string Naam { get; set; }
        public string Bespokememo { get; set; }
        public int Archief { get; set; }

        public ICollection<Dnodienst> Dnodienst { get; set; }
        public ICollection<MutatieDnodienst> MutatieDnodienst { get; set; }
    }
}
