using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class MailimportChange
    {
        public Guid? Branchid { get; set; }
        public Guid? Benefitid { get; set; }
        public Guid? Categoryid { get; set; }
        public DateTime? Dataanmk { get; set; }
        public DateTime? Datwijzig { get; set; }
        public Guid? Defaultoperatorid { get; set; }
        public Guid? Impactid { get; set; }
        public bool Isurgent { get; set; }
        public int Mailaddressunknown { get; set; }
        public Guid Mailimportsettingsid { get; set; }
        public Guid? Statusid { get; set; }
        public Guid? Subcategoryid { get; set; }
        public Guid? Uidaanmk { get; set; }
        public Guid? Uidwijzig { get; set; }
        public Guid Unid { get; set; }
        public bool Invisibleforcaller { get; set; }

        public Changebenefit Benefit { get; set; }
        public Vestiging Branch { get; set; }
        public Classificatie Category { get; set; }
        public Actiedoor Defaultoperator { get; set; }
        public WijzigingImpact Impact { get; set; }
        public MailimportSettings Mailimportsettings { get; set; }
        public Wijzigingstatus Status { get; set; }
        public Classificatie Subcategory { get; set; }
        public Gebruiker UidaanmkNavigation { get; set; }
        public Gebruiker UidwijzigNavigation { get; set; }
    }
}
