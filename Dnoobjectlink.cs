using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Dnoobjectlink
    {
        public Guid Unid { get; set; }
        public Guid Objectid { get; set; }
        public Guid Dnodienstid { get; set; }
        public bool IsStandard { get; set; }
        public int Importtype { get; set; }
        public string Importid { get; set; }
        public DateTime? Importdate { get; set; }

        public Dnodienst Dnodienst { get; set; }
        public Object Object { get; set; }
    }
}
