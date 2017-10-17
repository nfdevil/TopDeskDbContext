using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class KennisSysteem
    {
        public KennisSysteem()
        {
            Incidentkennissysteemlink = new HashSet<Incidentkennissysteemlink>();
            InverseOperatorconditie = new HashSet<KennisSysteem>();
            InverseParent = new HashSet<KennisSysteem>();
            InversePublicconditie = new HashSet<KennisSysteem>();
            KennisSysteemDocumenten = new HashSet<KennisSysteemDocumenten>();
            KennisVestigingOperCond = new HashSet<KennisVestigingOperCond>();
            KennisVestigingPublicCond = new HashSet<KennisVestigingPublicCond>();
            KennissysteemVestigingLink = new HashSet<KennissysteemVestigingLink>();
            Kennissysteemklik = new HashSet<Kennissysteemklik>();
            Kennissysteemreactie = new HashSet<Kennissysteemreactie>();
            Kennissysteemvertalingen = new HashSet<Kennissysteemvertalingen>();
            ProbleemKennissysteem = new HashSet<ProbleemKennissysteem>();
        }

        public int Actiefkeuze { get; set; }
        public Guid? Parentid { get; set; }
        public int Rang { get; set; }
        public Guid? Uidaanmk { get; set; }
        public Guid? Uidwijzig { get; set; }
        public Guid Unid { get; set; }
        public int Berichttype { get; set; }
        public bool Nieuwsitem { get; set; }
        public int Realm { get; set; }
        public DateTime? Actieftot { get; set; }
        public DateTime? Actiefvanaf { get; set; }
        public DateTime? Dataanmk { get; set; }
        public DateTime? Datwijzig { get; set; }
        public DateTime? Nieuwsdatumtot { get; set; }
        public DateTime? Nieuwsdatumvanaf { get; set; }
        public bool Gebruikvestiginglink { get; set; }
        public int Status { get; set; }
        public bool Gebruikvestiginglinkoperator { get; set; }
        public Guid? Publicconditieid { get; set; }
        public Guid? Operatorconditieid { get; set; }
        public Guid? Statusid { get; set; }
        public Guid? Beheerderid { get; set; }
        public string Bespokememo { get; set; }
        public int Importtype { get; set; }
        public DateTime? Importdate { get; set; }
        public string Importid { get; set; }
        public string Number { get; set; }

        public Actiedoor Beheerder { get; set; }
        public KennisSysteem Operatorconditie { get; set; }
        public KennisSysteem Parent { get; set; }
        public KennisSysteem Publicconditie { get; set; }
        public KennissysteemStatus StatusNavigation { get; set; }
        public Gebruiker UidaanmkNavigation { get; set; }
        public Gebruiker UidwijzigNavigation { get; set; }
        public ICollection<Incidentkennissysteemlink> Incidentkennissysteemlink { get; set; }
        public ICollection<KennisSysteem> InverseOperatorconditie { get; set; }
        public ICollection<KennisSysteem> InverseParent { get; set; }
        public ICollection<KennisSysteem> InversePublicconditie { get; set; }
        public ICollection<KennisSysteemDocumenten> KennisSysteemDocumenten { get; set; }
        public ICollection<KennisVestigingOperCond> KennisVestigingOperCond { get; set; }
        public ICollection<KennisVestigingPublicCond> KennisVestigingPublicCond { get; set; }
        public ICollection<KennissysteemVestigingLink> KennissysteemVestigingLink { get; set; }
        public ICollection<Kennissysteemklik> Kennissysteemklik { get; set; }
        public ICollection<Kennissysteemreactie> Kennissysteemreactie { get; set; }
        public ICollection<Kennissysteemvertalingen> Kennissysteemvertalingen { get; set; }
        public ICollection<ProbleemKennissysteem> ProbleemKennissysteem { get; set; }
    }
}
