using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class MailimportSettings
    {
        public MailimportSettings()
        {
            MailimportChange = new HashSet<MailimportChange>();
            MailimportIncident = new HashSet<MailimportIncident>();
        }

        public Guid Unid { get; set; }
        public string Shortdescription { get; set; }
        public string Notes { get; set; }
        public bool Sslsecured { get; set; }
        public string Imapserver { get; set; }
        public int Portnumber { get; set; }
        public string Imapuser { get; set; }
        public string Password { get; set; }
        public string Imapfolder { get; set; }
        public bool Active { get; set; }
        public string Directory { get; set; }
        public Guid? Executeasuserid { get; set; }
        public DateTime? Dataanmk { get; set; }
        public DateTime? Datwijzig { get; set; }
        public Guid? Uidaanmk { get; set; }
        public Guid? Uidwijzig { get; set; }
        public string Alternatefolder { get; set; }
        public int Movemail { get; set; }
        public string Failedfolder { get; set; }
        public int Movefailed { get; set; }
        public int Savemail { get; set; }
        public int Defaultimport { get; set; }
        public int Lastrunstatus { get; set; }
        public DateTime? Lastruntime { get; set; }
        public string Additionalproperties { get; set; }
        public int Imapsecuritytype { get; set; }
        public int Servertype { get; set; }
        public int Mailboxtype { get; set; }
        public string Exchangeversion { get; set; }
        public string Sharedmailaddress { get; set; }
        public bool Preferplaintextimport { get; set; }

        public Gebruiker Executeasuser { get; set; }
        public Gebruiker UidaanmkNavigation { get; set; }
        public Gebruiker UidwijzigNavigation { get; set; }
        public ICollection<MailimportChange> MailimportChange { get; set; }
        public ICollection<MailimportIncident> MailimportIncident { get; set; }
    }
}
