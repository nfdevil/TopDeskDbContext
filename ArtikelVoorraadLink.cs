using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class ArtikelVoorraadLink
    {
        public Guid Voorraadid { get; set; }
        public Guid Artikelid { get; set; }
        public int Voorraad { get; set; }
        public string Omschrijving { get; set; }
        public Guid Unid { get; set; }
        public string Bespokememo { get; set; }
        public int Importtype { get; set; }
        public string Importid { get; set; }
        public DateTime? Importdate { get; set; }

        public Object Artikel { get; set; }
        public Configuratie VoorraadNavigation { get; set; }
    }
}
