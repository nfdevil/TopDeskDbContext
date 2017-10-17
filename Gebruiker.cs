using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Gebruiker
    {
        public Gebruiker()
        {
            ActiedoorDocumentenUidaanmkNavigation = new HashSet<ActiedoorDocumenten>();
            ActiedoorDocumentenUidwijzigNavigation = new HashSet<ActiedoorDocumenten>();
            ActiedoorLogboekUidaanmkNavigation = new HashSet<ActiedoorLogboek>();
            ActiedoorLogboekUidwijzigNavigation = new HashSet<ActiedoorLogboek>();
            ActiedoorLoginnaamtopdesk = new HashSet<Actiedoor>();
            ActiedoorMemoHistoryGebruiker = new HashSet<ActiedoorMemoHistory>();
            ActiedoorMemoHistoryUidaanmkNavigation = new HashSet<ActiedoorMemoHistory>();
            ActiedoorMemoHistoryUidwijzigNavigation = new HashSet<ActiedoorMemoHistory>();
            ActiedoorOptionalgridUidaanmkNavigation = new HashSet<ActiedoorOptionalgrid>();
            ActiedoorOptionalgridUidwijzigNavigation = new HashSet<ActiedoorOptionalgrid>();
            ActiedoorUidaanmkNavigation = new HashSet<Actiedoor>();
            ActiedoorUidwijzigNavigation = new HashSet<Actiedoor>();
            AppliedshiftUidaanmkNavigation = new HashSet<Appliedshift>();
            AppliedshiftUidwijzigNavigation = new HashSet<Appliedshift>();
            AppointmentDocumentenUidaanmkNavigation = new HashSet<AppointmentDocumenten>();
            AppointmentDocumentenUidwijzigNavigation = new HashSet<AppointmentDocumenten>();
            AppointmentLogboekUidaanmkNavigation = new HashSet<AppointmentLogboek>();
            AppointmentLogboekUidwijzigNavigation = new HashSet<AppointmentLogboek>();
            AppointmentUidaanmkNavigation = new HashSet<Appointment>();
            AppointmentUidwijzigNavigation = new HashSet<Appointment>();
            ArtikelMutatie = new HashSet<ArtikelMutatie>();
            BestelaanvraagDocumentenUidaanmkNavigation = new HashSet<BestelaanvraagDocumenten>();
            BestelaanvraagDocumentenUidwijzigNavigation = new HashSet<BestelaanvraagDocumenten>();
            BestelaanvraagLogboekUidaanmkNavigation = new HashSet<BestelaanvraagLogboek>();
            BestelaanvraagLogboekUidwijzigNavigation = new HashSet<BestelaanvraagLogboek>();
            BestelaanvraagUidaanmkNavigation = new HashSet<Bestelaanvraag>();
            BestelaanvraagUidwijzigNavigation = new HashSet<Bestelaanvraag>();
            BestellingenDocumentenUidaanmkNavigation = new HashSet<BestellingenDocumenten>();
            BestellingenDocumentenUidwijzigNavigation = new HashSet<BestellingenDocumenten>();
            BestellingenLogboekUidaanmkNavigation = new HashSet<BestellingenLogboek>();
            BestellingenLogboekUidwijzigNavigation = new HashSet<BestellingenLogboek>();
            BestellingenUidaanmkNavigation = new HashSet<Bestellingen>();
            BestellingenUidwijzigNavigation = new HashSet<Bestellingen>();
            BezoekerDocumentenUidaanmkNavigation = new HashSet<BezoekerDocumenten>();
            BezoekerDocumentenUidwijzigNavigation = new HashSet<BezoekerDocumenten>();
            BezoekerLogboekUidaanmkNavigation = new HashSet<BezoekerLogboek>();
            BezoekerLogboekUidwijzigNavigation = new HashSet<BezoekerLogboek>();
            BezoekerMemoHistoryGebruiker = new HashSet<BezoekerMemoHistory>();
            BezoekerMemoHistoryUidaanmkNavigation = new HashSet<BezoekerMemoHistory>();
            BezoekerMemoHistoryUidwijzigNavigation = new HashSet<BezoekerMemoHistory>();
            BezoekerUidaanmkNavigation = new HashSet<Bezoeker>();
            BezoekerUidwijzigNavigation = new HashSet<Bezoeker>();
            BranchMeasurementUidaanmkNavigation = new HashSet<BranchMeasurement>();
            BranchMeasurementUidwijzigNavigation = new HashSet<BranchMeasurement>();
            BranchfilterUidaanmkNavigation = new HashSet<Branchfilter>();
            BranchfilterUidwijzigNavigation = new HashSet<Branchfilter>();
            Branchfiltercache = new HashSet<Branchfiltercache>();
            CampaignDocumentenUidaanmkNavigation = new HashSet<CampaignDocumenten>();
            CampaignDocumentenUidwijzigNavigation = new HashSet<CampaignDocumenten>();
            CampaignLogboekUidaanmkNavigation = new HashSet<CampaignLogboek>();
            CampaignLogboekUidwijzigNavigation = new HashSet<CampaignLogboek>();
            CampaignMemoHistoryGebruiker = new HashSet<CampaignMemoHistory>();
            CampaignMemoHistoryUidaanmkNavigation = new HashSet<CampaignMemoHistory>();
            CampaignMemoHistoryUidwijzigNavigation = new HashSet<CampaignMemoHistory>();
            CampaignUidaanmkNavigation = new HashSet<Campaign>();
            CampaignUidwijzigNavigation = new HashSet<Campaign>();
            CampaignmailingDocumentenUidaanmkNavigation = new HashSet<CampaignmailingDocumenten>();
            CampaignmailingDocumentenUidwijzigNavigation = new HashSet<CampaignmailingDocumenten>();
            CampaignmailingLogboekUidaanmkNavigation = new HashSet<CampaignmailingLogboek>();
            CampaignmailingLogboekUidwijzigNavigation = new HashSet<CampaignmailingLogboek>();
            CampaignmailingMemoHistoryGebruiker = new HashSet<CampaignmailingMemoHistory>();
            CampaignmailingMemoHistoryUidaanmkNavigation = new HashSet<CampaignmailingMemoHistory>();
            CampaignmailingMemoHistoryUidwijzigNavigation = new HashSet<CampaignmailingMemoHistory>();
            CampaignmailingUidaanmkNavigation = new HashSet<Campaignmailing>();
            CampaignmailingUidwijzigNavigation = new HashSet<Campaignmailing>();
            Carts = new HashSet<Carts>();
            CategoryfilterUidaanmkNavigation = new HashSet<Categoryfilter>();
            CategoryfilterUidwijzigNavigation = new HashSet<Categoryfilter>();
            Categoryfiltercache = new HashSet<Categoryfiltercache>();
            ChangeActivitytemplateDocumentenUidaanmkNavigation = new HashSet<ChangeActivitytemplateDocumenten>();
            ChangeActivitytemplateDocumentenUidwijzigNavigation = new HashSet<ChangeActivitytemplateDocumenten>();
            ChangeActivitytemplateDocumentsUidaanmkNavigation = new HashSet<ChangeActivitytemplateDocuments>();
            ChangeActivitytemplateDocumentsUidwijzigNavigation = new HashSet<ChangeActivitytemplateDocuments>();
            ChangeActivitytemplateLogboekUidaanmkNavigation = new HashSet<ChangeActivitytemplateLogboek>();
            ChangeActivitytemplateLogboekUidwijzigNavigation = new HashSet<ChangeActivitytemplateLogboek>();
            ChangeActivitytemplateMemoHistoryGebruiker = new HashSet<ChangeActivitytemplateMemoHistory>();
            ChangeActivitytemplateMemoHistoryUidaanmkNavigation = new HashSet<ChangeActivitytemplateMemoHistory>();
            ChangeActivitytemplateMemoHistoryUidwijzigNavigation = new HashSet<ChangeActivitytemplateMemoHistory>();
            ChangeActivitytemplateUidaanmkNavigation = new HashSet<ChangeActivitytemplate>();
            ChangeActivitytemplateUidwijzigNavigation = new HashSet<ChangeActivitytemplate>();
            ChangeDocumentenUidaanmkNavigation = new HashSet<ChangeDocumenten>();
            ChangeDocumentenUidwijzigNavigation = new HashSet<ChangeDocumenten>();
            ChangeLogboekUidaanmkNavigation = new HashSet<ChangeLogboek>();
            ChangeLogboekUidwijzigNavigation = new HashSet<ChangeLogboek>();
            ChangeMemoHistoryGebruiker = new HashSet<ChangeMemoHistory>();
            ChangeMemoHistoryUidaanmkNavigation = new HashSet<ChangeMemoHistory>();
            ChangeMemoHistoryUidwijzigNavigation = new HashSet<ChangeMemoHistory>();
            ChangeTemplateDocumentenUidaanmkNavigation = new HashSet<ChangeTemplateDocumenten>();
            ChangeTemplateDocumentenUidwijzigNavigation = new HashSet<ChangeTemplateDocumenten>();
            ChangeTemplateDocumentsUidaanmkNavigation = new HashSet<ChangeTemplateDocuments>();
            ChangeTemplateDocumentsUidwijzigNavigation = new HashSet<ChangeTemplateDocuments>();
            ChangeTemplateLogboekUidaanmkNavigation = new HashSet<ChangeTemplateLogboek>();
            ChangeTemplateLogboekUidwijzigNavigation = new HashSet<ChangeTemplateLogboek>();
            ChangeTemplateMemoHistoryGebruiker = new HashSet<ChangeTemplateMemoHistory>();
            ChangeTemplateMemoHistoryUidaanmkNavigation = new HashSet<ChangeTemplateMemoHistory>();
            ChangeTemplateMemoHistoryUidwijzigNavigation = new HashSet<ChangeTemplateMemoHistory>();
            ChangeTemplateUidaanmkNavigation = new HashSet<ChangeTemplate>();
            ChangeTemplateUidwijzigNavigation = new HashSet<ChangeTemplate>();
            ChangeUidaanmkNavigation = new HashSet<Change>();
            ChangeUidwijzigNavigation = new HashSet<Change>();
            ChangeactivityDocumentenUidaanmkNavigation = new HashSet<ChangeactivityDocumenten>();
            ChangeactivityDocumentenUidwijzigNavigation = new HashSet<ChangeactivityDocumenten>();
            ChangeactivityLogboekUidaanmkNavigation = new HashSet<ChangeactivityLogboek>();
            ChangeactivityLogboekUidwijzigNavigation = new HashSet<ChangeactivityLogboek>();
            ChangeactivityMemoHistoryGebruiker = new HashSet<ChangeactivityMemoHistory>();
            ChangeactivityMemoHistoryUidaanmkNavigation = new HashSet<ChangeactivityMemoHistory>();
            ChangeactivityMemoHistoryUidwijzigNavigation = new HashSet<ChangeactivityMemoHistory>();
            ChangeactivityUidaanmkNavigation = new HashSet<Changeactivity>();
            ChangeactivityUidwijzigNavigation = new HashSet<Changeactivity>();
            Changeauthorization = new HashSet<Changeauthorization>();
            ChangeversionDocumentenUidaanmkNavigation = new HashSet<ChangeversionDocumenten>();
            ChangeversionDocumentenUidwijzigNavigation = new HashSet<ChangeversionDocumenten>();
            ChangeversionLogboekUidaanmkNavigation = new HashSet<ChangeversionLogboek>();
            ChangeversionLogboekUidwijzigNavigation = new HashSet<ChangeversionLogboek>();
            ChangeversionMemoHistoryGebruiker = new HashSet<ChangeversionMemoHistory>();
            ChangeversionMemoHistoryUidaanmkNavigation = new HashSet<ChangeversionMemoHistory>();
            ChangeversionMemoHistoryUidwijzigNavigation = new HashSet<ChangeversionMemoHistory>();
            ChangeversionUidaanmkNavigation = new HashSet<Changeversion>();
            ChangeversionUidwijzigNavigation = new HashSet<Changeversion>();
            ClassificatieUidaanmkNavigation = new HashSet<Classificatie>();
            ClassificatieUidwijzigNavigation = new HashSet<Classificatie>();
            ConfiguratieDocumentenUidaanmkNavigation = new HashSet<ConfiguratieDocumenten>();
            ConfiguratieDocumentenUidwijzigNavigation = new HashSet<ConfiguratieDocumenten>();
            ConfiguratieLogboekUidaanmkNavigation = new HashSet<ConfiguratieLogboek>();
            ConfiguratieLogboekUidwijzigNavigation = new HashSet<ConfiguratieLogboek>();
            ConfiguratieMemoHistoryGebruiker = new HashSet<ConfiguratieMemoHistory>();
            ConfiguratieMemoHistoryUidaanmkNavigation = new HashSet<ConfiguratieMemoHistory>();
            ConfiguratieMemoHistoryUidwijzigNavigation = new HashSet<ConfiguratieMemoHistory>();
            ConfiguratieUidaanmkNavigation = new HashSet<Configuratie>();
            ConfiguratieUidwijzigNavigation = new HashSet<Configuratie>();
            DnocontractDocumentenUidaanmkNavigation = new HashSet<DnocontractDocumenten>();
            DnocontractDocumentenUidwijzigNavigation = new HashSet<DnocontractDocumenten>();
            DnocontractLogboekUidaanmkNavigation = new HashSet<DnocontractLogboek>();
            DnocontractLogboekUidwijzigNavigation = new HashSet<DnocontractLogboek>();
            DnocontractMemoHistoryGebruiker = new HashSet<DnocontractMemoHistory>();
            DnocontractMemoHistoryUidaanmkNavigation = new HashSet<DnocontractMemoHistory>();
            DnocontractMemoHistoryUidwijzigNavigation = new HashSet<DnocontractMemoHistory>();
            DnocontractUidaanmkNavigation = new HashSet<Dnocontract>();
            DnocontractUidwijzigNavigation = new HashSet<Dnocontract>();
            DnodienstDocumentenUidaanmkNavigation = new HashSet<DnodienstDocumenten>();
            DnodienstDocumentenUidwijzigNavigation = new HashSet<DnodienstDocumenten>();
            DnodienstLogboekUidaanmkNavigation = new HashSet<DnodienstLogboek>();
            DnodienstLogboekUidwijzigNavigation = new HashSet<DnodienstLogboek>();
            DnodienstMemoHistoryGebruiker = new HashSet<DnodienstMemoHistory>();
            DnodienstMemoHistoryUidaanmkNavigation = new HashSet<DnodienstMemoHistory>();
            DnodienstMemoHistoryUidwijzigNavigation = new HashSet<DnodienstMemoHistory>();
            DnodienstUidaanmkNavigation = new HashSet<Dnodienst>();
            DnodienstUidwijzigNavigation = new HashSet<Dnodienst>();
            EmailberichtUidaanmkNavigation = new HashSet<Emailbericht>();
            EmailberichtUidwijzigNavigation = new HashSet<Emailbericht>();
            GebruikerDocumentenKaart = new HashSet<GebruikerDocumenten>();
            GebruikerDocumentenUidaanmkNavigation = new HashSet<GebruikerDocumenten>();
            GebruikerDocumentenUidwijzigNavigation = new HashSet<GebruikerDocumenten>();
            GebruikerEmailberichten = new HashSet<GebruikerEmailberichten>();
            GebruikerLogboekKaart = new HashSet<GebruikerLogboek>();
            GebruikerLogboekUidaanmkNavigation = new HashSet<GebruikerLogboek>();
            GebruikerLogboekUidwijzigNavigation = new HashSet<GebruikerLogboek>();
            GebruikerMemoHistoryGebruiker = new HashSet<GebruikerMemoHistory>();
            GebruikerMemoHistoryParent = new HashSet<GebruikerMemoHistory>();
            GebruikerMemoHistoryUidaanmkNavigation = new HashSet<GebruikerMemoHistory>();
            GebruikerMemoHistoryUidwijzigNavigation = new HashSet<GebruikerMemoHistory>();
            HardwareDocumentenUidaanmkNavigation = new HashSet<HardwareDocumenten>();
            HardwareDocumentenUidwijzigNavigation = new HashSet<HardwareDocumenten>();
            HardwareLogboekUidaanmkNavigation = new HashSet<HardwareLogboek>();
            HardwareLogboekUidwijzigNavigation = new HashSet<HardwareLogboek>();
            HardwareOptionalgridUidaanmkNavigation = new HashSet<HardwareOptionalgrid>();
            HardwareOptionalgridUidwijzigNavigation = new HashSet<HardwareOptionalgrid>();
            HardwareUidaanmkNavigation = new HashSet<Hardware>();
            HardwareUidwijzigNavigation = new HashSet<Hardware>();
            HerhalingUidaanmkNavigation = new HashSet<Herhaling>();
            HerhalingUidwijzigNavigation = new HashSet<Herhaling>();
            ImportsettingsImportuser = new HashSet<Importsettings>();
            ImportsettingsUidaanmkNavigation = new HashSet<Importsettings>();
            ImportsettingsUidwijzigNavigation = new HashSet<Importsettings>();
            IncidentDocumentenUidaanmkNavigation = new HashSet<IncidentDocumenten>();
            IncidentDocumentenUidwijzigNavigation = new HashSet<IncidentDocumenten>();
            IncidentLogboekUidaanmkNavigation = new HashSet<IncidentLogboek>();
            IncidentLogboekUidwijzigNavigation = new HashSet<IncidentLogboek>();
            IncidentMemogeschiedenisGebruiker = new HashSet<IncidentMemogeschiedenis>();
            IncidentMemogeschiedenisUidaanmkNavigation = new HashSet<IncidentMemogeschiedenis>();
            IncidentMemogeschiedenisUidwijzigNavigation = new HashSet<IncidentMemogeschiedenis>();
            IncidentUidaanmkNavigation = new HashSet<Incident>();
            IncidentUidwijzigNavigation = new HashSet<Incident>();
            InventarisDocumentenUidaanmkNavigation = new HashSet<InventarisDocumenten>();
            InventarisDocumentenUidwijzigNavigation = new HashSet<InventarisDocumenten>();
            InventarisLogboekUidaanmkNavigation = new HashSet<InventarisLogboek>();
            InventarisLogboekUidwijzigNavigation = new HashSet<InventarisLogboek>();
            InventarisOptionalgridUidaanmkNavigation = new HashSet<InventarisOptionalgrid>();
            InventarisOptionalgridUidwijzigNavigation = new HashSet<InventarisOptionalgrid>();
            InventarisUidaanmkNavigation = new HashSet<Inventaris>();
            InventarisUidwijzigNavigation = new HashSet<Inventaris>();
            InverseUidaanmkNavigation = new HashSet<Gebruiker>();
            InverseUidwijzigNavigation = new HashSet<Gebruiker>();
            KennisSysteemDocumentenUidaanmkNavigation = new HashSet<KennisSysteemDocumenten>();
            KennisSysteemDocumentenUidwijzigNavigation = new HashSet<KennisSysteemDocumenten>();
            KennisSysteemUidaanmkNavigation = new HashSet<KennisSysteem>();
            KennisSysteemUidwijzigNavigation = new HashSet<KennisSysteem>();
            KennissysteemreactieUidaanmkNavigation = new HashSet<Kennissysteemreactie>();
            KennissysteemreactieUidwijzigNavigation = new HashSet<Kennissysteemreactie>();
            KennissysteemvertalingenUidaanmkNavigation = new HashSet<Kennissysteemvertalingen>();
            KennissysteemvertalingenUidwijzigNavigation = new HashSet<Kennissysteemvertalingen>();
            KostendeclaratieArtikelUidaanmkNavigation = new HashSet<KostendeclaratieArtikel>();
            KostendeclaratieArtikelUidwijzigNavigation = new HashSet<KostendeclaratieArtikel>();
            KostendeclaratieObjectUidaanmkNavigation = new HashSet<KostendeclaratieObject>();
            KostendeclaratieObjectUidwijzigNavigation = new HashSet<KostendeclaratieObject>();
            LeverancierDocumentenUidaanmkNavigation = new HashSet<LeverancierDocumenten>();
            LeverancierDocumentenUidwijzigNavigation = new HashSet<LeverancierDocumenten>();
            LeverancierLogboekUidaanmkNavigation = new HashSet<LeverancierLogboek>();
            LeverancierLogboekUidwijzigNavigation = new HashSet<LeverancierLogboek>();
            LeverancierMemoHistoryGebruiker = new HashSet<LeverancierMemoHistory>();
            LeverancierMemoHistoryUidaanmkNavigation = new HashSet<LeverancierMemoHistory>();
            LeverancierMemoHistoryUidwijzigNavigation = new HashSet<LeverancierMemoHistory>();
            LeverancierUidaanmkNavigation = new HashSet<Leverancier>();
            LeverancierUidwijzigNavigation = new HashSet<Leverancier>();
            LeveranciercontactpersoonDocumentenUidaanmkNavigation = new HashSet<LeveranciercontactpersoonDocumenten>();
            LeveranciercontactpersoonDocumentenUidwijzigNavigation = new HashSet<LeveranciercontactpersoonDocumenten>();
            LeveranciercontactpersoonLogboekUidaanmkNavigation = new HashSet<LeveranciercontactpersoonLogboek>();
            LeveranciercontactpersoonLogboekUidwijzigNavigation = new HashSet<LeveranciercontactpersoonLogboek>();
            LeveranciercontactpersoonUidaanmkNavigation = new HashSet<Leveranciercontactpersoon>();
            LeveranciercontactpersoonUidwijzigNavigation = new HashSet<Leveranciercontactpersoon>();
            LicentieDocumentenUidaanmkNavigation = new HashSet<LicentieDocumenten>();
            LicentieDocumentenUidwijzigNavigation = new HashSet<LicentieDocumenten>();
            LicentieLogboekUidaanmkNavigation = new HashSet<LicentieLogboek>();
            LicentieLogboekUidwijzigNavigation = new HashSet<LicentieLogboek>();
            LicentieUidaanmkNavigation = new HashSet<Licentie>();
            LicentieUidwijzigNavigation = new HashSet<Licentie>();
            LmpactivityDocumentenUidaanmkNavigation = new HashSet<LmpactivityDocumenten>();
            LmpactivityDocumentenUidwijzigNavigation = new HashSet<LmpactivityDocumenten>();
            LmpactivityLogboekUidaanmkNavigation = new HashSet<LmpactivityLogboek>();
            LmpactivityLogboekUidwijzigNavigation = new HashSet<LmpactivityLogboek>();
            LmpactivityMemoHistoryGebruiker = new HashSet<LmpactivityMemoHistory>();
            LmpactivityMemoHistoryUidaanmkNavigation = new HashSet<LmpactivityMemoHistory>();
            LmpactivityMemoHistoryUidwijzigNavigation = new HashSet<LmpactivityMemoHistory>();
            LmpactivityUidaanmkNavigation = new HashSet<Lmpactivity>();
            LmpactivityUidwijzigNavigation = new HashSet<Lmpactivity>();
            LmpscenarioDocumentenUidaanmkNavigation = new HashSet<LmpscenarioDocumenten>();
            LmpscenarioDocumentenUidwijzigNavigation = new HashSet<LmpscenarioDocumenten>();
            LmpscenarioLogboekUidaanmkNavigation = new HashSet<LmpscenarioLogboek>();
            LmpscenarioLogboekUidwijzigNavigation = new HashSet<LmpscenarioLogboek>();
            LmpscenarioMemoHistoryGebruiker = new HashSet<LmpscenarioMemoHistory>();
            LmpscenarioMemoHistoryUidaanmkNavigation = new HashSet<LmpscenarioMemoHistory>();
            LmpscenarioMemoHistoryUidwijzigNavigation = new HashSet<LmpscenarioMemoHistory>();
            LmpscenarioUidaanmkNavigation = new HashSet<Lmpscenario>();
            LmpscenarioUidwijzigNavigation = new HashSet<Lmpscenario>();
            LocatieDocumentenUidaanmkNavigation = new HashSet<LocatieDocumenten>();
            LocatieDocumentenUidwijzigNavigation = new HashSet<LocatieDocumenten>();
            LocatieLogboekUidaanmkNavigation = new HashSet<LocatieLogboek>();
            LocatieLogboekUidwijzigNavigation = new HashSet<LocatieLogboek>();
            LocatieMemoHistoryGebruiker = new HashSet<LocatieMemoHistory>();
            LocatieMemoHistoryUidaanmkNavigation = new HashSet<LocatieMemoHistory>();
            LocatieMemoHistoryUidwijzigNavigation = new HashSet<LocatieMemoHistory>();
            LocatieOptionalgridUidaanmkNavigation = new HashSet<LocatieOptionalgrid>();
            LocatieOptionalgridUidwijzigNavigation = new HashSet<LocatieOptionalgrid>();
            LocatieUidaanmkNavigation = new HashSet<Locatie>();
            LocatieUidwijzigNavigation = new HashSet<Locatie>();
            MailactiebestandUidaanmkNavigation = new HashSet<Mailactiebestand>();
            MailactiebestandUidwijzigNavigation = new HashSet<Mailactiebestand>();
            MailimportChangeUidaanmkNavigation = new HashSet<MailimportChange>();
            MailimportChangeUidwijzigNavigation = new HashSet<MailimportChange>();
            MailimportIncidentUidaanmkNavigation = new HashSet<MailimportIncident>();
            MailimportIncidentUidwijzigNavigation = new HashSet<MailimportIncident>();
            MailimportSettingsExecuteasuser = new HashSet<MailimportSettings>();
            MailimportSettingsUidaanmkNavigation = new HashSet<MailimportSettings>();
            MailimportSettingsUidwijzigNavigation = new HashSet<MailimportSettings>();
            MeetingDocumentenUidaanmkNavigation = new HashSet<MeetingDocumenten>();
            MeetingDocumentenUidwijzigNavigation = new HashSet<MeetingDocumenten>();
            MeetingLogboekUidaanmkNavigation = new HashSet<MeetingLogboek>();
            MeetingLogboekUidwijzigNavigation = new HashSet<MeetingLogboek>();
            MeetingMemoHistoryGebruiker = new HashSet<MeetingMemoHistory>();
            MeetingMemoHistoryUidaanmkNavigation = new HashSet<MeetingMemoHistory>();
            MeetingMemoHistoryUidwijzigNavigation = new HashSet<MeetingMemoHistory>();
            MeetingUidaanmkNavigation = new HashSet<Meeting>();
            MeetingUidwijzigNavigation = new HashSet<Meeting>();
            MutatieBestelaanvraag = new HashSet<MutatieBestelaanvraag>();
            MutatieBestellingen = new HashSet<MutatieBestellingen>();
            MutatieChange = new HashSet<MutatieChange>();
            MutatieChangeactivity = new HashSet<MutatieChangeactivity>();
            MutatieChangeversion = new HashSet<MutatieChangeversion>();
            MutatieConfiguratie = new HashSet<MutatieConfiguratie>();
            MutatieDnocontract = new HashSet<MutatieDnocontract>();
            MutatieDnodienst = new HashSet<MutatieDnodienst>();
            MutatieHardware = new HashSet<MutatieHardware>();
            MutatieIncident = new HashSet<MutatieIncident>();
            MutatieInventaris = new HashSet<MutatieInventaris>();
            MutatieNetwerkcomponent = new HashSet<MutatieNetwerkcomponent>();
            MutatieOmActiviteit = new HashSet<MutatieOmActiviteit>();
            MutatieOmReeks = new HashSet<MutatieOmReeks>();
            MutatieOmSchema = new HashSet<MutatieOmSchema>();
            MutatieProbleem = new HashSet<MutatieProbleem>();
            MutatieProfacboomProject = new HashSet<MutatieProfacboomProject>();
            MutatieReservering = new HashSet<MutatieReservering>();
            MutatieSoftware = new HashSet<MutatieSoftware>();
            MutatieTelefonie = new HashSet<MutatieTelefonie>();
            MutatieVestiging = new HashSet<MutatieVestiging>();
            MutatieVrij1object = new HashSet<MutatieVrij1object>();
            MutatieVrij2object = new HashSet<MutatieVrij2object>();
            MutatieVrij3object = new HashSet<MutatieVrij3object>();
            MutatieVrij4object = new HashSet<MutatieVrij4object>();
            MutatieVrij5object = new HashSet<MutatieVrij5object>();
            NetwerkcomponentDocumentenUidaanmkNavigation = new HashSet<NetwerkcomponentDocumenten>();
            NetwerkcomponentDocumentenUidwijzigNavigation = new HashSet<NetwerkcomponentDocumenten>();
            NetwerkcomponentLogboekUidaanmkNavigation = new HashSet<NetwerkcomponentLogboek>();
            NetwerkcomponentLogboekUidwijzigNavigation = new HashSet<NetwerkcomponentLogboek>();
            NetwerkcomponentOptionalgridUidaanmkNavigation = new HashSet<NetwerkcomponentOptionalgrid>();
            NetwerkcomponentOptionalgridUidwijzigNavigation = new HashSet<NetwerkcomponentOptionalgrid>();
            NetwerkcomponentUidaanmkNavigation = new HashSet<Netwerkcomponent>();
            NetwerkcomponentUidwijzigNavigation = new HashSet<Netwerkcomponent>();
            ObjectUidaanmkNavigation = new HashSet<Object>();
            ObjectUidwijzigNavigation = new HashSet<Object>();
            OmActiviteitDocumentenUidaanmkNavigation = new HashSet<OmActiviteitDocumenten>();
            OmActiviteitDocumentenUidwijzigNavigation = new HashSet<OmActiviteitDocumenten>();
            OmActiviteitLogboekUidaanmkNavigation = new HashSet<OmActiviteitLogboek>();
            OmActiviteitLogboekUidwijzigNavigation = new HashSet<OmActiviteitLogboek>();
            OmActiviteitMemoHistoryGebruiker = new HashSet<OmActiviteitMemoHistory>();
            OmActiviteitMemoHistoryUidaanmkNavigation = new HashSet<OmActiviteitMemoHistory>();
            OmActiviteitMemoHistoryUidwijzigNavigation = new HashSet<OmActiviteitMemoHistory>();
            OmActiviteitUidaanmkNavigation = new HashSet<OmActiviteit>();
            OmActiviteitUidwijzigNavigation = new HashSet<OmActiviteit>();
            OmGroeperingUidaanmkNavigation = new HashSet<OmGroepering>();
            OmGroeperingUidwijzigNavigation = new HashSet<OmGroepering>();
            OmReeksDocumentenUidaanmkNavigation = new HashSet<OmReeksDocumenten>();
            OmReeksDocumentenUidwijzigNavigation = new HashSet<OmReeksDocumenten>();
            OmReeksLogboekUidaanmkNavigation = new HashSet<OmReeksLogboek>();
            OmReeksLogboekUidwijzigNavigation = new HashSet<OmReeksLogboek>();
            OmReeksMemoHistoryGebruiker = new HashSet<OmReeksMemoHistory>();
            OmReeksMemoHistoryUidaanmkNavigation = new HashSet<OmReeksMemoHistory>();
            OmReeksMemoHistoryUidwijzigNavigation = new HashSet<OmReeksMemoHistory>();
            OmReeksUidaanmkNavigation = new HashSet<OmReeks>();
            OmReeksUidwijzigNavigation = new HashSet<OmReeks>();
            OmSchemaDocumentenUidaanmkNavigation = new HashSet<OmSchemaDocumenten>();
            OmSchemaDocumentenUidwijzigNavigation = new HashSet<OmSchemaDocumenten>();
            OmSchemaLogboekUidaanmkNavigation = new HashSet<OmSchemaLogboek>();
            OmSchemaLogboekUidwijzigNavigation = new HashSet<OmSchemaLogboek>();
            OmSchemaMemoHistoryGebruiker = new HashSet<OmSchemaMemoHistory>();
            OmSchemaMemoHistoryUidaanmkNavigation = new HashSet<OmSchemaMemoHistory>();
            OmSchemaMemoHistoryUidwijzigNavigation = new HashSet<OmSchemaMemoHistory>();
            OmSchemaUidaanmkNavigation = new HashSet<OmSchema>();
            OmSchemaUidwijzigNavigation = new HashSet<OmSchema>();
            OperatorPermissiongroup = new HashSet<OperatorPermissiongroup>();
            OperatorfilterUidaanmkNavigation = new HashSet<Operatorfilter>();
            OperatorfilterUidwijzigNavigation = new HashSet<Operatorfilter>();
            Operatorfiltercache = new HashSet<Operatorfiltercache>();
            OplossingenDocumentenUidaanmkNavigation = new HashSet<OplossingenDocumenten>();
            OplossingenDocumentenUidwijzigNavigation = new HashSet<OplossingenDocumenten>();
            OplossingenLogboekUidaanmkNavigation = new HashSet<OplossingenLogboek>();
            OplossingenLogboekUidwijzigNavigation = new HashSet<OplossingenLogboek>();
            OplossingenUidaanmkNavigation = new HashSet<Oplossingen>();
            OplossingenUidwijzigNavigation = new HashSet<Oplossingen>();
            PersoonDocumentenUidaanmkNavigation = new HashSet<PersoonDocumenten>();
            PersoonDocumentenUidwijzigNavigation = new HashSet<PersoonDocumenten>();
            PersoonLogboekUidaanmkNavigation = new HashSet<PersoonLogboek>();
            PersoonLogboekUidwijzigNavigation = new HashSet<PersoonLogboek>();
            PersoonMemoHistoryGebruiker = new HashSet<PersoonMemoHistory>();
            PersoonMemoHistoryUidaanmkNavigation = new HashSet<PersoonMemoHistory>();
            PersoonMemoHistoryUidwijzigNavigation = new HashSet<PersoonMemoHistory>();
            PersoonOptionalgridUidaanmkNavigation = new HashSet<PersoonOptionalgrid>();
            PersoonOptionalgridUidwijzigNavigation = new HashSet<PersoonOptionalgrid>();
            PersoonUidaanmkNavigation = new HashSet<Persoon>();
            PersoonUidwijzigNavigation = new HashSet<Persoon>();
            PersoongroepDocumentenUidaanmkNavigation = new HashSet<PersoongroepDocumenten>();
            PersoongroepDocumentenUidwijzigNavigation = new HashSet<PersoongroepDocumenten>();
            PersoongroepLogboekUidaanmkNavigation = new HashSet<PersoongroepLogboek>();
            PersoongroepLogboekUidwijzigNavigation = new HashSet<PersoongroepLogboek>();
            PersoongroepMemoHistoryGebruiker = new HashSet<PersoongroepMemoHistory>();
            PersoongroepMemoHistoryUidaanmkNavigation = new HashSet<PersoongroepMemoHistory>();
            PersoongroepMemoHistoryUidwijzigNavigation = new HashSet<PersoongroepMemoHistory>();
            PersoongroepUidaanmkNavigation = new HashSet<Persoongroep>();
            PersoongroepUidwijzigNavigation = new HashSet<Persoongroep>();
            PictureUidaanmkNavigation = new HashSet<Picture>();
            PictureUidwijzigNavigation = new HashSet<Picture>();
            Planboardgroupstate = new HashSet<Planboardgroupstate>();
            PlanningUidaanmkNavigation = new HashSet<Planning>();
            PlanningUidwijzigNavigation = new HashSet<Planning>();
            PoortDocumentenUidaanmkNavigation = new HashSet<PoortDocumenten>();
            PoortDocumentenUidwijzigNavigation = new HashSet<PoortDocumenten>();
            PoortLogboekUidaanmkNavigation = new HashSet<PoortLogboek>();
            PoortLogboekUidwijzigNavigation = new HashSet<PoortLogboek>();
            PoortUidaanmkNavigation = new HashSet<Poort>();
            PoortUidwijzigNavigation = new HashSet<Poort>();
            ProbleemDocumentenUidaanmkNavigation = new HashSet<ProbleemDocumenten>();
            ProbleemDocumentenUidwijzigNavigation = new HashSet<ProbleemDocumenten>();
            ProbleemLogboekUidaanmkNavigation = new HashSet<ProbleemLogboek>();
            ProbleemLogboekUidwijzigNavigation = new HashSet<ProbleemLogboek>();
            ProbleemMemogeschiedenisGebruiker = new HashSet<ProbleemMemogeschiedenis>();
            ProbleemMemogeschiedenisUidaanmkNavigation = new HashSet<ProbleemMemogeschiedenis>();
            ProbleemMemogeschiedenisUidwijzigNavigation = new HashSet<ProbleemMemogeschiedenis>();
            ProbleemUidaanmkNavigation = new HashSet<Probleem>();
            ProbleemUidwijzigNavigation = new HashSet<Probleem>();
            ProfacboomProjectDocumentenUidaanmkNavigation = new HashSet<ProfacboomProjectDocumenten>();
            ProfacboomProjectDocumentenUidwijzigNavigation = new HashSet<ProfacboomProjectDocumenten>();
            ProfacboomProjectLogboekUidaanmkNavigation = new HashSet<ProfacboomProjectLogboek>();
            ProfacboomProjectLogboekUidwijzigNavigation = new HashSet<ProfacboomProjectLogboek>();
            ProfacboomProjectMemoHistoryGebruiker = new HashSet<ProfacboomProjectMemoHistory>();
            ProfacboomProjectMemoHistoryUidaanmkNavigation = new HashSet<ProfacboomProjectMemoHistory>();
            ProfacboomProjectMemoHistoryUidwijzigNavigation = new HashSet<ProfacboomProjectMemoHistory>();
            ProfacboomProjectUidaanmkNavigation = new HashSet<ProfacboomProject>();
            ProfacboomProjectUidwijzigNavigation = new HashSet<ProfacboomProject>();
            ProjectbeheerdocumentenUidaanmkNavigation = new HashSet<Projectbeheerdocumenten>();
            ProjectbeheerdocumentenUidwijzigNavigation = new HashSet<Projectbeheerdocumenten>();
            RecurringeventUidaanmkNavigation = new HashSet<Recurringevent>();
            RecurringeventUidwijzigNavigation = new HashSet<Recurringevent>();
            ReportactionDocumentenUidaanmkNavigation = new HashSet<ReportactionDocumenten>();
            ReportactionDocumentenUidwijzigNavigation = new HashSet<ReportactionDocumenten>();
            ReportactionLogboekUidaanmkNavigation = new HashSet<ReportactionLogboek>();
            ReportactionLogboekUidwijzigNavigation = new HashSet<ReportactionLogboek>();
            ReportactionReportmailuser = new HashSet<Reportaction>();
            ReportactionUidaanmkNavigation = new HashSet<Reportaction>();
            ReportactionUidwijzigNavigation = new HashSet<Reportaction>();
            ReportwizardRole = new HashSet<Reportwizard>();
            ReportwizardUidaanmkNavigation = new HashSet<Reportwizard>();
            ReportwizardUidwijzigNavigation = new HashSet<Reportwizard>();
            ReservationDocumentenUidaanmkNavigation = new HashSet<ReservationDocumenten>();
            ReservationDocumentenUidwijzigNavigation = new HashSet<ReservationDocumenten>();
            ReservationEventDocumentenUidaanmkNavigation = new HashSet<ReservationEventDocumenten>();
            ReservationEventDocumentenUidwijzigNavigation = new HashSet<ReservationEventDocumenten>();
            ReservationEventUidaanmkNavigation = new HashSet<ReservationEvent>();
            ReservationEventUidwijzigNavigation = new HashSet<ReservationEvent>();
            ReservationFacilityFavorites = new HashSet<ReservationFacilityFavorites>();
            ReservationFacilityLinkUidaanmkNavigation = new HashSet<ReservationFacilityLink>();
            ReservationFacilityLinkUidwijzigNavigation = new HashSet<ReservationFacilityLink>();
            ReservationLogboekUidaanmkNavigation = new HashSet<ReservationLogboek>();
            ReservationLogboekUidwijzigNavigation = new HashSet<ReservationLogboek>();
            ReservationMemoHistoryGebruiker = new HashSet<ReservationMemoHistory>();
            ReservationMemoHistoryUidaanmkNavigation = new HashSet<ReservationMemoHistory>();
            ReservationMemoHistoryUidwijzigNavigation = new HashSet<ReservationMemoHistory>();
            ReservationServiceLinkUidaanmkNavigation = new HashSet<ReservationServiceLink>();
            ReservationServiceLinkUidwijzigNavigation = new HashSet<ReservationServiceLink>();
            ReservationUidaanmkNavigation = new HashSet<Reservation>();
            ReservationUidwijzigNavigation = new HashSet<Reservation>();
            ReserveringDocumentenUidaanmkNavigation = new HashSet<ReserveringDocumenten>();
            ReserveringDocumentenUidwijzigNavigation = new HashSet<ReserveringDocumenten>();
            ReserveringLocatieLinkUidaanmkNavigation = new HashSet<ReserveringLocatieLink>();
            ReserveringLocatieLinkUidwijzigNavigation = new HashSet<ReserveringLocatieLink>();
            ReserveringLogboekUidaanmkNavigation = new HashSet<ReserveringLogboek>();
            ReserveringLogboekUidwijzigNavigation = new HashSet<ReserveringLogboek>();
            ReserveringObjectLinkUidaanmkNavigation = new HashSet<ReserveringObjectLink>();
            ReserveringObjectLinkUidwijzigNavigation = new HashSet<ReserveringObjectLink>();
            ReserveringUidaanmkNavigation = new HashSet<Reservering>();
            ReserveringUidwijzigNavigation = new HashSet<Reservering>();
            ReserveringVoorzieningLinkDocumentenUidaanmkNavigation = new HashSet<ReserveringVoorzieningLinkDocumenten>();
            ReserveringVoorzieningLinkDocumentenUidwijzigNavigation = new HashSet<ReserveringVoorzieningLinkDocumenten>();
            ReserveringVoorzieningLinkLogboekUidaanmkNavigation = new HashSet<ReserveringVoorzieningLinkLogboek>();
            ReserveringVoorzieningLinkLogboekUidwijzigNavigation = new HashSet<ReserveringVoorzieningLinkLogboek>();
            ReserveringVoorzieningLinkUidaanmkNavigation = new HashSet<ReserveringVoorzieningLink>();
            ReserveringVoorzieningLinkUidwijzigNavigation = new HashSet<ReserveringVoorzieningLink>();
            RmSeriesUidaanmkNavigation = new HashSet<RmSeries>();
            RmSeriesUidwijzigNavigation = new HashSet<RmSeries>();
            ScheduleUidaanmkNavigation = new HashSet<Schedule>();
            ScheduleUidwijzigNavigation = new HashSet<Schedule>();
            SelvastGroep = new HashSet<Selvast>();
            SelvastUidaanmkNavigation = new HashSet<Selvast>();
            SelvastUidwijzigNavigation = new HashSet<Selvast>();
            ServicelevelDocumentenUidaanmkNavigation = new HashSet<ServicelevelDocumenten>();
            ServicelevelDocumentenUidwijzigNavigation = new HashSet<ServicelevelDocumenten>();
            ServicelevelLogboekUidaanmkNavigation = new HashSet<ServicelevelLogboek>();
            ServicelevelLogboekUidwijzigNavigation = new HashSet<ServicelevelLogboek>();
            ServicelevelMemoHistoryGebruiker = new HashSet<ServicelevelMemoHistory>();
            ServicelevelMemoHistoryUidaanmkNavigation = new HashSet<ServicelevelMemoHistory>();
            ServicelevelMemoHistoryUidwijzigNavigation = new HashSet<ServicelevelMemoHistory>();
            ServicelevelUidaanmkNavigation = new HashSet<Servicelevel>();
            ServicelevelUidwijzigNavigation = new HashSet<Servicelevel>();
            ServicewindowDocumentenUidaanmkNavigation = new HashSet<ServicewindowDocumenten>();
            ServicewindowDocumentenUidwijzigNavigation = new HashSet<ServicewindowDocumenten>();
            ServicewindowLogboekUidaanmkNavigation = new HashSet<ServicewindowLogboek>();
            ServicewindowLogboekUidwijzigNavigation = new HashSet<ServicewindowLogboek>();
            ServicewindowMemoHistoryGebruiker = new HashSet<ServicewindowMemoHistory>();
            ServicewindowMemoHistoryUidaanmkNavigation = new HashSet<ServicewindowMemoHistory>();
            ServicewindowMemoHistoryUidwijzigNavigation = new HashSet<ServicewindowMemoHistory>();
            ServicewindowUidaanmkNavigation = new HashSet<Servicewindow>();
            ServicewindowUidwijzigNavigation = new HashSet<Servicewindow>();
            Settings = new HashSet<Settings>();
            ShiftUidaanmkNavigation = new HashSet<Shift>();
            ShiftUidwijzigNavigation = new HashSet<Shift>();
            Shiftpriority = new HashSet<Shiftpriority>();
            ShiftsegmentUidaanmkNavigation = new HashSet<Shiftsegment>();
            ShiftsegmentUidwijzigNavigation = new HashSet<Shiftsegment>();
            SoftwareDocumentenUidaanmkNavigation = new HashSet<SoftwareDocumenten>();
            SoftwareDocumentenUidwijzigNavigation = new HashSet<SoftwareDocumenten>();
            SoftwareLogboekUidaanmkNavigation = new HashSet<SoftwareLogboek>();
            SoftwareLogboekUidwijzigNavigation = new HashSet<SoftwareLogboek>();
            SoftwareOptionalgridUidaanmkNavigation = new HashSet<SoftwareOptionalgrid>();
            SoftwareOptionalgridUidwijzigNavigation = new HashSet<SoftwareOptionalgrid>();
            SoftwareUidaanmkNavigation = new HashSet<Software>();
            SoftwareUidwijzigNavigation = new HashSet<Software>();
            Soort = new HashSet<Soort>();
            SsdFormUidaanmkNavigation = new HashSet<SsdForm>();
            SsdFormUidwijzigNavigation = new HashSet<SsdForm>();
            SuppliercontactMemoHistoryGebruiker = new HashSet<SuppliercontactMemoHistory>();
            SuppliercontactMemoHistoryUidaanmkNavigation = new HashSet<SuppliercontactMemoHistory>();
            SuppliercontactMemoHistoryUidwijzigNavigation = new HashSet<SuppliercontactMemoHistory>();
            SurveyDocumentenUidaanmkNavigation = new HashSet<SurveyDocumenten>();
            SurveyDocumentenUidwijzigNavigation = new HashSet<SurveyDocumenten>();
            SurveyLogboekUidaanmkNavigation = new HashSet<SurveyLogboek>();
            SurveyLogboekUidwijzigNavigation = new HashSet<SurveyLogboek>();
            SurveyMemoHistoryGebruiker = new HashSet<SurveyMemoHistory>();
            SurveyMemoHistoryUidaanmkNavigation = new HashSet<SurveyMemoHistory>();
            SurveyMemoHistoryUidwijzigNavigation = new HashSet<SurveyMemoHistory>();
            SurveyUidaanmkNavigation = new HashSet<Survey>();
            SurveyUidwijzigNavigation = new HashSet<Survey>();
            SurveyanswerUidaanmkNavigation = new HashSet<Surveyanswer>();
            SurveyanswerUidwijzigNavigation = new HashSet<Surveyanswer>();
            SurveyquestionDocumentenUidaanmkNavigation = new HashSet<SurveyquestionDocumenten>();
            SurveyquestionDocumentenUidwijzigNavigation = new HashSet<SurveyquestionDocumenten>();
            SurveyquestionLogboekUidaanmkNavigation = new HashSet<SurveyquestionLogboek>();
            SurveyquestionLogboekUidwijzigNavigation = new HashSet<SurveyquestionLogboek>();
            SurveyquestionMemoHistoryGebruiker = new HashSet<SurveyquestionMemoHistory>();
            SurveyquestionMemoHistoryUidaanmkNavigation = new HashSet<SurveyquestionMemoHistory>();
            SurveyquestionMemoHistoryUidwijzigNavigation = new HashSet<SurveyquestionMemoHistory>();
            SurveyquestionUidaanmkNavigation = new HashSet<Surveyquestion>();
            SurveyquestionUidwijzigNavigation = new HashSet<Surveyquestion>();
            SystemeventsDocumentenUidaanmkNavigation = new HashSet<SystemeventsDocumenten>();
            SystemeventsDocumentenUidwijzigNavigation = new HashSet<SystemeventsDocumenten>();
            SystemeventsLogboekUidaanmkNavigation = new HashSet<SystemeventsLogboek>();
            SystemeventsLogboekUidwijzigNavigation = new HashSet<SystemeventsLogboek>();
            TaskroleUidaanmkNavigation = new HashSet<Taskrole>();
            TaskroleUidwijzigNavigation = new HashSet<Taskrole>();
            Taskrolepriority = new HashSet<Taskrolepriority>();
            TelefonieDocumentenUidaanmkNavigation = new HashSet<TelefonieDocumenten>();
            TelefonieDocumentenUidwijzigNavigation = new HashSet<TelefonieDocumenten>();
            TelefonieLogboekUidaanmkNavigation = new HashSet<TelefonieLogboek>();
            TelefonieLogboekUidwijzigNavigation = new HashSet<TelefonieLogboek>();
            TelefonieOptionalgridUidaanmkNavigation = new HashSet<TelefonieOptionalgrid>();
            TelefonieOptionalgridUidwijzigNavigation = new HashSet<TelefonieOptionalgrid>();
            TelefonieUidaanmkNavigation = new HashSet<Telefonie>();
            TelefonieUidwijzigNavigation = new HashSet<Telefonie>();
            TimeRegistrationChangeUidaanmkNavigation = new HashSet<TimeRegistrationChange>();
            TimeRegistrationChangeUidwijzigNavigation = new HashSet<TimeRegistrationChange>();
            TimeRegistrationChangeactivityUidaanmkNavigation = new HashSet<TimeRegistrationChangeactivity>();
            TimeRegistrationChangeactivityUidwijzigNavigation = new HashSet<TimeRegistrationChangeactivity>();
            TimeRegistrationIncidentUidaanmkNavigation = new HashSet<TimeRegistrationIncident>();
            TimeRegistrationIncidentUidwijzigNavigation = new HashSet<TimeRegistrationIncident>();
            TimeRegistrationOmActiviteitUidaanmkNavigation = new HashSet<TimeRegistrationOmActiviteit>();
            TimeRegistrationOmActiviteitUidwijzigNavigation = new HashSet<TimeRegistrationOmActiviteit>();
            TimeRegistrationProbleemUidaanmkNavigation = new HashSet<TimeRegistrationProbleem>();
            TimeRegistrationProbleemUidwijzigNavigation = new HashSet<TimeRegistrationProbleem>();
            TimeRegistrationProfacboomProjectUidaanmkNavigation = new HashSet<TimeRegistrationProfacboomProject>();
            TimeRegistrationProfacboomProjectUidwijzigNavigation = new HashSet<TimeRegistrationProfacboomProject>();
            TopsisgroupUidaanmkNavigation = new HashSet<Topsisgroup>();
            TopsisgroupUidwijzigNavigation = new HashSet<Topsisgroup>();
            TopsisobjectUidaanmkNavigation = new HashSet<Topsisobject>();
            TopsisobjectUidwijzigNavigation = new HashSet<Topsisobject>();
            TopsisobjectclassUidaanmkNavigation = new HashSet<Topsisobjectclass>();
            TopsisobjectclassUidwijzigNavigation = new HashSet<Topsisobjectclass>();
            VestigingDocumentenUidaanmkNavigation = new HashSet<VestigingDocumenten>();
            VestigingDocumentenUidwijzigNavigation = new HashSet<VestigingDocumenten>();
            VestigingLogboekUidaanmkNavigation = new HashSet<VestigingLogboek>();
            VestigingLogboekUidwijzigNavigation = new HashSet<VestigingLogboek>();
            VestigingMemoHistoryGebruiker = new HashSet<VestigingMemoHistory>();
            VestigingMemoHistoryUidaanmkNavigation = new HashSet<VestigingMemoHistory>();
            VestigingMemoHistoryUidwijzigNavigation = new HashSet<VestigingMemoHistory>();
            VestigingOptionalgridUidaanmkNavigation = new HashSet<VestigingOptionalgrid>();
            VestigingOptionalgridUidwijzigNavigation = new HashSet<VestigingOptionalgrid>();
            VestigingUidaanmkNavigation = new HashSet<Vestiging>();
            VestigingUidwijzigNavigation = new HashSet<Vestiging>();
            VoorzieningDocumentenUidaanmkNavigation = new HashSet<VoorzieningDocumenten>();
            VoorzieningDocumentenUidwijzigNavigation = new HashSet<VoorzieningDocumenten>();
            VoorzieningLogboekUidaanmkNavigation = new HashSet<VoorzieningLogboek>();
            VoorzieningLogboekUidwijzigNavigation = new HashSet<VoorzieningLogboek>();
            VoorzieningUidaanmkNavigation = new HashSet<Voorziening>();
            VoorzieningUidwijzigNavigation = new HashSet<Voorziening>();
            Vrij1objectDocumentenUidaanmkNavigation = new HashSet<Vrij1objectDocumenten>();
            Vrij1objectDocumentenUidwijzigNavigation = new HashSet<Vrij1objectDocumenten>();
            Vrij1objectLogboekUidaanmkNavigation = new HashSet<Vrij1objectLogboek>();
            Vrij1objectLogboekUidwijzigNavigation = new HashSet<Vrij1objectLogboek>();
            Vrij1objectOptionalgridUidaanmkNavigation = new HashSet<Vrij1objectOptionalgrid>();
            Vrij1objectOptionalgridUidwijzigNavigation = new HashSet<Vrij1objectOptionalgrid>();
            Vrij1objectUidaanmkNavigation = new HashSet<Vrij1object>();
            Vrij1objectUidwijzigNavigation = new HashSet<Vrij1object>();
            Vrij2objectDocumentenUidaanmkNavigation = new HashSet<Vrij2objectDocumenten>();
            Vrij2objectDocumentenUidwijzigNavigation = new HashSet<Vrij2objectDocumenten>();
            Vrij2objectLogboekUidaanmkNavigation = new HashSet<Vrij2objectLogboek>();
            Vrij2objectLogboekUidwijzigNavigation = new HashSet<Vrij2objectLogboek>();
            Vrij2objectOptionalgridUidaanmkNavigation = new HashSet<Vrij2objectOptionalgrid>();
            Vrij2objectOptionalgridUidwijzigNavigation = new HashSet<Vrij2objectOptionalgrid>();
            Vrij2objectUidaanmkNavigation = new HashSet<Vrij2object>();
            Vrij2objectUidwijzigNavigation = new HashSet<Vrij2object>();
            Vrij3objectDocumentenUidaanmkNavigation = new HashSet<Vrij3objectDocumenten>();
            Vrij3objectDocumentenUidwijzigNavigation = new HashSet<Vrij3objectDocumenten>();
            Vrij3objectLogboekUidaanmkNavigation = new HashSet<Vrij3objectLogboek>();
            Vrij3objectLogboekUidwijzigNavigation = new HashSet<Vrij3objectLogboek>();
            Vrij3objectOptionalgridUidaanmkNavigation = new HashSet<Vrij3objectOptionalgrid>();
            Vrij3objectOptionalgridUidwijzigNavigation = new HashSet<Vrij3objectOptionalgrid>();
            Vrij3objectUidaanmkNavigation = new HashSet<Vrij3object>();
            Vrij3objectUidwijzigNavigation = new HashSet<Vrij3object>();
            Vrij4objectDocumentenUidaanmkNavigation = new HashSet<Vrij4objectDocumenten>();
            Vrij4objectDocumentenUidwijzigNavigation = new HashSet<Vrij4objectDocumenten>();
            Vrij4objectLogboekUidaanmkNavigation = new HashSet<Vrij4objectLogboek>();
            Vrij4objectLogboekUidwijzigNavigation = new HashSet<Vrij4objectLogboek>();
            Vrij4objectOptionalgridUidaanmkNavigation = new HashSet<Vrij4objectOptionalgrid>();
            Vrij4objectOptionalgridUidwijzigNavigation = new HashSet<Vrij4objectOptionalgrid>();
            Vrij4objectUidaanmkNavigation = new HashSet<Vrij4object>();
            Vrij4objectUidwijzigNavigation = new HashSet<Vrij4object>();
            Vrij5objectDocumentenUidaanmkNavigation = new HashSet<Vrij5objectDocumenten>();
            Vrij5objectDocumentenUidwijzigNavigation = new HashSet<Vrij5objectDocumenten>();
            Vrij5objectLogboekUidaanmkNavigation = new HashSet<Vrij5objectLogboek>();
            Vrij5objectLogboekUidwijzigNavigation = new HashSet<Vrij5objectLogboek>();
            Vrij5objectOptionalgridUidaanmkNavigation = new HashSet<Vrij5objectOptionalgrid>();
            Vrij5objectOptionalgridUidwijzigNavigation = new HashSet<Vrij5objectOptionalgrid>();
            Vrij5objectUidaanmkNavigation = new HashSet<Vrij5object>();
            Vrij5objectUidwijzigNavigation = new HashSet<Vrij5object>();
            Watchlist = new HashSet<Watchlist>();
        }

        public string Aantekeningen { get; set; }
        public Guid? Archiefredenid { get; set; }
        public int Defaultprofile { get; set; }
        public string Defaultprofilenaam { get; set; }
        public bool Maginloggen { get; set; }
        public int Status { get; set; }
        public int Supervrecht { get; set; }
        public bool Sv { get; set; }
        public Guid? Uidaanmk { get; set; }
        public Guid? Uidwijzig { get; set; }
        public Guid Unid { get; set; }
        public DateTime? Dataanmk { get; set; }
        public DateTime? Datwijzig { get; set; }
        public string Inlognaam { get; set; }
        public string Importid { get; set; }
        public string Bespokememo { get; set; }
        public int Importtype { get; set; }
        public DateTime? Importdate { get; set; }
        public DateTime? LoginDate { get; set; }
        public string Naam { get; set; }
        public string Passhash { get; set; }
        public string Svhash { get; set; }

        public Archiefreden Archiefreden { get; set; }
        public Gebruiker UidaanmkNavigation { get; set; }
        public Gebruiker UidwijzigNavigation { get; set; }
        public ICollection<ActiedoorDocumenten> ActiedoorDocumentenUidaanmkNavigation { get; set; }
        public ICollection<ActiedoorDocumenten> ActiedoorDocumentenUidwijzigNavigation { get; set; }
        public ICollection<ActiedoorLogboek> ActiedoorLogboekUidaanmkNavigation { get; set; }
        public ICollection<ActiedoorLogboek> ActiedoorLogboekUidwijzigNavigation { get; set; }
        public ICollection<Actiedoor> ActiedoorLoginnaamtopdesk { get; set; }
        public ICollection<ActiedoorMemoHistory> ActiedoorMemoHistoryGebruiker { get; set; }
        public ICollection<ActiedoorMemoHistory> ActiedoorMemoHistoryUidaanmkNavigation { get; set; }
        public ICollection<ActiedoorMemoHistory> ActiedoorMemoHistoryUidwijzigNavigation { get; set; }
        public ICollection<ActiedoorOptionalgrid> ActiedoorOptionalgridUidaanmkNavigation { get; set; }
        public ICollection<ActiedoorOptionalgrid> ActiedoorOptionalgridUidwijzigNavigation { get; set; }
        public ICollection<Actiedoor> ActiedoorUidaanmkNavigation { get; set; }
        public ICollection<Actiedoor> ActiedoorUidwijzigNavigation { get; set; }
        public ICollection<Appliedshift> AppliedshiftUidaanmkNavigation { get; set; }
        public ICollection<Appliedshift> AppliedshiftUidwijzigNavigation { get; set; }
        public ICollection<AppointmentDocumenten> AppointmentDocumentenUidaanmkNavigation { get; set; }
        public ICollection<AppointmentDocumenten> AppointmentDocumentenUidwijzigNavigation { get; set; }
        public ICollection<AppointmentLogboek> AppointmentLogboekUidaanmkNavigation { get; set; }
        public ICollection<AppointmentLogboek> AppointmentLogboekUidwijzigNavigation { get; set; }
        public ICollection<Appointment> AppointmentUidaanmkNavigation { get; set; }
        public ICollection<Appointment> AppointmentUidwijzigNavigation { get; set; }
        public ICollection<ArtikelMutatie> ArtikelMutatie { get; set; }
        public ICollection<BestelaanvraagDocumenten> BestelaanvraagDocumentenUidaanmkNavigation { get; set; }
        public ICollection<BestelaanvraagDocumenten> BestelaanvraagDocumentenUidwijzigNavigation { get; set; }
        public ICollection<BestelaanvraagLogboek> BestelaanvraagLogboekUidaanmkNavigation { get; set; }
        public ICollection<BestelaanvraagLogboek> BestelaanvraagLogboekUidwijzigNavigation { get; set; }
        public ICollection<Bestelaanvraag> BestelaanvraagUidaanmkNavigation { get; set; }
        public ICollection<Bestelaanvraag> BestelaanvraagUidwijzigNavigation { get; set; }
        public ICollection<BestellingenDocumenten> BestellingenDocumentenUidaanmkNavigation { get; set; }
        public ICollection<BestellingenDocumenten> BestellingenDocumentenUidwijzigNavigation { get; set; }
        public ICollection<BestellingenLogboek> BestellingenLogboekUidaanmkNavigation { get; set; }
        public ICollection<BestellingenLogboek> BestellingenLogboekUidwijzigNavigation { get; set; }
        public ICollection<Bestellingen> BestellingenUidaanmkNavigation { get; set; }
        public ICollection<Bestellingen> BestellingenUidwijzigNavigation { get; set; }
        public ICollection<BezoekerDocumenten> BezoekerDocumentenUidaanmkNavigation { get; set; }
        public ICollection<BezoekerDocumenten> BezoekerDocumentenUidwijzigNavigation { get; set; }
        public ICollection<BezoekerLogboek> BezoekerLogboekUidaanmkNavigation { get; set; }
        public ICollection<BezoekerLogboek> BezoekerLogboekUidwijzigNavigation { get; set; }
        public ICollection<BezoekerMemoHistory> BezoekerMemoHistoryGebruiker { get; set; }
        public ICollection<BezoekerMemoHistory> BezoekerMemoHistoryUidaanmkNavigation { get; set; }
        public ICollection<BezoekerMemoHistory> BezoekerMemoHistoryUidwijzigNavigation { get; set; }
        public ICollection<Bezoeker> BezoekerUidaanmkNavigation { get; set; }
        public ICollection<Bezoeker> BezoekerUidwijzigNavigation { get; set; }
        public ICollection<BranchMeasurement> BranchMeasurementUidaanmkNavigation { get; set; }
        public ICollection<BranchMeasurement> BranchMeasurementUidwijzigNavigation { get; set; }
        public ICollection<Branchfilter> BranchfilterUidaanmkNavigation { get; set; }
        public ICollection<Branchfilter> BranchfilterUidwijzigNavigation { get; set; }
        public ICollection<Branchfiltercache> Branchfiltercache { get; set; }
        public ICollection<CampaignDocumenten> CampaignDocumentenUidaanmkNavigation { get; set; }
        public ICollection<CampaignDocumenten> CampaignDocumentenUidwijzigNavigation { get; set; }
        public ICollection<CampaignLogboek> CampaignLogboekUidaanmkNavigation { get; set; }
        public ICollection<CampaignLogboek> CampaignLogboekUidwijzigNavigation { get; set; }
        public ICollection<CampaignMemoHistory> CampaignMemoHistoryGebruiker { get; set; }
        public ICollection<CampaignMemoHistory> CampaignMemoHistoryUidaanmkNavigation { get; set; }
        public ICollection<CampaignMemoHistory> CampaignMemoHistoryUidwijzigNavigation { get; set; }
        public ICollection<Campaign> CampaignUidaanmkNavigation { get; set; }
        public ICollection<Campaign> CampaignUidwijzigNavigation { get; set; }
        public ICollection<CampaignmailingDocumenten> CampaignmailingDocumentenUidaanmkNavigation { get; set; }
        public ICollection<CampaignmailingDocumenten> CampaignmailingDocumentenUidwijzigNavigation { get; set; }
        public ICollection<CampaignmailingLogboek> CampaignmailingLogboekUidaanmkNavigation { get; set; }
        public ICollection<CampaignmailingLogboek> CampaignmailingLogboekUidwijzigNavigation { get; set; }
        public ICollection<CampaignmailingMemoHistory> CampaignmailingMemoHistoryGebruiker { get; set; }
        public ICollection<CampaignmailingMemoHistory> CampaignmailingMemoHistoryUidaanmkNavigation { get; set; }
        public ICollection<CampaignmailingMemoHistory> CampaignmailingMemoHistoryUidwijzigNavigation { get; set; }
        public ICollection<Campaignmailing> CampaignmailingUidaanmkNavigation { get; set; }
        public ICollection<Campaignmailing> CampaignmailingUidwijzigNavigation { get; set; }
        public ICollection<Carts> Carts { get; set; }
        public ICollection<Categoryfilter> CategoryfilterUidaanmkNavigation { get; set; }
        public ICollection<Categoryfilter> CategoryfilterUidwijzigNavigation { get; set; }
        public ICollection<Categoryfiltercache> Categoryfiltercache { get; set; }
        public ICollection<ChangeActivitytemplateDocumenten> ChangeActivitytemplateDocumentenUidaanmkNavigation { get; set; }
        public ICollection<ChangeActivitytemplateDocumenten> ChangeActivitytemplateDocumentenUidwijzigNavigation { get; set; }
        public ICollection<ChangeActivitytemplateDocuments> ChangeActivitytemplateDocumentsUidaanmkNavigation { get; set; }
        public ICollection<ChangeActivitytemplateDocuments> ChangeActivitytemplateDocumentsUidwijzigNavigation { get; set; }
        public ICollection<ChangeActivitytemplateLogboek> ChangeActivitytemplateLogboekUidaanmkNavigation { get; set; }
        public ICollection<ChangeActivitytemplateLogboek> ChangeActivitytemplateLogboekUidwijzigNavigation { get; set; }
        public ICollection<ChangeActivitytemplateMemoHistory> ChangeActivitytemplateMemoHistoryGebruiker { get; set; }
        public ICollection<ChangeActivitytemplateMemoHistory> ChangeActivitytemplateMemoHistoryUidaanmkNavigation { get; set; }
        public ICollection<ChangeActivitytemplateMemoHistory> ChangeActivitytemplateMemoHistoryUidwijzigNavigation { get; set; }
        public ICollection<ChangeActivitytemplate> ChangeActivitytemplateUidaanmkNavigation { get; set; }
        public ICollection<ChangeActivitytemplate> ChangeActivitytemplateUidwijzigNavigation { get; set; }
        public ICollection<ChangeDocumenten> ChangeDocumentenUidaanmkNavigation { get; set; }
        public ICollection<ChangeDocumenten> ChangeDocumentenUidwijzigNavigation { get; set; }
        public ICollection<ChangeLogboek> ChangeLogboekUidaanmkNavigation { get; set; }
        public ICollection<ChangeLogboek> ChangeLogboekUidwijzigNavigation { get; set; }
        public ICollection<ChangeMemoHistory> ChangeMemoHistoryGebruiker { get; set; }
        public ICollection<ChangeMemoHistory> ChangeMemoHistoryUidaanmkNavigation { get; set; }
        public ICollection<ChangeMemoHistory> ChangeMemoHistoryUidwijzigNavigation { get; set; }
        public ICollection<ChangeTemplateDocumenten> ChangeTemplateDocumentenUidaanmkNavigation { get; set; }
        public ICollection<ChangeTemplateDocumenten> ChangeTemplateDocumentenUidwijzigNavigation { get; set; }
        public ICollection<ChangeTemplateDocuments> ChangeTemplateDocumentsUidaanmkNavigation { get; set; }
        public ICollection<ChangeTemplateDocuments> ChangeTemplateDocumentsUidwijzigNavigation { get; set; }
        public ICollection<ChangeTemplateLogboek> ChangeTemplateLogboekUidaanmkNavigation { get; set; }
        public ICollection<ChangeTemplateLogboek> ChangeTemplateLogboekUidwijzigNavigation { get; set; }
        public ICollection<ChangeTemplateMemoHistory> ChangeTemplateMemoHistoryGebruiker { get; set; }
        public ICollection<ChangeTemplateMemoHistory> ChangeTemplateMemoHistoryUidaanmkNavigation { get; set; }
        public ICollection<ChangeTemplateMemoHistory> ChangeTemplateMemoHistoryUidwijzigNavigation { get; set; }
        public ICollection<ChangeTemplate> ChangeTemplateUidaanmkNavigation { get; set; }
        public ICollection<ChangeTemplate> ChangeTemplateUidwijzigNavigation { get; set; }
        public ICollection<Change> ChangeUidaanmkNavigation { get; set; }
        public ICollection<Change> ChangeUidwijzigNavigation { get; set; }
        public ICollection<ChangeactivityDocumenten> ChangeactivityDocumentenUidaanmkNavigation { get; set; }
        public ICollection<ChangeactivityDocumenten> ChangeactivityDocumentenUidwijzigNavigation { get; set; }
        public ICollection<ChangeactivityLogboek> ChangeactivityLogboekUidaanmkNavigation { get; set; }
        public ICollection<ChangeactivityLogboek> ChangeactivityLogboekUidwijzigNavigation { get; set; }
        public ICollection<ChangeactivityMemoHistory> ChangeactivityMemoHistoryGebruiker { get; set; }
        public ICollection<ChangeactivityMemoHistory> ChangeactivityMemoHistoryUidaanmkNavigation { get; set; }
        public ICollection<ChangeactivityMemoHistory> ChangeactivityMemoHistoryUidwijzigNavigation { get; set; }
        public ICollection<Changeactivity> ChangeactivityUidaanmkNavigation { get; set; }
        public ICollection<Changeactivity> ChangeactivityUidwijzigNavigation { get; set; }
        public ICollection<Changeauthorization> Changeauthorization { get; set; }
        public ICollection<ChangeversionDocumenten> ChangeversionDocumentenUidaanmkNavigation { get; set; }
        public ICollection<ChangeversionDocumenten> ChangeversionDocumentenUidwijzigNavigation { get; set; }
        public ICollection<ChangeversionLogboek> ChangeversionLogboekUidaanmkNavigation { get; set; }
        public ICollection<ChangeversionLogboek> ChangeversionLogboekUidwijzigNavigation { get; set; }
        public ICollection<ChangeversionMemoHistory> ChangeversionMemoHistoryGebruiker { get; set; }
        public ICollection<ChangeversionMemoHistory> ChangeversionMemoHistoryUidaanmkNavigation { get; set; }
        public ICollection<ChangeversionMemoHistory> ChangeversionMemoHistoryUidwijzigNavigation { get; set; }
        public ICollection<Changeversion> ChangeversionUidaanmkNavigation { get; set; }
        public ICollection<Changeversion> ChangeversionUidwijzigNavigation { get; set; }
        public ICollection<Classificatie> ClassificatieUidaanmkNavigation { get; set; }
        public ICollection<Classificatie> ClassificatieUidwijzigNavigation { get; set; }
        public ICollection<ConfiguratieDocumenten> ConfiguratieDocumentenUidaanmkNavigation { get; set; }
        public ICollection<ConfiguratieDocumenten> ConfiguratieDocumentenUidwijzigNavigation { get; set; }
        public ICollection<ConfiguratieLogboek> ConfiguratieLogboekUidaanmkNavigation { get; set; }
        public ICollection<ConfiguratieLogboek> ConfiguratieLogboekUidwijzigNavigation { get; set; }
        public ICollection<ConfiguratieMemoHistory> ConfiguratieMemoHistoryGebruiker { get; set; }
        public ICollection<ConfiguratieMemoHistory> ConfiguratieMemoHistoryUidaanmkNavigation { get; set; }
        public ICollection<ConfiguratieMemoHistory> ConfiguratieMemoHistoryUidwijzigNavigation { get; set; }
        public ICollection<Configuratie> ConfiguratieUidaanmkNavigation { get; set; }
        public ICollection<Configuratie> ConfiguratieUidwijzigNavigation { get; set; }
        public ICollection<DnocontractDocumenten> DnocontractDocumentenUidaanmkNavigation { get; set; }
        public ICollection<DnocontractDocumenten> DnocontractDocumentenUidwijzigNavigation { get; set; }
        public ICollection<DnocontractLogboek> DnocontractLogboekUidaanmkNavigation { get; set; }
        public ICollection<DnocontractLogboek> DnocontractLogboekUidwijzigNavigation { get; set; }
        public ICollection<DnocontractMemoHistory> DnocontractMemoHistoryGebruiker { get; set; }
        public ICollection<DnocontractMemoHistory> DnocontractMemoHistoryUidaanmkNavigation { get; set; }
        public ICollection<DnocontractMemoHistory> DnocontractMemoHistoryUidwijzigNavigation { get; set; }
        public ICollection<Dnocontract> DnocontractUidaanmkNavigation { get; set; }
        public ICollection<Dnocontract> DnocontractUidwijzigNavigation { get; set; }
        public ICollection<DnodienstDocumenten> DnodienstDocumentenUidaanmkNavigation { get; set; }
        public ICollection<DnodienstDocumenten> DnodienstDocumentenUidwijzigNavigation { get; set; }
        public ICollection<DnodienstLogboek> DnodienstLogboekUidaanmkNavigation { get; set; }
        public ICollection<DnodienstLogboek> DnodienstLogboekUidwijzigNavigation { get; set; }
        public ICollection<DnodienstMemoHistory> DnodienstMemoHistoryGebruiker { get; set; }
        public ICollection<DnodienstMemoHistory> DnodienstMemoHistoryUidaanmkNavigation { get; set; }
        public ICollection<DnodienstMemoHistory> DnodienstMemoHistoryUidwijzigNavigation { get; set; }
        public ICollection<Dnodienst> DnodienstUidaanmkNavigation { get; set; }
        public ICollection<Dnodienst> DnodienstUidwijzigNavigation { get; set; }
        public ICollection<Emailbericht> EmailberichtUidaanmkNavigation { get; set; }
        public ICollection<Emailbericht> EmailberichtUidwijzigNavigation { get; set; }
        public ICollection<GebruikerDocumenten> GebruikerDocumentenKaart { get; set; }
        public ICollection<GebruikerDocumenten> GebruikerDocumentenUidaanmkNavigation { get; set; }
        public ICollection<GebruikerDocumenten> GebruikerDocumentenUidwijzigNavigation { get; set; }
        public ICollection<GebruikerEmailberichten> GebruikerEmailberichten { get; set; }
        public ICollection<GebruikerLogboek> GebruikerLogboekKaart { get; set; }
        public ICollection<GebruikerLogboek> GebruikerLogboekUidaanmkNavigation { get; set; }
        public ICollection<GebruikerLogboek> GebruikerLogboekUidwijzigNavigation { get; set; }
        public ICollection<GebruikerMemoHistory> GebruikerMemoHistoryGebruiker { get; set; }
        public ICollection<GebruikerMemoHistory> GebruikerMemoHistoryParent { get; set; }
        public ICollection<GebruikerMemoHistory> GebruikerMemoHistoryUidaanmkNavigation { get; set; }
        public ICollection<GebruikerMemoHistory> GebruikerMemoHistoryUidwijzigNavigation { get; set; }
        public ICollection<HardwareDocumenten> HardwareDocumentenUidaanmkNavigation { get; set; }
        public ICollection<HardwareDocumenten> HardwareDocumentenUidwijzigNavigation { get; set; }
        public ICollection<HardwareLogboek> HardwareLogboekUidaanmkNavigation { get; set; }
        public ICollection<HardwareLogboek> HardwareLogboekUidwijzigNavigation { get; set; }
        public ICollection<HardwareOptionalgrid> HardwareOptionalgridUidaanmkNavigation { get; set; }
        public ICollection<HardwareOptionalgrid> HardwareOptionalgridUidwijzigNavigation { get; set; }
        public ICollection<Hardware> HardwareUidaanmkNavigation { get; set; }
        public ICollection<Hardware> HardwareUidwijzigNavigation { get; set; }
        public ICollection<Herhaling> HerhalingUidaanmkNavigation { get; set; }
        public ICollection<Herhaling> HerhalingUidwijzigNavigation { get; set; }
        public ICollection<Importsettings> ImportsettingsImportuser { get; set; }
        public ICollection<Importsettings> ImportsettingsUidaanmkNavigation { get; set; }
        public ICollection<Importsettings> ImportsettingsUidwijzigNavigation { get; set; }
        public ICollection<IncidentDocumenten> IncidentDocumentenUidaanmkNavigation { get; set; }
        public ICollection<IncidentDocumenten> IncidentDocumentenUidwijzigNavigation { get; set; }
        public ICollection<IncidentLogboek> IncidentLogboekUidaanmkNavigation { get; set; }
        public ICollection<IncidentLogboek> IncidentLogboekUidwijzigNavigation { get; set; }
        public ICollection<IncidentMemogeschiedenis> IncidentMemogeschiedenisGebruiker { get; set; }
        public ICollection<IncidentMemogeschiedenis> IncidentMemogeschiedenisUidaanmkNavigation { get; set; }
        public ICollection<IncidentMemogeschiedenis> IncidentMemogeschiedenisUidwijzigNavigation { get; set; }
        public ICollection<Incident> IncidentUidaanmkNavigation { get; set; }
        public ICollection<Incident> IncidentUidwijzigNavigation { get; set; }
        public ICollection<InventarisDocumenten> InventarisDocumentenUidaanmkNavigation { get; set; }
        public ICollection<InventarisDocumenten> InventarisDocumentenUidwijzigNavigation { get; set; }
        public ICollection<InventarisLogboek> InventarisLogboekUidaanmkNavigation { get; set; }
        public ICollection<InventarisLogboek> InventarisLogboekUidwijzigNavigation { get; set; }
        public ICollection<InventarisOptionalgrid> InventarisOptionalgridUidaanmkNavigation { get; set; }
        public ICollection<InventarisOptionalgrid> InventarisOptionalgridUidwijzigNavigation { get; set; }
        public ICollection<Inventaris> InventarisUidaanmkNavigation { get; set; }
        public ICollection<Inventaris> InventarisUidwijzigNavigation { get; set; }
        public ICollection<Gebruiker> InverseUidaanmkNavigation { get; set; }
        public ICollection<Gebruiker> InverseUidwijzigNavigation { get; set; }
        public ICollection<KennisSysteemDocumenten> KennisSysteemDocumentenUidaanmkNavigation { get; set; }
        public ICollection<KennisSysteemDocumenten> KennisSysteemDocumentenUidwijzigNavigation { get; set; }
        public ICollection<KennisSysteem> KennisSysteemUidaanmkNavigation { get; set; }
        public ICollection<KennisSysteem> KennisSysteemUidwijzigNavigation { get; set; }
        public ICollection<Kennissysteemreactie> KennissysteemreactieUidaanmkNavigation { get; set; }
        public ICollection<Kennissysteemreactie> KennissysteemreactieUidwijzigNavigation { get; set; }
        public ICollection<Kennissysteemvertalingen> KennissysteemvertalingenUidaanmkNavigation { get; set; }
        public ICollection<Kennissysteemvertalingen> KennissysteemvertalingenUidwijzigNavigation { get; set; }
        public ICollection<KostendeclaratieArtikel> KostendeclaratieArtikelUidaanmkNavigation { get; set; }
        public ICollection<KostendeclaratieArtikel> KostendeclaratieArtikelUidwijzigNavigation { get; set; }
        public ICollection<KostendeclaratieObject> KostendeclaratieObjectUidaanmkNavigation { get; set; }
        public ICollection<KostendeclaratieObject> KostendeclaratieObjectUidwijzigNavigation { get; set; }
        public ICollection<LeverancierDocumenten> LeverancierDocumentenUidaanmkNavigation { get; set; }
        public ICollection<LeverancierDocumenten> LeverancierDocumentenUidwijzigNavigation { get; set; }
        public ICollection<LeverancierLogboek> LeverancierLogboekUidaanmkNavigation { get; set; }
        public ICollection<LeverancierLogboek> LeverancierLogboekUidwijzigNavigation { get; set; }
        public ICollection<LeverancierMemoHistory> LeverancierMemoHistoryGebruiker { get; set; }
        public ICollection<LeverancierMemoHistory> LeverancierMemoHistoryUidaanmkNavigation { get; set; }
        public ICollection<LeverancierMemoHistory> LeverancierMemoHistoryUidwijzigNavigation { get; set; }
        public ICollection<Leverancier> LeverancierUidaanmkNavigation { get; set; }
        public ICollection<Leverancier> LeverancierUidwijzigNavigation { get; set; }
        public ICollection<LeveranciercontactpersoonDocumenten> LeveranciercontactpersoonDocumentenUidaanmkNavigation { get; set; }
        public ICollection<LeveranciercontactpersoonDocumenten> LeveranciercontactpersoonDocumentenUidwijzigNavigation { get; set; }
        public ICollection<LeveranciercontactpersoonLogboek> LeveranciercontactpersoonLogboekUidaanmkNavigation { get; set; }
        public ICollection<LeveranciercontactpersoonLogboek> LeveranciercontactpersoonLogboekUidwijzigNavigation { get; set; }
        public ICollection<Leveranciercontactpersoon> LeveranciercontactpersoonUidaanmkNavigation { get; set; }
        public ICollection<Leveranciercontactpersoon> LeveranciercontactpersoonUidwijzigNavigation { get; set; }
        public ICollection<LicentieDocumenten> LicentieDocumentenUidaanmkNavigation { get; set; }
        public ICollection<LicentieDocumenten> LicentieDocumentenUidwijzigNavigation { get; set; }
        public ICollection<LicentieLogboek> LicentieLogboekUidaanmkNavigation { get; set; }
        public ICollection<LicentieLogboek> LicentieLogboekUidwijzigNavigation { get; set; }
        public ICollection<Licentie> LicentieUidaanmkNavigation { get; set; }
        public ICollection<Licentie> LicentieUidwijzigNavigation { get; set; }
        public ICollection<LmpactivityDocumenten> LmpactivityDocumentenUidaanmkNavigation { get; set; }
        public ICollection<LmpactivityDocumenten> LmpactivityDocumentenUidwijzigNavigation { get; set; }
        public ICollection<LmpactivityLogboek> LmpactivityLogboekUidaanmkNavigation { get; set; }
        public ICollection<LmpactivityLogboek> LmpactivityLogboekUidwijzigNavigation { get; set; }
        public ICollection<LmpactivityMemoHistory> LmpactivityMemoHistoryGebruiker { get; set; }
        public ICollection<LmpactivityMemoHistory> LmpactivityMemoHistoryUidaanmkNavigation { get; set; }
        public ICollection<LmpactivityMemoHistory> LmpactivityMemoHistoryUidwijzigNavigation { get; set; }
        public ICollection<Lmpactivity> LmpactivityUidaanmkNavigation { get; set; }
        public ICollection<Lmpactivity> LmpactivityUidwijzigNavigation { get; set; }
        public ICollection<LmpscenarioDocumenten> LmpscenarioDocumentenUidaanmkNavigation { get; set; }
        public ICollection<LmpscenarioDocumenten> LmpscenarioDocumentenUidwijzigNavigation { get; set; }
        public ICollection<LmpscenarioLogboek> LmpscenarioLogboekUidaanmkNavigation { get; set; }
        public ICollection<LmpscenarioLogboek> LmpscenarioLogboekUidwijzigNavigation { get; set; }
        public ICollection<LmpscenarioMemoHistory> LmpscenarioMemoHistoryGebruiker { get; set; }
        public ICollection<LmpscenarioMemoHistory> LmpscenarioMemoHistoryUidaanmkNavigation { get; set; }
        public ICollection<LmpscenarioMemoHistory> LmpscenarioMemoHistoryUidwijzigNavigation { get; set; }
        public ICollection<Lmpscenario> LmpscenarioUidaanmkNavigation { get; set; }
        public ICollection<Lmpscenario> LmpscenarioUidwijzigNavigation { get; set; }
        public ICollection<LocatieDocumenten> LocatieDocumentenUidaanmkNavigation { get; set; }
        public ICollection<LocatieDocumenten> LocatieDocumentenUidwijzigNavigation { get; set; }
        public ICollection<LocatieLogboek> LocatieLogboekUidaanmkNavigation { get; set; }
        public ICollection<LocatieLogboek> LocatieLogboekUidwijzigNavigation { get; set; }
        public ICollection<LocatieMemoHistory> LocatieMemoHistoryGebruiker { get; set; }
        public ICollection<LocatieMemoHistory> LocatieMemoHistoryUidaanmkNavigation { get; set; }
        public ICollection<LocatieMemoHistory> LocatieMemoHistoryUidwijzigNavigation { get; set; }
        public ICollection<LocatieOptionalgrid> LocatieOptionalgridUidaanmkNavigation { get; set; }
        public ICollection<LocatieOptionalgrid> LocatieOptionalgridUidwijzigNavigation { get; set; }
        public ICollection<Locatie> LocatieUidaanmkNavigation { get; set; }
        public ICollection<Locatie> LocatieUidwijzigNavigation { get; set; }
        public ICollection<Mailactiebestand> MailactiebestandUidaanmkNavigation { get; set; }
        public ICollection<Mailactiebestand> MailactiebestandUidwijzigNavigation { get; set; }
        public ICollection<MailimportChange> MailimportChangeUidaanmkNavigation { get; set; }
        public ICollection<MailimportChange> MailimportChangeUidwijzigNavigation { get; set; }
        public ICollection<MailimportIncident> MailimportIncidentUidaanmkNavigation { get; set; }
        public ICollection<MailimportIncident> MailimportIncidentUidwijzigNavigation { get; set; }
        public ICollection<MailimportSettings> MailimportSettingsExecuteasuser { get; set; }
        public ICollection<MailimportSettings> MailimportSettingsUidaanmkNavigation { get; set; }
        public ICollection<MailimportSettings> MailimportSettingsUidwijzigNavigation { get; set; }
        public ICollection<MeetingDocumenten> MeetingDocumentenUidaanmkNavigation { get; set; }
        public ICollection<MeetingDocumenten> MeetingDocumentenUidwijzigNavigation { get; set; }
        public ICollection<MeetingLogboek> MeetingLogboekUidaanmkNavigation { get; set; }
        public ICollection<MeetingLogboek> MeetingLogboekUidwijzigNavigation { get; set; }
        public ICollection<MeetingMemoHistory> MeetingMemoHistoryGebruiker { get; set; }
        public ICollection<MeetingMemoHistory> MeetingMemoHistoryUidaanmkNavigation { get; set; }
        public ICollection<MeetingMemoHistory> MeetingMemoHistoryUidwijzigNavigation { get; set; }
        public ICollection<Meeting> MeetingUidaanmkNavigation { get; set; }
        public ICollection<Meeting> MeetingUidwijzigNavigation { get; set; }
        public ICollection<MutatieBestelaanvraag> MutatieBestelaanvraag { get; set; }
        public ICollection<MutatieBestellingen> MutatieBestellingen { get; set; }
        public ICollection<MutatieChange> MutatieChange { get; set; }
        public ICollection<MutatieChangeactivity> MutatieChangeactivity { get; set; }
        public ICollection<MutatieChangeversion> MutatieChangeversion { get; set; }
        public ICollection<MutatieConfiguratie> MutatieConfiguratie { get; set; }
        public ICollection<MutatieDnocontract> MutatieDnocontract { get; set; }
        public ICollection<MutatieDnodienst> MutatieDnodienst { get; set; }
        public ICollection<MutatieHardware> MutatieHardware { get; set; }
        public ICollection<MutatieIncident> MutatieIncident { get; set; }
        public ICollection<MutatieInventaris> MutatieInventaris { get; set; }
        public ICollection<MutatieNetwerkcomponent> MutatieNetwerkcomponent { get; set; }
        public ICollection<MutatieOmActiviteit> MutatieOmActiviteit { get; set; }
        public ICollection<MutatieOmReeks> MutatieOmReeks { get; set; }
        public ICollection<MutatieOmSchema> MutatieOmSchema { get; set; }
        public ICollection<MutatieProbleem> MutatieProbleem { get; set; }
        public ICollection<MutatieProfacboomProject> MutatieProfacboomProject { get; set; }
        public ICollection<MutatieReservering> MutatieReservering { get; set; }
        public ICollection<MutatieSoftware> MutatieSoftware { get; set; }
        public ICollection<MutatieTelefonie> MutatieTelefonie { get; set; }
        public ICollection<MutatieVestiging> MutatieVestiging { get; set; }
        public ICollection<MutatieVrij1object> MutatieVrij1object { get; set; }
        public ICollection<MutatieVrij2object> MutatieVrij2object { get; set; }
        public ICollection<MutatieVrij3object> MutatieVrij3object { get; set; }
        public ICollection<MutatieVrij4object> MutatieVrij4object { get; set; }
        public ICollection<MutatieVrij5object> MutatieVrij5object { get; set; }
        public ICollection<NetwerkcomponentDocumenten> NetwerkcomponentDocumentenUidaanmkNavigation { get; set; }
        public ICollection<NetwerkcomponentDocumenten> NetwerkcomponentDocumentenUidwijzigNavigation { get; set; }
        public ICollection<NetwerkcomponentLogboek> NetwerkcomponentLogboekUidaanmkNavigation { get; set; }
        public ICollection<NetwerkcomponentLogboek> NetwerkcomponentLogboekUidwijzigNavigation { get; set; }
        public ICollection<NetwerkcomponentOptionalgrid> NetwerkcomponentOptionalgridUidaanmkNavigation { get; set; }
        public ICollection<NetwerkcomponentOptionalgrid> NetwerkcomponentOptionalgridUidwijzigNavigation { get; set; }
        public ICollection<Netwerkcomponent> NetwerkcomponentUidaanmkNavigation { get; set; }
        public ICollection<Netwerkcomponent> NetwerkcomponentUidwijzigNavigation { get; set; }
        public ICollection<Object> ObjectUidaanmkNavigation { get; set; }
        public ICollection<Object> ObjectUidwijzigNavigation { get; set; }
        public ICollection<OmActiviteitDocumenten> OmActiviteitDocumentenUidaanmkNavigation { get; set; }
        public ICollection<OmActiviteitDocumenten> OmActiviteitDocumentenUidwijzigNavigation { get; set; }
        public ICollection<OmActiviteitLogboek> OmActiviteitLogboekUidaanmkNavigation { get; set; }
        public ICollection<OmActiviteitLogboek> OmActiviteitLogboekUidwijzigNavigation { get; set; }
        public ICollection<OmActiviteitMemoHistory> OmActiviteitMemoHistoryGebruiker { get; set; }
        public ICollection<OmActiviteitMemoHistory> OmActiviteitMemoHistoryUidaanmkNavigation { get; set; }
        public ICollection<OmActiviteitMemoHistory> OmActiviteitMemoHistoryUidwijzigNavigation { get; set; }
        public ICollection<OmActiviteit> OmActiviteitUidaanmkNavigation { get; set; }
        public ICollection<OmActiviteit> OmActiviteitUidwijzigNavigation { get; set; }
        public ICollection<OmGroepering> OmGroeperingUidaanmkNavigation { get; set; }
        public ICollection<OmGroepering> OmGroeperingUidwijzigNavigation { get; set; }
        public ICollection<OmReeksDocumenten> OmReeksDocumentenUidaanmkNavigation { get; set; }
        public ICollection<OmReeksDocumenten> OmReeksDocumentenUidwijzigNavigation { get; set; }
        public ICollection<OmReeksLogboek> OmReeksLogboekUidaanmkNavigation { get; set; }
        public ICollection<OmReeksLogboek> OmReeksLogboekUidwijzigNavigation { get; set; }
        public ICollection<OmReeksMemoHistory> OmReeksMemoHistoryGebruiker { get; set; }
        public ICollection<OmReeksMemoHistory> OmReeksMemoHistoryUidaanmkNavigation { get; set; }
        public ICollection<OmReeksMemoHistory> OmReeksMemoHistoryUidwijzigNavigation { get; set; }
        public ICollection<OmReeks> OmReeksUidaanmkNavigation { get; set; }
        public ICollection<OmReeks> OmReeksUidwijzigNavigation { get; set; }
        public ICollection<OmSchemaDocumenten> OmSchemaDocumentenUidaanmkNavigation { get; set; }
        public ICollection<OmSchemaDocumenten> OmSchemaDocumentenUidwijzigNavigation { get; set; }
        public ICollection<OmSchemaLogboek> OmSchemaLogboekUidaanmkNavigation { get; set; }
        public ICollection<OmSchemaLogboek> OmSchemaLogboekUidwijzigNavigation { get; set; }
        public ICollection<OmSchemaMemoHistory> OmSchemaMemoHistoryGebruiker { get; set; }
        public ICollection<OmSchemaMemoHistory> OmSchemaMemoHistoryUidaanmkNavigation { get; set; }
        public ICollection<OmSchemaMemoHistory> OmSchemaMemoHistoryUidwijzigNavigation { get; set; }
        public ICollection<OmSchema> OmSchemaUidaanmkNavigation { get; set; }
        public ICollection<OmSchema> OmSchemaUidwijzigNavigation { get; set; }
        public ICollection<OperatorPermissiongroup> OperatorPermissiongroup { get; set; }
        public ICollection<Operatorfilter> OperatorfilterUidaanmkNavigation { get; set; }
        public ICollection<Operatorfilter> OperatorfilterUidwijzigNavigation { get; set; }
        public ICollection<Operatorfiltercache> Operatorfiltercache { get; set; }
        public ICollection<OplossingenDocumenten> OplossingenDocumentenUidaanmkNavigation { get; set; }
        public ICollection<OplossingenDocumenten> OplossingenDocumentenUidwijzigNavigation { get; set; }
        public ICollection<OplossingenLogboek> OplossingenLogboekUidaanmkNavigation { get; set; }
        public ICollection<OplossingenLogboek> OplossingenLogboekUidwijzigNavigation { get; set; }
        public ICollection<Oplossingen> OplossingenUidaanmkNavigation { get; set; }
        public ICollection<Oplossingen> OplossingenUidwijzigNavigation { get; set; }
        public ICollection<PersoonDocumenten> PersoonDocumentenUidaanmkNavigation { get; set; }
        public ICollection<PersoonDocumenten> PersoonDocumentenUidwijzigNavigation { get; set; }
        public ICollection<PersoonLogboek> PersoonLogboekUidaanmkNavigation { get; set; }
        public ICollection<PersoonLogboek> PersoonLogboekUidwijzigNavigation { get; set; }
        public ICollection<PersoonMemoHistory> PersoonMemoHistoryGebruiker { get; set; }
        public ICollection<PersoonMemoHistory> PersoonMemoHistoryUidaanmkNavigation { get; set; }
        public ICollection<PersoonMemoHistory> PersoonMemoHistoryUidwijzigNavigation { get; set; }
        public ICollection<PersoonOptionalgrid> PersoonOptionalgridUidaanmkNavigation { get; set; }
        public ICollection<PersoonOptionalgrid> PersoonOptionalgridUidwijzigNavigation { get; set; }
        public ICollection<Persoon> PersoonUidaanmkNavigation { get; set; }
        public ICollection<Persoon> PersoonUidwijzigNavigation { get; set; }
        public ICollection<PersoongroepDocumenten> PersoongroepDocumentenUidaanmkNavigation { get; set; }
        public ICollection<PersoongroepDocumenten> PersoongroepDocumentenUidwijzigNavigation { get; set; }
        public ICollection<PersoongroepLogboek> PersoongroepLogboekUidaanmkNavigation { get; set; }
        public ICollection<PersoongroepLogboek> PersoongroepLogboekUidwijzigNavigation { get; set; }
        public ICollection<PersoongroepMemoHistory> PersoongroepMemoHistoryGebruiker { get; set; }
        public ICollection<PersoongroepMemoHistory> PersoongroepMemoHistoryUidaanmkNavigation { get; set; }
        public ICollection<PersoongroepMemoHistory> PersoongroepMemoHistoryUidwijzigNavigation { get; set; }
        public ICollection<Persoongroep> PersoongroepUidaanmkNavigation { get; set; }
        public ICollection<Persoongroep> PersoongroepUidwijzigNavigation { get; set; }
        public ICollection<Picture> PictureUidaanmkNavigation { get; set; }
        public ICollection<Picture> PictureUidwijzigNavigation { get; set; }
        public ICollection<Planboardgroupstate> Planboardgroupstate { get; set; }
        public ICollection<Planning> PlanningUidaanmkNavigation { get; set; }
        public ICollection<Planning> PlanningUidwijzigNavigation { get; set; }
        public ICollection<PoortDocumenten> PoortDocumentenUidaanmkNavigation { get; set; }
        public ICollection<PoortDocumenten> PoortDocumentenUidwijzigNavigation { get; set; }
        public ICollection<PoortLogboek> PoortLogboekUidaanmkNavigation { get; set; }
        public ICollection<PoortLogboek> PoortLogboekUidwijzigNavigation { get; set; }
        public ICollection<Poort> PoortUidaanmkNavigation { get; set; }
        public ICollection<Poort> PoortUidwijzigNavigation { get; set; }
        public ICollection<ProbleemDocumenten> ProbleemDocumentenUidaanmkNavigation { get; set; }
        public ICollection<ProbleemDocumenten> ProbleemDocumentenUidwijzigNavigation { get; set; }
        public ICollection<ProbleemLogboek> ProbleemLogboekUidaanmkNavigation { get; set; }
        public ICollection<ProbleemLogboek> ProbleemLogboekUidwijzigNavigation { get; set; }
        public ICollection<ProbleemMemogeschiedenis> ProbleemMemogeschiedenisGebruiker { get; set; }
        public ICollection<ProbleemMemogeschiedenis> ProbleemMemogeschiedenisUidaanmkNavigation { get; set; }
        public ICollection<ProbleemMemogeschiedenis> ProbleemMemogeschiedenisUidwijzigNavigation { get; set; }
        public ICollection<Probleem> ProbleemUidaanmkNavigation { get; set; }
        public ICollection<Probleem> ProbleemUidwijzigNavigation { get; set; }
        public ICollection<ProfacboomProjectDocumenten> ProfacboomProjectDocumentenUidaanmkNavigation { get; set; }
        public ICollection<ProfacboomProjectDocumenten> ProfacboomProjectDocumentenUidwijzigNavigation { get; set; }
        public ICollection<ProfacboomProjectLogboek> ProfacboomProjectLogboekUidaanmkNavigation { get; set; }
        public ICollection<ProfacboomProjectLogboek> ProfacboomProjectLogboekUidwijzigNavigation { get; set; }
        public ICollection<ProfacboomProjectMemoHistory> ProfacboomProjectMemoHistoryGebruiker { get; set; }
        public ICollection<ProfacboomProjectMemoHistory> ProfacboomProjectMemoHistoryUidaanmkNavigation { get; set; }
        public ICollection<ProfacboomProjectMemoHistory> ProfacboomProjectMemoHistoryUidwijzigNavigation { get; set; }
        public ICollection<ProfacboomProject> ProfacboomProjectUidaanmkNavigation { get; set; }
        public ICollection<ProfacboomProject> ProfacboomProjectUidwijzigNavigation { get; set; }
        public ICollection<Projectbeheerdocumenten> ProjectbeheerdocumentenUidaanmkNavigation { get; set; }
        public ICollection<Projectbeheerdocumenten> ProjectbeheerdocumentenUidwijzigNavigation { get; set; }
        public ICollection<Recurringevent> RecurringeventUidaanmkNavigation { get; set; }
        public ICollection<Recurringevent> RecurringeventUidwijzigNavigation { get; set; }
        public ICollection<ReportactionDocumenten> ReportactionDocumentenUidaanmkNavigation { get; set; }
        public ICollection<ReportactionDocumenten> ReportactionDocumentenUidwijzigNavigation { get; set; }
        public ICollection<ReportactionLogboek> ReportactionLogboekUidaanmkNavigation { get; set; }
        public ICollection<ReportactionLogboek> ReportactionLogboekUidwijzigNavigation { get; set; }
        public ICollection<Reportaction> ReportactionReportmailuser { get; set; }
        public ICollection<Reportaction> ReportactionUidaanmkNavigation { get; set; }
        public ICollection<Reportaction> ReportactionUidwijzigNavigation { get; set; }
        public ICollection<Reportwizard> ReportwizardRole { get; set; }
        public ICollection<Reportwizard> ReportwizardUidaanmkNavigation { get; set; }
        public ICollection<Reportwizard> ReportwizardUidwijzigNavigation { get; set; }
        public ICollection<ReservationDocumenten> ReservationDocumentenUidaanmkNavigation { get; set; }
        public ICollection<ReservationDocumenten> ReservationDocumentenUidwijzigNavigation { get; set; }
        public ICollection<ReservationEventDocumenten> ReservationEventDocumentenUidaanmkNavigation { get; set; }
        public ICollection<ReservationEventDocumenten> ReservationEventDocumentenUidwijzigNavigation { get; set; }
        public ICollection<ReservationEvent> ReservationEventUidaanmkNavigation { get; set; }
        public ICollection<ReservationEvent> ReservationEventUidwijzigNavigation { get; set; }
        public ICollection<ReservationFacilityFavorites> ReservationFacilityFavorites { get; set; }
        public ICollection<ReservationFacilityLink> ReservationFacilityLinkUidaanmkNavigation { get; set; }
        public ICollection<ReservationFacilityLink> ReservationFacilityLinkUidwijzigNavigation { get; set; }
        public ICollection<ReservationLogboek> ReservationLogboekUidaanmkNavigation { get; set; }
        public ICollection<ReservationLogboek> ReservationLogboekUidwijzigNavigation { get; set; }
        public ICollection<ReservationMemoHistory> ReservationMemoHistoryGebruiker { get; set; }
        public ICollection<ReservationMemoHistory> ReservationMemoHistoryUidaanmkNavigation { get; set; }
        public ICollection<ReservationMemoHistory> ReservationMemoHistoryUidwijzigNavigation { get; set; }
        public ICollection<ReservationServiceLink> ReservationServiceLinkUidaanmkNavigation { get; set; }
        public ICollection<ReservationServiceLink> ReservationServiceLinkUidwijzigNavigation { get; set; }
        public ICollection<Reservation> ReservationUidaanmkNavigation { get; set; }
        public ICollection<Reservation> ReservationUidwijzigNavigation { get; set; }
        public ICollection<ReserveringDocumenten> ReserveringDocumentenUidaanmkNavigation { get; set; }
        public ICollection<ReserveringDocumenten> ReserveringDocumentenUidwijzigNavigation { get; set; }
        public ICollection<ReserveringLocatieLink> ReserveringLocatieLinkUidaanmkNavigation { get; set; }
        public ICollection<ReserveringLocatieLink> ReserveringLocatieLinkUidwijzigNavigation { get; set; }
        public ICollection<ReserveringLogboek> ReserveringLogboekUidaanmkNavigation { get; set; }
        public ICollection<ReserveringLogboek> ReserveringLogboekUidwijzigNavigation { get; set; }
        public ICollection<ReserveringObjectLink> ReserveringObjectLinkUidaanmkNavigation { get; set; }
        public ICollection<ReserveringObjectLink> ReserveringObjectLinkUidwijzigNavigation { get; set; }
        public ICollection<Reservering> ReserveringUidaanmkNavigation { get; set; }
        public ICollection<Reservering> ReserveringUidwijzigNavigation { get; set; }
        public ICollection<ReserveringVoorzieningLinkDocumenten> ReserveringVoorzieningLinkDocumentenUidaanmkNavigation { get; set; }
        public ICollection<ReserveringVoorzieningLinkDocumenten> ReserveringVoorzieningLinkDocumentenUidwijzigNavigation { get; set; }
        public ICollection<ReserveringVoorzieningLinkLogboek> ReserveringVoorzieningLinkLogboekUidaanmkNavigation { get; set; }
        public ICollection<ReserveringVoorzieningLinkLogboek> ReserveringVoorzieningLinkLogboekUidwijzigNavigation { get; set; }
        public ICollection<ReserveringVoorzieningLink> ReserveringVoorzieningLinkUidaanmkNavigation { get; set; }
        public ICollection<ReserveringVoorzieningLink> ReserveringVoorzieningLinkUidwijzigNavigation { get; set; }
        public ICollection<RmSeries> RmSeriesUidaanmkNavigation { get; set; }
        public ICollection<RmSeries> RmSeriesUidwijzigNavigation { get; set; }
        public ICollection<Schedule> ScheduleUidaanmkNavigation { get; set; }
        public ICollection<Schedule> ScheduleUidwijzigNavigation { get; set; }
        public ICollection<Selvast> SelvastGroep { get; set; }
        public ICollection<Selvast> SelvastUidaanmkNavigation { get; set; }
        public ICollection<Selvast> SelvastUidwijzigNavigation { get; set; }
        public ICollection<ServicelevelDocumenten> ServicelevelDocumentenUidaanmkNavigation { get; set; }
        public ICollection<ServicelevelDocumenten> ServicelevelDocumentenUidwijzigNavigation { get; set; }
        public ICollection<ServicelevelLogboek> ServicelevelLogboekUidaanmkNavigation { get; set; }
        public ICollection<ServicelevelLogboek> ServicelevelLogboekUidwijzigNavigation { get; set; }
        public ICollection<ServicelevelMemoHistory> ServicelevelMemoHistoryGebruiker { get; set; }
        public ICollection<ServicelevelMemoHistory> ServicelevelMemoHistoryUidaanmkNavigation { get; set; }
        public ICollection<ServicelevelMemoHistory> ServicelevelMemoHistoryUidwijzigNavigation { get; set; }
        public ICollection<Servicelevel> ServicelevelUidaanmkNavigation { get; set; }
        public ICollection<Servicelevel> ServicelevelUidwijzigNavigation { get; set; }
        public ICollection<ServicewindowDocumenten> ServicewindowDocumentenUidaanmkNavigation { get; set; }
        public ICollection<ServicewindowDocumenten> ServicewindowDocumentenUidwijzigNavigation { get; set; }
        public ICollection<ServicewindowLogboek> ServicewindowLogboekUidaanmkNavigation { get; set; }
        public ICollection<ServicewindowLogboek> ServicewindowLogboekUidwijzigNavigation { get; set; }
        public ICollection<ServicewindowMemoHistory> ServicewindowMemoHistoryGebruiker { get; set; }
        public ICollection<ServicewindowMemoHistory> ServicewindowMemoHistoryUidaanmkNavigation { get; set; }
        public ICollection<ServicewindowMemoHistory> ServicewindowMemoHistoryUidwijzigNavigation { get; set; }
        public ICollection<Servicewindow> ServicewindowUidaanmkNavigation { get; set; }
        public ICollection<Servicewindow> ServicewindowUidwijzigNavigation { get; set; }
        public ICollection<Settings> Settings { get; set; }
        public ICollection<Shift> ShiftUidaanmkNavigation { get; set; }
        public ICollection<Shift> ShiftUidwijzigNavigation { get; set; }
        public ICollection<Shiftpriority> Shiftpriority { get; set; }
        public ICollection<Shiftsegment> ShiftsegmentUidaanmkNavigation { get; set; }
        public ICollection<Shiftsegment> ShiftsegmentUidwijzigNavigation { get; set; }
        public ICollection<SoftwareDocumenten> SoftwareDocumentenUidaanmkNavigation { get; set; }
        public ICollection<SoftwareDocumenten> SoftwareDocumentenUidwijzigNavigation { get; set; }
        public ICollection<SoftwareLogboek> SoftwareLogboekUidaanmkNavigation { get; set; }
        public ICollection<SoftwareLogboek> SoftwareLogboekUidwijzigNavigation { get; set; }
        public ICollection<SoftwareOptionalgrid> SoftwareOptionalgridUidaanmkNavigation { get; set; }
        public ICollection<SoftwareOptionalgrid> SoftwareOptionalgridUidwijzigNavigation { get; set; }
        public ICollection<Software> SoftwareUidaanmkNavigation { get; set; }
        public ICollection<Software> SoftwareUidwijzigNavigation { get; set; }
        public ICollection<Soort> Soort { get; set; }
        public ICollection<SsdForm> SsdFormUidaanmkNavigation { get; set; }
        public ICollection<SsdForm> SsdFormUidwijzigNavigation { get; set; }
        public ICollection<SuppliercontactMemoHistory> SuppliercontactMemoHistoryGebruiker { get; set; }
        public ICollection<SuppliercontactMemoHistory> SuppliercontactMemoHistoryUidaanmkNavigation { get; set; }
        public ICollection<SuppliercontactMemoHistory> SuppliercontactMemoHistoryUidwijzigNavigation { get; set; }
        public ICollection<SurveyDocumenten> SurveyDocumentenUidaanmkNavigation { get; set; }
        public ICollection<SurveyDocumenten> SurveyDocumentenUidwijzigNavigation { get; set; }
        public ICollection<SurveyLogboek> SurveyLogboekUidaanmkNavigation { get; set; }
        public ICollection<SurveyLogboek> SurveyLogboekUidwijzigNavigation { get; set; }
        public ICollection<SurveyMemoHistory> SurveyMemoHistoryGebruiker { get; set; }
        public ICollection<SurveyMemoHistory> SurveyMemoHistoryUidaanmkNavigation { get; set; }
        public ICollection<SurveyMemoHistory> SurveyMemoHistoryUidwijzigNavigation { get; set; }
        public ICollection<Survey> SurveyUidaanmkNavigation { get; set; }
        public ICollection<Survey> SurveyUidwijzigNavigation { get; set; }
        public ICollection<Surveyanswer> SurveyanswerUidaanmkNavigation { get; set; }
        public ICollection<Surveyanswer> SurveyanswerUidwijzigNavigation { get; set; }
        public ICollection<SurveyquestionDocumenten> SurveyquestionDocumentenUidaanmkNavigation { get; set; }
        public ICollection<SurveyquestionDocumenten> SurveyquestionDocumentenUidwijzigNavigation { get; set; }
        public ICollection<SurveyquestionLogboek> SurveyquestionLogboekUidaanmkNavigation { get; set; }
        public ICollection<SurveyquestionLogboek> SurveyquestionLogboekUidwijzigNavigation { get; set; }
        public ICollection<SurveyquestionMemoHistory> SurveyquestionMemoHistoryGebruiker { get; set; }
        public ICollection<SurveyquestionMemoHistory> SurveyquestionMemoHistoryUidaanmkNavigation { get; set; }
        public ICollection<SurveyquestionMemoHistory> SurveyquestionMemoHistoryUidwijzigNavigation { get; set; }
        public ICollection<Surveyquestion> SurveyquestionUidaanmkNavigation { get; set; }
        public ICollection<Surveyquestion> SurveyquestionUidwijzigNavigation { get; set; }
        public ICollection<SystemeventsDocumenten> SystemeventsDocumentenUidaanmkNavigation { get; set; }
        public ICollection<SystemeventsDocumenten> SystemeventsDocumentenUidwijzigNavigation { get; set; }
        public ICollection<SystemeventsLogboek> SystemeventsLogboekUidaanmkNavigation { get; set; }
        public ICollection<SystemeventsLogboek> SystemeventsLogboekUidwijzigNavigation { get; set; }
        public ICollection<Taskrole> TaskroleUidaanmkNavigation { get; set; }
        public ICollection<Taskrole> TaskroleUidwijzigNavigation { get; set; }
        public ICollection<Taskrolepriority> Taskrolepriority { get; set; }
        public ICollection<TelefonieDocumenten> TelefonieDocumentenUidaanmkNavigation { get; set; }
        public ICollection<TelefonieDocumenten> TelefonieDocumentenUidwijzigNavigation { get; set; }
        public ICollection<TelefonieLogboek> TelefonieLogboekUidaanmkNavigation { get; set; }
        public ICollection<TelefonieLogboek> TelefonieLogboekUidwijzigNavigation { get; set; }
        public ICollection<TelefonieOptionalgrid> TelefonieOptionalgridUidaanmkNavigation { get; set; }
        public ICollection<TelefonieOptionalgrid> TelefonieOptionalgridUidwijzigNavigation { get; set; }
        public ICollection<Telefonie> TelefonieUidaanmkNavigation { get; set; }
        public ICollection<Telefonie> TelefonieUidwijzigNavigation { get; set; }
        public ICollection<TimeRegistrationChange> TimeRegistrationChangeUidaanmkNavigation { get; set; }
        public ICollection<TimeRegistrationChange> TimeRegistrationChangeUidwijzigNavigation { get; set; }
        public ICollection<TimeRegistrationChangeactivity> TimeRegistrationChangeactivityUidaanmkNavigation { get; set; }
        public ICollection<TimeRegistrationChangeactivity> TimeRegistrationChangeactivityUidwijzigNavigation { get; set; }
        public ICollection<TimeRegistrationIncident> TimeRegistrationIncidentUidaanmkNavigation { get; set; }
        public ICollection<TimeRegistrationIncident> TimeRegistrationIncidentUidwijzigNavigation { get; set; }
        public ICollection<TimeRegistrationOmActiviteit> TimeRegistrationOmActiviteitUidaanmkNavigation { get; set; }
        public ICollection<TimeRegistrationOmActiviteit> TimeRegistrationOmActiviteitUidwijzigNavigation { get; set; }
        public ICollection<TimeRegistrationProbleem> TimeRegistrationProbleemUidaanmkNavigation { get; set; }
        public ICollection<TimeRegistrationProbleem> TimeRegistrationProbleemUidwijzigNavigation { get; set; }
        public ICollection<TimeRegistrationProfacboomProject> TimeRegistrationProfacboomProjectUidaanmkNavigation { get; set; }
        public ICollection<TimeRegistrationProfacboomProject> TimeRegistrationProfacboomProjectUidwijzigNavigation { get; set; }
        public ICollection<Topsisgroup> TopsisgroupUidaanmkNavigation { get; set; }
        public ICollection<Topsisgroup> TopsisgroupUidwijzigNavigation { get; set; }
        public ICollection<Topsisobject> TopsisobjectUidaanmkNavigation { get; set; }
        public ICollection<Topsisobject> TopsisobjectUidwijzigNavigation { get; set; }
        public ICollection<Topsisobjectclass> TopsisobjectclassUidaanmkNavigation { get; set; }
        public ICollection<Topsisobjectclass> TopsisobjectclassUidwijzigNavigation { get; set; }
        public ICollection<VestigingDocumenten> VestigingDocumentenUidaanmkNavigation { get; set; }
        public ICollection<VestigingDocumenten> VestigingDocumentenUidwijzigNavigation { get; set; }
        public ICollection<VestigingLogboek> VestigingLogboekUidaanmkNavigation { get; set; }
        public ICollection<VestigingLogboek> VestigingLogboekUidwijzigNavigation { get; set; }
        public ICollection<VestigingMemoHistory> VestigingMemoHistoryGebruiker { get; set; }
        public ICollection<VestigingMemoHistory> VestigingMemoHistoryUidaanmkNavigation { get; set; }
        public ICollection<VestigingMemoHistory> VestigingMemoHistoryUidwijzigNavigation { get; set; }
        public ICollection<VestigingOptionalgrid> VestigingOptionalgridUidaanmkNavigation { get; set; }
        public ICollection<VestigingOptionalgrid> VestigingOptionalgridUidwijzigNavigation { get; set; }
        public ICollection<Vestiging> VestigingUidaanmkNavigation { get; set; }
        public ICollection<Vestiging> VestigingUidwijzigNavigation { get; set; }
        public ICollection<VoorzieningDocumenten> VoorzieningDocumentenUidaanmkNavigation { get; set; }
        public ICollection<VoorzieningDocumenten> VoorzieningDocumentenUidwijzigNavigation { get; set; }
        public ICollection<VoorzieningLogboek> VoorzieningLogboekUidaanmkNavigation { get; set; }
        public ICollection<VoorzieningLogboek> VoorzieningLogboekUidwijzigNavigation { get; set; }
        public ICollection<Voorziening> VoorzieningUidaanmkNavigation { get; set; }
        public ICollection<Voorziening> VoorzieningUidwijzigNavigation { get; set; }
        public ICollection<Vrij1objectDocumenten> Vrij1objectDocumentenUidaanmkNavigation { get; set; }
        public ICollection<Vrij1objectDocumenten> Vrij1objectDocumentenUidwijzigNavigation { get; set; }
        public ICollection<Vrij1objectLogboek> Vrij1objectLogboekUidaanmkNavigation { get; set; }
        public ICollection<Vrij1objectLogboek> Vrij1objectLogboekUidwijzigNavigation { get; set; }
        public ICollection<Vrij1objectOptionalgrid> Vrij1objectOptionalgridUidaanmkNavigation { get; set; }
        public ICollection<Vrij1objectOptionalgrid> Vrij1objectOptionalgridUidwijzigNavigation { get; set; }
        public ICollection<Vrij1object> Vrij1objectUidaanmkNavigation { get; set; }
        public ICollection<Vrij1object> Vrij1objectUidwijzigNavigation { get; set; }
        public ICollection<Vrij2objectDocumenten> Vrij2objectDocumentenUidaanmkNavigation { get; set; }
        public ICollection<Vrij2objectDocumenten> Vrij2objectDocumentenUidwijzigNavigation { get; set; }
        public ICollection<Vrij2objectLogboek> Vrij2objectLogboekUidaanmkNavigation { get; set; }
        public ICollection<Vrij2objectLogboek> Vrij2objectLogboekUidwijzigNavigation { get; set; }
        public ICollection<Vrij2objectOptionalgrid> Vrij2objectOptionalgridUidaanmkNavigation { get; set; }
        public ICollection<Vrij2objectOptionalgrid> Vrij2objectOptionalgridUidwijzigNavigation { get; set; }
        public ICollection<Vrij2object> Vrij2objectUidaanmkNavigation { get; set; }
        public ICollection<Vrij2object> Vrij2objectUidwijzigNavigation { get; set; }
        public ICollection<Vrij3objectDocumenten> Vrij3objectDocumentenUidaanmkNavigation { get; set; }
        public ICollection<Vrij3objectDocumenten> Vrij3objectDocumentenUidwijzigNavigation { get; set; }
        public ICollection<Vrij3objectLogboek> Vrij3objectLogboekUidaanmkNavigation { get; set; }
        public ICollection<Vrij3objectLogboek> Vrij3objectLogboekUidwijzigNavigation { get; set; }
        public ICollection<Vrij3objectOptionalgrid> Vrij3objectOptionalgridUidaanmkNavigation { get; set; }
        public ICollection<Vrij3objectOptionalgrid> Vrij3objectOptionalgridUidwijzigNavigation { get; set; }
        public ICollection<Vrij3object> Vrij3objectUidaanmkNavigation { get; set; }
        public ICollection<Vrij3object> Vrij3objectUidwijzigNavigation { get; set; }
        public ICollection<Vrij4objectDocumenten> Vrij4objectDocumentenUidaanmkNavigation { get; set; }
        public ICollection<Vrij4objectDocumenten> Vrij4objectDocumentenUidwijzigNavigation { get; set; }
        public ICollection<Vrij4objectLogboek> Vrij4objectLogboekUidaanmkNavigation { get; set; }
        public ICollection<Vrij4objectLogboek> Vrij4objectLogboekUidwijzigNavigation { get; set; }
        public ICollection<Vrij4objectOptionalgrid> Vrij4objectOptionalgridUidaanmkNavigation { get; set; }
        public ICollection<Vrij4objectOptionalgrid> Vrij4objectOptionalgridUidwijzigNavigation { get; set; }
        public ICollection<Vrij4object> Vrij4objectUidaanmkNavigation { get; set; }
        public ICollection<Vrij4object> Vrij4objectUidwijzigNavigation { get; set; }
        public ICollection<Vrij5objectDocumenten> Vrij5objectDocumentenUidaanmkNavigation { get; set; }
        public ICollection<Vrij5objectDocumenten> Vrij5objectDocumentenUidwijzigNavigation { get; set; }
        public ICollection<Vrij5objectLogboek> Vrij5objectLogboekUidaanmkNavigation { get; set; }
        public ICollection<Vrij5objectLogboek> Vrij5objectLogboekUidwijzigNavigation { get; set; }
        public ICollection<Vrij5objectOptionalgrid> Vrij5objectOptionalgridUidaanmkNavigation { get; set; }
        public ICollection<Vrij5objectOptionalgrid> Vrij5objectOptionalgridUidwijzigNavigation { get; set; }
        public ICollection<Vrij5object> Vrij5objectUidaanmkNavigation { get; set; }
        public ICollection<Vrij5object> Vrij5objectUidwijzigNavigation { get; set; }
        public ICollection<Watchlist> Watchlist { get; set; }
    }
}
