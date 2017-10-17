using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Shiftpriority
    {
        public Guid Unid { get; set; }
        public Guid Shiftid { get; set; }
        public Guid Userid { get; set; }
        public int Rank { get; set; }

        public Shift Shift { get; set; }
        public Gebruiker User { get; set; }
    }
}
