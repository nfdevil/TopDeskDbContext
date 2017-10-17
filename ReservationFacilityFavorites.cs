using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class ReservationFacilityFavorites
    {
        public Guid Unid { get; set; }
        public Guid Userid { get; set; }
        public string Definitionname { get; set; }
        public Guid Cardidentifier { get; set; }

        public Gebruiker User { get; set; }
    }
}
