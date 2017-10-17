using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class MutatieConfiguratie
    {
        public Guid? MutPersoongroepid { get; set; }
        public Guid? MutPersoonid { get; set; }
        public int MutStatus { get; set; }
        public Guid? Parentid { get; set; }
        public Guid? Uidwijzig { get; set; }
        public Guid Unid { get; set; }
        public DateTime? Datwijzig { get; set; }
        public bool MutPersoongroepidAct { get; set; }
        public Guid? MutPersoongroepidRid { get; set; }
        public bool MutPersoonidAct { get; set; }
        public Guid? MutPersoonidRid { get; set; }
        public int Importtype { get; set; }
        public string Importid { get; set; }
        public DateTime? Importdate { get; set; }

        public Persoon MutPersoon { get; set; }
        public Persoongroep MutPersoongroep { get; set; }
        public Mutatiereden MutPersoongroepidR { get; set; }
        public Mutatiereden MutPersoonidR { get; set; }
        public Configuratie Parent { get; set; }
        public Gebruiker UidwijzigNavigation { get; set; }
    }
}
