using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Actiedoorlink
    {
        public Guid Unid { get; set; }
        public Guid Actiedoorgroepid { get; set; }
        public Guid Actiedoorid { get; set; }
        public string Bespokememo { get; set; }
        public int Importtype { get; set; }
        public string Importid { get; set; }
        public DateTime? Importdate { get; set; }

        public Actiedoor Actiedoor { get; set; }
        public Actiedoor Actiedoorgroep { get; set; }
    }
}
