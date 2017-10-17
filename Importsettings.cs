using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Importsettings
    {
        public Guid Unid { get; set; }
        public Guid? Uidaanmk { get; set; }
        public Guid? Uidwijzig { get; set; }
        public DateTime? Dataanmk { get; set; }
        public DateTime? Datwijzig { get; set; }
        public string Importdefinition { get; set; }
        public string Sourcestructure { get; set; }
        public string Name { get; set; }
        public string Databaseconnection { get; set; }
        public string Schedule { get; set; }
        public long? Lastimport { get; set; }
        public long Commitdelay { get; set; }
        public int Rank { get; set; }
        public bool Advancedlogging { get; set; }
        public Guid? Importuserid { get; set; }

        public Gebruiker Importuser { get; set; }
        public Gebruiker UidaanmkNavigation { get; set; }
        public Gebruiker UidwijzigNavigation { get; set; }
    }
}
