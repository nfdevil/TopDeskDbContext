using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Taskrole
    {
        public Taskrole()
        {
            Availabilitycheck = new HashSet<Availabilitycheck>();
            Shiftsegment = new HashSet<Shiftsegment>();
            Taskroleoperatorgrouplink = new HashSet<Taskroleoperatorgrouplink>();
            Taskrolepriority = new HashSet<Taskrolepriority>();
        }

        public Guid Unid { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Colour { get; set; }
        public bool Operatoravailable { get; set; }
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
        public ICollection<Availabilitycheck> Availabilitycheck { get; set; }
        public ICollection<Shiftsegment> Shiftsegment { get; set; }
        public ICollection<Taskroleoperatorgrouplink> Taskroleoperatorgrouplink { get; set; }
        public ICollection<Taskrolepriority> Taskrolepriority { get; set; }
    }
}
