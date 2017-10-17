using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class WijzigingImpact
    {
        public WijzigingImpact()
        {
            Change = new HashSet<Change>();
            ChangePrioritylink = new HashSet<ChangePrioritylink>();
            ChangeTemplate = new HashSet<ChangeTemplate>();
            Changeversion = new HashSet<Changeversion>();
            MailimportChange = new HashSet<MailimportChange>();
            MutatieChange = new HashSet<MutatieChange>();
        }

        public int Rang { get; set; }
        public Guid Unid { get; set; }
        public string Bespokememo { get; set; }
        public string Naam { get; set; }
        public int Archief { get; set; }

        public ICollection<Change> Change { get; set; }
        public ICollection<ChangePrioritylink> ChangePrioritylink { get; set; }
        public ICollection<ChangeTemplate> ChangeTemplate { get; set; }
        public ICollection<Changeversion> Changeversion { get; set; }
        public ICollection<MailimportChange> MailimportChange { get; set; }
        public ICollection<MutatieChange> MutatieChange { get; set; }
    }
}
