using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class KennissysteemVestigingLink
    {
        public Guid? Kennisitemid { get; set; }
        public Guid? Vestigingid { get; set; }
        public Guid Unid { get; set; }
        public int Importtype { get; set; }
        public string Importid { get; set; }
        public DateTime? Importdate { get; set; }

        public KennisSysteem Kennisitem { get; set; }
        public Vestiging Vestiging { get; set; }
    }
}
