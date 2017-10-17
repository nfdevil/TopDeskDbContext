using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class ChangeActTemplDependency
    {
        public Guid Headid { get; set; }
        public bool Startautomatically { get; set; }
        public Guid Tailid { get; set; }
        public Guid Templateid { get; set; }
        public Guid Unid { get; set; }

        public ChangeActivitytemplate Head { get; set; }
        public ChangeActivitytemplate Tail { get; set; }
        public ChangeTemplate Template { get; set; }
    }
}
