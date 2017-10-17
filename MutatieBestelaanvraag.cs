using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class MutatieBestelaanvraag
    {
        public Guid Unid { get; set; }
        public Guid Parentid { get; set; }
        public int MutStatus { get; set; }
        public DateTime Datwijzig { get; set; }
        public Guid? Uidwijzig { get; set; }
        public Guid? MutBehandelaarid { get; set; }
        public Guid? MutBehandelaaridRid { get; set; }
        public bool MutBehandelaaridAct { get; set; }
        public DateTime? MutAanvraagdatum { get; set; }
        public Guid? MutAanvraagdatumRid { get; set; }
        public bool MutAanvraagdatumAct { get; set; }
        public DateTime? MutGewensteleverdatum { get; set; }
        public Guid? MutGewensteleverdatumRid { get; set; }
        public bool MutGewensteleverdatumAct { get; set; }
        public DateTime? MutRappeldatum { get; set; }
        public Guid? MutRappeldatumRid { get; set; }
        public bool MutRappeldatumAct { get; set; }
        public int Importtype { get; set; }
        public string Importid { get; set; }
        public DateTime? Importdate { get; set; }

        public Mutatiereden MutAanvraagdatumR { get; set; }
        public Actiedoor MutBehandelaar { get; set; }
        public Mutatiereden MutBehandelaaridR { get; set; }
        public Mutatiereden MutGewensteleverdatumR { get; set; }
        public Mutatiereden MutRappeldatumR { get; set; }
        public Bestelaanvraag Parent { get; set; }
        public Gebruiker UidwijzigNavigation { get; set; }
    }
}
