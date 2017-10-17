using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Mailactie
    {
        public Mailactie()
        {
            Campaignmailing = new HashSet<Campaignmailing>();
            Gebeurtenismailactielink = new HashSet<Gebeurtenismailactielink>();
            Mailactiebestand = new HashSet<Mailactiebestand>();
            Mailactiekopie = new HashSet<Mailactiekopie>();
        }

        public bool Actief { get; set; }
        public bool Actieftasbeveiligd { get; set; }
        public bool Actieftaspubliek { get; set; }
        public string Bericht1 { get; set; }
        public bool Bevestigen { get; set; }
        public bool Html { get; set; }
        public bool Kopiezelf { get; set; }
        public bool Leesbevestiging { get; set; }
        public string Naam { get; set; }
        public string Omschrijving { get; set; }
        public string Onderwerp1 { get; set; }
        public bool Ontvangstbevestiging { get; set; }
        public int Prioriteit { get; set; }
        public string Sleutel { get; set; }
        public string Structurename { get; set; }
        public Guid Unid { get; set; }
        public bool Wijzigbaar { get; set; }
        public int Uitvoerenbijselecties { get; set; }
        public string Vanadres1 { get; set; }
        public int Carddocuments { get; set; }
        public bool Vanadreswijzigbaar { get; set; }
        public string Maildistribution { get; set; }
        public string MaildistributionCc { get; set; }
        public string MaildistributionBcc { get; set; }
        public string MaildistributionReplyto { get; set; }
        public long Entityversion { get; set; }

        public ICollection<Campaignmailing> Campaignmailing { get; set; }
        public ICollection<Gebeurtenismailactielink> Gebeurtenismailactielink { get; set; }
        public ICollection<Mailactiebestand> Mailactiebestand { get; set; }
        public ICollection<Mailactiekopie> Mailactiekopie { get; set; }
    }
}
