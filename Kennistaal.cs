using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Kennistaal
    {
        public Kennistaal()
        {
            Actiedoor = new HashSet<Actiedoor>();
            ClassificatieTranslation = new HashSet<ClassificatieTranslation>();
            Kennissysteemvertalingen = new HashSet<Kennissysteemvertalingen>();
            Persoon = new HashSet<Persoon>();
            SsdFormTranslations = new HashSet<SsdFormTranslations>();
            Translations = new HashSet<Translations>();
        }

        public int Rang { get; set; }
        public string Taalcode { get; set; }
        public Guid Unid { get; set; }
        public string Naam { get; set; }
        public string Bespokememo { get; set; }
        public int Archief { get; set; }

        public ICollection<Actiedoor> Actiedoor { get; set; }
        public ICollection<ClassificatieTranslation> ClassificatieTranslation { get; set; }
        public ICollection<Kennissysteemvertalingen> Kennissysteemvertalingen { get; set; }
        public ICollection<Persoon> Persoon { get; set; }
        public ICollection<SsdFormTranslations> SsdFormTranslations { get; set; }
        public ICollection<Translations> Translations { get; set; }
    }
}
