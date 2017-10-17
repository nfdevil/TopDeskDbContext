using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Escalatiereden
    {
        public Escalatiereden()
        {
            IncidentDeescalatiereden = new HashSet<Incident>();
            IncidentEscalatiereden = new HashSet<Incident>();
        }

        public int Lijn { get; set; }
        public int Rang { get; set; }
        public Guid Unid { get; set; }
        public string Bespokememo { get; set; }
        public string Naam { get; set; }
        public int Archief { get; set; }

        public ICollection<Incident> IncidentDeescalatiereden { get; set; }
        public ICollection<Incident> IncidentEscalatiereden { get; set; }
    }
}
