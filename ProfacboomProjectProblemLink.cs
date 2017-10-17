using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class ProfacboomProjectProblemLink
    {
        public Guid Projectitemid { get; set; }
        public Guid Problemid { get; set; }
        public Guid Unid { get; set; }

        public Probleem Problem { get; set; }
        public ProfacboomProject Projectitem { get; set; }
    }
}
