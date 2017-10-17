using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class OmGroepering
    {
        public OmGroepering()
        {
            OmActiviteit = new HashSet<OmActiviteit>();
            OmReeks = new HashSet<OmReeks>();
        }

        public Guid Unid { get; set; }
        public string Naam { get; set; }
        public Guid Schemaid { get; set; }
        public int Status { get; set; }
        public Guid? Archiefredenid { get; set; }
        public DateTime? Dataanmk { get; set; }
        public DateTime? Datwijzig { get; set; }
        public Guid? Uidaanmk { get; set; }
        public Guid? Uidwijzig { get; set; }
        public string Bespokememo { get; set; }

        public Archiefreden Archiefreden { get; set; }
        public OmSchema Schema { get; set; }
        public Gebruiker UidaanmkNavigation { get; set; }
        public Gebruiker UidwijzigNavigation { get; set; }
        public ICollection<OmActiviteit> OmActiviteit { get; set; }
        public ICollection<OmReeks> OmReeks { get; set; }
    }
}
