using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Campaignmailing
    {
        public Campaignmailing()
        {
            CampaignmailingDocumenten = new HashSet<CampaignmailingDocumenten>();
            CampaignmailingEmailberichten = new HashSet<CampaignmailingEmailberichten>();
            CampaignmailingLogboek = new HashSet<CampaignmailingLogboek>();
            CampaignmailingMemoHistory = new HashSet<CampaignmailingMemoHistory>();
            Campaignmailinginvitation = new HashSet<Campaignmailinginvitation>();
        }

        public Guid Unid { get; set; }
        public Guid Campaignid { get; set; }
        public string Naam { get; set; }
        public int Status { get; set; }
        public Guid? Invitationmailid { get; set; }
        public Guid? Incidentselectionid { get; set; }
        public int Selectiontype { get; set; }
        public Guid? Personselectionid { get; set; }
        public int Randomselectionsize { get; set; }
        public bool Userandomselection { get; set; }
        public DateTime? Dataanmk { get; set; }
        public DateTime? Datwijzig { get; set; }
        public Guid? Uidaanmk { get; set; }
        public Guid? Uidwijzig { get; set; }
        public string Aantekeningen { get; set; }
        public int Importtype { get; set; }
        public string Importid { get; set; }
        public DateTime? Importdate { get; set; }

        public Campaign Campaign { get; set; }
        public Selvast Incidentselection { get; set; }
        public Mailactie Invitationmail { get; set; }
        public Selvast Personselection { get; set; }
        public Gebruiker UidaanmkNavigation { get; set; }
        public Gebruiker UidwijzigNavigation { get; set; }
        public ICollection<CampaignmailingDocumenten> CampaignmailingDocumenten { get; set; }
        public ICollection<CampaignmailingEmailberichten> CampaignmailingEmailberichten { get; set; }
        public ICollection<CampaignmailingLogboek> CampaignmailingLogboek { get; set; }
        public ICollection<CampaignmailingMemoHistory> CampaignmailingMemoHistory { get; set; }
        public ICollection<Campaignmailinginvitation> Campaignmailinginvitation { get; set; }
    }
}
