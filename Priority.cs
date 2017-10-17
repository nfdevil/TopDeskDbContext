using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Priority
    {
        public Priority()
        {
            Incident = new HashSet<Incident>();
            MailimportIncident = new HashSet<MailimportIncident>();
            MutatieIncident = new HashSet<MutatieIncident>();
            Oplossingen = new HashSet<Oplossingen>();
            Prioritylink = new HashSet<Prioritylink>();
            Servicelevel = new HashSet<Servicelevel>();
            ServicelevelPrioritylink = new HashSet<ServicelevelPrioritylink>();
        }

        public Guid Unid { get; set; }
        public int Archief { get; set; }
        public int Rang { get; set; }
        public Guid? Line1durationid { get; set; }
        public Guid? Line2durationid { get; set; }
        public string Bespokememo { get; set; }
        public string Naam { get; set; }

        public Doorlooptijd Line1duration { get; set; }
        public Doorlooptijd Line2duration { get; set; }
        public ICollection<Incident> Incident { get; set; }
        public ICollection<MailimportIncident> MailimportIncident { get; set; }
        public ICollection<MutatieIncident> MutatieIncident { get; set; }
        public ICollection<Oplossingen> Oplossingen { get; set; }
        public ICollection<Prioritylink> Prioritylink { get; set; }
        public ICollection<Servicelevel> Servicelevel { get; set; }
        public ICollection<ServicelevelPrioritylink> ServicelevelPrioritylink { get; set; }
    }
}
