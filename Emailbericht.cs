using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Emailbericht
    {
        public Emailbericht()
        {
            ActiedoorEmailberichten = new HashSet<ActiedoorEmailberichten>();
            AppointmentEmailberichten = new HashSet<AppointmentEmailberichten>();
            BestelaanvraagEmailberichten = new HashSet<BestelaanvraagEmailberichten>();
            BestellingenEmailberichten = new HashSet<BestellingenEmailberichten>();
            BezoekerEmailberichten = new HashSet<BezoekerEmailberichten>();
            CampaignEmailberichten = new HashSet<CampaignEmailberichten>();
            CampaignmailingEmailberichten = new HashSet<CampaignmailingEmailberichten>();
            ChangeActivitytemplateEmailberichten = new HashSet<ChangeActivitytemplateEmailberichten>();
            ChangeEmailberichten = new HashSet<ChangeEmailberichten>();
            ChangeTemplateEmailberichten = new HashSet<ChangeTemplateEmailberichten>();
            ChangeactivityEmailberichten = new HashSet<ChangeactivityEmailberichten>();
            ChangeversionEmailberichten = new HashSet<ChangeversionEmailberichten>();
            ConfiguratieEmailberichten = new HashSet<ConfiguratieEmailberichten>();
            DnocontractEmailberichten = new HashSet<DnocontractEmailberichten>();
            DnodienstEmailberichten = new HashSet<DnodienstEmailberichten>();
            Emailberichtbestand = new HashSet<Emailberichtbestand>();
            Emailberichtkopie = new HashSet<Emailberichtkopie>();
            GebruikerEmailberichten = new HashSet<GebruikerEmailberichten>();
            HardwareEmailberichten = new HashSet<HardwareEmailberichten>();
            IncidentEmailberichten = new HashSet<IncidentEmailberichten>();
            InventarisEmailberichten = new HashSet<InventarisEmailberichten>();
            LeverancierEmailberichten = new HashSet<LeverancierEmailberichten>();
            LeveranciercontactpersoonEmailberichten = new HashSet<LeveranciercontactpersoonEmailberichten>();
            LicentieEmailberichten = new HashSet<LicentieEmailberichten>();
            LmpactivityEmailberichten = new HashSet<LmpactivityEmailberichten>();
            LmpscenarioEmailberichten = new HashSet<LmpscenarioEmailberichten>();
            LocatieEmailberichten = new HashSet<LocatieEmailberichten>();
            MeetingEmailberichten = new HashSet<MeetingEmailberichten>();
            NetwerkcomponentEmailberichten = new HashSet<NetwerkcomponentEmailberichten>();
            OmActiviteitEmailberichten = new HashSet<OmActiviteitEmailberichten>();
            OmReeksEmailberichten = new HashSet<OmReeksEmailberichten>();
            OmSchemaEmailberichten = new HashSet<OmSchemaEmailberichten>();
            OplossingenEmailberichten = new HashSet<OplossingenEmailberichten>();
            PersoonEmailberichten = new HashSet<PersoonEmailberichten>();
            PersoongroepEmailberichten = new HashSet<PersoongroepEmailberichten>();
            PoortEmailberichten = new HashSet<PoortEmailberichten>();
            ProbleemEmailberichten = new HashSet<ProbleemEmailberichten>();
            ProfacboomProjectEmailberichten = new HashSet<ProfacboomProjectEmailberichten>();
            ReportactionEmailberichten = new HashSet<ReportactionEmailberichten>();
            ReservationEmailberichten = new HashSet<ReservationEmailberichten>();
            ReservationEventEmailberichten = new HashSet<ReservationEventEmailberichten>();
            ReservationFacilityLinkEmailberichten = new HashSet<ReservationFacilityLinkEmailberichten>();
            ReservationServiceLinkEmailberichten = new HashSet<ReservationServiceLinkEmailberichten>();
            ReserveringEmailberichten = new HashSet<ReserveringEmailberichten>();
            ReserveringVoorzieningLinkEmailberichten = new HashSet<ReserveringVoorzieningLinkEmailberichten>();
            ServicelevelEmailberichten = new HashSet<ServicelevelEmailberichten>();
            ServicewindowEmailberichten = new HashSet<ServicewindowEmailberichten>();
            SoftwareEmailberichten = new HashSet<SoftwareEmailberichten>();
            SurveyEmailberichten = new HashSet<SurveyEmailberichten>();
            SurveyquestionEmailberichten = new HashSet<SurveyquestionEmailberichten>();
            SystemeventsEmailberichten = new HashSet<SystemeventsEmailberichten>();
            TelefonieEmailberichten = new HashSet<TelefonieEmailberichten>();
            VestigingEmailberichten = new HashSet<VestigingEmailberichten>();
            VoorzieningEmailberichten = new HashSet<VoorzieningEmailberichten>();
            Vrij1objectEmailberichten = new HashSet<Vrij1objectEmailberichten>();
            Vrij2objectEmailberichten = new HashSet<Vrij2objectEmailberichten>();
            Vrij3objectEmailberichten = new HashSet<Vrij3objectEmailberichten>();
            Vrij4objectEmailberichten = new HashSet<Vrij4objectEmailberichten>();
            Vrij5objectEmailberichten = new HashSet<Vrij5objectEmailberichten>();
        }

        public Guid? Archiefredenid { get; set; }
        public string Bericht { get; set; }
        public bool Html { get; set; }
        public bool KopieNaarEigen { get; set; }
        public bool Leesbevestiging { get; set; }
        public bool Ontvangstbevestiging { get; set; }
        public int Prioriteit { get; set; }
        public int Status { get; set; }
        public Guid? Uidaanmk { get; set; }
        public Guid? Uidwijzig { get; set; }
        public Guid Unid { get; set; }
        public bool Vanuitkaart { get; set; }
        public DateTime? Dataanmk { get; set; }
        public DateTime? Datwijzig { get; set; }
        public DateTime? Verzenddatum { get; set; }
        public int OorsprongType { get; set; }
        public string Naam { get; set; }
        public string Bespokememo { get; set; }
        public string Emailaction { get; set; }
        public string Geadresseerde { get; set; }
        public string Afzender { get; set; }
        public int Importtype { get; set; }
        public string Importid { get; set; }
        public DateTime? Importdate { get; set; }

        public Archiefreden Archiefreden { get; set; }
        public Gebruiker UidaanmkNavigation { get; set; }
        public Gebruiker UidwijzigNavigation { get; set; }
        public ICollection<ActiedoorEmailberichten> ActiedoorEmailberichten { get; set; }
        public ICollection<AppointmentEmailberichten> AppointmentEmailberichten { get; set; }
        public ICollection<BestelaanvraagEmailberichten> BestelaanvraagEmailberichten { get; set; }
        public ICollection<BestellingenEmailberichten> BestellingenEmailberichten { get; set; }
        public ICollection<BezoekerEmailberichten> BezoekerEmailberichten { get; set; }
        public ICollection<CampaignEmailberichten> CampaignEmailberichten { get; set; }
        public ICollection<CampaignmailingEmailberichten> CampaignmailingEmailberichten { get; set; }
        public ICollection<ChangeActivitytemplateEmailberichten> ChangeActivitytemplateEmailberichten { get; set; }
        public ICollection<ChangeEmailberichten> ChangeEmailberichten { get; set; }
        public ICollection<ChangeTemplateEmailberichten> ChangeTemplateEmailberichten { get; set; }
        public ICollection<ChangeactivityEmailberichten> ChangeactivityEmailberichten { get; set; }
        public ICollection<ChangeversionEmailberichten> ChangeversionEmailberichten { get; set; }
        public ICollection<ConfiguratieEmailberichten> ConfiguratieEmailberichten { get; set; }
        public ICollection<DnocontractEmailberichten> DnocontractEmailberichten { get; set; }
        public ICollection<DnodienstEmailberichten> DnodienstEmailberichten { get; set; }
        public ICollection<Emailberichtbestand> Emailberichtbestand { get; set; }
        public ICollection<Emailberichtkopie> Emailberichtkopie { get; set; }
        public ICollection<GebruikerEmailberichten> GebruikerEmailberichten { get; set; }
        public ICollection<HardwareEmailberichten> HardwareEmailberichten { get; set; }
        public ICollection<IncidentEmailberichten> IncidentEmailberichten { get; set; }
        public ICollection<InventarisEmailberichten> InventarisEmailberichten { get; set; }
        public ICollection<LeverancierEmailberichten> LeverancierEmailberichten { get; set; }
        public ICollection<LeveranciercontactpersoonEmailberichten> LeveranciercontactpersoonEmailberichten { get; set; }
        public ICollection<LicentieEmailberichten> LicentieEmailberichten { get; set; }
        public ICollection<LmpactivityEmailberichten> LmpactivityEmailberichten { get; set; }
        public ICollection<LmpscenarioEmailberichten> LmpscenarioEmailberichten { get; set; }
        public ICollection<LocatieEmailberichten> LocatieEmailberichten { get; set; }
        public ICollection<MeetingEmailberichten> MeetingEmailberichten { get; set; }
        public ICollection<NetwerkcomponentEmailberichten> NetwerkcomponentEmailberichten { get; set; }
        public ICollection<OmActiviteitEmailberichten> OmActiviteitEmailberichten { get; set; }
        public ICollection<OmReeksEmailberichten> OmReeksEmailberichten { get; set; }
        public ICollection<OmSchemaEmailberichten> OmSchemaEmailberichten { get; set; }
        public ICollection<OplossingenEmailberichten> OplossingenEmailberichten { get; set; }
        public ICollection<PersoonEmailberichten> PersoonEmailberichten { get; set; }
        public ICollection<PersoongroepEmailberichten> PersoongroepEmailberichten { get; set; }
        public ICollection<PoortEmailberichten> PoortEmailberichten { get; set; }
        public ICollection<ProbleemEmailberichten> ProbleemEmailberichten { get; set; }
        public ICollection<ProfacboomProjectEmailberichten> ProfacboomProjectEmailberichten { get; set; }
        public ICollection<ReportactionEmailberichten> ReportactionEmailberichten { get; set; }
        public ICollection<ReservationEmailberichten> ReservationEmailberichten { get; set; }
        public ICollection<ReservationEventEmailberichten> ReservationEventEmailberichten { get; set; }
        public ICollection<ReservationFacilityLinkEmailberichten> ReservationFacilityLinkEmailberichten { get; set; }
        public ICollection<ReservationServiceLinkEmailberichten> ReservationServiceLinkEmailberichten { get; set; }
        public ICollection<ReserveringEmailberichten> ReserveringEmailberichten { get; set; }
        public ICollection<ReserveringVoorzieningLinkEmailberichten> ReserveringVoorzieningLinkEmailberichten { get; set; }
        public ICollection<ServicelevelEmailberichten> ServicelevelEmailberichten { get; set; }
        public ICollection<ServicewindowEmailberichten> ServicewindowEmailberichten { get; set; }
        public ICollection<SoftwareEmailberichten> SoftwareEmailberichten { get; set; }
        public ICollection<SurveyEmailberichten> SurveyEmailberichten { get; set; }
        public ICollection<SurveyquestionEmailberichten> SurveyquestionEmailberichten { get; set; }
        public ICollection<SystemeventsEmailberichten> SystemeventsEmailberichten { get; set; }
        public ICollection<TelefonieEmailberichten> TelefonieEmailberichten { get; set; }
        public ICollection<VestigingEmailberichten> VestigingEmailberichten { get; set; }
        public ICollection<VoorzieningEmailberichten> VoorzieningEmailberichten { get; set; }
        public ICollection<Vrij1objectEmailberichten> Vrij1objectEmailberichten { get; set; }
        public ICollection<Vrij2objectEmailberichten> Vrij2objectEmailberichten { get; set; }
        public ICollection<Vrij3objectEmailberichten> Vrij3objectEmailberichten { get; set; }
        public ICollection<Vrij4objectEmailberichten> Vrij4objectEmailberichten { get; set; }
        public ICollection<Vrij5objectEmailberichten> Vrij5objectEmailberichten { get; set; }
    }
}
