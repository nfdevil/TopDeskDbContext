using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Appointment
    {
        public Appointment()
        {
            AppointmentDocumenten = new HashSet<AppointmentDocumenten>();
            AppointmentEmailberichten = new HashSet<AppointmentEmailberichten>();
            AppointmentLogboek = new HashSet<AppointmentLogboek>();
            Change = new HashSet<Change>();
            Changeactivity = new HashSet<Changeactivity>();
            Incident = new HashSet<Incident>();
            OmActiviteit = new HashSet<OmActiviteit>();
            ProfacboomProject = new HashSet<ProfacboomProject>();
            ReservationServiceLink = new HashSet<ReservationServiceLink>();
            ReserveringVoorzieningLink = new HashSet<ReserveringVoorzieningLink>();
        }

        public Guid Unid { get; set; }
        public Guid? Uidaanmk { get; set; }
        public Guid? Uidwijzig { get; set; }
        public DateTime? Dataanmk { get; set; }
        public DateTime? Datwijzig { get; set; }
        public int Status { get; set; }
        public Guid Operatorid { get; set; }
        public Guid? Branchid { get; set; }
        public Guid? Personid { get; set; }
        public long Start { get; set; }
        public long End { get; set; }
        public string Number { get; set; }
        public string Briefdescription { get; set; }
        public string Ewsid { get; set; }
        public string Description { get; set; }
        public string RefBranchName { get; set; }
        public string RefBranchCity { get; set; }
        public string Importid { get; set; }
        public DateTime? Importdate { get; set; }
        public int Importtype { get; set; }
        public string Bespokememo { get; set; }
        public DateTime? Datexport { get; set; }
        public string RefCreatorName { get; set; }
        public string RefOperatorName { get; set; }
        public string RefModifierName { get; set; }
        public string RefPersonName { get; set; }

        public Vestiging Branch { get; set; }
        public Actiedoor Operator { get; set; }
        public Persoon Person { get; set; }
        public Gebruiker UidaanmkNavigation { get; set; }
        public Gebruiker UidwijzigNavigation { get; set; }
        public ICollection<AppointmentDocumenten> AppointmentDocumenten { get; set; }
        public ICollection<AppointmentEmailberichten> AppointmentEmailberichten { get; set; }
        public ICollection<AppointmentLogboek> AppointmentLogboek { get; set; }
        public ICollection<Change> Change { get; set; }
        public ICollection<Changeactivity> Changeactivity { get; set; }
        public ICollection<Incident> Incident { get; set; }
        public ICollection<OmActiviteit> OmActiviteit { get; set; }
        public ICollection<ProfacboomProject> ProfacboomProject { get; set; }
        public ICollection<ReservationServiceLink> ReservationServiceLink { get; set; }
        public ICollection<ReserveringVoorzieningLink> ReserveringVoorzieningLink { get; set; }
    }
}
