using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Uitvoeractie
    {
        public Uitvoeractie()
        {
            Gebeurtenisuitvoeractielink = new HashSet<Gebeurtenisuitvoeractielink>();
        }

        public bool Actief { get; set; }
        public bool Actieftasbeveiligd { get; set; }
        public bool Actieftaspubliek { get; set; }
        public bool Actieftopdesk { get; set; }
        public string Bestand { get; set; }
        public bool Bestandmeegeven { get; set; }
        public string Inhoudtekstbestand { get; set; }
        public string Inhoudtekstbestand1 { get; set; }
        public string Meegeeftekstbestand { get; set; }
        public string Naam { get; set; }
        public string Omschrijving { get; set; }
        public string Parameters { get; set; }
        public string Parameters1 { get; set; }
        public string Sleutel { get; set; }
        public string Structurename { get; set; }
        public string Tabelstatus { get; set; }
        public Guid Unid { get; set; }
        public int Welkbestand { get; set; }

        public ICollection<Gebeurtenisuitvoeractielink> Gebeurtenisuitvoeractielink { get; set; }
    }
}
