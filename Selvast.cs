using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Selvast
    {
        public Selvast()
        {
            CampaignmailingIncidentselection = new HashSet<Campaignmailing>();
            CampaignmailingPersonselection = new HashSet<Campaignmailing>();
            DnodienstIncidentselection = new HashSet<Dnodienst>();
            DnodienstSelection = new HashSet<Dnodienst>();
            Reportwizard = new HashSet<Reportwizard>();
        }

        public string Aantekeningen { get; set; }
        public Guid? Groepid { get; set; }
        public bool Istijdlk { get; set; }
        public string Kaart { get; set; }
        public string Omschr { get; set; }
        public int Slacode { get; set; }
        public int Status { get; set; }
        public Guid? Uidaanmk { get; set; }
        public Guid? Uidwijzig { get; set; }
        public Guid Unid { get; set; }
        public int Voorwiecode { get; set; }
        public string Kaartnaam { get; set; }
        public DateTime? Dataanmk { get; set; }
        public DateTime? Datwijzig { get; set; }
        public string Bespokememo { get; set; }
        public string Naam { get; set; }
        public DateTime? LastUsed { get; set; }

        public Gebruiker Groep { get; set; }
        public Gebruiker UidaanmkNavigation { get; set; }
        public Gebruiker UidwijzigNavigation { get; set; }
        public ICollection<Campaignmailing> CampaignmailingIncidentselection { get; set; }
        public ICollection<Campaignmailing> CampaignmailingPersonselection { get; set; }
        public ICollection<Dnodienst> DnodienstIncidentselection { get; set; }
        public ICollection<Dnodienst> DnodienstSelection { get; set; }
        public ICollection<Reportwizard> Reportwizard { get; set; }
    }
}
