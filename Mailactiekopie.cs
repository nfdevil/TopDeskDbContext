using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Mailactiekopie
    {
        public Guid? Actieid { get; set; }
        public string Adres1 { get; set; }
        public string Sleutel { get; set; }
        public int Totype { get; set; }
        public Guid Unid { get; set; }
        public bool Verplicht { get; set; }
        public long Entityversion { get; set; }

        public Mailactie Actie { get; set; }
    }
}
