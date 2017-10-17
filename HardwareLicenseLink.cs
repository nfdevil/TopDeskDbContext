using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class HardwareLicenseLink
    {
        public Guid Unid { get; set; }
        public Guid Hardwareid { get; set; }
        public Guid Softwaretopsissoftwarelinkid { get; set; }
        public int Importtype { get; set; }
        public string Importid { get; set; }
        public DateTime? Importdate { get; set; }

        public Hardware Hardware { get; set; }
        public SoftwareTopsissoftwareLink Softwaretopsissoftwarelink { get; set; }
    }
}
