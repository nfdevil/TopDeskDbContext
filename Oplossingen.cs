using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Oplossingen
    {
        public Oplossingen()
        {
            Incident = new HashSet<Incident>();
            OplossingenDocumenten = new HashSet<OplossingenDocumenten>();
            OplossingenEmailberichten = new HashSet<OplossingenEmailberichten>();
            OplossingenLogboek = new HashSet<OplossingenLogboek>();
        }

        public string Actie { get; set; }
        public Guid? Actiedoorlijn1id { get; set; }
        public Guid? Actiedoorlijn2id { get; set; }
        public Guid? Doorlooptijdlijn1id { get; set; }
        public Guid? Doorlooptijdlijn2id { get; set; }
        public Guid? Impactid { get; set; }
        public Guid? Probleemid { get; set; }
        public Guid? Uidaanmk { get; set; }
        public Guid? Uidwijzig { get; set; }
        public Guid Unid { get; set; }
        public string Verzoek { get; set; }
        public DateTime? Dataanmk { get; set; }
        public DateTime? Datwijzig { get; set; }
        public long Tijdbesteed { get; set; }
        public Guid? Soortmeldingid { get; set; }
        public Guid? Oplosmethodeid { get; set; }
        public Guid? Soortbinnenkomstid { get; set; }
        public Guid? Afhandelingstatusid { get; set; }
        public int Status { get; set; }
        public decimal Onkosten { get; set; }
        public bool Currentoperatorline1 { get; set; }
        public bool Currentoperatorline2 { get; set; }
        public Guid? Categoryid { get; set; }
        public Guid? Subcategoryid { get; set; }
        public Guid? Urgencyid { get; set; }
        public Guid? Priorityid { get; set; }
        public string Korteomschrijving { get; set; }
        public bool Gereed { get; set; }
        public bool Afgemeld { get; set; }
        public string Bespokememo { get; set; }
        public bool Invisibleforcaller { get; set; }
        public Guid? Firstlinesupplierid { get; set; }
        public Guid? Secondlinesupplierid { get; set; }
        public int Importtype { get; set; }
        public string Importid { get; set; }
        public DateTime? Importdate { get; set; }

        public Actiedoor Actiedoorlijn1 { get; set; }
        public Actiedoor Actiedoorlijn2 { get; set; }
        public Afhandelingstatus Afhandelingstatus { get; set; }
        public Classificatie Category { get; set; }
        public Doorlooptijd Doorlooptijdlijn1 { get; set; }
        public Doorlooptijd Doorlooptijdlijn2 { get; set; }
        public Leverancier Firstlinesupplier { get; set; }
        public Impact Impact { get; set; }
        public Oplossingsmethode Oplosmethode { get; set; }
        public Priority Priority { get; set; }
        public Probleem Probleem { get; set; }
        public Leverancier Secondlinesupplier { get; set; }
        public Soortbinnenkomst Soortbinnenkomst { get; set; }
        public Soortmelding Soortmelding { get; set; }
        public Classificatie Subcategory { get; set; }
        public Gebruiker UidaanmkNavigation { get; set; }
        public Gebruiker UidwijzigNavigation { get; set; }
        public Urgency Urgency { get; set; }
        public ICollection<Incident> Incident { get; set; }
        public ICollection<OplossingenDocumenten> OplossingenDocumenten { get; set; }
        public ICollection<OplossingenEmailberichten> OplossingenEmailberichten { get; set; }
        public ICollection<OplossingenLogboek> OplossingenLogboek { get; set; }
    }
}
