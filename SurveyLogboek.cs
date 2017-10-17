using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class SurveyLogboek
    {
        public string Bericht { get; set; }
        public DateTime Dataanmk { get; set; }
        public DateTime Datwijzig { get; set; }
        public Guid? Kaartid { get; set; }
        public Guid? Persoonid { get; set; }
        public Guid? Uidaanmk { get; set; }
        public Guid? Uidwijzig { get; set; }
        public Guid Unid { get; set; }
        public string Actienaam { get; set; }

        public Survey Kaart { get; set; }
        public Persoon Persoon { get; set; }
        public Gebruiker UidaanmkNavigation { get; set; }
        public Gebruiker UidwijzigNavigation { get; set; }
    }
}
