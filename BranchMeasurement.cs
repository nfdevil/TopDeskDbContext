using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class BranchMeasurement
    {
        public Guid Unid { get; set; }
        public DateTime? Dataanmk { get; set; }
        public DateTime? Datwijzig { get; set; }
        public Guid? Uidaanmk { get; set; }
        public Guid? Uidwijzig { get; set; }
        public int Status { get; set; }
        public double? Measurement { get; set; }
        public DateTime? Measurementdate { get; set; }
        public Guid Typeid { get; set; }
        public Guid Parentid { get; set; }
        public Guid? Personid { get; set; }
        public int Importtype { get; set; }
        public string Importid { get; set; }
        public DateTime? Importdate { get; set; }

        public Vestiging Parent { get; set; }
        public Persoon Person { get; set; }
        public MeasurementType Type { get; set; }
        public Gebruiker UidaanmkNavigation { get; set; }
        public Gebruiker UidwijzigNavigation { get; set; }
    }
}
