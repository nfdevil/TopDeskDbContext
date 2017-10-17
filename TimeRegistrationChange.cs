using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class TimeRegistrationChange
    {
        public Guid Unid { get; set; }
        public long Timetaken { get; set; }
        public DateTime Entrydate { get; set; }
        public Guid? Operatorid { get; set; }
        public Guid? Operatorgroupid { get; set; }
        public int Status { get; set; }
        public DateTime Datwijzig { get; set; }
        public Guid? Uidwijzig { get; set; }
        public DateTime Dataanmk { get; set; }
        public Guid? Uidaanmk { get; set; }
        public Guid? Reason { get; set; }
        public Guid Cardid { get; set; }
        public string Notes { get; set; }

        public Change Card { get; set; }
        public Actiedoor Operator { get; set; }
        public Actiedoor Operatorgroup { get; set; }
        public TimeRegistrationReason ReasonNavigation { get; set; }
        public Gebruiker UidaanmkNavigation { get; set; }
        public Gebruiker UidwijzigNavigation { get; set; }
    }
}
