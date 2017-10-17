using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class ProfacboomprojectChangeLink
    {
        public Guid Projectid { get; set; }
        public Guid Changeid { get; set; }
        public Guid Unid { get; set; }

        public Change Change { get; set; }
        public ProfacboomProject Project { get; set; }
    }
}
