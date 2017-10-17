using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Shiftoperatorgrouplink
    {
        public Guid Unid { get; set; }
        public Guid Shiftid { get; set; }
        public Guid Operatorgroupid { get; set; }

        public Actiedoor Operatorgroup { get; set; }
        public Shift Shift { get; set; }
    }
}
