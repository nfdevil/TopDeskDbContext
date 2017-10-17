using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Attentie
    {
        public Attentie()
        {
            Actiedoor = new HashSet<Actiedoor>();
            Hardware = new HashSet<Hardware>();
            Inventaris = new HashSet<Inventaris>();
            Netwerkcomponent = new HashSet<Netwerkcomponent>();
            Object = new HashSet<Object>();
            Persoon = new HashSet<Persoon>();
            Software = new HashSet<Software>();
            Telefonie = new HashSet<Telefonie>();
            Vestiging = new HashSet<Vestiging>();
            Vrij1object = new HashSet<Vrij1object>();
            Vrij2object = new HashSet<Vrij2object>();
            Vrij3object = new HashSet<Vrij3object>();
            Vrij4object = new HashSet<Vrij4object>();
            Vrij5object = new HashSet<Vrij5object>();
        }

        public int Kleur { get; set; }
        public int Rang { get; set; }
        public Guid Unid { get; set; }
        public string Naam { get; set; }
        public string Bespokememo { get; set; }
        public int Archief { get; set; }

        public ICollection<Actiedoor> Actiedoor { get; set; }
        public ICollection<Hardware> Hardware { get; set; }
        public ICollection<Inventaris> Inventaris { get; set; }
        public ICollection<Netwerkcomponent> Netwerkcomponent { get; set; }
        public ICollection<Object> Object { get; set; }
        public ICollection<Persoon> Persoon { get; set; }
        public ICollection<Software> Software { get; set; }
        public ICollection<Telefonie> Telefonie { get; set; }
        public ICollection<Vestiging> Vestiging { get; set; }
        public ICollection<Vrij1object> Vrij1object { get; set; }
        public ICollection<Vrij2object> Vrij2object { get; set; }
        public ICollection<Vrij3object> Vrij3object { get; set; }
        public ICollection<Vrij4object> Vrij4object { get; set; }
        public ICollection<Vrij5object> Vrij5object { get; set; }
    }
}
