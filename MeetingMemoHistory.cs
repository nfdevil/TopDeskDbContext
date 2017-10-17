using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class MeetingMemoHistory
    {
        public DateTime? Dataanmk { get; set; }
        public DateTime? Datwijzig { get; set; }
        public string Memotekst { get; set; }
        public Guid Parentid { get; set; }
        public Guid? Uidaanmk { get; set; }
        public Guid? Uidwijzig { get; set; }
        public Guid Unid { get; set; }
        public string Veldnaam { get; set; }
        public Guid? Persoonid { get; set; }
        public Guid? Gebruikerid { get; set; }
        public string Importid { get; set; }
        public DateTime? Recordtimestamp { get; set; }
        public int Importtype { get; set; }
        public int Origin { get; set; }
        public bool Invisibleforcaller { get; set; }
        public byte[] MemotekstRtf { get; set; }

        public Gebruiker Gebruiker { get; set; }
        public Meeting Parent { get; set; }
        public Persoon Persoon { get; set; }
        public Gebruiker UidaanmkNavigation { get; set; }
        public Gebruiker UidwijzigNavigation { get; set; }
    }
}
