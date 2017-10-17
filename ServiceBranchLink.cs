using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class ServiceBranchLink
    {
        public Guid Unid { get; set; }
        public Guid Serviceid { get; set; }
        public Guid Branchid { get; set; }
        public string Bespokememo { get; set; }
        public DateTime? Importdate { get; set; }
        public string Importid { get; set; }
        public int Importtype { get; set; }

        public Vestiging Branch { get; set; }
        public Dnodienst Service { get; set; }
    }
}
