using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Dnolink
    {
        public Dnolink()
        {
            Incident = new HashSet<Incident>();
        }

        public bool RefAlgemeneafspraak { get; set; }
        public Guid? RefBudgethouderid { get; set; }
        public Guid? RefDomeinid { get; set; }
        public Guid? RefSoortmeldingid { get; set; }
        public Guid? RefSpecificatieid { get; set; }
        public Guid Unid { get; set; }
        public bool RefAlgemenevestigingafspraak { get; set; }
        public Guid? RefVestigingid { get; set; }
        public decimal Kosten { get; set; }
        public bool RefAlgemenebhouderafspraak { get; set; }
        public Guid Dnocontractid { get; set; }
        public Guid Dnodienstid { get; set; }
        public string RefNaam { get; set; }
        public string Bespokememo { get; set; }
        public Guid? Servicelevelid { get; set; }
        public int Importtype { get; set; }
        public string Importid { get; set; }
        public DateTime? Importdate { get; set; }

        public Dnocontract Dnocontract { get; set; }
        public Dnodienst Dnodienst { get; set; }
        public Budgethouder RefBudgethouder { get; set; }
        public Classificatie RefDomein { get; set; }
        public Soortmelding RefSoortmelding { get; set; }
        public Classificatie RefSpecificatie { get; set; }
        public Vestiging RefVestiging { get; set; }
        public Servicelevel Servicelevel { get; set; }
        public ICollection<Incident> Incident { get; set; }
    }
}
