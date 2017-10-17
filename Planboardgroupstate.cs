using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Planboardgroupstate
    {
        public Guid Unid { get; set; }
        public Guid Operatorgroupid { get; set; }
        public Guid Userid { get; set; }
        public bool Visible { get; set; }
        public int Rank { get; set; }

        public Actiedoor Operatorgroup { get; set; }
        public Gebruiker User { get; set; }
    }
}
