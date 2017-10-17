using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Surveyquestioncategory
    {
        public Surveyquestioncategory()
        {
            Surveyquestion = new HashSet<Surveyquestion>();
        }

        public Guid Unid { get; set; }
        public int Rang { get; set; }
        public int Archief { get; set; }
        public string Naam { get; set; }
        public string Bespokememo { get; set; }

        public ICollection<Surveyquestion> Surveyquestion { get; set; }
    }
}
