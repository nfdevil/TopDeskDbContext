using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Gebeurtenistijden
    {
        public int Dagen { get; set; }
        public Guid? Gebeurtenisid { get; set; }
        public int Minuten { get; set; }
        public Guid Unid { get; set; }
        public string Veldnaam { get; set; }
        public int Wanneer { get; set; }

        public Gebeurtenis Gebeurtenis { get; set; }
    }
}
