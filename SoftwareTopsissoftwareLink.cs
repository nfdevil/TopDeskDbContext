using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class SoftwareTopsissoftwareLink
    {
        public SoftwareTopsissoftwareLink()
        {
            HardwareLicenseLink = new HashSet<HardwareLicenseLink>();
        }

        public Guid Unid { get; set; }
        public Guid Softwareid { get; set; }
        public Guid Topsissoftwareid { get; set; }
        public int Importtype { get; set; }
        public string Importid { get; set; }
        public DateTime? Importdate { get; set; }

        public Software Software { get; set; }
        public Topsissoftware Topsissoftware { get; set; }
        public ICollection<HardwareLicenseLink> HardwareLicenseLink { get; set; }
    }
}
