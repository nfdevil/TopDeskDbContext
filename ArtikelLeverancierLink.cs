using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class ArtikelLeverancierLink
    {
        public string Bestelcode { get; set; }
        public Guid? Btwsoortid { get; set; }
        public int Levertijd { get; set; }
        public int Minimumbestelling { get; set; }
        public string RefLeverancier { get; set; }
        public bool Standaardleverancier { get; set; }
        public Guid Unid { get; set; }
        public string Voorwaarde { get; set; }
        public int Status { get; set; }
        public decimal Prijs { get; set; }
        public Guid Artikelid { get; set; }
        public Guid Leverancierid { get; set; }
        public double Korting { get; set; }
        public string Bespokememo { get; set; }
        public int Importtype { get; set; }
        public string Importid { get; set; }
        public DateTime? Importdate { get; set; }

        public Object Artikel { get; set; }
        public Btw Btwsoort { get; set; }
        public Leverancier Leverancier { get; set; }
    }
}
