using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class ImportRunInfo
    {
        public Guid Id { get; set; }
        public Guid ImportRunid { get; set; }
        public string Stacktrace { get; set; }

        public ImportRun ImportRun { get; set; }
    }
}
