using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class MeasurementType
    {
        public MeasurementType()
        {
            BranchMeasurement = new HashSet<BranchMeasurement>();
        }

        public Guid Unid { get; set; }
        public string Naam { get; set; }
        public int Archief { get; set; }
        public int Rang { get; set; }
        public string Bespokememo { get; set; }
        public string UnitOfMeasure { get; set; }

        public ICollection<BranchMeasurement> BranchMeasurement { get; set; }
    }
}
