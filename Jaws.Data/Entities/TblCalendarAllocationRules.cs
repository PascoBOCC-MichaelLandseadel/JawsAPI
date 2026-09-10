using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblCalendarAllocationRules
{
    public int AllocationRuleId { get; set; }

    public int? AllocationId { get; set; }

    public int? DivisionId { get; set; }

    public int? ApprovalTypeId { get; set; }

    public int? MaxHearingLength { get; set; }

    public bool? PretrialRequired { get; set; }

    public bool? AllowPublicScheduling { get; set; }

    public bool? CattleCall { get; set; }

    public int? MinCancellationNotice { get; set; }

    public int? MinAppointmentNotice { get; set; }

    public string? Message { get; set; }

    public string? AllocationLabel { get; set; }

    public int? NumberOfCases { get; set; }

    public bool? HearingDescRequired { get; set; }

    public bool? CollectTrialSelections { get; set; }

    public bool? FileUploadRequired { get; set; }

    public bool? AppearanceByPhoneAllowed { get; set; }

    public string? AppointmentLocation { get; set; }

    public bool? AttorneyAgreementRequired { get; set; }

    public string? AttorneyAgreementText { get; set; }
}
