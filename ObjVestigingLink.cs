using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class ObjVestigingLink
    {
        public Guid Unid { get; set; }
        public Guid Objectid { get; set; }
        public Guid Vestigingid { get; set; }
        public Guid? Locatieid { get; set; }
        public string Bespokememo { get; set; }
        public int Importtype { get; set; }
        public string Importid { get; set; }
        public DateTime? Importdate { get; set; }

        public Locatie Locatie { get; set; }
        public Object Object { get; set; }
        public Vestiging Vestiging { get; set; }
    }
}
