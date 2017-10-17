using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Changerejectionreason
    {
        public Changerejectionreason()
        {
            Change = new HashSet<Change>();
        }

        public Guid Unid { get; set; }
        public int Archief { get; set; }
        public int Rang { get; set; }
        public string Bespokememo { get; set; }
        public string Naam { get; set; }

        public ICollection<Change> Change { get; set; }
    }
}
