using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Persoonlink
    {
        public Guid Unid { get; set; }
        public Guid Persoongroepid { get; set; }
        public Guid Persoonid { get; set; }
        public int Importtype { get; set; }
        public string Importid { get; set; }
        public DateTime? Importdate { get; set; }

        public Persoon Persoon { get; set; }
        public Persoongroep Persoongroep { get; set; }
    }
}
