using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Branchfiltercache
    {
        public Guid Unid { get; set; }
        public Guid Userid { get; set; }
        public Guid Branchid { get; set; }

        public Vestiging Branch { get; set; }
        public Gebruiker User { get; set; }
    }
}
