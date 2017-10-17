using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class MutatieBestellingen
    {
        public Guid Unid { get; set; }
        public Guid Parentid { get; set; }
        public int MutStatus { get; set; }
        public DateTime Datwijzig { get; set; }
        public Guid? Uidwijzig { get; set; }
        public Guid? MutBehandelaarid { get; set; }
        public Guid? MutBehandelaaridRid { get; set; }
        public bool MutBehandelaaridAct { get; set; }
        public Guid? MutStatusid { get; set; }
        public Guid? MutStatusidRid { get; set; }
        public bool MutStatusidAct { get; set; }
        public Guid? MutBestelautorisatieid { get; set; }
        public Guid? MutBestelautorisatieidRid { get; set; }
        public bool MutBestelautorisatieidAct { get; set; }
        public DateTime? MutGeplandebesteldatum { get; set; }
        public Guid? MutGeplandebesteldatumRid { get; set; }
        public bool MutGeplandebesteldatumAct { get; set; }
        public DateTime? MutOrdernrdatum { get; set; }
        public Guid? MutOrdernrdatumRid { get; set; }
        public bool MutOrdernrdatumAct { get; set; }
        public int Importtype { get; set; }
        public string Importid { get; set; }
        public DateTime? Importdate { get; set; }

        public Actiedoor MutBehandelaar { get; set; }
        public Mutatiereden MutBehandelaaridR { get; set; }
        public Actiedoor MutBestelautorisatie { get; set; }
        public Mutatiereden MutBestelautorisatieidR { get; set; }
        public Mutatiereden MutGeplandebesteldatumR { get; set; }
        public Mutatiereden MutOrdernrdatumR { get; set; }
        public Bestelstatus MutStatusNavigation { get; set; }
        public Mutatiereden MutStatusidR { get; set; }
        public Bestellingen Parent { get; set; }
        public Gebruiker UidwijzigNavigation { get; set; }
    }
}
