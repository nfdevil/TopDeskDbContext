using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class ArtikelBestelLink
    {
        public ArtikelBestelLink()
        {
            ArtikelMutatie = new HashSet<ArtikelMutatie>();
            Hardware = new HashSet<Hardware>();
            Inventaris = new HashSet<Inventaris>();
            Netwerkcomponent = new HashSet<Netwerkcomponent>();
            Software = new HashSet<Software>();
            Telefonie = new HashSet<Telefonie>();
            Vrij1object = new HashSet<Vrij1object>();
            Vrij2object = new HashSet<Vrij2object>();
            Vrij3object = new HashSet<Vrij3object>();
            Vrij4object = new HashSet<Vrij4object>();
            Vrij5object = new HashSet<Vrij5object>();
        }

        public int Aantal { get; set; }
        public Guid Unid { get; set; }
        public int Fase { get; set; }
        public decimal Artikelkorting { get; set; }
        public decimal Prijs { get; set; }
        public Guid Artikelid { get; set; }
        public Guid Bestellingid { get; set; }
        public Guid? Btwsoortid { get; set; }
        public int Aantalgeleverd { get; set; }
        public string Bespokememo { get; set; }
        public int Importtype { get; set; }
        public string Importid { get; set; }
        public DateTime? Importdate { get; set; }

        public Object Artikel { get; set; }
        public Bestellingen Bestelling { get; set; }
        public Btw Btwsoort { get; set; }
        public ICollection<ArtikelMutatie> ArtikelMutatie { get; set; }
        public ICollection<Hardware> Hardware { get; set; }
        public ICollection<Inventaris> Inventaris { get; set; }
        public ICollection<Netwerkcomponent> Netwerkcomponent { get; set; }
        public ICollection<Software> Software { get; set; }
        public ICollection<Telefonie> Telefonie { get; set; }
        public ICollection<Vrij1object> Vrij1object { get; set; }
        public ICollection<Vrij2object> Vrij2object { get; set; }
        public ICollection<Vrij3object> Vrij3object { get; set; }
        public ICollection<Vrij4object> Vrij4object { get; set; }
        public ICollection<Vrij5object> Vrij5object { get; set; }
    }
}
