using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Categoryfilter
    {
        public Categoryfilter()
        {
            CategoryfilterCategory = new HashSet<CategoryfilterCategory>();
            CategoryfilterOperator = new HashSet<CategoryfilterOperator>();
        }

        public Guid Unid { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public bool Shownocategory { get; set; }
        public int Status { get; set; }
        public Guid? Uidaanmk { get; set; }
        public Guid? Uidwijzig { get; set; }
        public DateTime? Dataanmk { get; set; }
        public DateTime? Datwijzig { get; set; }
        public int Userscope { get; set; }

        public Gebruiker UidaanmkNavigation { get; set; }
        public Gebruiker UidwijzigNavigation { get; set; }
        public ICollection<CategoryfilterCategory> CategoryfilterCategory { get; set; }
        public ICollection<CategoryfilterOperator> CategoryfilterOperator { get; set; }
    }
}
