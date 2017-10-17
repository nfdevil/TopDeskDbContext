using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class ProfacboomProjectPersonLink
    {
        public Guid Projectitemid { get; set; }
        public Guid Personid { get; set; }
        public Guid Unid { get; set; }

        public Persoon Person { get; set; }
        public ProfacboomProject Projectitem { get; set; }
    }
}
