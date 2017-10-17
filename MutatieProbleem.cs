using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class MutatieProbleem
    {
        public Guid? MutActiedoorbfid { get; set; }
        public Guid? MutActiedoorid { get; set; }
        public Guid? MutBeheerderbfid { get; set; }
        public int MutStatus { get; set; }
        public Guid? MutStatusbfid { get; set; }
        public Guid? MutStatusid { get; set; }
        public Guid? MutVerantwoordelijkeid { get; set; }
        public Guid? Parentid { get; set; }
        public Guid? Uidwijzig { get; set; }
        public Guid Unid { get; set; }
        public DateTime? Datwijzig { get; set; }
        public DateTime? MutStreefdatum { get; set; }
        public DateTime? MutStreefdatumbf { get; set; }
        public long Bestedetijd { get; set; }
        public bool MutActiedoorbfidAct { get; set; }
        public Guid? MutActiedoorbfidRid { get; set; }
        public bool MutActiedooridAct { get; set; }
        public Guid? MutActiedooridRid { get; set; }
        public bool MutBeheerderbfidAct { get; set; }
        public Guid? MutBeheerderbfidRid { get; set; }
        public bool MutStatusbfidAct { get; set; }
        public Guid? MutStatusbfidRid { get; set; }
        public bool MutStatusidAct { get; set; }
        public Guid? MutStatusidRid { get; set; }
        public bool MutStreefdatumAct { get; set; }
        public Guid? MutStreefdatumRid { get; set; }
        public bool MutStreefdatumbfAct { get; set; }
        public Guid? MutStreefdatumbfRid { get; set; }
        public bool MutVerantwoordelijkeidAct { get; set; }
        public Guid? MutVerantwoordelijkeidRid { get; set; }
        public DateTime? MutDatumgereed { get; set; }
        public Guid? MutDatumgereedRid { get; set; }
        public bool MutDatumgereedAct { get; set; }
        public DateTime? MutDatumafgemeld { get; set; }
        public Guid? MutDatumafgemeldRid { get; set; }
        public bool MutDatumafgemeldAct { get; set; }
        public Guid? MutOperatorgroupid { get; set; }
        public bool MutOperatorgroupidAct { get; set; }
        public Guid? MutOperatorgroupidRid { get; set; }
        public Guid? MutOperatorgroupbfid { get; set; }
        public bool MutOperatorgroupbfidAct { get; set; }
        public Guid? MutOperatorgroupbfidRid { get; set; }
        public DateTime? MutDatumgereedbf { get; set; }
        public bool MutDatumgereedbfAct { get; set; }
        public Guid? MutDatumgereedbfRid { get; set; }
        public DateTime? MutDatumafgemeldbf { get; set; }
        public bool MutDatumafgemeldbfAct { get; set; }
        public Guid? MutDatumafgemeldbfRid { get; set; }
        public Guid? MutUrgencyid { get; set; }
        public bool MutUrgencyidAct { get; set; }
        public Guid? MutUrgencyidRid { get; set; }
        public Guid? MutPriorityid { get; set; }
        public bool MutPriorityidAct { get; set; }
        public Guid? MutPriorityidRid { get; set; }
        public int Importtype { get; set; }
        public string Importid { get; set; }
        public DateTime? Importdate { get; set; }

        public Actiedoor MutActiedoor { get; set; }
        public Actiedoor MutActiedoorbf { get; set; }
        public Mutatiereden MutActiedoorbfidR { get; set; }
        public Mutatiereden MutActiedooridR { get; set; }
        public Actiedoor MutBeheerderbf { get; set; }
        public Mutatiereden MutBeheerderbfidR { get; set; }
        public Mutatiereden MutDatumafgemeldR { get; set; }
        public Mutatiereden MutDatumafgemeldbfR { get; set; }
        public Mutatiereden MutDatumgereedR { get; set; }
        public Mutatiereden MutDatumgereedbfR { get; set; }
        public Actiedoor MutOperatorgroup { get; set; }
        public Actiedoor MutOperatorgroupbf { get; set; }
        public Mutatiereden MutOperatorgroupbfidR { get; set; }
        public Mutatiereden MutOperatorgroupidR { get; set; }
        public ProblemPriority MutPriority { get; set; }
        public Mutatiereden MutPriorityidR { get; set; }
        public ProbleemStatus MutStatusNavigation { get; set; }
        public ProbleemStatus MutStatusbf { get; set; }
        public Mutatiereden MutStatusbfidR { get; set; }
        public Mutatiereden MutStatusidR { get; set; }
        public Mutatiereden MutStreefdatumR { get; set; }
        public Mutatiereden MutStreefdatumbfR { get; set; }
        public ProblemUrgency MutUrgency { get; set; }
        public Mutatiereden MutUrgencyidR { get; set; }
        public Actiedoor MutVerantwoordelijke { get; set; }
        public Mutatiereden MutVerantwoordelijkeidR { get; set; }
        public Probleem Parent { get; set; }
        public Gebruiker UidwijzigNavigation { get; set; }
    }
}
