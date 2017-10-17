using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class ChangeactivitySkippedreason
    {
        public ChangeactivitySkippedreason()
        {
            Changeactivity = new HashSet<Changeactivity>();
            ProfacboomProject = new HashSet<ProfacboomProject>();
        }

        public Guid Unid { get; set; }
        public int Archief { get; set; }
        public int Rang { get; set; }
        public string Bespokememo { get; set; }
        public bool InChangeManagement { get; set; }
        public bool InProjectManagement { get; set; }
        public string Naam { get; set; }

        public ICollection<Changeactivity> Changeactivity { get; set; }
        public ICollection<ProfacboomProject> ProfacboomProject { get; set; }
    }
}
