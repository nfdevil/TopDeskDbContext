using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Changegrouplink
    {
        public Guid Changeid { get; set; }
        public Guid Groupid { get; set; }
        public Guid Unid { get; set; }

        public Change Change { get; set; }
        public ChangeGroup Group { get; set; }
    }
}
