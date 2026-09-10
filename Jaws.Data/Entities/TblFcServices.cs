using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblFcServices
{
    public int? Idnum { get; set; }

    public string? CaseId { get; set; }

    public string? CaseName { get; set; }

    public byte? Type { get; set; }

    public byte? ReferralBy { get; set; }

    public DateTime? DateOfReferral { get; set; }

    public byte? Division { get; set; }

    public bool CrisisIntervention { get; set; }

    public bool InitialAssessmentInterventionSession { get; set; }

    public string? CoParentingInterventionSession { get; set; }

    public string? ReferredFor { get; set; }

    public bool FcsRSupervisedVisitation { get; set; }

    public bool FcsRChildCustodyInvestigation { get; set; }

    public bool FcsRSubstanceAbuseEval { get; set; }

    public bool FcsRHighConflictParentClass { get; set; }

    public bool FcsRParentCoordinator { get; set; }

    public bool FcsRDrugScreen { get; set; }

    public bool FcsRPsychologicalEval { get; set; }

    public bool AlcoholScreen { get; set; }

    public bool HairFollicleScreen { get; set; }

    public bool MentalHealthEvaluation { get; set; }

    public bool PsychiatricEvaluation { get; set; }

    public string? ComplianceWithFcs { get; set; }

    public string? MotherDateOfAssessment { get; set; }

    public string? FatherComplianceWithFcs { get; set; }

    public string? FatherDateOfAssessment { get; set; }

    public byte? MetWithSystemNavigator { get; set; }

    public string? ReferredTo { get; set; }

    public string? ReportsTheFollowing { get; set; }

    public string? Info2 { get; set; }

    public string? Info3 { get; set; }

    public DateTime? CreationDate { get; set; }

    public string? UserName { get; set; }

    public DateTime? ChangeDate { get; set; }
}
