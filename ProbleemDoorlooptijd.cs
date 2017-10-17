using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class ProbleemDoorlooptijd
    {
        public ProbleemDoorlooptijd()
        {
            ProbleemDoorlooptijdNavigation = new HashSet<Probleem>();
            ProbleemDoorlooptijdbf = new HashSet<Probleem>();
            ProbleemRefcombiDoorlooptijd = new HashSet<Probleem>();
        }

        public Guid Unid { get; set; }
        public int Archief { get; set; }
        public int Type { get; set; }
        public int Rang { get; set; }
        public string Naam { get; set; }
        public string Bespokememo { get; set; }
        public int Aantal { get; set; }

        public ICollection<Probleem> ProbleemDoorlooptijdNavigation { get; set; }
        public ICollection<Probleem> ProbleemDoorlooptijdbf { get; set; }
        public ICollection<Probleem> ProbleemRefcombiDoorlooptijd { get; set; }
    }
}
