using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class RmSeries
    {
        public RmSeries()
        {
            Reservering = new HashSet<Reservering>();
            RmSeriesLocationLink = new HashSet<RmSeriesLocationLink>();
            RmSeriesObjectLink = new HashSet<RmSeriesObjectLink>();
            RmSeriesServiceLink = new HashSet<RmSeriesServiceLink>();
        }

        public Guid Unid { get; set; }
        public Guid? Uidaanmk { get; set; }
        public Guid? Uidwijzig { get; set; }
        public DateTime? Dataanmk { get; set; }
        public DateTime? Datwijzig { get; set; }
        public string Briefdescription { get; set; }
        public int Status { get; set; }
        public Guid? Statusid { get; set; }
        public int Numberofpersons { get; set; }
        public int Starttime { get; set; }
        public int Duration { get; set; }
        public Guid Planningid { get; set; }
        public string Bespokememo { get; set; }
        public bool Hasconflicts { get; set; }

        public Planning Planning { get; set; }
        public RmSeriesStatus StatusNavigation { get; set; }
        public Gebruiker UidaanmkNavigation { get; set; }
        public Gebruiker UidwijzigNavigation { get; set; }
        public ICollection<Reservering> Reservering { get; set; }
        public ICollection<RmSeriesLocationLink> RmSeriesLocationLink { get; set; }
        public ICollection<RmSeriesObjectLink> RmSeriesObjectLink { get; set; }
        public ICollection<RmSeriesServiceLink> RmSeriesServiceLink { get; set; }
    }
}
