using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class ProfacboomProjectafhankelijkheden
    {
        public bool Aansluiten { get; set; }
        public Guid Unid { get; set; }
        public Guid Kopid { get; set; }
        public Guid Staartid { get; set; }

        public ProfacboomProject Kop { get; set; }
        public ProfacboomProject Staart { get; set; }
    }
}
