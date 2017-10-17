using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class TimeRegistrationReason
    {
        public TimeRegistrationReason()
        {
            TimeRegistrationChange = new HashSet<TimeRegistrationChange>();
            TimeRegistrationChangeactivity = new HashSet<TimeRegistrationChangeactivity>();
            TimeRegistrationIncident = new HashSet<TimeRegistrationIncident>();
            TimeRegistrationOmActiviteit = new HashSet<TimeRegistrationOmActiviteit>();
            TimeRegistrationProbleem = new HashSet<TimeRegistrationProbleem>();
            TimeRegistrationProfacboomProject = new HashSet<TimeRegistrationProfacboomProject>();
        }

        public Guid Unid { get; set; }
        public int Rang { get; set; }
        public string Naam { get; set; }
        public string Bespokememo { get; set; }
        public int Archief { get; set; }

        public ICollection<TimeRegistrationChange> TimeRegistrationChange { get; set; }
        public ICollection<TimeRegistrationChangeactivity> TimeRegistrationChangeactivity { get; set; }
        public ICollection<TimeRegistrationIncident> TimeRegistrationIncident { get; set; }
        public ICollection<TimeRegistrationOmActiviteit> TimeRegistrationOmActiviteit { get; set; }
        public ICollection<TimeRegistrationProbleem> TimeRegistrationProbleem { get; set; }
        public ICollection<TimeRegistrationProfacboomProject> TimeRegistrationProfacboomProject { get; set; }
    }
}
