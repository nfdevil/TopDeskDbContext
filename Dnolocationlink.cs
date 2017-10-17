using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Dnolocationlink
    {
        public Guid Unid { get; set; }
        public Guid Serviceid { get; set; }
        public Guid Locationid { get; set; }
        public string Bespokememo { get; set; }
        public bool IsStandard { get; set; }
        public int Importtype { get; set; }
        public string Importid { get; set; }
        public DateTime? Importdate { get; set; }

        public Locatie Location { get; set; }
        public Dnodienst Service { get; set; }
    }
}
