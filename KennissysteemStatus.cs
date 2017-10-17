using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class KennissysteemStatus
    {
        public KennissysteemStatus()
        {
            KennisSysteem = new HashSet<KennisSysteem>();
        }

        public Guid Unid { get; set; }
        public int Rang { get; set; }
        public string Naam { get; set; }
        public string Bespokememo { get; set; }
        public int Archief { get; set; }

        public ICollection<KennisSysteem> KennisSysteem { get; set; }
    }
}
