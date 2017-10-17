using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Planning
    {
        public Planning()
        {
            Herhaling = new HashSet<Herhaling>();
            OmReeks = new HashSet<OmReeks>();
            PlanningMultidate = new HashSet<PlanningMultidate>();
            RmSeries = new HashSet<RmSeries>();
        }

        public Guid Unid { get; set; }
        public DateTime? Startdatum { get; set; }
        public DateTime? Einddatum { get; set; }
        public int Aantalherhalingen { get; set; }
        public DateTime? Dataanmk { get; set; }
        public DateTime? Datwijzig { get; set; }
        public Guid? Uidaanmk { get; set; }
        public Guid? Uidwijzig { get; set; }
        public DateTime? Ingeplandtotdatum { get; set; }
        public int Eindtype { get; set; }
        public string Importid { get; set; }
        public int Importtype { get; set; }
        public DateTime? Importdate { get; set; }
        public string Bespokememo { get; set; }

        public Gebruiker UidaanmkNavigation { get; set; }
        public Gebruiker UidwijzigNavigation { get; set; }
        public ICollection<Herhaling> Herhaling { get; set; }
        public ICollection<OmReeks> OmReeks { get; set; }
        public ICollection<PlanningMultidate> PlanningMultidate { get; set; }
        public ICollection<RmSeries> RmSeries { get; set; }
    }
}
