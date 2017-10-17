using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class ChangeGroup
    {
        public ChangeGroup()
        {
            ChangeTemplActivityLink = new HashSet<ChangeTemplActivityLink>();
            Changeactivity = new HashSet<Changeactivity>();
            Changegrouplink = new HashSet<Changegrouplink>();
            Changetemplategrouplink = new HashSet<Changetemplategrouplink>();
        }

        public int Archief { get; set; }
        public int Color { get; set; }
        public bool Linkable { get; set; }
        public string Name { get; set; }
        public Guid Unid { get; set; }

        public ICollection<ChangeTemplActivityLink> ChangeTemplActivityLink { get; set; }
        public ICollection<Changeactivity> Changeactivity { get; set; }
        public ICollection<Changegrouplink> Changegrouplink { get; set; }
        public ICollection<Changetemplategrouplink> Changetemplategrouplink { get; set; }
    }
}
