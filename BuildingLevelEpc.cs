using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class BuildingLevelEpc
    {
        public BuildingLevelEpc()
        {
            MutatieVestiging = new HashSet<MutatieVestiging>();
            Vestiging = new HashSet<Vestiging>();
        }

        public Guid Unid { get; set; }
        public string Naam { get; set; }
        public int Archief { get; set; }
        public int Rang { get; set; }
        public string Bespokememo { get; set; }

        public ICollection<MutatieVestiging> MutatieVestiging { get; set; }
        public ICollection<Vestiging> Vestiging { get; set; }
    }
}
