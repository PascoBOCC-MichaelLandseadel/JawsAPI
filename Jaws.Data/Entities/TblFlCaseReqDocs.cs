using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblFlCaseReqDocs
{
    public int CaseDocId { get; set; }

    public string? CaseId { get; set; }

    public byte? CertificateCompletionParentingClassPetReq { get; set; }

    public byte? CertificateCompletionParentingClassRespReq { get; set; }

    public byte? ChildSupportGuidelinesWorksheetPetReq { get; set; }

    public byte? ChildSupportGuidelinesWorksheetRespReq { get; set; }

    public byte? CompletedMandatoryDisclosurePetReq { get; set; }

    public byte? CompletedMandatoryDisclosureRespReq { get; set; }

    public byte? CompletedUccjeaPetReq { get; set; }

    public byte? CompletedUccjeaRespReq { get; set; }

    public byte? CurrentFinancialAffidavitsPetReq { get; set; }

    public byte? CurrentFinancialAffidavitsRespReq { get; set; }

    public byte? EvidenceServiceProcessPetReq { get; set; }

    public byte? EvidenceServiceProcessRespReq { get; set; }

    public byte? MaritalSettlementAgreementPetReq { get; set; }

    public byte? MaritalSettlementAgreementRespReq { get; set; }

    public byte? MotionForDefaultPetReq { get; set; }

    public byte? MotionForDefaultRespReq { get; set; }

    public byte? OtherPetReq { get; set; }

    public byte? OtherRespReq { get; set; }

    public byte? ProofOfResidencyPetReq { get; set; }

    public byte? ProofOfResidencyRespReq { get; set; }

    public DateTime CaseReqDocCreationDate { get; set; }

    public string UserName { get; set; } = null!;

    public DateTime? FileChangeDate { get; set; }
}
