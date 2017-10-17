using System;
using System.Collections.Generic;

namespace TopDeskApiv2.TopDeskDatabase
{
    public partial class Mutatiereden
    {
        public Mutatiereden()
        {
            Geschiedenis = new HashSet<Geschiedenis>();
            Geschiedenismutatieredenlink = new HashSet<Geschiedenismutatieredenlink>();
            MutatieBestelaanvraagMutAanvraagdatumR = new HashSet<MutatieBestelaanvraag>();
            MutatieBestelaanvraagMutBehandelaaridR = new HashSet<MutatieBestelaanvraag>();
            MutatieBestelaanvraagMutGewensteleverdatumR = new HashSet<MutatieBestelaanvraag>();
            MutatieBestelaanvraagMutRappeldatumR = new HashSet<MutatieBestelaanvraag>();
            MutatieBestellingenMutBehandelaaridR = new HashSet<MutatieBestellingen>();
            MutatieBestellingenMutBestelautorisatieidR = new HashSet<MutatieBestellingen>();
            MutatieBestellingenMutGeplandebesteldatumR = new HashSet<MutatieBestellingen>();
            MutatieBestellingenMutOrdernrdatumR = new HashSet<MutatieBestellingen>();
            MutatieBestellingenMutStatusidR = new HashSet<MutatieBestellingen>();
            MutatieChangeMutAuthorizationdateR = new HashSet<MutatieChange>();
            MutatieChangeMutBenefitidR = new HashSet<MutatieChange>();
            MutatieChangeMutCloseddateR = new HashSet<MutatieChange>();
            MutatieChangeMutCompleteddateR = new HashSet<MutatieChange>();
            MutatieChangeMutEvalAuthoperatoridR = new HashSet<MutatieChange>();
            MutatieChangeMutEvalAuthpersonidR = new HashSet<MutatieChange>();
            MutatieChangeMutFinaldateR = new HashSet<MutatieChange>();
            MutatieChangeMutImpactidR = new HashSet<MutatieChange>();
            MutatieChangeMutImplementationdateR = new HashSet<MutatieChange>();
            MutatieChangeMutManageridR = new HashSet<MutatieChange>();
            MutatieChangeMutMilestoneidR = new HashSet<MutatieChange>();
            MutatieChangeMutOperatoridR = new HashSet<MutatieChange>();
            MutatieChangeMutPlannedauthdateR = new HashSet<MutatieChange>();
            MutatieChangeMutPriorityidR = new HashSet<MutatieChange>();
            MutatieChangeMutProAuthoperatoridR = new HashSet<MutatieChange>();
            MutatieChangeMutProAuthpersonidR = new HashSet<MutatieChange>();
            MutatieChangeMutReqAuthoperatoridR = new HashSet<MutatieChange>();
            MutatieChangeMutReqAuthpersonidR = new HashSet<MutatieChange>();
            MutatieChangeMutStatusidR = new HashSet<MutatieChange>();
            MutatieChangeMutVersionidR = new HashSet<MutatieChange>();
            MutatieChangeactivityMutActivitystatusidR = new HashSet<MutatieChangeactivity>();
            MutatieChangeactivityMutApproveddateR = new HashSet<MutatieChangeactivity>();
            MutatieChangeactivityMutDecidedbypersonidR = new HashSet<MutatieChangeactivity>();
            MutatieChangeactivityMutMilestoneidR = new HashSet<MutatieChangeactivity>();
            MutatieChangeactivityMutOperatorgroupidR = new HashSet<MutatieChangeactivity>();
            MutatieChangeactivityMutOperatoridR = new HashSet<MutatieChangeactivity>();
            MutatieChangeactivityMutRejecteddateR = new HashSet<MutatieChangeactivity>();
            MutatieChangeactivityMutRejectionreasonidR = new HashSet<MutatieChangeactivity>();
            MutatieChangeactivityMutResolveddateR = new HashSet<MutatieChangeactivity>();
            MutatieChangeactivityMutSkippeddateR = new HashSet<MutatieChangeactivity>();
            MutatieChangeversionMutFreezedateR = new HashSet<MutatieChangeversion>();
            MutatieChangeversionMutOperatoridR = new HashSet<MutatieChangeversion>();
            MutatieChangeversionMutPlannedimpldateR = new HashSet<MutatieChangeversion>();
            MutatieChangeversionMutStatusidR = new HashSet<MutatieChangeversion>();
            MutatieConfiguratieMutPersoongroepidR = new HashSet<MutatieConfiguratie>();
            MutatieConfiguratieMutPersoonidR = new HashSet<MutatieConfiguratie>();
            MutatieDnocontractMutBehandelaaridR = new HashSet<MutatieDnocontract>();
            MutatieDnocontractMutContractstatusidR = new HashSet<MutatieDnocontract>();
            MutatieDnodienstMutDnodienstsoortidR = new HashSet<MutatieDnodienst>();
            MutatieDnodienstMutDomeinidR = new HashSet<MutatieDnodienst>();
            MutatieDnodienstMutPublishedR = new HashSet<MutatieDnodienst>();
            MutatieDnodienstMutSoortmeldingidR = new HashSet<MutatieDnodienst>();
            MutatieDnodienstMutSpecificatieidR = new HashSet<MutatieDnodienst>();
            MutatieDnodienstMutUnderpinningcontractidR = new HashSet<MutatieDnodienst>();
            MutatieDnodienstMutUnderpinningdienstidR = new HashSet<MutatieDnodienst>();
            MutatieHardwareMutConfiguratieidR = new HashSet<MutatieHardware>();
            MutatieHardwareMutLokatieidR = new HashSet<MutatieHardware>();
            MutatieHardwareMutPersoongroepidR = new HashSet<MutatieHardware>();
            MutatieHardwareMutPersoonidR = new HashSet<MutatieHardware>();
            MutatieHardwareMutVestigingidR = new HashSet<MutatieHardware>();
            MutatieIncidentMutAfhandelingstatusidR = new HashSet<MutatieIncident>();
            MutatieIncidentMutDatumafgemeldR = new HashSet<MutatieIncident>();
            MutatieIncidentMutDatumafspraakR = new HashSet<MutatieIncident>();
            MutatieIncidentMutDatumgereedR = new HashSet<MutatieIncident>();
            MutatieIncidentMutImpactidR = new HashSet<MutatieIncident>();
            MutatieIncidentMutOnholddatumR = new HashSet<MutatieIncident>();
            MutatieIncidentMutOperatorgroupidR = new HashSet<MutatieIncident>();
            MutatieIncidentMutOperatoridR = new HashSet<MutatieIncident>();
            MutatieIncidentMutPriorityidR = new HashSet<MutatieIncident>();
            MutatieIncidentMutSupplieridR = new HashSet<MutatieIncident>();
            MutatieIncidentMutUrgencyidR = new HashSet<MutatieIncident>();
            MutatieInventarisMutConfiguratieidR = new HashSet<MutatieInventaris>();
            MutatieInventarisMutLokatieidR = new HashSet<MutatieInventaris>();
            MutatieInventarisMutPersoongroepidR = new HashSet<MutatieInventaris>();
            MutatieInventarisMutPersoonidR = new HashSet<MutatieInventaris>();
            MutatieInventarisMutVestigingidR = new HashSet<MutatieInventaris>();
            MutatieNetwerkcomponentMutConfiguratieidR = new HashSet<MutatieNetwerkcomponent>();
            MutatieNetwerkcomponentMutLokatieidR = new HashSet<MutatieNetwerkcomponent>();
            MutatieNetwerkcomponentMutPersoongroepidR = new HashSet<MutatieNetwerkcomponent>();
            MutatieNetwerkcomponentMutPersoonidR = new HashSet<MutatieNetwerkcomponent>();
            MutatieNetwerkcomponentMutVestigingidR = new HashSet<MutatieNetwerkcomponent>();
            MutatieOmActiviteitMutBehandelaaridR = new HashSet<MutatieOmActiviteit>();
            MutatieOmActiviteitMutOperatorgroupidR = new HashSet<MutatieOmActiviteit>();
            MutatieOmActiviteitMutStatusidR = new HashSet<MutatieOmActiviteit>();
            MutatieOmActiviteitMutSupplieridR = new HashSet<MutatieOmActiviteit>();
            MutatieOmReeksMutBeheerderidR = new HashSet<MutatieOmReeks>();
            MutatieOmReeksMutStatusidR = new HashSet<MutatieOmReeks>();
            MutatieOmSchemaMutBeheerderidR = new HashSet<MutatieOmSchema>();
            MutatieOmSchemaMutStatusidR = new HashSet<MutatieOmSchema>();
            MutatieProbleemMutActiedoorbfidR = new HashSet<MutatieProbleem>();
            MutatieProbleemMutActiedooridR = new HashSet<MutatieProbleem>();
            MutatieProbleemMutBeheerderbfidR = new HashSet<MutatieProbleem>();
            MutatieProbleemMutDatumafgemeldR = new HashSet<MutatieProbleem>();
            MutatieProbleemMutDatumafgemeldbfR = new HashSet<MutatieProbleem>();
            MutatieProbleemMutDatumgereedR = new HashSet<MutatieProbleem>();
            MutatieProbleemMutDatumgereedbfR = new HashSet<MutatieProbleem>();
            MutatieProbleemMutOperatorgroupbfidR = new HashSet<MutatieProbleem>();
            MutatieProbleemMutOperatorgroupidR = new HashSet<MutatieProbleem>();
            MutatieProbleemMutPriorityidR = new HashSet<MutatieProbleem>();
            MutatieProbleemMutStatusbfidR = new HashSet<MutatieProbleem>();
            MutatieProbleemMutStatusidR = new HashSet<MutatieProbleem>();
            MutatieProbleemMutStreefdatumR = new HashSet<MutatieProbleem>();
            MutatieProbleemMutStreefdatumbfR = new HashSet<MutatieProbleem>();
            MutatieProbleemMutUrgencyidR = new HashSet<MutatieProbleem>();
            MutatieProbleemMutVerantwoordelijkeidR = new HashSet<MutatieProbleem>();
            MutatieProfacboomProjectMutBehandelaaridR = new HashSet<MutatieProfacboomProject>();
            MutatieProfacboomProjectMutCurrentplanexpensesR = new HashSet<MutatieProfacboomProject>();
            MutatieProfacboomProjectMutCurrentplantimetakenR = new HashSet<MutatieProfacboomProject>();
            MutatieProfacboomProjectMutEstimateexpensesR = new HashSet<MutatieProfacboomProject>();
            MutatieProfacboomProjectMutEstimatetimetakenR = new HashSet<MutatieProfacboomProject>();
            MutatieProfacboomProjectMutMilestoneidR = new HashSet<MutatieProfacboomProject>();
            MutatieProfacboomProjectMutOperatorgroupidR = new HashSet<MutatieProfacboomProject>();
            MutatieProfacboomProjectMutOriginalplanexpensesR = new HashSet<MutatieProfacboomProject>();
            MutatieProfacboomProjectMutOriginalplantimetakenR = new HashSet<MutatieProfacboomProject>();
            MutatieProfacboomProjectMutPlannedfinaldateR = new HashSet<MutatieProfacboomProject>();
            MutatieProfacboomProjectMutPlannedstartdateR = new HashSet<MutatieProfacboomProject>();
            MutatieProfacboomProjectMutResolveddateR = new HashSet<MutatieProfacboomProject>();
            MutatieProfacboomProjectMutSkippeddateR = new HashSet<MutatieProfacboomProject>();
            MutatieProfacboomProjectMutStarteddateR = new HashSet<MutatieProfacboomProject>();
            MutatieProfacboomProjectMutStatusidR = new HashSet<MutatieProfacboomProject>();
            MutatieProfacboomProjectMutVersionidR = new HashSet<MutatieProfacboomProject>();
            MutatieReserveringMutBeheerderidR = new HashSet<MutatieReservering>();
            MutatieReserveringMutCategorieidR = new HashSet<MutatieReservering>();
            MutatieReserveringMutEinddatumgeplandR = new HashSet<MutatieReservering>();
            MutatieReserveringMutStartdatumgeplandR = new HashSet<MutatieReservering>();
            MutatieReserveringMutStatusidR = new HashSet<MutatieReservering>();
            MutatieSoftwareMutConfiguratieidR = new HashSet<MutatieSoftware>();
            MutatieSoftwareMutLokatieidR = new HashSet<MutatieSoftware>();
            MutatieSoftwareMutPersoongroepidR = new HashSet<MutatieSoftware>();
            MutatieSoftwareMutPersoonidR = new HashSet<MutatieSoftware>();
            MutatieSoftwareMutVestigingidR = new HashSet<MutatieSoftware>();
            MutatieTelefonieMutConfiguratieidR = new HashSet<MutatieTelefonie>();
            MutatieTelefonieMutLokatieidR = new HashSet<MutatieTelefonie>();
            MutatieTelefonieMutPersoongroepidR = new HashSet<MutatieTelefonie>();
            MutatieTelefonieMutPersoonidR = new HashSet<MutatieTelefonie>();
            MutatieTelefonieMutVestigingidR = new HashSet<MutatieTelefonie>();
            MutatieVestigingMutAnnualdepreciationR = new HashSet<MutatieVestiging>();
            MutatieVestigingMutBuildingLevelEpcIdR = new HashSet<MutatieVestiging>();
            MutatieVestigingMutDepreciationperiodR = new HashSet<MutatieVestiging>();
            MutatieVestigingMutDesignationIdR = new HashSet<MutatieVestiging>();
            MutatieVestigingMutEnergyPerformanceIdR = new HashSet<MutatieVestiging>();
            MutatieVestigingMutEnergyperformancemeasurementdateR = new HashSet<MutatieVestiging>();
            MutatieVestigingMutEnvironmentalImpactIdR = new HashSet<MutatieVestiging>();
            MutatieVestigingMutEnvironmentalimpactmeasurementdateR = new HashSet<MutatieVestiging>();
            MutatieVestigingMutExtraaidR = new HashSet<MutatieVestiging>();
            MutatieVestigingMutExtrabidR = new HashSet<MutatieVestiging>();
            MutatieVestigingMutForeclosurevalueR = new HashSet<MutatieVestiging>();
            MutatieVestigingMutForeclosurevaluesurveydateR = new HashSet<MutatieVestiging>();
            MutatieVestigingMutHistoricalSiteIdR = new HashSet<MutatieVestiging>();
            MutatieVestigingMutLandvalueR = new HashSet<MutatieVestiging>();
            MutatieVestigingMutLandvaluesurveydateR = new HashSet<MutatieVestiging>();
            MutatieVestigingMutMarketvalueR = new HashSet<MutatieVestiging>();
            MutatieVestigingMutMarketvaluesurveydateR = new HashSet<MutatieVestiging>();
            MutatieVestigingMutOwneremailR = new HashSet<MutatieVestiging>();
            MutatieVestigingMutOwnermobilephoneR = new HashSet<MutatieVestiging>();
            MutatieVestigingMutOwnernameR = new HashSet<MutatieVestiging>();
            MutatieVestigingMutOwnertelephoneR = new HashSet<MutatieVestiging>();
            MutatieVestigingMutPriceofacquisitionR = new HashSet<MutatieVestiging>();
            MutatieVestigingMutPropertyvaluationR = new HashSet<MutatieVestiging>();
            MutatieVestigingMutRebuildingvalueR = new HashSet<MutatieVestiging>();
            MutatieVestigingMutRebuildingvaluesurveydateR = new HashSet<MutatieVestiging>();
            MutatieVestigingMutRegistryreferenceR = new HashSet<MutatieVestiging>();
            MutatieVestigingMutRentalvalueR = new HashSet<MutatieVestiging>();
            MutatieVestigingMutRentalvaluesurveydateR = new HashSet<MutatieVestiging>();
            MutatieVestigingMutResidualvalueR = new HashSet<MutatieVestiging>();
            MutatieVestigingMutSurfaceAreaM2R = new HashSet<MutatieVestiging>();
            MutatieVestigingMutTotalcostofacquisitionR = new HashSet<MutatieVestiging>();
            MutatieVestigingMutVolumeM3R = new HashSet<MutatieVestiging>();
            MutatieVestigingMutYearofacquisitionR = new HashSet<MutatieVestiging>();
            MutatieVestigingMutYearofconstructionR = new HashSet<MutatieVestiging>();
            MutatieVrij1objectMutConfiguratieidR = new HashSet<MutatieVrij1object>();
            MutatieVrij1objectMutLokatieidR = new HashSet<MutatieVrij1object>();
            MutatieVrij1objectMutPersoongroepidR = new HashSet<MutatieVrij1object>();
            MutatieVrij1objectMutPersoonidR = new HashSet<MutatieVrij1object>();
            MutatieVrij1objectMutVestigingidR = new HashSet<MutatieVrij1object>();
            MutatieVrij2objectMutConfiguratieidR = new HashSet<MutatieVrij2object>();
            MutatieVrij2objectMutLokatieidR = new HashSet<MutatieVrij2object>();
            MutatieVrij2objectMutPersoongroepidR = new HashSet<MutatieVrij2object>();
            MutatieVrij2objectMutPersoonidR = new HashSet<MutatieVrij2object>();
            MutatieVrij2objectMutVestigingidR = new HashSet<MutatieVrij2object>();
            MutatieVrij3objectMutConfiguratieidR = new HashSet<MutatieVrij3object>();
            MutatieVrij3objectMutLokatieidR = new HashSet<MutatieVrij3object>();
            MutatieVrij3objectMutPersoongroepidR = new HashSet<MutatieVrij3object>();
            MutatieVrij3objectMutPersoonidR = new HashSet<MutatieVrij3object>();
            MutatieVrij3objectMutVestigingidR = new HashSet<MutatieVrij3object>();
            MutatieVrij4objectMutConfiguratieidR = new HashSet<MutatieVrij4object>();
            MutatieVrij4objectMutLokatieidR = new HashSet<MutatieVrij4object>();
            MutatieVrij4objectMutPersoongroepidR = new HashSet<MutatieVrij4object>();
            MutatieVrij4objectMutPersoonidR = new HashSet<MutatieVrij4object>();
            MutatieVrij4objectMutVestigingidR = new HashSet<MutatieVrij4object>();
            MutatieVrij5objectMutConfiguratieidR = new HashSet<MutatieVrij5object>();
            MutatieVrij5objectMutLokatieidR = new HashSet<MutatieVrij5object>();
            MutatieVrij5objectMutPersoongroepidR = new HashSet<MutatieVrij5object>();
            MutatieVrij5objectMutPersoonidR = new HashSet<MutatieVrij5object>();
            MutatieVrij5objectMutVestigingidR = new HashSet<MutatieVrij5object>();
        }

        public string Code { get; set; }
        public int Rang { get; set; }
        public Guid Unid { get; set; }
        public string Naam { get; set; }
        public string Bespokememo { get; set; }
        public int Archief { get; set; }

        public ICollection<Geschiedenis> Geschiedenis { get; set; }
        public ICollection<Geschiedenismutatieredenlink> Geschiedenismutatieredenlink { get; set; }
        public ICollection<MutatieBestelaanvraag> MutatieBestelaanvraagMutAanvraagdatumR { get; set; }
        public ICollection<MutatieBestelaanvraag> MutatieBestelaanvraagMutBehandelaaridR { get; set; }
        public ICollection<MutatieBestelaanvraag> MutatieBestelaanvraagMutGewensteleverdatumR { get; set; }
        public ICollection<MutatieBestelaanvraag> MutatieBestelaanvraagMutRappeldatumR { get; set; }
        public ICollection<MutatieBestellingen> MutatieBestellingenMutBehandelaaridR { get; set; }
        public ICollection<MutatieBestellingen> MutatieBestellingenMutBestelautorisatieidR { get; set; }
        public ICollection<MutatieBestellingen> MutatieBestellingenMutGeplandebesteldatumR { get; set; }
        public ICollection<MutatieBestellingen> MutatieBestellingenMutOrdernrdatumR { get; set; }
        public ICollection<MutatieBestellingen> MutatieBestellingenMutStatusidR { get; set; }
        public ICollection<MutatieChange> MutatieChangeMutAuthorizationdateR { get; set; }
        public ICollection<MutatieChange> MutatieChangeMutBenefitidR { get; set; }
        public ICollection<MutatieChange> MutatieChangeMutCloseddateR { get; set; }
        public ICollection<MutatieChange> MutatieChangeMutCompleteddateR { get; set; }
        public ICollection<MutatieChange> MutatieChangeMutEvalAuthoperatoridR { get; set; }
        public ICollection<MutatieChange> MutatieChangeMutEvalAuthpersonidR { get; set; }
        public ICollection<MutatieChange> MutatieChangeMutFinaldateR { get; set; }
        public ICollection<MutatieChange> MutatieChangeMutImpactidR { get; set; }
        public ICollection<MutatieChange> MutatieChangeMutImplementationdateR { get; set; }
        public ICollection<MutatieChange> MutatieChangeMutManageridR { get; set; }
        public ICollection<MutatieChange> MutatieChangeMutMilestoneidR { get; set; }
        public ICollection<MutatieChange> MutatieChangeMutOperatoridR { get; set; }
        public ICollection<MutatieChange> MutatieChangeMutPlannedauthdateR { get; set; }
        public ICollection<MutatieChange> MutatieChangeMutPriorityidR { get; set; }
        public ICollection<MutatieChange> MutatieChangeMutProAuthoperatoridR { get; set; }
        public ICollection<MutatieChange> MutatieChangeMutProAuthpersonidR { get; set; }
        public ICollection<MutatieChange> MutatieChangeMutReqAuthoperatoridR { get; set; }
        public ICollection<MutatieChange> MutatieChangeMutReqAuthpersonidR { get; set; }
        public ICollection<MutatieChange> MutatieChangeMutStatusidR { get; set; }
        public ICollection<MutatieChange> MutatieChangeMutVersionidR { get; set; }
        public ICollection<MutatieChangeactivity> MutatieChangeactivityMutActivitystatusidR { get; set; }
        public ICollection<MutatieChangeactivity> MutatieChangeactivityMutApproveddateR { get; set; }
        public ICollection<MutatieChangeactivity> MutatieChangeactivityMutDecidedbypersonidR { get; set; }
        public ICollection<MutatieChangeactivity> MutatieChangeactivityMutMilestoneidR { get; set; }
        public ICollection<MutatieChangeactivity> MutatieChangeactivityMutOperatorgroupidR { get; set; }
        public ICollection<MutatieChangeactivity> MutatieChangeactivityMutOperatoridR { get; set; }
        public ICollection<MutatieChangeactivity> MutatieChangeactivityMutRejecteddateR { get; set; }
        public ICollection<MutatieChangeactivity> MutatieChangeactivityMutRejectionreasonidR { get; set; }
        public ICollection<MutatieChangeactivity> MutatieChangeactivityMutResolveddateR { get; set; }
        public ICollection<MutatieChangeactivity> MutatieChangeactivityMutSkippeddateR { get; set; }
        public ICollection<MutatieChangeversion> MutatieChangeversionMutFreezedateR { get; set; }
        public ICollection<MutatieChangeversion> MutatieChangeversionMutOperatoridR { get; set; }
        public ICollection<MutatieChangeversion> MutatieChangeversionMutPlannedimpldateR { get; set; }
        public ICollection<MutatieChangeversion> MutatieChangeversionMutStatusidR { get; set; }
        public ICollection<MutatieConfiguratie> MutatieConfiguratieMutPersoongroepidR { get; set; }
        public ICollection<MutatieConfiguratie> MutatieConfiguratieMutPersoonidR { get; set; }
        public ICollection<MutatieDnocontract> MutatieDnocontractMutBehandelaaridR { get; set; }
        public ICollection<MutatieDnocontract> MutatieDnocontractMutContractstatusidR { get; set; }
        public ICollection<MutatieDnodienst> MutatieDnodienstMutDnodienstsoortidR { get; set; }
        public ICollection<MutatieDnodienst> MutatieDnodienstMutDomeinidR { get; set; }
        public ICollection<MutatieDnodienst> MutatieDnodienstMutPublishedR { get; set; }
        public ICollection<MutatieDnodienst> MutatieDnodienstMutSoortmeldingidR { get; set; }
        public ICollection<MutatieDnodienst> MutatieDnodienstMutSpecificatieidR { get; set; }
        public ICollection<MutatieDnodienst> MutatieDnodienstMutUnderpinningcontractidR { get; set; }
        public ICollection<MutatieDnodienst> MutatieDnodienstMutUnderpinningdienstidR { get; set; }
        public ICollection<MutatieHardware> MutatieHardwareMutConfiguratieidR { get; set; }
        public ICollection<MutatieHardware> MutatieHardwareMutLokatieidR { get; set; }
        public ICollection<MutatieHardware> MutatieHardwareMutPersoongroepidR { get; set; }
        public ICollection<MutatieHardware> MutatieHardwareMutPersoonidR { get; set; }
        public ICollection<MutatieHardware> MutatieHardwareMutVestigingidR { get; set; }
        public ICollection<MutatieIncident> MutatieIncidentMutAfhandelingstatusidR { get; set; }
        public ICollection<MutatieIncident> MutatieIncidentMutDatumafgemeldR { get; set; }
        public ICollection<MutatieIncident> MutatieIncidentMutDatumafspraakR { get; set; }
        public ICollection<MutatieIncident> MutatieIncidentMutDatumgereedR { get; set; }
        public ICollection<MutatieIncident> MutatieIncidentMutImpactidR { get; set; }
        public ICollection<MutatieIncident> MutatieIncidentMutOnholddatumR { get; set; }
        public ICollection<MutatieIncident> MutatieIncidentMutOperatorgroupidR { get; set; }
        public ICollection<MutatieIncident> MutatieIncidentMutOperatoridR { get; set; }
        public ICollection<MutatieIncident> MutatieIncidentMutPriorityidR { get; set; }
        public ICollection<MutatieIncident> MutatieIncidentMutSupplieridR { get; set; }
        public ICollection<MutatieIncident> MutatieIncidentMutUrgencyidR { get; set; }
        public ICollection<MutatieInventaris> MutatieInventarisMutConfiguratieidR { get; set; }
        public ICollection<MutatieInventaris> MutatieInventarisMutLokatieidR { get; set; }
        public ICollection<MutatieInventaris> MutatieInventarisMutPersoongroepidR { get; set; }
        public ICollection<MutatieInventaris> MutatieInventarisMutPersoonidR { get; set; }
        public ICollection<MutatieInventaris> MutatieInventarisMutVestigingidR { get; set; }
        public ICollection<MutatieNetwerkcomponent> MutatieNetwerkcomponentMutConfiguratieidR { get; set; }
        public ICollection<MutatieNetwerkcomponent> MutatieNetwerkcomponentMutLokatieidR { get; set; }
        public ICollection<MutatieNetwerkcomponent> MutatieNetwerkcomponentMutPersoongroepidR { get; set; }
        public ICollection<MutatieNetwerkcomponent> MutatieNetwerkcomponentMutPersoonidR { get; set; }
        public ICollection<MutatieNetwerkcomponent> MutatieNetwerkcomponentMutVestigingidR { get; set; }
        public ICollection<MutatieOmActiviteit> MutatieOmActiviteitMutBehandelaaridR { get; set; }
        public ICollection<MutatieOmActiviteit> MutatieOmActiviteitMutOperatorgroupidR { get; set; }
        public ICollection<MutatieOmActiviteit> MutatieOmActiviteitMutStatusidR { get; set; }
        public ICollection<MutatieOmActiviteit> MutatieOmActiviteitMutSupplieridR { get; set; }
        public ICollection<MutatieOmReeks> MutatieOmReeksMutBeheerderidR { get; set; }
        public ICollection<MutatieOmReeks> MutatieOmReeksMutStatusidR { get; set; }
        public ICollection<MutatieOmSchema> MutatieOmSchemaMutBeheerderidR { get; set; }
        public ICollection<MutatieOmSchema> MutatieOmSchemaMutStatusidR { get; set; }
        public ICollection<MutatieProbleem> MutatieProbleemMutActiedoorbfidR { get; set; }
        public ICollection<MutatieProbleem> MutatieProbleemMutActiedooridR { get; set; }
        public ICollection<MutatieProbleem> MutatieProbleemMutBeheerderbfidR { get; set; }
        public ICollection<MutatieProbleem> MutatieProbleemMutDatumafgemeldR { get; set; }
        public ICollection<MutatieProbleem> MutatieProbleemMutDatumafgemeldbfR { get; set; }
        public ICollection<MutatieProbleem> MutatieProbleemMutDatumgereedR { get; set; }
        public ICollection<MutatieProbleem> MutatieProbleemMutDatumgereedbfR { get; set; }
        public ICollection<MutatieProbleem> MutatieProbleemMutOperatorgroupbfidR { get; set; }
        public ICollection<MutatieProbleem> MutatieProbleemMutOperatorgroupidR { get; set; }
        public ICollection<MutatieProbleem> MutatieProbleemMutPriorityidR { get; set; }
        public ICollection<MutatieProbleem> MutatieProbleemMutStatusbfidR { get; set; }
        public ICollection<MutatieProbleem> MutatieProbleemMutStatusidR { get; set; }
        public ICollection<MutatieProbleem> MutatieProbleemMutStreefdatumR { get; set; }
        public ICollection<MutatieProbleem> MutatieProbleemMutStreefdatumbfR { get; set; }
        public ICollection<MutatieProbleem> MutatieProbleemMutUrgencyidR { get; set; }
        public ICollection<MutatieProbleem> MutatieProbleemMutVerantwoordelijkeidR { get; set; }
        public ICollection<MutatieProfacboomProject> MutatieProfacboomProjectMutBehandelaaridR { get; set; }
        public ICollection<MutatieProfacboomProject> MutatieProfacboomProjectMutCurrentplanexpensesR { get; set; }
        public ICollection<MutatieProfacboomProject> MutatieProfacboomProjectMutCurrentplantimetakenR { get; set; }
        public ICollection<MutatieProfacboomProject> MutatieProfacboomProjectMutEstimateexpensesR { get; set; }
        public ICollection<MutatieProfacboomProject> MutatieProfacboomProjectMutEstimatetimetakenR { get; set; }
        public ICollection<MutatieProfacboomProject> MutatieProfacboomProjectMutMilestoneidR { get; set; }
        public ICollection<MutatieProfacboomProject> MutatieProfacboomProjectMutOperatorgroupidR { get; set; }
        public ICollection<MutatieProfacboomProject> MutatieProfacboomProjectMutOriginalplanexpensesR { get; set; }
        public ICollection<MutatieProfacboomProject> MutatieProfacboomProjectMutOriginalplantimetakenR { get; set; }
        public ICollection<MutatieProfacboomProject> MutatieProfacboomProjectMutPlannedfinaldateR { get; set; }
        public ICollection<MutatieProfacboomProject> MutatieProfacboomProjectMutPlannedstartdateR { get; set; }
        public ICollection<MutatieProfacboomProject> MutatieProfacboomProjectMutResolveddateR { get; set; }
        public ICollection<MutatieProfacboomProject> MutatieProfacboomProjectMutSkippeddateR { get; set; }
        public ICollection<MutatieProfacboomProject> MutatieProfacboomProjectMutStarteddateR { get; set; }
        public ICollection<MutatieProfacboomProject> MutatieProfacboomProjectMutStatusidR { get; set; }
        public ICollection<MutatieProfacboomProject> MutatieProfacboomProjectMutVersionidR { get; set; }
        public ICollection<MutatieReservering> MutatieReserveringMutBeheerderidR { get; set; }
        public ICollection<MutatieReservering> MutatieReserveringMutCategorieidR { get; set; }
        public ICollection<MutatieReservering> MutatieReserveringMutEinddatumgeplandR { get; set; }
        public ICollection<MutatieReservering> MutatieReserveringMutStartdatumgeplandR { get; set; }
        public ICollection<MutatieReservering> MutatieReserveringMutStatusidR { get; set; }
        public ICollection<MutatieSoftware> MutatieSoftwareMutConfiguratieidR { get; set; }
        public ICollection<MutatieSoftware> MutatieSoftwareMutLokatieidR { get; set; }
        public ICollection<MutatieSoftware> MutatieSoftwareMutPersoongroepidR { get; set; }
        public ICollection<MutatieSoftware> MutatieSoftwareMutPersoonidR { get; set; }
        public ICollection<MutatieSoftware> MutatieSoftwareMutVestigingidR { get; set; }
        public ICollection<MutatieTelefonie> MutatieTelefonieMutConfiguratieidR { get; set; }
        public ICollection<MutatieTelefonie> MutatieTelefonieMutLokatieidR { get; set; }
        public ICollection<MutatieTelefonie> MutatieTelefonieMutPersoongroepidR { get; set; }
        public ICollection<MutatieTelefonie> MutatieTelefonieMutPersoonidR { get; set; }
        public ICollection<MutatieTelefonie> MutatieTelefonieMutVestigingidR { get; set; }
        public ICollection<MutatieVestiging> MutatieVestigingMutAnnualdepreciationR { get; set; }
        public ICollection<MutatieVestiging> MutatieVestigingMutBuildingLevelEpcIdR { get; set; }
        public ICollection<MutatieVestiging> MutatieVestigingMutDepreciationperiodR { get; set; }
        public ICollection<MutatieVestiging> MutatieVestigingMutDesignationIdR { get; set; }
        public ICollection<MutatieVestiging> MutatieVestigingMutEnergyPerformanceIdR { get; set; }
        public ICollection<MutatieVestiging> MutatieVestigingMutEnergyperformancemeasurementdateR { get; set; }
        public ICollection<MutatieVestiging> MutatieVestigingMutEnvironmentalImpactIdR { get; set; }
        public ICollection<MutatieVestiging> MutatieVestigingMutEnvironmentalimpactmeasurementdateR { get; set; }
        public ICollection<MutatieVestiging> MutatieVestigingMutExtraaidR { get; set; }
        public ICollection<MutatieVestiging> MutatieVestigingMutExtrabidR { get; set; }
        public ICollection<MutatieVestiging> MutatieVestigingMutForeclosurevalueR { get; set; }
        public ICollection<MutatieVestiging> MutatieVestigingMutForeclosurevaluesurveydateR { get; set; }
        public ICollection<MutatieVestiging> MutatieVestigingMutHistoricalSiteIdR { get; set; }
        public ICollection<MutatieVestiging> MutatieVestigingMutLandvalueR { get; set; }
        public ICollection<MutatieVestiging> MutatieVestigingMutLandvaluesurveydateR { get; set; }
        public ICollection<MutatieVestiging> MutatieVestigingMutMarketvalueR { get; set; }
        public ICollection<MutatieVestiging> MutatieVestigingMutMarketvaluesurveydateR { get; set; }
        public ICollection<MutatieVestiging> MutatieVestigingMutOwneremailR { get; set; }
        public ICollection<MutatieVestiging> MutatieVestigingMutOwnermobilephoneR { get; set; }
        public ICollection<MutatieVestiging> MutatieVestigingMutOwnernameR { get; set; }
        public ICollection<MutatieVestiging> MutatieVestigingMutOwnertelephoneR { get; set; }
        public ICollection<MutatieVestiging> MutatieVestigingMutPriceofacquisitionR { get; set; }
        public ICollection<MutatieVestiging> MutatieVestigingMutPropertyvaluationR { get; set; }
        public ICollection<MutatieVestiging> MutatieVestigingMutRebuildingvalueR { get; set; }
        public ICollection<MutatieVestiging> MutatieVestigingMutRebuildingvaluesurveydateR { get; set; }
        public ICollection<MutatieVestiging> MutatieVestigingMutRegistryreferenceR { get; set; }
        public ICollection<MutatieVestiging> MutatieVestigingMutRentalvalueR { get; set; }
        public ICollection<MutatieVestiging> MutatieVestigingMutRentalvaluesurveydateR { get; set; }
        public ICollection<MutatieVestiging> MutatieVestigingMutResidualvalueR { get; set; }
        public ICollection<MutatieVestiging> MutatieVestigingMutSurfaceAreaM2R { get; set; }
        public ICollection<MutatieVestiging> MutatieVestigingMutTotalcostofacquisitionR { get; set; }
        public ICollection<MutatieVestiging> MutatieVestigingMutVolumeM3R { get; set; }
        public ICollection<MutatieVestiging> MutatieVestigingMutYearofacquisitionR { get; set; }
        public ICollection<MutatieVestiging> MutatieVestigingMutYearofconstructionR { get; set; }
        public ICollection<MutatieVrij1object> MutatieVrij1objectMutConfiguratieidR { get; set; }
        public ICollection<MutatieVrij1object> MutatieVrij1objectMutLokatieidR { get; set; }
        public ICollection<MutatieVrij1object> MutatieVrij1objectMutPersoongroepidR { get; set; }
        public ICollection<MutatieVrij1object> MutatieVrij1objectMutPersoonidR { get; set; }
        public ICollection<MutatieVrij1object> MutatieVrij1objectMutVestigingidR { get; set; }
        public ICollection<MutatieVrij2object> MutatieVrij2objectMutConfiguratieidR { get; set; }
        public ICollection<MutatieVrij2object> MutatieVrij2objectMutLokatieidR { get; set; }
        public ICollection<MutatieVrij2object> MutatieVrij2objectMutPersoongroepidR { get; set; }
        public ICollection<MutatieVrij2object> MutatieVrij2objectMutPersoonidR { get; set; }
        public ICollection<MutatieVrij2object> MutatieVrij2objectMutVestigingidR { get; set; }
        public ICollection<MutatieVrij3object> MutatieVrij3objectMutConfiguratieidR { get; set; }
        public ICollection<MutatieVrij3object> MutatieVrij3objectMutLokatieidR { get; set; }
        public ICollection<MutatieVrij3object> MutatieVrij3objectMutPersoongroepidR { get; set; }
        public ICollection<MutatieVrij3object> MutatieVrij3objectMutPersoonidR { get; set; }
        public ICollection<MutatieVrij3object> MutatieVrij3objectMutVestigingidR { get; set; }
        public ICollection<MutatieVrij4object> MutatieVrij4objectMutConfiguratieidR { get; set; }
        public ICollection<MutatieVrij4object> MutatieVrij4objectMutLokatieidR { get; set; }
        public ICollection<MutatieVrij4object> MutatieVrij4objectMutPersoongroepidR { get; set; }
        public ICollection<MutatieVrij4object> MutatieVrij4objectMutPersoonidR { get; set; }
        public ICollection<MutatieVrij4object> MutatieVrij4objectMutVestigingidR { get; set; }
        public ICollection<MutatieVrij5object> MutatieVrij5objectMutConfiguratieidR { get; set; }
        public ICollection<MutatieVrij5object> MutatieVrij5objectMutLokatieidR { get; set; }
        public ICollection<MutatieVrij5object> MutatieVrij5objectMutPersoongroepidR { get; set; }
        public ICollection<MutatieVrij5object> MutatieVrij5objectMutPersoonidR { get; set; }
        public ICollection<MutatieVrij5object> MutatieVrij5objectMutVestigingidR { get; set; }
    }
}
