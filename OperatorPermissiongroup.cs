using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class OperatorPermissiongroup
    {
        public Guid Operatorid { get; set; }
        public Guid Permissiongroupid { get; set; }
        public Guid Unid { get; set; }
        public int Importtype { get; set; }
        public string Importid { get; set; }
        public DateTime? Importdate { get; set; }

        public Actiedoor Operator { get; set; }
        public Gebruiker Permissiongroup { get; set; }
    }
}
