using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Wbaanvraagtype
    {
        public Wbaanvraagtype()
        {
            Change = new HashSet<Change>();
            ChangeTemplate = new HashSet<ChangeTemplate>();
            Changeversion = new HashSet<Changeversion>();
        }

        public int Rang { get; set; }
        public Guid Unid { get; set; }
        public string Bespokememo { get; set; }
        public string Naam { get; set; }
        public int Archief { get; set; }

        public ICollection<Change> Change { get; set; }
        public ICollection<ChangeTemplate> ChangeTemplate { get; set; }
        public ICollection<Changeversion> Changeversion { get; set; }
    }
}
