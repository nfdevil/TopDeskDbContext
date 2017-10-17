using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Changeduration
    {
        public Changeduration()
        {
            ChangePrioritySimpleProgressChduration = new HashSet<ChangePriority>();
            ChangePrioritySimpleRequestChduration = new HashSet<ChangePriority>();
        }

        public int Count { get; set; }
        public int Rang { get; set; }
        public Guid Unid { get; set; }
        public bool InChangeManagement { get; set; }
        public bool InProjectManagement { get; set; }
        public string Naam { get; set; }
        public string Bespokememo { get; set; }
        public int Archief { get; set; }
        public int Type { get; set; }

        public ICollection<ChangePriority> ChangePrioritySimpleProgressChduration { get; set; }
        public ICollection<ChangePriority> ChangePrioritySimpleRequestChduration { get; set; }
    }
}
