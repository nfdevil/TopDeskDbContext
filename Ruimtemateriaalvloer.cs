﻿using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Ruimtemateriaalvloer
    {
        public Ruimtemateriaalvloer()
        {
            Locatie = new HashSet<Locatie>();
        }

        public int Archief { get; set; }
        public string Naam { get; set; }
        public Guid Unid { get; set; }
        public int Rang { get; set; }
        public string Bespokememo { get; set; }

        public ICollection<Locatie> Locatie { get; set; }
    }
}
