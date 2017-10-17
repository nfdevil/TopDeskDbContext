using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Artikelmutatiereden
    {
        public Artikelmutatiereden()
        {
            ArtikelMutatie = new HashSet<ArtikelMutatie>();
        }

        public int Rang { get; set; }
        public Guid Unid { get; set; }
        public string Naam { get; set; }
        public string Bespokememo { get; set; }
        public int Archief { get; set; }

        public ICollection<ArtikelMutatie> ArtikelMutatie { get; set; }
    }
}
