﻿using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class SwStatus
    {
        public SwStatus()
        {
            Servicewindow = new HashSet<Servicewindow>();
        }

        public Guid Unid { get; set; }
        public int Archief { get; set; }
        public string Naam { get; set; }
        public string Bespokememo { get; set; }
        public int Rang { get; set; }

        public ICollection<Servicewindow> Servicewindow { get; set; }
    }
}
