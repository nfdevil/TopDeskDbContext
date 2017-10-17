using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class ChangeObjectLink
    {
        public Guid Changeid { get; set; }
        public Guid Objectid { get; set; }
        public Guid Unid { get; set; }
        public string Bespokememo { get; set; }
        public int Importtype { get; set; }
        public string Importid { get; set; }
        public DateTime? Importdate { get; set; }

        public Change Change { get; set; }
        public Object Object { get; set; }
    }
}
