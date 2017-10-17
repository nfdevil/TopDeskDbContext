using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class ChangeProblemCausedbyLink
    {
        public Guid Changeid { get; set; }
        public Guid Problemid { get; set; }
        public Guid Unid { get; set; }

        public Change Change { get; set; }
        public Probleem Problem { get; set; }
    }
}
