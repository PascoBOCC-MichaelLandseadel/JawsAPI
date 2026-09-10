using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblFosterTeen
{
    public int Idnum { get; set; }

    public short? CaseType { get; set; }

    public string? CaseId { get; set; }

    public string? OldCaseId { get; set; }

    public string? CmSupervisor { get; set; }

    public byte? CareCenter { get; set; }

    public string? Runaway { get; set; }

    public DateTime? PreferredCourtTime { get; set; }

    public string? Ffn { get; set; }

    public string? Notes { get; set; }

    public DateTime? HearingDate { get; set; }

    public DateTime? HearingTime { get; set; }

    public byte? JrStatus { get; set; }

    public DateTime? ApplicationFiledDate { get; set; }

    public DateTime? MentorAssignedDate { get; set; }

    public DateTime? CaseTransferredDate { get; set; }

    public DateTime? CaseClosedDate { get; set; }

    public DateTime? CourtDateWithOriginalJudgeGm { get; set; }

    public short? OrderToTransferDone { get; set; }

    public short? OriginalDivision { get; set; }

    public short? OnlyChildInTheFamily { get; set; }

    public string? SeventeenYrOldAdReason { get; set; }

    public string? SeventeenAndOneHalfYrAdReason { get; set; }

    public string? TransCpReason { get; set; }

    public string? LifeSkDmReason { get; set; }

    public string? TeenNpReason { get; set; }

    public string? LstlReason { get; set; }

    public string? IepReason { get; set; }

    public string? MedicaidReason { get; set; }

    public string? IdReason { get; set; }

    public string? BcReason { get; set; }

    public string? BankAccountReason { get; set; }

    public string? SscReason { get; set; }

    public DateTime? LastJr { get; set; }

    public short? ExtendingJurisdiction { get; set; }

    public DateTime? ExtendingJurisdictionDate { get; set; }

    public short? Nsmp { get; set; }

    public short? Hsd { get; set; }

    public short? Phsg { get; set; }

    public string? Dchcj { get; set; }

    public short? Rti { get; set; }

    public string? SeventeenYrOldAddendum { get; set; }

    public string? CurrentMedicaidCard { get; set; }

    public string? TransitionIlpCasePlan { get; set; }

    public string? ValidFloridaId { get; set; }

    public string? LifeSkillsAccess { get; set; }

    public string? BankAccount { get; set; }

    public string? IepEducationPlan { get; set; }

    public string? SocialSecurityCard { get; set; }

    public string? SeventeenOneHalfYrOldAddendum { get; set; }

    public string? LifeSkillsTrainingLog { get; set; }

    public string? CertCopyBirthCertificate { get; set; }

    public string? TeenNormalcyPlan { get; set; }

    public string? TeenPresent { get; set; }

    public byte? GuardianVolunteer { get; set; }

    public byte? MedicaidWaiver { get; set; }

    public byte? Ssi { get; set; }

    public string? Placement { get; set; }

    public string? PlacementAfterEighteen { get; set; }

    public string? PlacementIssues { get; set; }

    public string? Employed { get; set; }

    public string? PsychRecommendations { get; set; }

    public string? CareerPlan { get; set; }

    public string? EducationalPlan { get; set; }

    public string? Enrollment { get; set; }

    public string? GradeLevel { get; set; }

    public string? Gpa { get; set; }

    public byte? Ese { get; set; }

    public string? FcatMath { get; set; }

    public string? FcatReading { get; set; }

    public string? FcatWriting { get; set; }

    public string? DiplomaType { get; set; }

    public DateTime? DateExtended { get; set; }

    public byte? MentalHealthLiaison { get; set; }

    public DateTime? MentalHealthCourtDate { get; set; }

    public DateTime? MentalHealthCourtTime { get; set; }

    public string? Medicaid { get; set; }

    public byte? SsiAdult { get; set; }

    public DateTime? MentalHealthRecords { get; set; }

    public DateTime? LastDocketViewedDate { get; set; }

    public string? Goal { get; set; }

    public DateTime? GoalEnteredDate { get; set; }

    public string? GoalConfirmed { get; set; }

    public string? Apd { get; set; }

    public string? Ged { get; set; }

    public string? HsDiploma { get; set; }

    public string? EmployedCheck { get; set; }

    public DateTime? Aal { get; set; }

    public byte? Attended { get; set; }

    public DateTime? CreationDate { get; set; }

    public string? UserName { get; set; }

    public DateTime? ChangeDate { get; set; }
}
