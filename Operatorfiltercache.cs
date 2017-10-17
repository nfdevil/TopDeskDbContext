using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Operatorfiltercache
    {
        public Guid Unid { get; set; }
        public Guid Userid { get; set; }
        public Guid Operatorid { get; set; }

        public Actiedoor Operator { get; set; }
        public Gebruiker User { get; set; }
    }
}
