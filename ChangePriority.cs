using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class ChangePriority
    {
        public ChangePriority()
        {
            Change = new HashSet<Change>();
            ChangePrioritylink = new HashSet<ChangePrioritylink>();
            ChangeTemplate = new HashSet<ChangeTemplate>();
            Changeversion = new HashSet<Changeversion>();
            MutatieChange = new HashSet<MutatieChange>();
        }

        public Guid Unid { get; set; }
        public int Archief { get; set; }
        public int Rang { get; set; }
        public string Bespokememo { get; set; }
        public string Naam { get; set; }
        public Guid? SimpleRequestChdurationid { get; set; }
        public Guid? SimpleProgressChdurationid { get; set; }

        public Changeduration SimpleProgressChduration { get; set; }
        public Changeduration SimpleRequestChduration { get; set; }
        public ICollection<Change> Change { get; set; }
        public ICollection<ChangePrioritylink> ChangePrioritylink { get; set; }
        public ICollection<ChangeTemplate> ChangeTemplate { get; set; }
        public ICollection<Changeversion> Changeversion { get; set; }
        public ICollection<MutatieChange> MutatieChange { get; set; }
    }
}
