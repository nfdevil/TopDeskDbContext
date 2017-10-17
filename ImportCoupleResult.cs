using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class ImportCoupleResult
    {
        public Guid Id { get; set; }
        public Guid Coupleid { get; set; }
        public int Mad { get; set; }
        public int Success { get; set; }
        public int Count { get; set; }

        public ImportCouple Couple { get; set; }
    }
}
