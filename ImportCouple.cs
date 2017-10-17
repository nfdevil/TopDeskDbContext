using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class ImportCouple
    {
        public ImportCouple()
        {
            ImportCoupleResult = new HashSet<ImportCoupleResult>();
            ImportRecordResult = new HashSet<ImportRecordResult>();
        }

        public Guid Id { get; set; }
        public Guid Runid { get; set; }
        public string Source { get; set; }
        public string Target { get; set; }

        public ImportRun Run { get; set; }
        public ICollection<ImportCoupleResult> ImportCoupleResult { get; set; }
        public ICollection<ImportRecordResult> ImportRecordResult { get; set; }
    }
}
