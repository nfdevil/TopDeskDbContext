using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class ProbleemImpact
    {
        public ProbleemImpact()
        {
            ProbleemImpactNavigation = new HashSet<Probleem>();
            ProbleemImpactbf = new HashSet<Probleem>();
        }

        public int Rang { get; set; }
        public Guid Unid { get; set; }
        public string Naam { get; set; }
        public string Bespokememo { get; set; }
        public int Archief { get; set; }

        public ICollection<Probleem> ProbleemImpactNavigation { get; set; }
        public ICollection<Probleem> ProbleemImpactbf { get; set; }
    }
}
