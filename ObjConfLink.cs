using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class ObjConfLink
    {
        public Guid? Groepid { get; set; }
        public bool Isfileserver { get; set; }
        public bool Isvoorraadlink { get; set; }
        public Guid? RefPersoongroepid { get; set; }
        public Guid? RefPersoonid { get; set; }
        public Guid Unid { get; set; }
        public Guid Objectid { get; set; }
        public Guid Configuratieid { get; set; }
        public string RefObjectnaam { get; set; }
        public string Bespokememo { get; set; }
        public int Importtype { get; set; }
        public string Importid { get; set; }
        public DateTime? Importdate { get; set; }

        public Configuratie Configuratie { get; set; }
        public Persoongroep Groep { get; set; }
        public Object Object { get; set; }
        public Persoon RefPersoon { get; set; }
        public Persoongroep RefPersoongroep { get; set; }
    }
}
