using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class MutatieReservering
    {
        public Guid Unid { get; set; }
        public DateTime? Datwijzig { get; set; }
        public int MutStatus { get; set; }
        public Guid? Parentid { get; set; }
        public Guid? Uidwijzig { get; set; }
        public Guid? MutBeheerderid { get; set; }
        public bool MutBeheerderidAct { get; set; }
        public Guid? MutBeheerderidRid { get; set; }
        public Guid? MutCategorieid { get; set; }
        public bool MutCategorieidAct { get; set; }
        public Guid? MutCategorieidRid { get; set; }
        public Guid? MutStatusid { get; set; }
        public Guid? MutStatusidRid { get; set; }
        public bool MutStatusidAct { get; set; }
        public DateTime? MutStartdatumgepland { get; set; }
        public bool MutStartdatumgeplandAct { get; set; }
        public Guid? MutStartdatumgeplandRid { get; set; }
        public DateTime? MutEinddatumgepland { get; set; }
        public bool MutEinddatumgeplandAct { get; set; }
        public Guid? MutEinddatumgeplandRid { get; set; }
        public int Importtype { get; set; }
        public string Importid { get; set; }
        public DateTime? Importdate { get; set; }

        public Actiedoor MutBeheerder { get; set; }
        public Mutatiereden MutBeheerderidR { get; set; }
        public Verhuurcategorie MutCategorie { get; set; }
        public Mutatiereden MutCategorieidR { get; set; }
        public Mutatiereden MutEinddatumgeplandR { get; set; }
        public Mutatiereden MutStartdatumgeplandR { get; set; }
        public Verhuurstatus MutStatusNavigation { get; set; }
        public Mutatiereden MutStatusidR { get; set; }
        public Reservering Parent { get; set; }
        public Gebruiker UidwijzigNavigation { get; set; }
    }
}
