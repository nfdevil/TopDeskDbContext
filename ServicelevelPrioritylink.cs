using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class ServicelevelPrioritylink
    {
        public Guid Unid { get; set; }
        public Guid Servicelevelid { get; set; }
        public Guid Impactid { get; set; }
        public Guid Urgencyid { get; set; }
        public Guid? Priorityid { get; set; }
        public Guid? Line1durationid { get; set; }
        public Guid? Line2durationid { get; set; }
        public string Bespokememo { get; set; }
        public int Importtype { get; set; }
        public string Importid { get; set; }
        public DateTime? Importdate { get; set; }

        public Impact Impact { get; set; }
        public Doorlooptijd Line1duration { get; set; }
        public Doorlooptijd Line2duration { get; set; }
        public Priority Priority { get; set; }
        public Servicelevel Servicelevel { get; set; }
        public Urgency Urgency { get; set; }
    }
}
