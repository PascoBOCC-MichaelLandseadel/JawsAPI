using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblCalendarAllocationCaseAttorneyInput
{
    public int AllocationCaseId { get; set; }

    public bool? AppearingByPhone { get; set; }

    public string? HearingDesc { get; set; }

    public bool? FileUpload { get; set; }

    public int? TrialType { get; set; }

    public int? TrialDuration { get; set; }

    public bool? AgreeIndicator { get; set; }

    public int? UserId { get; set; }

    public DateTime? AgreedDate { get; set; }

    public string? AttyNotes { get; set; }

    public DateTime? PretrialDate { get; set; }
}
