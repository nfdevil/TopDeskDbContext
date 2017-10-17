using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Shiftsegment
    {
        public Guid Unid { get; set; }
        public Guid Shiftid { get; set; }
        public Guid Taskroleid { get; set; }
        public int Start { get; set; }
        public int End { get; set; }
        public Guid? Uidaanmk { get; set; }
        public DateTime? Dataanmk { get; set; }
        public Guid? Uidwijzig { get; set; }
        public DateTime? Datwijzig { get; set; }
        public string Importid { get; set; }
        public DateTime? Importdate { get; set; }
        public int Importtype { get; set; }
        public string Bespokememo { get; set; }

        public Shift Shift { get; set; }
        public Taskrole Taskrole { get; set; }
        public Gebruiker UidaanmkNavigation { get; set; }
        public Gebruiker UidwijzigNavigation { get; set; }
    }
}
