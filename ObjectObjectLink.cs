using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class ObjectObjectLink
    {
        public Guid Unid { get; set; }
        public Guid Parentid { get; set; }
        public Guid Childid { get; set; }
        public string Bespokememo { get; set; }
        public int Importtype { get; set; }
        public string Importid { get; set; }
        public DateTime? Importdate { get; set; }

        public Object Child { get; set; }
        public Object Parent { get; set; }
    }
}
