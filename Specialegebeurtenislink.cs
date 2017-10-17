using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Specialegebeurtenislink
    {
        public string Code { get; set; }
        public string Tabelstatus { get; set; }
        public string Type { get; set; }
        public Guid Unid { get; set; }
        public Guid? Actieid { get; set; }
        public long Entityversion { get; set; }
    }
}
