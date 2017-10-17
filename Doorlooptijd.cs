using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Doorlooptijd
    {
        public Doorlooptijd()
        {
            DnodienstDoorlooptijdlijn1 = new HashSet<Dnodienst>();
            DnodienstDoorlooptijdlijn2 = new HashSet<Dnodienst>();
            Incident = new HashSet<Incident>();
            OplossingenDoorlooptijdlijn1 = new HashSet<Oplossingen>();
            OplossingenDoorlooptijdlijn2 = new HashSet<Oplossingen>();
            PriorityLine1duration = new HashSet<Priority>();
            PriorityLine2duration = new HashSet<Priority>();
            ServicelevelLine1duration = new HashSet<Servicelevel>();
            ServicelevelLine2duration = new HashSet<Servicelevel>();
            ServicelevelPrioritylinkLine1duration = new HashSet<ServicelevelPrioritylink>();
            ServicelevelPrioritylinkLine2duration = new HashSet<ServicelevelPrioritylink>();
        }

        public int Aantal { get; set; }
        public int Rang { get; set; }
        public Guid Unid { get; set; }
        public string Bespokememo { get; set; }
        public string Naam { get; set; }
        public int Archief { get; set; }
        public int Type { get; set; }
        public bool InFirstLine { get; set; }
        public bool InSecondLine { get; set; }

        public ICollection<Dnodienst> DnodienstDoorlooptijdlijn1 { get; set; }
        public ICollection<Dnodienst> DnodienstDoorlooptijdlijn2 { get; set; }
        public ICollection<Incident> Incident { get; set; }
        public ICollection<Oplossingen> OplossingenDoorlooptijdlijn1 { get; set; }
        public ICollection<Oplossingen> OplossingenDoorlooptijdlijn2 { get; set; }
        public ICollection<Priority> PriorityLine1duration { get; set; }
        public ICollection<Priority> PriorityLine2duration { get; set; }
        public ICollection<Servicelevel> ServicelevelLine1duration { get; set; }
        public ICollection<Servicelevel> ServicelevelLine2duration { get; set; }
        public ICollection<ServicelevelPrioritylink> ServicelevelPrioritylinkLine1duration { get; set; }
        public ICollection<ServicelevelPrioritylink> ServicelevelPrioritylinkLine2duration { get; set; }
    }
}
