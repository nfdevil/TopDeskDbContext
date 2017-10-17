using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Soortaansluiting
    {
        public Soortaansluiting()
        {
            Configuratie = new HashSet<Configuratie>();
        }

        public int Rang { get; set; }
        public Guid Unid { get; set; }
        public string Naam { get; set; }
        public string Bespokememo { get; set; }
        public int Archief { get; set; }

        public ICollection<Configuratie> Configuratie { get; set; }
    }
}
