using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Integration
    {
        public Guid Unid { get; set; }
        public Guid? Parentid { get; set; }
        public string Parenttable { get; set; }
        public string Linkname { get; set; }
        public string Linknumber { get; set; }
        public string Linktype { get; set; }
        public DateTime? Linkdate { get; set; }
        public bool? Linkisactive { get; set; }
        public string Importid { get; set; }
        public int Importtype { get; set; }
        public DateTime? Importdate { get; set; }
        public string Bespokememo { get; set; }
    }
}
