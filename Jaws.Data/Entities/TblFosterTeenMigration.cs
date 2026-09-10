using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblFosterTeenMigration
{
    public int Idnum { get; set; }

    public short? CaseType { get; set; }

    public string? OldCaseId { get; set; }

    public string? CaseId { get; set; }

    public string? CmSupervisor { get; set; }

    public byte? CareCenter { get; set; }

    public string? Runaway { get; set; }

    public DateTime? PreferredCourtTime { get; set; }

    public string? Ffn { get; set; }

    public string? Notes { get; set; }

    public DateTime? HearingDate { get; set; }

    public DateTime? HearingTime { get; set; }

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

    public DateTime? CreationDate { get; set; }

    public string? UserName { get; set; }

    public DateTime? ChangeDate { get; set; }
}
