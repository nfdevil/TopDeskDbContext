using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class ReserveringPersoonLink
    {
        public Guid Unid { get; set; }
        public Guid Reserveringid { get; set; }
        public Guid Persoonid { get; set; }

        public Persoon Persoon { get; set; }
        public Reservering Reservering { get; set; }
    }
}
