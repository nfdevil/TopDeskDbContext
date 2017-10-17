using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Logboekactie
    {
        public Logboekactie()
        {
            Gebeurtenislogboekactielink = new HashSet<Gebeurtenislogboekactielink>();
        }

        public bool Actief { get; set; }
        public bool Actieftasbeveiligd { get; set; }
        public bool Actieftaspubliek { get; set; }
        public bool Actieftopdesk { get; set; }
        public string Bericht { get; set; }
        public string Bericht1 { get; set; }
        public bool Bevestigen { get; set; }
        public string Naam { get; set; }
        public string Omschrijving { get; set; }
        public string Sleutel { get; set; }
        public string Structurename { get; set; }
        public string Tabelstatus { get; set; }
        public Guid Unid { get; set; }
        public bool Wijzigbaar { get; set; }

        public ICollection<Gebeurtenislogboekactielink> Gebeurtenislogboekactielink { get; set; }
    }
}
