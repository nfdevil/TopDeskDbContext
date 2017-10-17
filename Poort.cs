using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Poort
    {
        public Poort()
        {
            PoortDocumenten = new HashSet<PoortDocumenten>();
            PoortEmailberichten = new HashSet<PoortEmailberichten>();
            PoortLogboek = new HashSet<PoortLogboek>();
            VerbindingPoort1 = new HashSet<Verbinding>();
            VerbindingPoort2 = new HashSet<Verbinding>();
        }

        public string Aantekeningen { get; set; }
        public string Naam { get; set; }
        public Guid? Objectid { get; set; }
        public int Richting { get; set; }
        public int Soort { get; set; }
        public int Status { get; set; }
        public Guid? Typeid { get; set; }
        public Guid? Uidaanmk { get; set; }
        public Guid? Uidwijzig { get; set; }
        public Guid Unid { get; set; }
        public DateTime? Dataanmk { get; set; }
        public DateTime? Datwijzig { get; set; }
        public string RefObject { get; set; }

        public Object Object { get; set; }
        public Poorttype Type { get; set; }
        public Gebruiker UidaanmkNavigation { get; set; }
        public Gebruiker UidwijzigNavigation { get; set; }
        public ICollection<PoortDocumenten> PoortDocumenten { get; set; }
        public ICollection<PoortEmailberichten> PoortEmailberichten { get; set; }
        public ICollection<PoortLogboek> PoortLogboek { get; set; }
        public ICollection<Verbinding> VerbindingPoort1 { get; set; }
        public ICollection<Verbinding> VerbindingPoort2 { get; set; }
    }
}
