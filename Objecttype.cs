using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Objecttype
    {
        public Objecttype()
        {
            Hardware = new HashSet<Hardware>();
            Inventaris = new HashSet<Inventaris>();
            Netwerkcomponent = new HashSet<Netwerkcomponent>();
            Object = new HashSet<Object>();
            Telefonie = new HashSet<Telefonie>();
            Vrij1object = new HashSet<Vrij1object>();
            Vrij2object = new HashSet<Vrij2object>();
            Vrij3object = new HashSet<Vrij3object>();
            Vrij4object = new HashSet<Vrij4object>();
            Vrij5object = new HashSet<Vrij5object>();
        }

        public int Archief { get; set; }
        public int Rang { get; set; }
        public Guid Unid { get; set; }
        public string Code { get; set; }
        public Guid? Soortid { get; set; }
        public Guid? Merkid { get; set; }
        public string Bespokememo { get; set; }
        public string Naam { get; set; }

        public Objectmerk Merk { get; set; }
        public Objectsoort Soort { get; set; }
        public ICollection<Hardware> Hardware { get; set; }
        public ICollection<Inventaris> Inventaris { get; set; }
        public ICollection<Netwerkcomponent> Netwerkcomponent { get; set; }
        public ICollection<Object> Object { get; set; }
        public ICollection<Telefonie> Telefonie { get; set; }
        public ICollection<Vrij1object> Vrij1object { get; set; }
        public ICollection<Vrij2object> Vrij2object { get; set; }
        public ICollection<Vrij3object> Vrij3object { get; set; }
        public ICollection<Vrij4object> Vrij4object { get; set; }
        public ICollection<Vrij5object> Vrij5object { get; set; }
    }
}
