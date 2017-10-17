using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Changetemplategrouplink
    {
        public Guid Changetemplateid { get; set; }
        public Guid Groupid { get; set; }
        public Guid Unid { get; set; }

        public ChangeTemplate Changetemplate { get; set; }
        public ChangeGroup Group { get; set; }
    }
}
