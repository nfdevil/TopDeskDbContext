using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Settings
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
        public Guid? Userid { get; set; }
        public Guid? Personid { get; set; }
        public string Characters { get; set; }
        public string Text { get; set; }
        public int? Integer { get; set; }
        public DateTime? Date { get; set; }
        public double? Double { get; set; }
        public long? Long { get; set; }
        public bool? Boolean { get; set; }
        public decimal? Bigdecimal { get; set; }
        public byte[] Binary { get; set; }
        public Guid? Foreignid { get; set; }
        public string ForeignidTable { get; set; }

        public Persoon Person { get; set; }
        public Gebruiker User { get; set; }
    }
}
