using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Translations
    {
        public Guid Unid { get; set; }
        public Guid LanguageId { get; set; }
        public string Context { get; set; }
        public string ResourceKey { get; set; }
        public string Translation { get; set; }
        public string Bespokememo { get; set; }

        public Kennistaal Language { get; set; }
    }
}
