using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Lmppattern
    {
        public Lmppattern()
        {
            Lmpplanning = new HashSet<Lmpplanning>();
        }

        public Guid Unid { get; set; }
        public Guid Lmplinkid { get; set; }
        public int Startyear { get; set; }
        public int Endyear { get; set; }
        public int Cycle { get; set; }
        public string Importid { get; set; }
        public string Bespokememo { get; set; }
        public int Importtype { get; set; }
        public DateTime? Importdate { get; set; }

        public Lmplink Lmplink { get; set; }
        public ICollection<Lmpplanning> Lmpplanning { get; set; }
    }
}
