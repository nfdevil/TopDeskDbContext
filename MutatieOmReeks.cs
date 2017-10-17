using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class MutatieOmReeks
    {
        public Guid Unid { get; set; }
        public Guid Parentid { get; set; }
        public int MutStatus { get; set; }
        public Guid? Uidwijzig { get; set; }
        public Guid? MutBeheerderid { get; set; }
        public Guid? MutBeheerderidRid { get; set; }
        public bool MutBeheerderidAct { get; set; }
        public Guid? MutStatusid { get; set; }
        public Guid? MutStatusidRid { get; set; }
        public bool MutStatusidAct { get; set; }
        public DateTime? Datwijzig { get; set; }
        public int Importtype { get; set; }
        public string Importid { get; set; }
        public DateTime? Importdate { get; set; }

        public Actiedoor MutBeheerder { get; set; }
        public Mutatiereden MutBeheerderidR { get; set; }
        public OmStatus MutStatusNavigation { get; set; }
        public Mutatiereden MutStatusidR { get; set; }
        public OmReeks Parent { get; set; }
        public Gebruiker UidwijzigNavigation { get; set; }
    }
}
