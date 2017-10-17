using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Reportwizard
    {
        public Reportwizard()
        {
            Reportaction = new HashSet<Reportaction>();
        }

        public string Aantekeningen { get; set; }
        public DateTime? Dataanmk { get; set; }
        public DateTime? Datwijzig { get; set; }
        public string Kaart { get; set; }
        public string Naam { get; set; }
        public string Omschr { get; set; }
        public int Status { get; set; }
        public Guid? Uidaanmk { get; set; }
        public Guid? Uidwijzig { get; set; }
        public Guid Unid { get; set; }
        public int Voorwiecode { get; set; }
        public Guid? Roleid { get; set; }
        public string Bespokememo { get; set; }
        public Guid? Selectionid { get; set; }

        public Gebruiker Role { get; set; }
        public Selvast Selection { get; set; }
        public Gebruiker UidaanmkNavigation { get; set; }
        public Gebruiker UidwijzigNavigation { get; set; }
        public ICollection<Reportaction> Reportaction { get; set; }
    }
}
