using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class ActiedoorDocumenten
    {
        public Guid? Kaartid { get; set; }
        public string Omschrijving { get; set; }
        public Guid? Persoonid { get; set; }
        public Guid? Uidaanmk { get; set; }
        public Guid? Uidwijzig { get; set; }
        public Guid Unid { get; set; }
        public DateTime? Dataanmk { get; set; }
        public DateTime? Datwijzig { get; set; }
        public bool Isuploaded { get; set; }
        public string Filename { get; set; }
        public long Bytes { get; set; }
        public int Accessibility { get; set; }
        public bool Invisibleforcaller { get; set; }
        public bool Inline { get; set; }

        public Actiedoor Kaart { get; set; }
        public Persoon Persoon { get; set; }
        public Gebruiker UidaanmkNavigation { get; set; }
        public Gebruiker UidwijzigNavigation { get; set; }
    }
}
