using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Taskroleoperatorgrouplink
    {
        public Guid Unid { get; set; }
        public Guid Taskroleid { get; set; }
        public Guid Operatorgroupid { get; set; }

        public Actiedoor Operatorgroup { get; set; }
        public Taskrole Taskrole { get; set; }
    }
}
