using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Soort
    {
        public bool Aanmaak { get; set; }
        public int Archief { get; set; }
        public bool Archiveer { get; set; }
        public bool Lezen { get; set; }
        public Guid? Rechtid { get; set; }
        public bool Schrijven { get; set; }
        public Guid Unid { get; set; }
        public Guid? Usergroepid { get; set; }
        public bool Verw { get; set; }
        public bool Wijzig { get; set; }
        public bool Selectie { get; set; }
        public int Importtype { get; set; }
        public string Importid { get; set; }
        public DateTime? Importdate { get; set; }

        public Recht Recht { get; set; }
        public Gebruiker Usergroep { get; set; }
    }
}
