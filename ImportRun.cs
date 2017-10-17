using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class ImportRun
    {
        public ImportRun()
        {
            ImportCouple = new HashSet<ImportCouple>();
            ImportRunInfo = new HashSet<ImportRunInfo>();
        }

        public string Naam { get; set; }
        public string Versie { get; set; }
        public DateTime Begin { get; set; }
        public DateTime? Eind { get; set; }
        public Guid Unid { get; set; }

        public ICollection<ImportCouple> ImportCouple { get; set; }
        public ICollection<ImportRunInfo> ImportRunInfo { get; set; }
    }
}
