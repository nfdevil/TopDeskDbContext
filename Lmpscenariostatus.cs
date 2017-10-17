using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Lmpscenariostatus
    {
        public Lmpscenariostatus()
        {
            Lmpscenario = new HashSet<Lmpscenario>();
        }

        public Guid Unid { get; set; }
        public int Rang { get; set; }
        public int Archief { get; set; }
        public string Naam { get; set; }
        public string Bespokememo { get; set; }

        public ICollection<Lmpscenario> Lmpscenario { get; set; }
    }
}
