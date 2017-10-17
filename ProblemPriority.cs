using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class ProblemPriority
    {
        public ProblemPriority()
        {
            MutatieProbleem = new HashSet<MutatieProbleem>();
            Probleem = new HashSet<Probleem>();
        }

        public Guid Unid { get; set; }
        public int Archief { get; set; }
        public int Rang { get; set; }
        public string Bespokememo { get; set; }
        public string Naam { get; set; }

        public ICollection<MutatieProbleem> MutatieProbleem { get; set; }
        public ICollection<Probleem> Probleem { get; set; }
    }
}
