using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Emailberichtbestand
    {
        public string Bestandsnaam { get; set; }
        public Guid? Emailid { get; set; }
        public Guid Unid { get; set; }
        public int Importtype { get; set; }
        public string Importid { get; set; }
        public DateTime? Importdate { get; set; }

        public Emailbericht Email { get; set; }
    }
}
