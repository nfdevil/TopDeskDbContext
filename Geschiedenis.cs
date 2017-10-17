using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Geschiedenis
    {
        public Geschiedenis()
        {
            Geschiedenismutatieredenlink = new HashSet<Geschiedenismutatieredenlink>();
        }

        public bool Actief { get; set; }
        public bool Bestedetijdvragen { get; set; }
        public string Naam { get; set; }
        public bool Redenvragen { get; set; }
        public Guid? Standaardredenid { get; set; }
        public string Structurename { get; set; }
        public string Tabelstatus { get; set; }
        public Guid Unid { get; set; }
        public string Veldnaam { get; set; }

        public Mutatiereden Standaardreden { get; set; }
        public ICollection<Geschiedenismutatieredenlink> Geschiedenismutatieredenlink { get; set; }
    }
}
