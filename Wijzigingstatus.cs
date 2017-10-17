using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Wijzigingstatus
    {
        public Wijzigingstatus()
        {
            Change = new HashSet<Change>();
            ChangeTemplate = new HashSet<ChangeTemplate>();
            Changeversion = new HashSet<Changeversion>();
            MailimportChange = new HashSet<MailimportChange>();
            MutatieChange = new HashSet<MutatieChange>();
            MutatieChangeversion = new HashSet<MutatieChangeversion>();
        }

        public int Rang { get; set; }
        public Guid Unid { get; set; }
        public string Bespokememo { get; set; }
        public int SimplechangeState { get; set; }
        public int PreliminaryState { get; set; }
        public int RfcState { get; set; }
        public int ExtensivechangeState { get; set; }
        public int VersionState { get; set; }
        public string Naam { get; set; }
        public int Archief { get; set; }

        public ICollection<Change> Change { get; set; }
        public ICollection<ChangeTemplate> ChangeTemplate { get; set; }
        public ICollection<Changeversion> Changeversion { get; set; }
        public ICollection<MailimportChange> MailimportChange { get; set; }
        public ICollection<MutatieChange> MutatieChange { get; set; }
        public ICollection<MutatieChangeversion> MutatieChangeversion { get; set; }
    }
}
