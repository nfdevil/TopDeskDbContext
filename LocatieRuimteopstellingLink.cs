using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class LocatieRuimteopstellingLink
    {
        public Guid Opstellingid { get; set; }
        public Guid Locatieid { get; set; }
        public int Capaciteit { get; set; }
        public bool Isstandaard { get; set; }
        public string Omschrijving { get; set; }
        public Guid Unid { get; set; }

        public Locatie Locatie { get; set; }
        public Ruimteopstelling Opstelling { get; set; }
    }
}
