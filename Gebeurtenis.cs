using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Gebeurtenis
    {
        public Gebeurtenis()
        {
            Gebeurtenisfilter = new HashSet<Gebeurtenisfilter>();
            Gebeurtenishttpactielink = new HashSet<Gebeurtenishttpactielink>();
            Gebeurtenislogboekactielink = new HashSet<Gebeurtenislogboekactielink>();
            Gebeurtenismailactielink = new HashSet<Gebeurtenismailactielink>();
            Gebeurtenistijden = new HashSet<Gebeurtenistijden>();
            Gebeurtenisuitvoeractielink = new HashSet<Gebeurtenisuitvoeractielink>();
            Gebeurtenisvelden = new HashSet<Gebeurtenisvelden>();
        }

        public bool Actief { get; set; }
        public bool Filteractief { get; set; }
        public int Filterofen { get; set; }
        public int Filtersoort { get; set; }
        public string Naam { get; set; }
        public bool Naarstatus { get; set; }
        public string Naarstatuscode { get; set; }
        public string Omschrijving { get; set; }
        public string Soortcode { get; set; }
        public int Statuswaarde { get; set; }
        public string Structurename { get; set; }
        public string Tabelstatus { get; set; }
        public Guid Unid { get; set; }
        public bool Vanstatus { get; set; }
        public string Vanstatuscode { get; set; }
        public bool Veldenactief { get; set; }
        public int Veldenofen { get; set; }
        public long Entityversion { get; set; }

        public ICollection<Gebeurtenisfilter> Gebeurtenisfilter { get; set; }
        public ICollection<Gebeurtenishttpactielink> Gebeurtenishttpactielink { get; set; }
        public ICollection<Gebeurtenislogboekactielink> Gebeurtenislogboekactielink { get; set; }
        public ICollection<Gebeurtenismailactielink> Gebeurtenismailactielink { get; set; }
        public ICollection<Gebeurtenistijden> Gebeurtenistijden { get; set; }
        public ICollection<Gebeurtenisuitvoeractielink> Gebeurtenisuitvoeractielink { get; set; }
        public ICollection<Gebeurtenisvelden> Gebeurtenisvelden { get; set; }
    }
}
