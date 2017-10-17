using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Changeauthorization
    {
        public DateTime? Authorizationdate { get; set; }
        public int Authorized { get; set; }
        public Guid? Byoperatorid { get; set; }
        public Guid? Bypersonid { get; set; }
        public Guid Changeid { get; set; }
        public DateTime? Datwijzig { get; set; }
        public string Importid { get; set; }
        public Guid? Uidwijzig { get; set; }
        public Guid Unid { get; set; }
        public int Oldphase { get; set; }
        public int Newphase { get; set; }
        public string Bespokememo { get; set; }
        public int Importtype { get; set; }
        public DateTime? Importdate { get; set; }

        public Actiedoor Byoperator { get; set; }
        public Persoon Byperson { get; set; }
        public Change Change { get; set; }
        public Gebruiker UidwijzigNavigation { get; set; }
    }
}
