using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class BestelaanvraagArtikelLink
    {
        public BestelaanvraagArtikelLink()
        {
            ArtikelMutatie = new HashSet<ArtikelMutatie>();
        }

        public int Aantal { get; set; }
        public bool Geaccepteerd { get; set; }
        public Guid? Leverancierid { get; set; }
        public Guid Unid { get; set; }
        public Guid Artikelid { get; set; }
        public Guid Bestelaanvraagid { get; set; }
        public int Aantaluitgeleverd { get; set; }
        public decimal Verkoopprijs { get; set; }
        public string Bespokememo { get; set; }
        public int Importtype { get; set; }
        public string Importid { get; set; }
        public DateTime? Importdate { get; set; }

        public Object Artikel { get; set; }
        public Bestelaanvraag Bestelaanvraag { get; set; }
        public Leverancier Leverancier { get; set; }
        public ICollection<ArtikelMutatie> ArtikelMutatie { get; set; }
    }
}
