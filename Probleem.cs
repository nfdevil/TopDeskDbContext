using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Probleem
    {
        public Probleem()
        {
            ChangeProblemCausedbyLink = new HashSet<ChangeProblemCausedbyLink>();
            ChangeProblemLink = new HashSet<ChangeProblemLink>();
            InverseProbleemNavigation = new HashSet<Probleem>();
            MeetingProblemLink = new HashSet<MeetingProblemLink>();
            MutatieProbleem = new HashSet<MutatieProbleem>();
            ObjProblemLink = new HashSet<ObjProblemLink>();
            Oplossingen = new HashSet<Oplossingen>();
            ProbleemDocumenten = new HashSet<ProbleemDocumenten>();
            ProbleemEmailberichten = new HashSet<ProbleemEmailberichten>();
            ProbleemKennissysteem = new HashSet<ProbleemKennissysteem>();
            ProbleemLogboek = new HashSet<ProbleemLogboek>();
            ProbleemMemogeschiedenis = new HashSet<ProbleemMemogeschiedenis>();
            Probleemincidentlink = new HashSet<Probleemincidentlink>();
            ProfacboomProjectProblemLink = new HashSet<ProfacboomProjectProblemLink>();
            TimeRegistrationProbleem = new HashSet<TimeRegistrationProbleem>();
        }

        public string Aantekeningen { get; set; }
        public string Actie { get; set; }
        public Guid? Actiedoorbfid { get; set; }
        public Guid? Actiedoorid { get; set; }
        public bool Afgemeld { get; set; }
        public bool Afgemeldbf { get; set; }
        public Guid? Archiefredenid { get; set; }
        public Guid? Beheerderbfid { get; set; }
        public string Bestedetijdmemo { get; set; }
        public Guid? Categorieid { get; set; }
        public int Deelprobleemvolgnummer { get; set; }
        public Guid? Domeinid { get; set; }
        public Guid? Doorlooptijdbfid { get; set; }
        public Guid? Doorlooptijdid { get; set; }
        public bool Gereed { get; set; }
        public bool Gereedbf { get; set; }
        public Guid? Impactbfid { get; set; }
        public Guid? Impactid { get; set; }
        public string Kostenmemo { get; set; }
        public string Omschrijving { get; set; }
        public Guid? Oorzaakid { get; set; }
        public string Oplossing { get; set; }
        public Guid? Probleemid { get; set; }
        public string RefDomein { get; set; }
        public string RefSpecificatie { get; set; }
        public string RefTelefoon { get; set; }
        public Guid? Specificatieid { get; set; }
        public int Status { get; set; }
        public Guid? Statusbfid { get; set; }
        public Guid? Statusid { get; set; }
        public Guid? Uidaanmk { get; set; }
        public Guid? Uidwijzig { get; set; }
        public Guid Unid { get; set; }
        public Guid? Verantwoordelijkeid { get; set; }
        public double Vrijegetal1 { get; set; }
        public double Vrijegetal2 { get; set; }
        public bool Vrijelogisch1 { get; set; }
        public bool Vrijelogisch2 { get; set; }
        public bool Vrijelogisch3 { get; set; }
        public bool Vrijelogisch4 { get; set; }
        public bool Vrijelogisch5 { get; set; }
        public string Vrijememo1 { get; set; }
        public string Vrijememo2 { get; set; }
        public Guid? Vrijeopzoek1 { get; set; }
        public Guid? Vrijeopzoek2 { get; set; }
        public Guid? Vrijeopzoek3 { get; set; }
        public DateTime? Aanmaakdatum { get; set; }
        public DateTime? Aanmaakdatumbf { get; set; }
        public DateTime? Dataanmk { get; set; }
        public DateTime? Datumafgemeld { get; set; }
        public DateTime? Datumafgemeldbf { get; set; }
        public DateTime? Datumgereed { get; set; }
        public DateTime? Datumgereedbf { get; set; }
        public DateTime? Datwijzig { get; set; }
        public DateTime? RefEinddatum { get; set; }
        public DateTime? Streefdatum { get; set; }
        public DateTime? Streefdatumbf { get; set; }
        public DateTime? Vrijedatum1 { get; set; }
        public DateTime? Vrijedatum2 { get; set; }
        public decimal Kostenbegroot { get; set; }
        public decimal Kostenverwacht { get; set; }
        public decimal Onkosten { get; set; }
        public decimal Onkostenbf { get; set; }
        public long Tijdbegroot { get; set; }
        public long Tijdbesteed { get; set; }
        public long Tijdbesteedbf { get; set; }
        public long Tijdverwacht { get; set; }
        public decimal Totalekosten { get; set; }
        public long Totaletijd { get; set; }
        public long RefBestedetijdsgat { get; set; }
        public long RefBestedetijdverschil { get; set; }
        public decimal RefKostengat { get; set; }
        public decimal RefKostenverschil { get; set; }
        public DateTime? RefcombiAanmaakdatum { get; set; }
        public bool RefcombiAfgemeld { get; set; }
        public DateTime? RefcombiDatumafgemeld { get; set; }
        public DateTime? RefcombiDatumgereed { get; set; }
        public Guid? RefcombiDoorlooptijdid { get; set; }
        public bool RefcombiGereed { get; set; }
        public DateTime? RefcombiStreefdatum { get; set; }
        public decimal RefcombiOnkosten { get; set; }
        public long RefcombiTijdbesteed { get; set; }
        public long Minutendoorlooptijd { get; set; }
        public long Minutendoorlooptijdbf { get; set; }
        public long RefcombiMinutendoorlooptijd { get; set; }
        public Guid? Domeinprobleemid { get; set; }
        public Guid? Specificatieprobleemid { get; set; }
        public string Korteomschrijving { get; set; }
        public string Korteomschrijvingbf { get; set; }
        public string RefcombiKorteomschrijving { get; set; }
        public string RefDomeinprobleem { get; set; }
        public string RefSpecificatieprobleem { get; set; }
        public DateTime? Vrijedatum3 { get; set; }
        public double Vrijegetal3 { get; set; }
        public string Vrijememo3 { get; set; }
        public DateTime? Vrijedatum4 { get; set; }
        public double Vrijegetal4 { get; set; }
        public string Vrijememo4 { get; set; }
        public DateTime? Vrijedatum5 { get; set; }
        public double Vrijegetal5 { get; set; }
        public string Vrijememo5 { get; set; }
        public Guid? Vrijeopzoek4 { get; set; }
        public Guid? Vrijeopzoek5 { get; set; }
        public string Vrijetekst1 { get; set; }
        public string Vrijetekst2 { get; set; }
        public string Vrijetekst3 { get; set; }
        public string Vrijetekst4 { get; set; }
        public string Vrijetekst5 { get; set; }
        public DateTime? Attvrijedatum1 { get; set; }
        public double Attvrijegetal1 { get; set; }
        public bool Attvrijelogisch1 { get; set; }
        public string Attvrijememo1 { get; set; }
        public Guid? Attvrijeopzoek1 { get; set; }
        public string Attvrijetekst1 { get; set; }
        public DateTime? Attvrijedatum2 { get; set; }
        public double Attvrijegetal2 { get; set; }
        public bool Attvrijelogisch2 { get; set; }
        public string Attvrijememo2 { get; set; }
        public Guid? Attvrijeopzoek2 { get; set; }
        public string Attvrijetekst2 { get; set; }
        public DateTime? Attvrijedatum3 { get; set; }
        public double Attvrijegetal3 { get; set; }
        public bool Attvrijelogisch3 { get; set; }
        public string Attvrijememo3 { get; set; }
        public Guid? Attvrijeopzoek3 { get; set; }
        public string Attvrijetekst3 { get; set; }
        public DateTime? Attvrijedatum4 { get; set; }
        public double Attvrijegetal4 { get; set; }
        public bool Attvrijelogisch4 { get; set; }
        public string Attvrijememo4 { get; set; }
        public Guid? Attvrijeopzoek4 { get; set; }
        public string Attvrijetekst4 { get; set; }
        public DateTime? Attvrijedatum5 { get; set; }
        public double Attvrijegetal5 { get; set; }
        public bool Attvrijelogisch5 { get; set; }
        public string Attvrijememo5 { get; set; }
        public Guid? Attvrijeopzoek5 { get; set; }
        public string Attvrijetekst5 { get; set; }
        public string Naam { get; set; }
        public string RefHoofdprobleem { get; set; }
        public Guid? Operatorgroupid { get; set; }
        public Guid? Operatorgroupbfid { get; set; }
        public string Bespokememo { get; set; }
        public Guid? Urgencyid { get; set; }
        public Guid? Priorityid { get; set; }
        public int Importtype { get; set; }
        public string Importid { get; set; }
        public DateTime? Importdate { get; set; }
        public string RefMainDesc { get; set; }
        public string RefcombiBehandelaar { get; set; }
        public string RefcombiBeheerder { get; set; }
        public string RefBehandelaar { get; set; }
        public string RefBehandelaarbf { get; set; }
        public string RefBeheerder { get; set; }
        public string RefBeheerderbf { get; set; }
        public string RefCategorie { get; set; }
        public string RefImpact { get; set; }
        public string RefImpactbf { get; set; }
        public string RefOorzaak { get; set; }
        public string RefStatus { get; set; }
        public string RefStatusbf { get; set; }
        public string RefcombiStatus { get; set; }
        public string RefcombiImpact { get; set; }
        public string RefProgresstrail { get; set; }

        public Actiedoor Actiedoor { get; set; }
        public Actiedoor Actiedoorbf { get; set; }
        public Archiefreden Archiefreden { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek1Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek2Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek3Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek4Navigation { get; set; }
        public Vrijeopzoekvelden Attvrijeopzoek5Navigation { get; set; }
        public Actiedoor Beheerderbf { get; set; }
        public ProbleemCategorie Categorie { get; set; }
        public Classificatie Domein { get; set; }
        public Classificatie Domeinprobleem { get; set; }
        public ProbleemDoorlooptijd Doorlooptijd { get; set; }
        public ProbleemDoorlooptijd Doorlooptijdbf { get; set; }
        public ProbleemImpact Impact { get; set; }
        public ProbleemImpact Impactbf { get; set; }
        public ProbleemOorzaak Oorzaak { get; set; }
        public Actiedoor Operatorgroup { get; set; }
        public Actiedoor Operatorgroupbf { get; set; }
        public ProblemPriority Priority { get; set; }
        public Probleem ProbleemNavigation { get; set; }
        public ProbleemDoorlooptijd RefcombiDoorlooptijd { get; set; }
        public Classificatie Specificatie { get; set; }
        public Classificatie Specificatieprobleem { get; set; }
        public ProbleemStatus StatusNavigation { get; set; }
        public ProbleemStatus Statusbf { get; set; }
        public Gebruiker UidaanmkNavigation { get; set; }
        public Gebruiker UidwijzigNavigation { get; set; }
        public ProblemUrgency Urgency { get; set; }
        public Actiedoor Verantwoordelijke { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek1Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek2Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek3Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek4Navigation { get; set; }
        public Vrijeopzoekvelden Vrijeopzoek5Navigation { get; set; }
        public ICollection<ChangeProblemCausedbyLink> ChangeProblemCausedbyLink { get; set; }
        public ICollection<ChangeProblemLink> ChangeProblemLink { get; set; }
        public ICollection<Probleem> InverseProbleemNavigation { get; set; }
        public ICollection<MeetingProblemLink> MeetingProblemLink { get; set; }
        public ICollection<MutatieProbleem> MutatieProbleem { get; set; }
        public ICollection<ObjProblemLink> ObjProblemLink { get; set; }
        public ICollection<Oplossingen> Oplossingen { get; set; }
        public ICollection<ProbleemDocumenten> ProbleemDocumenten { get; set; }
        public ICollection<ProbleemEmailberichten> ProbleemEmailberichten { get; set; }
        public ICollection<ProbleemKennissysteem> ProbleemKennissysteem { get; set; }
        public ICollection<ProbleemLogboek> ProbleemLogboek { get; set; }
        public ICollection<ProbleemMemogeschiedenis> ProbleemMemogeschiedenis { get; set; }
        public ICollection<Probleemincidentlink> Probleemincidentlink { get; set; }
        public ICollection<ProfacboomProjectProblemLink> ProfacboomProjectProblemLink { get; set; }
        public ICollection<TimeRegistrationProbleem> TimeRegistrationProbleem { get; set; }
    }
}
