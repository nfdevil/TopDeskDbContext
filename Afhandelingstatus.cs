using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Afhandelingstatus
    {
        public Afhandelingstatus()
        {
            Incident = new HashSet<Incident>();
            MailimportIncidentStatus = new HashSet<MailimportIncident>();
            MailimportIncidentStatusclosed = new HashSet<MailimportIncident>();
            MailimportIncidentStatuscompleted = new HashSet<MailimportIncident>();
            MailimportIncidentStatusopen = new HashSet<MailimportIncident>();
            MutatieIncident = new HashSet<MutatieIncident>();
            Oplossingen = new HashSet<Oplossingen>();
        }

        public int Rang { get; set; }
        public Guid Unid { get; set; }
        public int Onhold { get; set; }
        public int Processingstate { get; set; }
        public string Bespokememo { get; set; }
        public string Naam { get; set; }
        public int Archief { get; set; }

        public ICollection<Incident> Incident { get; set; }
        public ICollection<MailimportIncident> MailimportIncidentStatus { get; set; }
        public ICollection<MailimportIncident> MailimportIncidentStatusclosed { get; set; }
        public ICollection<MailimportIncident> MailimportIncidentStatuscompleted { get; set; }
        public ICollection<MailimportIncident> MailimportIncidentStatusopen { get; set; }
        public ICollection<MutatieIncident> MutatieIncident { get; set; }
        public ICollection<Oplossingen> Oplossingen { get; set; }
    }
}
