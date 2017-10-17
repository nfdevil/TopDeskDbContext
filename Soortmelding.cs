using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Soortmelding
    {
        public Soortmelding()
        {
            ChangeTemplate = new HashSet<ChangeTemplate>();
            Dnodienst = new HashSet<Dnodienst>();
            Dnolink = new HashSet<Dnolink>();
            Incident = new HashSet<Incident>();
            MailimportIncident = new HashSet<MailimportIncident>();
            MutatieDnodienst = new HashSet<MutatieDnodienst>();
            Oplossingen = new HashSet<Oplossingen>();
        }

        public int Rang { get; set; }
        public Guid Unid { get; set; }
        public string Bespokememo { get; set; }
        public string Naam { get; set; }
        public int Archief { get; set; }

        public ICollection<ChangeTemplate> ChangeTemplate { get; set; }
        public ICollection<Dnodienst> Dnodienst { get; set; }
        public ICollection<Dnolink> Dnolink { get; set; }
        public ICollection<Incident> Incident { get; set; }
        public ICollection<MailimportIncident> MailimportIncident { get; set; }
        public ICollection<MutatieDnodienst> MutatieDnodienst { get; set; }
        public ICollection<Oplossingen> Oplossingen { get; set; }
    }
}
