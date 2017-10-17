using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class ProbleemStatus
    {
        public ProbleemStatus()
        {
            MutatieProbleemMutStatusNavigation = new HashSet<MutatieProbleem>();
            MutatieProbleemMutStatusbf = new HashSet<MutatieProbleem>();
            ProbleemStatusNavigation = new HashSet<Probleem>();
            ProbleemStatusbf = new HashSet<Probleem>();
        }

        public int Rang { get; set; }
        public Guid Unid { get; set; }
        public string Naam { get; set; }
        public string Bespokememo { get; set; }
        public int Archief { get; set; }

        public ICollection<MutatieProbleem> MutatieProbleemMutStatusNavigation { get; set; }
        public ICollection<MutatieProbleem> MutatieProbleemMutStatusbf { get; set; }
        public ICollection<Probleem> ProbleemStatusNavigation { get; set; }
        public ICollection<Probleem> ProbleemStatusbf { get; set; }
    }
}
