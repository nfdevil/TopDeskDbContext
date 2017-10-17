using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Topsissoftware
    {
        public Topsissoftware()
        {
            SoftwareTopsissoftwareLink = new HashSet<SoftwareTopsissoftwareLink>();
        }

        public Guid Unid { get; set; }
        public string Topsisstring { get; set; }
        public int Importtype { get; set; }
        public string Importid { get; set; }
        public DateTime? Importdate { get; set; }

        public ICollection<SoftwareTopsissoftwareLink> SoftwareTopsissoftwareLink { get; set; }
    }
}
