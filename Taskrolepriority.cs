using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Taskrolepriority
    {
        public Guid Unid { get; set; }
        public Guid Taskroleid { get; set; }
        public Guid Userid { get; set; }
        public int Rank { get; set; }

        public Taskrole Taskrole { get; set; }
        public Gebruiker User { get; set; }
    }
}
