using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class ChangeactivityRejectionreason
    {
        public ChangeactivityRejectionreason()
        {
            Changeactivity = new HashSet<Changeactivity>();
            MutatieChangeactivity = new HashSet<MutatieChangeactivity>();
        }

        public Guid Unid { get; set; }
        public int Archief { get; set; }
        public int Rang { get; set; }
        public string Bespokememo { get; set; }
        public string Naam { get; set; }

        public ICollection<Changeactivity> Changeactivity { get; set; }
        public ICollection<MutatieChangeactivity> MutatieChangeactivity { get; set; }
    }
}
