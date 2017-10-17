using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Appliedshift
    {
        public Guid Unid { get; set; }
        public Guid Operatorid { get; set; }
        public Guid Shiftid { get; set; }
        public long Day { get; set; }
        public string Timezone { get; set; }
        public int Status { get; set; }
        public Guid? Uidaanmk { get; set; }
        public DateTime? Dataanmk { get; set; }
        public Guid? Uidwijzig { get; set; }
        public DateTime? Datwijzig { get; set; }

        public Actiedoor Operator { get; set; }
        public Shift Shift { get; set; }
        public Gebruiker UidaanmkNavigation { get; set; }
        public Gebruiker UidwijzigNavigation { get; set; }
    }
}
