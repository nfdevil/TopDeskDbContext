using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Lmpindex
    {
        public Guid Unid { get; set; }
        public int Year { get; set; }
        public decimal Indexvalue { get; set; }
        public Guid? Lmpworktypeid { get; set; }

        public Lmpworktype Lmpworktype { get; set; }
    }
}
