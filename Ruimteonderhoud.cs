using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Ruimteonderhoud
    {
        public string Code { get; set; }
        public DateTime? Einddatum { get; set; }
        public decimal? Kosten { get; set; }
        public Guid? Leverancierid { get; set; }
        public Guid Locatieid { get; set; }
        public string Omschrijving { get; set; }
        public DateTime Startdatum { get; set; }
        public Guid Unid { get; set; }
        public int Importtype { get; set; }
        public string Importid { get; set; }
        public DateTime? Importdate { get; set; }

        public Leverancier Leverancier { get; set; }
        public Locatie Locatie { get; set; }
    }
}
