using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class MutatieVrij1object
    {
        public Guid Unid { get; set; }
        public DateTime? Datwijzig { get; set; }
        public int MutStatus { get; set; }
        public Guid? Parentid { get; set; }
        public Guid? Uidwijzig { get; set; }
        public Guid? MutConfiguratieid { get; set; }
        public bool MutConfiguratieidAct { get; set; }
        public Guid? MutConfiguratieidRid { get; set; }
        public Guid? MutLokatieid { get; set; }
        public bool MutLokatieidAct { get; set; }
        public Guid? MutLokatieidRid { get; set; }
        public Guid? MutPersoongroepid { get; set; }
        public bool MutPersoongroepidAct { get; set; }
        public Guid? MutPersoongroepidRid { get; set; }
        public Guid? MutPersoonid { get; set; }
        public bool MutPersoonidAct { get; set; }
        public Guid? MutPersoonidRid { get; set; }
        public Guid? MutVestigingid { get; set; }
        public bool MutVestigingidAct { get; set; }
        public Guid? MutVestigingidRid { get; set; }
        public int Importtype { get; set; }
        public string Importid { get; set; }
        public DateTime? Importdate { get; set; }

        public Configuratie MutConfiguratie { get; set; }
        public Mutatiereden MutConfiguratieidR { get; set; }
        public Locatie MutLokatie { get; set; }
        public Mutatiereden MutLokatieidR { get; set; }
        public Persoon MutPersoon { get; set; }
        public Persoongroep MutPersoongroep { get; set; }
        public Mutatiereden MutPersoongroepidR { get; set; }
        public Mutatiereden MutPersoonidR { get; set; }
        public Vestiging MutVestiging { get; set; }
        public Mutatiereden MutVestigingidR { get; set; }
        public Vrij1object Parent { get; set; }
        public Gebruiker UidwijzigNavigation { get; set; }
    }
}
