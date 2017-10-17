using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class ChangeIncidentLink
    {
        public Guid Changeid { get; set; }
        public Guid Incidentid { get; set; }
        public Guid Unid { get; set; }
        public string Bespokememo { get; set; }
        public int Importtype { get; set; }
        public string Importid { get; set; }
        public DateTime? Importdate { get; set; }

        public Change Change { get; set; }
        public Incident Incident { get; set; }
    }
}
