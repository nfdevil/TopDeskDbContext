using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Dnocontractstatus
    {
        public Dnocontractstatus()
        {
            Dnocontract = new HashSet<Dnocontract>();
            MutatieDnocontract = new HashSet<MutatieDnocontract>();
        }

        public Guid Unid { get; set; }
        public int Archief { get; set; }
        public int Rang { get; set; }
        public string Naam { get; set; }
        public string Bespokememo { get; set; }

        public ICollection<Dnocontract> Dnocontract { get; set; }
        public ICollection<MutatieDnocontract> MutatieDnocontract { get; set; }
    }
}
