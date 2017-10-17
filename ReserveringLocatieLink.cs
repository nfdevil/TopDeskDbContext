using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class ReserveringLocatieLink
    {
        public Guid Unid { get; set; }
        public Guid Locatieid { get; set; }
        public Guid Reserveringid { get; set; }
        public DateTime? Einddatum { get; set; }
        public DateTime? Einddatumgepland { get; set; }
        public DateTime? Startdatum { get; set; }
        public DateTime? Startdatumgepland { get; set; }
        public int Status { get; set; }
        public DateTime? Dataanmk { get; set; }
        public DateTime? Datwijzig { get; set; }
        public Guid? Uidaanmk { get; set; }
        public Guid? Uidwijzig { get; set; }
        public DateTime Startdatumgeplandblok { get; set; }
        public DateTime Einddatumgeplandblok { get; set; }
        public string Bespokememo { get; set; }

        public Locatie Locatie { get; set; }
        public Reservering Reservering { get; set; }
        public Gebruiker UidaanmkNavigation { get; set; }
        public Gebruiker UidwijzigNavigation { get; set; }
    }
}
