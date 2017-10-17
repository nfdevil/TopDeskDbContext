using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Herhaling
    {
        public Guid Unid { get; set; }
        public Guid Planningid { get; set; }
        public string Periode { get; set; }
        public int Jaarinterval { get; set; }
        public string Jaarperiode { get; set; }
        public int Maandvanjaar { get; set; }
        public int Weekvanjaar { get; set; }
        public int Dagvanjaar { get; set; }
        public int Maandinterval { get; set; }
        public string Maandperiode { get; set; }
        public int Weekvanmaand { get; set; }
        public int Dagvanmaand { get; set; }
        public int Weekinterval { get; set; }
        public bool Maandag { get; set; }
        public bool Dinsdag { get; set; }
        public bool Woensdag { get; set; }
        public bool Donderdag { get; set; }
        public bool Vrijdag { get; set; }
        public bool Zaterdag { get; set; }
        public bool Zondag { get; set; }
        public int Daginterval { get; set; }
        public long Starttijd { get; set; }
        public DateTime Dataanmk { get; set; }
        public DateTime Datwijzig { get; set; }
        public long? Doorlooptijd { get; set; }
        public Guid? Uidaanmk { get; set; }
        public Guid? Uidwijzig { get; set; }
        public int Dagvanweek { get; set; }
        public string Importid { get; set; }
        public int Importtype { get; set; }
        public DateTime? Importdate { get; set; }
        public string Bespokememo { get; set; }

        public Planning Planning { get; set; }
        public Gebruiker UidaanmkNavigation { get; set; }
        public Gebruiker UidwijzigNavigation { get; set; }
    }
}
