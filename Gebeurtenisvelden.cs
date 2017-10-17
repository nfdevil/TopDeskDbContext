using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Gebeurtenisvelden
    {
        public Guid? Gebeurtenisid { get; set; }
        public bool Nieuwgebruikt { get; set; }
        public bool Oudgebruikt { get; set; }
        public Guid Unid { get; set; }
        public string Veldnaam { get; set; }
        public string Oudeveldwaarde { get; set; }
        public string Nieuweveldwaarde { get; set; }

        public Gebeurtenis Gebeurtenis { get; set; }
    }
}
