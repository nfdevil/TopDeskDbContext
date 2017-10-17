using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Categoryfiltercache
    {
        public Guid Unid { get; set; }
        public Guid Userid { get; set; }
        public Guid Categoryid { get; set; }

        public Classificatie Category { get; set; }
        public Gebruiker User { get; set; }
    }
}
