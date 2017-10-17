using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Servicelevel
    {
        public Servicelevel()
        {
            Dnolink = new HashSet<Dnolink>();
            Incident = new HashSet<Incident>();
            ServicelevelDocumenten = new HashSet<ServicelevelDocumenten>();
            ServicelevelEmailberichten = new HashSet<ServicelevelEmailberichten>();
            ServicelevelLogboek = new HashSet<ServicelevelLogboek>();
            ServicelevelMemoHistory = new HashSet<ServicelevelMemoHistory>();
            ServicelevelPrioritylink = new HashSet<ServicelevelPrioritylink>();
            ServicelevelServiceLink = new HashSet<ServicelevelServiceLink>();
        }

        public string Briefdescription { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public string Bespokememo { get; set; }
        public string Aantekeningen { get; set; }
        public Guid? Servicewindowid { get; set; }
        public int ServicewindowOption { get; set; }
        public Guid? Priorityid { get; set; }
        public string Importid { get; set; }
        public int Importtype { get; set; }
        public DateTime? Importdate { get; set; }
        public Guid? Archivereasonid { get; set; }
        public DateTime? Dataanmk { get; set; }
        public DateTime? Datwijzig { get; set; }
        public int Status { get; set; }
        public Guid? Uidaanmk { get; set; }
        public Guid? Uidwijzig { get; set; }
        public Guid? Line1durationid { get; set; }
        public Guid? Line2durationid { get; set; }
        public Guid Unid { get; set; }

        public Archiefreden Archivereason { get; set; }
        public Doorlooptijd Line1duration { get; set; }
        public Doorlooptijd Line2duration { get; set; }
        public Priority Priority { get; set; }
        public Servicewindow Servicewindow { get; set; }
        public Gebruiker UidaanmkNavigation { get; set; }
        public Gebruiker UidwijzigNavigation { get; set; }
        public ICollection<Dnolink> Dnolink { get; set; }
        public ICollection<Incident> Incident { get; set; }
        public ICollection<ServicelevelDocumenten> ServicelevelDocumenten { get; set; }
        public ICollection<ServicelevelEmailberichten> ServicelevelEmailberichten { get; set; }
        public ICollection<ServicelevelLogboek> ServicelevelLogboek { get; set; }
        public ICollection<ServicelevelMemoHistory> ServicelevelMemoHistory { get; set; }
        public ICollection<ServicelevelPrioritylink> ServicelevelPrioritylink { get; set; }
        public ICollection<ServicelevelServiceLink> ServicelevelServiceLink { get; set; }
    }
}
