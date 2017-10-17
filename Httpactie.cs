using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Httpactie
    {
        public Httpactie()
        {
            Gebeurtenishttpactielink = new HashSet<Gebeurtenishttpactielink>();
        }

        public bool Actief { get; set; }
        public bool Actieftasbeveiligd { get; set; }
        public bool Actieftaspubliek { get; set; }
        public bool Actieftopdesk { get; set; }
        public bool Berichttonen { get; set; }
        public bool Bevestigen { get; set; }
        public string Body { get; set; }
        public string Body1 { get; set; }
        public int Eenofalle { get; set; }
        public string Headers { get; set; }
        public string Headers1 { get; set; }
        public int Httpmethod { get; set; }
        public int Httpversie { get; set; }
        public int Komtvoor { get; set; }
        public string Naam { get; set; }
        public string Omschrijving { get; set; }
        public int Poort { get; set; }
        public string Server { get; set; }
        public string Server1 { get; set; }
        public string Sleutel { get; set; }
        public int Soortuitvoer { get; set; }
        public int Soortuitvoer2 { get; set; }
        public int Specplaats { get; set; }
        public string Structurename { get; set; }
        public string Tabelstatus { get; set; }
        public string Tekstals { get; set; }
        public string Tekstals1 { get; set; }
        public string Tekstalsniet { get; set; }
        public string Tekstalsniet1 { get; set; }
        public bool Toonanders { get; set; }
        public Guid Unid { get; set; }
        public string Uri { get; set; }
        public string Uri1 { get; set; }
        public bool Voorwaarde { get; set; }
        public bool Wijzigbaar { get; set; }
        public string Woorden { get; set; }
        public string Woorden1 { get; set; }
        public bool Usessl { get; set; }
        public bool Serversideauth { get; set; }
        public bool Clientsideauth { get; set; }
        public bool Intopdesk { get; set; }
        public bool Toonreactie { get; set; }
        public bool Optionalwebtab { get; set; }

        public ICollection<Gebeurtenishttpactielink> Gebeurtenishttpactielink { get; set; }
    }
}
