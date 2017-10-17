using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class ServicelevelServiceLink
    {
        public Guid Unid { get; set; }
        public Guid Serviceid { get; set; }
        public Guid Servicelevelid { get; set; }
        public string Bespokememo { get; set; }
        public decimal Costs { get; set; }
        public int Importtype { get; set; }
        public string Importid { get; set; }
        public DateTime? Importdate { get; set; }

        public Dnodienst Service { get; set; }
        public Servicelevel Servicelevel { get; set; }
    }
}
