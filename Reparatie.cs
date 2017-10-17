using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Reparatie
    {
        public string Code { get; set; }
        public Guid? Leverancierid { get; set; }
        public Guid? Objectid { get; set; }
        public string Omschrijving { get; set; }
        public Guid Unid { get; set; }
        public DateTime? Einddatum { get; set; }
        public DateTime? Startdatum { get; set; }
        public decimal Kosten { get; set; }

        public Leverancier Leverancier { get; set; }
        public Object Object { get; set; }
    }
}
