using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class ClassificatieTranslation
    {
        public Guid Unid { get; set; }
        public Guid Entityid { get; set; }
        public Guid Localeid { get; set; }
        public string Name { get; set; }
        public int? Rank { get; set; }
        public string Bespokememo { get; set; }
        public string Importid { get; set; }
        public int Importtype { get; set; }
        public DateTime? Importdate { get; set; }

        public Classificatie Entity { get; set; }
        public Kennistaal Locale { get; set; }
    }
}
