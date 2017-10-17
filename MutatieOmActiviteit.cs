using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class MutatieOmActiviteit
    {
        public Guid Unid { get; set; }
        public Guid Parentid { get; set; }
        public int MutStatus { get; set; }
        public Guid? Uidwijzig { get; set; }
        public int Bestedetijd { get; set; }
        public Guid? MutBehandelaarid { get; set; }
        public Guid? MutBehandelaaridRid { get; set; }
        public bool MutBehandelaaridAct { get; set; }
        public Guid? MutStatusid { get; set; }
        public Guid? MutStatusidRid { get; set; }
        public bool MutStatusidAct { get; set; }
        public DateTime? Datwijzig { get; set; }
        public Guid? MutOperatorgroupid { get; set; }
        public bool MutOperatorgroupidAct { get; set; }
        public Guid? MutOperatorgroupidRid { get; set; }
        public int Importtype { get; set; }
        public string Importid { get; set; }
        public DateTime? Importdate { get; set; }
        public Guid? MutSupplierid { get; set; }
        public bool MutSupplieridAct { get; set; }
        public Guid? MutSupplieridRid { get; set; }

        public Actiedoor MutBehandelaar { get; set; }
        public Mutatiereden MutBehandelaaridR { get; set; }
        public Actiedoor MutOperatorgroup { get; set; }
        public Mutatiereden MutOperatorgroupidR { get; set; }
        public OmActiviteitStatus MutStatusNavigation { get; set; }
        public Mutatiereden MutStatusidR { get; set; }
        public Leverancier MutSupplier { get; set; }
        public Mutatiereden MutSupplieridR { get; set; }
        public OmActiviteit Parent { get; set; }
        public Gebruiker UidwijzigNavigation { get; set; }
    }
}
