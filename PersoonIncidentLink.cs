using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class PersoonIncidentLink
    {
        public Guid Unid { get; set; }
        public Guid Persoonid { get; set; }
        public Guid Incidentid { get; set; }
        public string Bespokememo { get; set; }
        public int Importtype { get; set; }
        public string Importid { get; set; }
        public DateTime? Importdate { get; set; }

        public Incident Incident { get; set; }
        public Persoon Persoon { get; set; }
    }
}
