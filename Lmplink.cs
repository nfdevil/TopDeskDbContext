using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Lmplink
    {
        public Lmplink()
        {
            Lmppattern = new HashSet<Lmppattern>();
            Lmpplanning = new HashSet<Lmpplanning>();
        }

        public Guid Unid { get; set; }
        public Guid Scenarioid { get; set; }
        public Guid Activityid { get; set; }
        public double Quantity { get; set; }
        public int Unit { get; set; }
        public decimal Cost { get; set; }
        public string Importid { get; set; }
        public int Importtype { get; set; }
        public DateTime? Importdate { get; set; }
        public string Bespokememo { get; set; }
        public int Baseyear { get; set; }

        public Lmpactivity Activity { get; set; }
        public Lmpscenario Scenario { get; set; }
        public ICollection<Lmppattern> Lmppattern { get; set; }
        public ICollection<Lmpplanning> Lmpplanning { get; set; }
    }
}
