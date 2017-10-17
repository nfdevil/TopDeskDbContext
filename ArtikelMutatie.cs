using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class ArtikelMutatie
    {
        public ArtikelMutatie()
        {
            KostendeclaratieArtikel = new HashSet<KostendeclaratieArtikel>();
        }

        public int Aantal { get; set; }
        public Guid? Artikelbestellinkid { get; set; }
        public Guid? Artikelid { get; set; }
        public Guid? Budgethouderid { get; set; }
        public Guid? Mutatieredenid { get; set; }
        public string Opmerking { get; set; }
        public int Tussenvoorraad { get; set; }
        public Guid Unid { get; set; }
        public DateTime? Dataanmk { get; set; }
        public DateTime? Datum { get; set; }
        public Guid? Uidaanmk { get; set; }
        public Guid? Voorraadid { get; set; }
        public Guid? Bestelaanvraagartikellinkid { get; set; }
        public Guid? Kostendeclaratieleverancierid { get; set; }
        public int Importtype { get; set; }
        public string Importid { get; set; }
        public DateTime? Importdate { get; set; }

        public Object Artikel { get; set; }
        public ArtikelBestelLink Artikelbestellink { get; set; }
        public BestelaanvraagArtikelLink Bestelaanvraagartikellink { get; set; }
        public Budgethouder Budgethouder { get; set; }
        public Leverancier Kostendeclaratieleverancier { get; set; }
        public Artikelmutatiereden Mutatiereden { get; set; }
        public Gebruiker UidaanmkNavigation { get; set; }
        public Configuratie Voorraad { get; set; }
        public ICollection<KostendeclaratieArtikel> KostendeclaratieArtikel { get; set; }
    }
}
