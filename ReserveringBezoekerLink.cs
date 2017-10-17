using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class ReserveringBezoekerLink
    {
        public Guid Unid { get; set; }
        public Guid Reserveringid { get; set; }
        public Guid Bezoekerid { get; set; }

        public Bezoeker Bezoeker { get; set; }
        public Reservering Reservering { get; set; }
    }
}
