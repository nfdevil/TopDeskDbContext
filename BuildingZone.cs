using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class BuildingZone
    {
        public BuildingZone()
        {
            Locatie = new HashSet<Locatie>();
        }

        public Guid Unid { get; set; }
        public Guid Branchid { get; set; }
        public string Naam { get; set; }
        public int Rang { get; set; }
        public int Archief { get; set; }
        public string Bespokememo { get; set; }

        public Vestiging Branch { get; set; }
        public ICollection<Locatie> Locatie { get; set; }
    }
}
