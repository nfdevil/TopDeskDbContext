using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Projectbeheerdocumenten
    {
        public Projectbeheerdocumenten()
        {
            ProjectdocumentkoppelProject = new HashSet<ProjectdocumentkoppelProject>();
        }

        public Guid? Archiefredenid { get; set; }
        public string Bestandsnaam { get; set; }
        public string Naam { get; set; }
        public string Omschrijving { get; set; }
        public int Status { get; set; }
        public Guid Unid { get; set; }
        public DateTime? Dataanmk { get; set; }
        public DateTime? Datwijzig { get; set; }
        public Guid? Uidaanmk { get; set; }
        public Guid? Uidwijzig { get; set; }

        public Archiefreden Archiefreden { get; set; }
        public Gebruiker UidaanmkNavigation { get; set; }
        public Gebruiker UidwijzigNavigation { get; set; }
        public ICollection<ProjectdocumentkoppelProject> ProjectdocumentkoppelProject { get; set; }
    }
}
