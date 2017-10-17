using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Geschiedenismutatieredenlink
    {
        public Guid Unid { get; set; }
        public Guid Geschiedenisid { get; set; }
        public Guid Mutatieredenid { get; set; }

        public Geschiedenis Geschiedenis { get; set; }
        public Mutatiereden Mutatiereden { get; set; }
    }
}
