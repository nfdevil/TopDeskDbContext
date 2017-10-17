using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class SwUitzonderingen
    {
        public Guid Unid { get; set; }
        public Guid Swid { get; set; }
        public DateTime Datum { get; set; }
        public long Openingstijd { get; set; }
        public long Sluitingstijd { get; set; }
        public bool Workday { get; set; }
        public string Name { get; set; }
        public int Importtype { get; set; }
        public string Importid { get; set; }
        public DateTime? Importdate { get; set; }

        public Servicewindow Sw { get; set; }
    }
}
