using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Schedule
    {
        public Schedule()
        {
            Scheduleshiftlink = new HashSet<Scheduleshiftlink>();
        }

        public Guid Unid { get; set; }
        public Guid Operatorid { get; set; }
        public long Start { get; set; }
        public long? End { get; set; }
        public string Timezone { get; set; }
        public int Length { get; set; }
        public Guid? Uidaanmk { get; set; }
        public DateTime? Dataanmk { get; set; }
        public Guid? Uidwijzig { get; set; }
        public DateTime? Datwijzig { get; set; }
        public string Importid { get; set; }
        public DateTime? Importdate { get; set; }
        public int Importtype { get; set; }
        public string Bespokememo { get; set; }

        public Actiedoor Operator { get; set; }
        public Gebruiker UidaanmkNavigation { get; set; }
        public Gebruiker UidwijzigNavigation { get; set; }
        public ICollection<Scheduleshiftlink> Scheduleshiftlink { get; set; }
    }
}
