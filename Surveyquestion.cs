using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Surveyquestion
    {
        public Surveyquestion()
        {
            Campaignresponse = new HashSet<Campaignresponse>();
            Surveyanswer = new HashSet<Surveyanswer>();
            SurveyquestionDocumenten = new HashSet<SurveyquestionDocumenten>();
            SurveyquestionEmailberichten = new HashSet<SurveyquestionEmailberichten>();
            SurveyquestionLogboek = new HashSet<SurveyquestionLogboek>();
            SurveyquestionMemoHistory = new HashSet<SurveyquestionMemoHistory>();
        }

        public Guid Unid { get; set; }
        public Guid Surveyid { get; set; }
        public int Rank { get; set; }
        public string Naam { get; set; }
        public string Question { get; set; }
        public string Comment { get; set; }
        public int Status { get; set; }
        public int Answertype { get; set; }
        public Guid? Surveyquestioncategoryid { get; set; }
        public bool Mandatory { get; set; }
        public DateTime? Dataanmk { get; set; }
        public DateTime? Datwijzig { get; set; }
        public Guid? Uidaanmk { get; set; }
        public Guid? Uidwijzig { get; set; }
        public string Aantekeningen { get; set; }
        public int Importtype { get; set; }
        public string Importid { get; set; }
        public DateTime? Importdate { get; set; }

        public Survey Survey { get; set; }
        public Surveyquestioncategory Surveyquestioncategory { get; set; }
        public Gebruiker UidaanmkNavigation { get; set; }
        public Gebruiker UidwijzigNavigation { get; set; }
        public ICollection<Campaignresponse> Campaignresponse { get; set; }
        public ICollection<Surveyanswer> Surveyanswer { get; set; }
        public ICollection<SurveyquestionDocumenten> SurveyquestionDocumenten { get; set; }
        public ICollection<SurveyquestionEmailberichten> SurveyquestionEmailberichten { get; set; }
        public ICollection<SurveyquestionLogboek> SurveyquestionLogboek { get; set; }
        public ICollection<SurveyquestionMemoHistory> SurveyquestionMemoHistory { get; set; }
    }
}
