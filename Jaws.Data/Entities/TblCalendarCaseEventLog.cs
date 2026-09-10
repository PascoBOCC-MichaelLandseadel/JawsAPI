using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblCalendarCaseEventLog
{
    public int CaseEventLogId { get; set; }

    public int? CaseId { get; set; }

    public int? AllocationCaseId { get; set; }

    public int? CaseEventId { get; set; }

    public string? CancelReason { get; set; }

    public int? RescheduledAllocationCaseIdFrom { get; set; }

    public int? RescheduledAllocationCaseIdTo { get; set; }

    public DateTime? EventDate { get; set; }

    public int? UserId { get; set; }
}
