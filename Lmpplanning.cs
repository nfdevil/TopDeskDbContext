using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Lmpplanning
    {
        public Guid Unid { get; set; }
        public Guid Patternid { get; set; }
        public Guid Lmplinkid { get; set; }
        public string Importid { get; set; }
        public int Importtype { get; set; }
        public DateTime? Importdate { get; set; }
        public DateTime Year { get; set; }
        public decimal Totalcost { get; set; }

        public Lmplink Lmplink { get; set; }
        public Lmppattern Pattern { get; set; }
    }
}
