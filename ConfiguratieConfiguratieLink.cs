using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class ConfiguratieConfiguratieLink
    {
        public Guid Unid { get; set; }
        public Guid Parentid { get; set; }
        public Guid Childid { get; set; }

        public Configuratie Child { get; set; }
        public Configuratie Parent { get; set; }
    }
}
