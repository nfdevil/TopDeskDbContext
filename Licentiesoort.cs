using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Licentiesoort
    {
        public Licentiesoort()
        {
            Licentie = new HashSet<Licentie>();
            Object = new HashSet<Object>();
            Software = new HashSet<Software>();
        }

        public int Rang { get; set; }
        public Guid Unid { get; set; }
        public string Naam { get; set; }
        public string Bespokememo { get; set; }
        public int Archief { get; set; }

        public ICollection<Licentie> Licentie { get; set; }
        public ICollection<Object> Object { get; set; }
        public ICollection<Software> Software { get; set; }
    }
}
