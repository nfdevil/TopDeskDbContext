using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class MailimportIncident
    {
        public Guid? Branchid { get; set; }
        public Guid? Calltypeid { get; set; }
        public Guid? Categoryid { get; set; }
        public DateTime? Dataanmk { get; set; }
        public DateTime? Datwijzig { get; set; }
        public Guid? Defaultoperatorid { get; set; }
        public Guid? Entryid { get; set; }
        public Guid? Impactid { get; set; }
        public int IncidentLine { get; set; }
        public int Mailaddressunknown { get; set; }
        public Guid Mailimportsettingsid { get; set; }
        public Guid? Statusid { get; set; }
        public Guid? Subcategoryid { get; set; }
        public bool Subject2description { get; set; }
        public Guid? Uidaanmk { get; set; }
        public Guid? Uidwijzig { get; set; }
        public Guid Unid { get; set; }
        public Guid? Urgencyid { get; set; }
        public Guid? Priorityid { get; set; }
        public Guid? Statusopenid { get; set; }
        public Guid? Statuscompletedid { get; set; }
        public Guid? Statusclosedid { get; set; }
        public int Processingstatusopen { get; set; }
        public int Actiontypecompleted { get; set; }
        public int Processingstatuscompleted { get; set; }
        public int Actiontypeclosed { get; set; }
        public int Processingstatusclosed { get; set; }
        public bool Invisibleforcaller { get; set; }

        public Vestiging Branch { get; set; }
        public Soortmelding Calltype { get; set; }
        public Classificatie Category { get; set; }
        public Actiedoor Defaultoperator { get; set; }
        public Soortbinnenkomst Entry { get; set; }
        public Impact Impact { get; set; }
        public MailimportSettings Mailimportsettings { get; set; }
        public Priority Priority { get; set; }
        public Afhandelingstatus Status { get; set; }
        public Afhandelingstatus Statusclosed { get; set; }
        public Afhandelingstatus Statuscompleted { get; set; }
        public Afhandelingstatus Statusopen { get; set; }
        public Classificatie Subcategory { get; set; }
        public Gebruiker UidaanmkNavigation { get; set; }
        public Gebruiker UidwijzigNavigation { get; set; }
        public Urgency Urgency { get; set; }
    }
}
