using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class OmSoort
    {
        public OmSoort()
        {
            OmActiviteit = new HashSet<OmActiviteit>();
            OmReeks = new HashSet<OmReeks>();
            OmSchema = new HashSet<OmSchema>();
        }

        public Guid Unid { get; set; }
        public int Archief { get; set; }
        public int Rang { get; set; }
        public string Naam { get; set; }
        public string Bespokememo { get; set; }

        public ICollection<OmActiviteit> OmActiviteit { get; set; }
        public ICollection<OmReeks> OmReeks { get; set; }
        public ICollection<OmSchema> OmSchema { get; set; }
    }
}
