using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class OmStatus
    {
        public OmStatus()
        {
            MutatieOmReeks = new HashSet<MutatieOmReeks>();
            MutatieOmSchema = new HashSet<MutatieOmSchema>();
            OmReeks = new HashSet<OmReeks>();
            OmSchema = new HashSet<OmSchema>();
        }

        public Guid Unid { get; set; }
        public int Archief { get; set; }
        public int Rang { get; set; }
        public string Naam { get; set; }
        public string Bespokememo { get; set; }

        public ICollection<MutatieOmReeks> MutatieOmReeks { get; set; }
        public ICollection<MutatieOmSchema> MutatieOmSchema { get; set; }
        public ICollection<OmReeks> OmReeks { get; set; }
        public ICollection<OmSchema> OmSchema { get; set; }
    }
}
