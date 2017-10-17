using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class ImportRecordResult
    {
        public Guid Id { get; set; }
        public Guid Coupleid { get; set; }
        public int Mad { get; set; }
        public int Success { get; set; }
        public string Representation { get; set; }
        public string Comment { get; set; }

        public ImportCouple Couple { get; set; }
    }
}
