using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Gebruikersinstellingen
    {
        public Guid? Gebruikerid { get; set; }
        public string Instelling { get; set; }
        public string Instellingnaam { get; set; }
        public Guid Unid { get; set; }
    }
}
