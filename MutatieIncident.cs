using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class MutatieIncident
    {
        public Guid? MutAfhandelingstatusid { get; set; }
        public int MutStatus { get; set; }
        public Guid? Parentid { get; set; }
        public Guid? Uidwijzig { get; set; }
        public Guid Unid { get; set; }
        public DateTime? Datwijzig { get; set; }
        public DateTime? MutDatumafspraak { get; set; }
        public long Bestedetijd { get; set; }
        public bool MutAfhandelingstatusidAct { get; set; }
        public Guid? MutAfhandelingstatusidRid { get; set; }
        public bool MutDatumafspraakAct { get; set; }
        public Guid? MutDatumafspraakRid { get; set; }
        public DateTime? MutDatumgereed { get; set; }
        public Guid? MutDatumgereedRid { get; set; }
        public bool MutDatumgereedAct { get; set; }
        public DateTime? MutDatumafgemeld { get; set; }
        public Guid? MutDatumafgemeldRid { get; set; }
        public bool MutDatumafgemeldAct { get; set; }
        public Guid? MutOperatorid { get; set; }
        public bool MutOperatoridAct { get; set; }
        public Guid? MutOperatoridRid { get; set; }
        public Guid? MutOperatorgroupid { get; set; }
        public bool MutOperatorgroupidAct { get; set; }
        public Guid? MutOperatorgroupidRid { get; set; }
        public DateTime? MutOnholddatum { get; set; }
        public bool MutOnholddatumAct { get; set; }
        public Guid? MutOnholddatumRid { get; set; }
        public Guid? MutImpactid { get; set; }
        public Guid? MutImpactidRid { get; set; }
        public bool MutImpactidAct { get; set; }
        public Guid? MutUrgencyid { get; set; }
        public Guid? MutUrgencyidRid { get; set; }
        public bool MutUrgencyidAct { get; set; }
        public Guid? MutPriorityid { get; set; }
        public Guid? MutPriorityidRid { get; set; }
        public bool MutPriorityidAct { get; set; }
        public Guid? MutSupplierid { get; set; }
        public bool MutSupplieridAct { get; set; }
        public Guid? MutSupplieridRid { get; set; }
        public int Importtype { get; set; }
        public string Importid { get; set; }
        public DateTime? Importdate { get; set; }

        public Afhandelingstatus MutAfhandelingstatus { get; set; }
        public Mutatiereden MutAfhandelingstatusidR { get; set; }
        public Mutatiereden MutDatumafgemeldR { get; set; }
        public Mutatiereden MutDatumafspraakR { get; set; }
        public Mutatiereden MutDatumgereedR { get; set; }
        public Impact MutImpact { get; set; }
        public Mutatiereden MutImpactidR { get; set; }
        public Mutatiereden MutOnholddatumR { get; set; }
        public Actiedoor MutOperator { get; set; }
        public Actiedoor MutOperatorgroup { get; set; }
        public Mutatiereden MutOperatorgroupidR { get; set; }
        public Mutatiereden MutOperatoridR { get; set; }
        public Priority MutPriority { get; set; }
        public Mutatiereden MutPriorityidR { get; set; }
        public Leverancier MutSupplier { get; set; }
        public Mutatiereden MutSupplieridR { get; set; }
        public Urgency MutUrgency { get; set; }
        public Mutatiereden MutUrgencyidR { get; set; }
        public Incident Parent { get; set; }
        public Gebruiker UidwijzigNavigation { get; set; }
    }
}
