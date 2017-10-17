using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Kennissysteemvertalingen
    {
        public string Aantekeningen { get; set; }
        public Guid? Kennisid { get; set; }
        public string Onderwerp { get; set; }
        public Guid? Taalid { get; set; }
        public string Trefwoorden { get; set; }
        public Guid Unid { get; set; }
        public string Naam { get; set; }
        public DateTime? Dataanmk { get; set; }
        public DateTime? Datwijzig { get; set; }
        public Guid? Uidaanmk { get; set; }
        public Guid? Uidwijzig { get; set; }
        public int Status { get; set; }
        public string Toelichting { get; set; }
        public int Importtype { get; set; }
        public string Importid { get; set; }
        public DateTime? Importdate { get; set; }
        public byte[] AantekeningenRtf { get; set; }
        public byte[] OnderwerpRtf { get; set; }
        public byte[] ToelichtingRtf { get; set; }

        public KennisSysteem Kennis { get; set; }
        public Kennistaal Taal { get; set; }
        public Gebruiker UidaanmkNavigation { get; set; }
        public Gebruiker UidwijzigNavigation { get; set; }
    }
}
