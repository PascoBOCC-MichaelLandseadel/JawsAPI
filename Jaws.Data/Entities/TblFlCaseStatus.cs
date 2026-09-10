using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblFlCaseStatus
{
    public int CaseStatusId { get; set; }

    public string? CaseId { get; set; }

    public DateTime? DateOfFilingDateTime { get; set; }

    public DateTime? PersonalServiceDateTime { get; set; }

    public DateTime? NoticeOfActionDateTime { get; set; }

    public DateTime? AnswerWaiverDateTime { get; set; }

    public DateTime? AnswerDateTime { get; set; }

    public DateTime? AnswerAndCounterPetitionDateTime { get; set; }

    public DateTime? DefaultedDateTime { get; set; }

    public DateTime? DriversLicenseIssueDateDateTime { get; set; }

    public byte? IssueDriversLicenseReq { get; set; }

    public DateTime? IssueDateCorroboratingWitnessDateTime { get; set; }

    public DateTime? CourtTimeDateTime { get; set; }

    public byte? CorroboratingWitnessReq { get; set; }

    public DateTime? SummonsIssuedDateTimePet { get; set; }

    public byte? SummonsIssuedDateTimeReq { get; set; }

    public DateTime? EvidenceServiceProcessPet { get; set; }

    public byte? EvidenceServiceProcessReq { get; set; }

    public byte? EvidenceServiceProcessPetReq { get; set; }

    public byte? EvidenceServiceProcessRespReq { get; set; }

    public DateTime? CurrentFinancialAffidavitsDateTimePet { get; set; }

    public byte? CurrentFinancialAffidavitsDateTimeReq { get; set; }

    public byte? CurrentFinancialAffidavitsRespReq { get; set; }

    public byte? CurrentFinancialAffidavitsPetReq { get; set; }

    public decimal? NetIncomePet { get; set; }

    public byte? NetIncomeReq { get; set; }

    public DateTime? NoticeSocialSecurityDateTimePet { get; set; }

    public byte? NoticeSocialSecurityDateTimeReq { get; set; }

    public DateTime? PetitionDateTimePet { get; set; }

    public byte? PetitionReq { get; set; }

    public DateTime? AffidavitDiligentSearchDateTimePet { get; set; }

    public byte? AffidavitDiligentSearchDateTimeReq { get; set; }

    public DateTime? CompletedUccjeaPet { get; set; }

    public byte? CompletedUccjeaReq { get; set; }

    public byte? CompletedUccjeaPetReq { get; set; }

    public byte? CompletedUccjeaRespReq { get; set; }

    public DateTime? CompletedMandatoryDisclosurePet { get; set; }

    public byte? CompletedMandatoryDisclosureReq { get; set; }

    public byte? CompletedMandatoryDisclosurePetReq { get; set; }

    public byte? CompletedMandatoryDisclosureRespReq { get; set; }

    public DateTime? CertificateCompletionParentingClassPet { get; set; }

    public byte? CertificateCompletionParentingClassReq { get; set; }

    public byte? CertificateCompletionParentingClassPetReq { get; set; }

    public byte? CertificateCompletionParentingClassRespReq { get; set; }

    public DateTime? ChildSupportGuidelinesWorksheetPet { get; set; }

    public byte? ChildSupportGuidelinesWorksheetReq { get; set; }

    public byte? ChildSupportGuidelinesWorksheetPetReq { get; set; }

    public byte? ChildSupportGuidelinesWorksheetRespReq { get; set; }

    public DateTime? MotionToDevChildSupportGuidelinesPet { get; set; }

    public byte? MotionToDevChildSupportGuidelinesReq { get; set; }

    public byte? MotionToDevChildSupportGuidelinesPetReq { get; set; }

    public byte? MotionToDevChildSupportGuidelinesRespReq { get; set; }

    public DateTime? MaritalSettlementAgreementPet { get; set; }

    public byte? MaritalSettlementAgreementReq { get; set; }

    public string? MaritalSettlementAgreementPetReq { get; set; }

    public byte? MaritalSettlementAgreementRespReq { get; set; }

    public DateTime? VisitationSchedulePet { get; set; }

    public byte? VisitationScheduleReq { get; set; }

    public DateTime? NonMilitaryAffidavitPet { get; set; }

    public byte? NonMilitaryAffidavitReq { get; set; }

    public DateTime? FingerprintCardPet { get; set; }

    public byte? FingerprintCardReq { get; set; }

    public DateTime? NewspaperAdDateTimePet { get; set; }

    public byte? NewspaperAdDateTimeReq { get; set; }

    public DateTime? CounterPetitionPet { get; set; }

    public byte? CounterPetitionReq { get; set; }

    public DateTime? MotionForDefaultPet { get; set; }

    public byte? MotionForDefaultReq { get; set; }

    public string? MotionForDefaultPetReq { get; set; }

    public byte? MotionForDefaultRespReq { get; set; }

    public DateTime? NoticeOfHearingPet { get; set; }

    public byte? NoticeOfHearingReq { get; set; }

    public DateTime? FinalJudgmentFormPet { get; set; }

    public byte? FinalJudgmentFormReq { get; set; }

    public DateTime? MediationAndDiversionPet { get; set; }

    public byte? MediationAndDiversionReq { get; set; }

    public byte? OtherReq { get; set; }

    public byte? OtherPetReq { get; set; }

    public byte? OtherRespReq { get; set; }

    public DateTime? CurrentFinancialAffidavitsDateTimeResp { get; set; }

    public decimal? NetIncomeResp { get; set; }

    public DateTime? NoticeSocialSecurityDateTimeResp { get; set; }

    public DateTime? CompletedMandatoryDisclosureResp { get; set; }

    public DateTime? CertificateCompletionParentingClassResp { get; set; }

    public DateTime? MaritalSettlementAgreementResp { get; set; }

    public DateTime? MotionToDevChildSupportGuidelinesResp { get; set; }

    public DateTime? VisitationScheduleResp { get; set; }

    public string? SummonsIssuedComments { get; set; }

    public string? EvidenceServiceProcessComments { get; set; }

    public string? CurrentFinancialAffidavitsComments { get; set; }

    public string? MotionToDevChildSupportGuidelinesComments { get; set; }

    public string? NetIncomeComments { get; set; }

    public string? NoticeSocialSecurityComments { get; set; }

    public string? AffidavitDiligentSearchComments { get; set; }

    public string? CompletedUccjeaComments { get; set; }

    public string? CompletedMandatoryDisclosureComments { get; set; }

    public string? CertificateCompletionParentingClassComments { get; set; }

    public string? ChildSupportGuidelinesWorksheetComments { get; set; }

    public string? MaritalSettlementAgreementComments { get; set; }

    public string? VisitationScheduleComments { get; set; }

    public string? NonMilitaryAffidavitComments { get; set; }

    public string? FingerprintCardComments { get; set; }

    public string? NewspaperAdComments { get; set; }

    public string? PetitionComments { get; set; }

    public string? CounterPetitionComments { get; set; }

    public string? MotionForDefaultComments { get; set; }

    public string? NoticeOfHearingComments { get; set; }

    public string? FinalJudgmentFormComments { get; set; }

    public string? MediationAndDiversionComments { get; set; }

    public string? IssueDriversLicenseComments { get; set; }

    public string? CorroboratingWitnessComments { get; set; }

    public string? Notes { get; set; }

    public string? ReviewedBy { get; set; }

    public DateTime? FileReviewDateTime { get; set; }

    public DateTime? MediationSetDateTime { get; set; }

    public DateTime CaseStatusCreationDate { get; set; }

    public DateTime? ReferredToCourtServices { get; set; }

    public string UserName { get; set; } = null!;

    public DateTime? FileChangeDate { get; set; }
}
