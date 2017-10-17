using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Scheduleshiftlink
    {
        public Guid Unid { get; set; }
        public Guid Scheduleid { get; set; }
        public Guid Shiftid { get; set; }
        public int Dayofschedule { get; set; }

        public Schedule Schedule { get; set; }
        public Shift Shift { get; set; }
    }
}
