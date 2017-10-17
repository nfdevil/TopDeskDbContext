using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class OplossingenEmailberichten
    {
        public Guid? Emailid { get; set; }
        public Guid? Kaartid { get; set; }
        public Guid Unid { get; set; }

        public Emailbericht Email { get; set; }
        public Oplossingen Kaart { get; set; }
    }
}
