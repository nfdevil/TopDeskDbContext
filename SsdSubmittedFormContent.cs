using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class SsdSubmittedFormContent
    {
        public Guid Unid { get; set; }
        public Guid Formid { get; set; }
        public string Cardid { get; set; }
        public string SubmittedData { get; set; }
        public int FormVersion { get; set; }
        public string Bespokememo { get; set; }
        public int Importtype { get; set; }
        public string Importid { get; set; }
        public DateTime? Importdate { get; set; }

        public SsdForm Form { get; set; }
    }
}
