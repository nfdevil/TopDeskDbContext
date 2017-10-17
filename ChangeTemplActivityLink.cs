using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class ChangeTemplActivityLink
    {
        public Guid Activityid { get; set; }
        public Guid Templateid { get; set; }
        public Guid Unid { get; set; }
        public Guid? Groupid { get; set; }
        public string Bespokememo { get; set; }
        public int Importtype { get; set; }
        public string Importid { get; set; }
        public DateTime? Importdate { get; set; }

        public ChangeActivitytemplate Activity { get; set; }
        public ChangeGroup Group { get; set; }
        public ChangeTemplate Template { get; set; }
    }
}
