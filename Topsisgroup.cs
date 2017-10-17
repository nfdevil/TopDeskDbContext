using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Topsisgroup
    {
        public Topsisgroup()
        {
            Topsisobject = new HashSet<Topsisobject>();
        }

        public string Host { get; set; }
        public long Macaddress { get; set; }
        public Guid Id { get; set; }
        public DateTime? Datwijzig { get; set; }
        public Guid? Uidwijzig { get; set; }
        public Guid? Uidaanmk { get; set; }
        public DateTime? Dataanmk { get; set; }
        public int Status { get; set; }
        public int Importtype { get; set; }
        public DateTime? Importdate { get; set; }
        public Guid Objectid { get; set; }
        public string Importid { get; set; }

        public Object Object { get; set; }
        public Gebruiker UidaanmkNavigation { get; set; }
        public Gebruiker UidwijzigNavigation { get; set; }
        public ICollection<Topsisobject> Topsisobject { get; set; }
    }
}
