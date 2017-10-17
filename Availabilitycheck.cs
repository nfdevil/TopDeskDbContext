using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Availabilitycheck
    {
        public Guid Unid { get; set; }
        public Guid Operatorgroupid { get; set; }
        public Guid Taskroleid { get; set; }
        public int Dayofweek { get; set; }
        public int Start { get; set; }
        public int End { get; set; }
        public int Minimum { get; set; }

        public Actiedoor Operatorgroup { get; set; }
        public Taskrole Taskrole { get; set; }
    }
}
