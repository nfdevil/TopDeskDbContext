using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class MutatieDnodienst
    {
        public DateTime? Datwijzig { get; set; }
        public Guid? Parentid { get; set; }
        public Guid? Uidwijzig { get; set; }
        public Guid Unid { get; set; }
        public Guid? MutDnodienstsoortid { get; set; }
        public bool MutDnodienstsoortidAct { get; set; }
        public Guid? MutDnodienstsoortidRid { get; set; }
        public Guid? MutSoortmeldingid { get; set; }
        public bool MutSoortmeldingidAct { get; set; }
        public Guid? MutSoortmeldingidRid { get; set; }
        public Guid? MutDomeinid { get; set; }
        public bool MutDomeinidAct { get; set; }
        public Guid? MutDomeinidRid { get; set; }
        public Guid? MutSpecificatieid { get; set; }
        public bool MutSpecificatieidAct { get; set; }
        public Guid? MutSpecificatieidRid { get; set; }
        public Guid? MutUnderpinningcontractid { get; set; }
        public bool MutUnderpinningcontractidAct { get; set; }
        public Guid? MutUnderpinningcontractidRid { get; set; }
        public Guid? MutUnderpinningdienstid { get; set; }
        public bool MutUnderpinningdienstidAct { get; set; }
        public Guid? MutUnderpinningdienstidRid { get; set; }
        public bool MutPublished { get; set; }
        public bool MutPublishedAct { get; set; }
        public Guid? MutPublishedRid { get; set; }
        public int Importtype { get; set; }
        public string Importid { get; set; }
        public DateTime? Importdate { get; set; }

        public Dnodienstsoort MutDnodienstsoort { get; set; }
        public Mutatiereden MutDnodienstsoortidR { get; set; }
        public Classificatie MutDomein { get; set; }
        public Mutatiereden MutDomeinidR { get; set; }
        public Mutatiereden MutPublishedR { get; set; }
        public Soortmelding MutSoortmelding { get; set; }
        public Mutatiereden MutSoortmeldingidR { get; set; }
        public Classificatie MutSpecificatie { get; set; }
        public Mutatiereden MutSpecificatieidR { get; set; }
        public Dnocontract MutUnderpinningcontract { get; set; }
        public Mutatiereden MutUnderpinningcontractidR { get; set; }
        public Dnodienst MutUnderpinningdienst { get; set; }
        public Mutatiereden MutUnderpinningdienstidR { get; set; }
        public Dnodienst Parent { get; set; }
        public Gebruiker UidwijzigNavigation { get; set; }
    }
}
