using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class Query
{
    public string? AppointmentType { get; set; }

    public string? AppointmentDescription { get; set; }

    public string? CaseNumber { get; set; }

    public string? Judge { get; set; }

    public string? OptionalAttyDefinition { get; set; }

    public string? OptionalOpposingAtty { get; set; }

    public string? Defendant { get; set; }

    public string? DefendantAttorney { get; set; }

    public string? DefendantAttorneyEmail { get; set; }

    public string? DefendantAttorneyBarNumber { get; set; }

    public string? DefendantAttorneyPhone { get; set; }

    public string? DefendantProSe { get; set; }

    public string? Plaintiff { get; set; }

    public string? PlaintiffAttorney { get; set; }

    public string? PlaintiffAttorneyEmail { get; set; }

    public string? PlaintiffAttorneyBarNumber { get; set; }

    public string? PlaintiffAttorneyPhone { get; set; }

    public string? PlaintiffProSe { get; set; }

    public string? ApptStartTime { get; set; }

    public string? AppointmentEndDate { get; set; }

    public string? AppointmentStatus { get; set; }

    public string? LegacyNotes { get; set; }

    public string? ApptDescription { get; set; }

    public string TrialType { get; set; } = null!;

    public int? EstTrialDays { get; set; }

    public string? AdditionalRelatedParties { get; set; }

    public string? DateLastModified { get; set; }

    public string? SubmittedDate { get; set; }

    public int? CreatedBy { get; set; }

    public bool? Deleted { get; set; }

    public string? ApptStatus { get; set; }

    public string? Motion { get; set; }

    public string? Description { get; set; }

    public int? LocationId { get; set; }

    public int? RecordUid { get; set; }

    public DateTime? ApptActualStartTime { get; set; }

    public DateTime? ApptActualEndTime { get; set; }

    public int? ScheduleDetailId { get; set; }

    public string? AllocationLabel { get; set; }

    public string? AllocationDate { get; set; }

    public string? AllocationStartTime { get; set; }

    public string? AllocationEndTime { get; set; }

    public int? MaxEventTimeInMinutes { get; set; }

    public int? MaxNumberOfCases0EqualsUnlimited { get; set; }

    public string? PubliclyAvailable { get; set; }

    public string? SchedulerEmail { get; set; }

    public string? MessageToAttorneyOrAdditionalMsgToAttorney { get; set; }

    public string? AllowAttysToCancel { get; set; }

    public bool? AllowAttysToSchedule { get; set; }

    public bool? FileUploadOrFilingRequired { get; set; }

    public bool? ShowEndTime { get; set; }

    public bool? CollectTrialInfo { get; set; }

    public string? CaseUcn { get; set; }

    public string? CaseNumber1 { get; set; }

    public string? CaseDescription { get; set; }

    public string? CourtType { get; set; }

    public string? DivisionCode { get; set; }

    public string? CaseStatus { get; set; }

    public string? CaseCreated { get; set; }

    public string? DateCaseEnteredIntoJcal { get; set; }

    public string CaseDetailSource { get; set; } = null!;

    public string? DateSourceLastAccessed { get; set; }

    public bool Inserted { get; set; }

    public int PastId { get; set; }

    public int? AllocationStartId { get; set; }

    public int? AllocationEndId { get; set; }

    public int? AllocationId { get; set; }
}
