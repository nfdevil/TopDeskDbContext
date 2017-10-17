using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class KostendeclaratieArtikel
    {
        public Guid Unid { get; set; }
        public DateTime? Dataanmk { get; set; }
        public DateTime? Datwijzig { get; set; }
        public Guid? Uidaanmk { get; set; }
        public Guid? Uidwijzig { get; set; }
        public Guid? Incidentid { get; set; }
        public DateTime Datum { get; set; }
        public Guid? Artikelmutatieid { get; set; }
        public decimal Prijs { get; set; }
        public decimal Totaalprijs { get; set; }
        public string Aantekeningen { get; set; }
        public int Importtype { get; set; }
        public string Importid { get; set; }
        public DateTime? Importdate { get; set; }

        public ArtikelMutatie Artikelmutatie { get; set; }
        public Incident Incident { get; set; }
        public Gebruiker UidaanmkNavigation { get; set; }
        public Gebruiker UidwijzigNavigation { get; set; }
    }
}
