using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Reportaction
    {
        public Reportaction()
        {
            RecurringeventReportactionLink = new HashSet<RecurringeventReportactionLink>();
            ReportactionDocumenten = new HashSet<ReportactionDocumenten>();
            ReportactionEmailberichten = new HashSet<ReportactionEmailberichten>();
            ReportactionLogboek = new HashSet<ReportactionLogboek>();
            ReportactionOperatorLink = new HashSet<ReportactionOperatorLink>();
            ReportactionPersonLink = new HashSet<ReportactionPersonLink>();
        }

        public Guid Unid { get; set; }
        public string Senderaddress { get; set; }
        public string Message { get; set; }
        public int Filetype { get; set; }
        public Guid Reportid { get; set; }
        public string Locale { get; set; }
        public string Subject { get; set; }
        public DateTime? Dataanmk { get; set; }
        public DateTime? Datwijzig { get; set; }
        public Guid? Uidaanmk { get; set; }
        public Guid? Uidwijzig { get; set; }
        public int Status { get; set; }
        public Guid? Archiefredenid { get; set; }
        public bool Reportmailindividual { get; set; }
        public Guid? Reportmailuserid { get; set; }
        public bool Sendmail { get; set; }
        public bool Storefile { get; set; }

        public Archiefreden Archiefreden { get; set; }
        public Reportwizard Report { get; set; }
        public Gebruiker Reportmailuser { get; set; }
        public Gebruiker UidaanmkNavigation { get; set; }
        public Gebruiker UidwijzigNavigation { get; set; }
        public ICollection<RecurringeventReportactionLink> RecurringeventReportactionLink { get; set; }
        public ICollection<ReportactionDocumenten> ReportactionDocumenten { get; set; }
        public ICollection<ReportactionEmailberichten> ReportactionEmailberichten { get; set; }
        public ICollection<ReportactionLogboek> ReportactionLogboek { get; set; }
        public ICollection<ReportactionOperatorLink> ReportactionOperatorLink { get; set; }
        public ICollection<ReportactionPersonLink> ReportactionPersonLink { get; set; }
    }
}
