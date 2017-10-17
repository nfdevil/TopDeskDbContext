using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Surveyanswer
    {
        public Surveyanswer()
        {
            Campaignresponse = new HashSet<Campaignresponse>();
        }

        public Guid Unid { get; set; }
        public Guid Surveyquestionid { get; set; }
        public int Rank { get; set; }
        public string Description { get; set; }
        public int Answertype { get; set; }
        public string Naam { get; set; }
        public DateTime? Dataanmk { get; set; }
        public DateTime? Datwijzig { get; set; }
        public Guid? Uidaanmk { get; set; }
        public Guid? Uidwijzig { get; set; }

        public Surveyquestion Surveyquestion { get; set; }
        public Gebruiker UidaanmkNavigation { get; set; }
        public Gebruiker UidwijzigNavigation { get; set; }
        public ICollection<Campaignresponse> Campaignresponse { get; set; }
    }
}
