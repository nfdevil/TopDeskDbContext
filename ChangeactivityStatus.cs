using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class ChangeactivityStatus
    {
        public ChangeactivityStatus()
        {
            ChangeActivitytemplate = new HashSet<ChangeActivitytemplate>();
            Changeactivity = new HashSet<Changeactivity>();
            MutatieChangeactivity = new HashSet<MutatieChangeactivity>();
        }

        public Guid Unid { get; set; }
        public int Archief { get; set; }
        public int Rang { get; set; }
        public string Bespokememo { get; set; }
        public int ActivityState { get; set; }
        public int AuthorizationactivityState { get; set; }
        public string Naam { get; set; }

        public ICollection<ChangeActivitytemplate> ChangeActivitytemplate { get; set; }
        public ICollection<Changeactivity> Changeactivity { get; set; }
        public ICollection<MutatieChangeactivity> MutatieChangeactivity { get; set; }
    }
}
