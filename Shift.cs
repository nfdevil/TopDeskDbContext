using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Shift
    {
        public Shift()
        {
            Appliedshift = new HashSet<Appliedshift>();
            Scheduleshiftlink = new HashSet<Scheduleshiftlink>();
            Shiftoperatorgrouplink = new HashSet<Shiftoperatorgrouplink>();
            Shiftpriority = new HashSet<Shiftpriority>();
            Shiftsegment = new HashSet<Shiftsegment>();
        }

        public Guid Unid { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Availableforall { get; set; }
        public int Status { get; set; }
        public Guid? Archiefredenid { get; set; }
        public DateTime? Dataanmk { get; set; }
        public DateTime? Datwijzig { get; set; }
        public Guid? Uidaanmk { get; set; }
        public Guid? Uidwijzig { get; set; }
        public string Importid { get; set; }
        public DateTime? Importdate { get; set; }
        public int Importtype { get; set; }
        public string Bespokememo { get; set; }

        public Archiefreden Archiefreden { get; set; }
        public Gebruiker UidaanmkNavigation { get; set; }
        public Gebruiker UidwijzigNavigation { get; set; }
        public ICollection<Appliedshift> Appliedshift { get; set; }
        public ICollection<Scheduleshiftlink> Scheduleshiftlink { get; set; }
        public ICollection<Shiftoperatorgrouplink> Shiftoperatorgrouplink { get; set; }
        public ICollection<Shiftpriority> Shiftpriority { get; set; }
        public ICollection<Shiftsegment> Shiftsegment { get; set; }
    }
}
