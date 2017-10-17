using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class SsdFormTranslations
    {
        public Guid Unid { get; set; }
        public Guid Formid { get; set; }
        public Guid? Localeid { get; set; }
        public string Translation { get; set; }
        public string Title { get; set; }
        public bool Published { get; set; }
        public string Bespokememo { get; set; }
        public int Importtype { get; set; }
        public string Importid { get; set; }
        public DateTime? Importdate { get; set; }

        public SsdForm Form { get; set; }
        public Kennistaal Locale { get; set; }
    }
}
