using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Topsisiprange
    {
        public Guid Unid { get; set; }
        public string Beginaddress { get; set; }
        public string Endaddress { get; set; }
        public string Description { get; set; }
        public Guid? Hardwareid { get; set; }

        public Hardware Hardware { get; set; }
    }
}
