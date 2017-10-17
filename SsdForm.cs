using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class SsdForm
    {
        public SsdForm()
        {
            ServiceSsdformLink = new HashSet<ServiceSsdformLink>();
            SsdFormTranslations = new HashSet<SsdFormTranslations>();
            SsdSubmittedFormContent = new HashSet<SsdSubmittedFormContent>();
        }

        public Guid Unid { get; set; }
        public string Form { get; set; }
        public string Card { get; set; }
        public string Cardtype { get; set; }
        public int Status { get; set; }
        public int? Version { get; set; }
        public bool Published { get; set; }
        public bool Frontpage { get; set; }
        public DateTime Dataanmk { get; set; }
        public DateTime Datwijzig { get; set; }
        public Guid? Archivereasonid { get; set; }
        public string Bespokememo { get; set; }
        public bool Standardform { get; set; }
        public Guid? Uidaanmk { get; set; }
        public Guid? Uidwijzig { get; set; }
        public int Importtype { get; set; }
        public string Importid { get; set; }
        public DateTime? Importdate { get; set; }

        public Archiefreden Archivereason { get; set; }
        public Gebruiker UidaanmkNavigation { get; set; }
        public Gebruiker UidwijzigNavigation { get; set; }
        public ICollection<ServiceSsdformLink> ServiceSsdformLink { get; set; }
        public ICollection<SsdFormTranslations> SsdFormTranslations { get; set; }
        public ICollection<SsdSubmittedFormContent> SsdSubmittedFormContent { get; set; }
    }
}
