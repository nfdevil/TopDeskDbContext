using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class DnocontractVestigingLink
    {
        public Guid Unid { get; set; }
        public Guid Vestigingid { get; set; }
        public Guid Dnocontractid { get; set; }
        public string Bespokememo { get; set; }
        public int Importtype { get; set; }
        public string Importid { get; set; }
        public DateTime? Importdate { get; set; }

        public Dnocontract Dnocontract { get; set; }
        public Vestiging Vestiging { get; set; }
    }
}
