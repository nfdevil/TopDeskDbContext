using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Gebeurtenismailactielink
    {
        public Guid Unid { get; set; }
        public Guid Actieid { get; set; }
        public Guid Gebeurtenisid { get; set; }
        public long Entityversion { get; set; }

        public Mailactie Actie { get; set; }
        public Gebeurtenis Gebeurtenis { get; set; }
    }
}
