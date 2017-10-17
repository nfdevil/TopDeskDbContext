using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class ProjectdocumentkoppelProject
    {
        public Guid Unid { get; set; }
        public Guid Documentid { get; set; }
        public Guid Projectbeheerid { get; set; }

        public Projectbeheerdocumenten Document { get; set; }
        public ProfacboomProject Projectbeheer { get; set; }
    }
}
