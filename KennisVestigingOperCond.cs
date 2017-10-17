using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class KennisVestigingOperCond
    {
        public Guid Unid { get; set; }
        public Guid Kennisid { get; set; }
        public Guid Vestigingid { get; set; }
        public int Importtype { get; set; }
        public string Importid { get; set; }
        public DateTime? Importdate { get; set; }

        public KennisSysteem Kennis { get; set; }
        public Vestiging Vestiging { get; set; }
    }
}
