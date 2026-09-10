using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class VwEmailIssue
{
    public DateTime? EventDate { get; set; }

    public int? EventLogUserId { get; set; }

    public string? CancelReason { get; set; }

    public int? EventLogCaseId { get; set; }

    public int? AllocationCaseId { get; set; }

    public int? CaseEventId { get; set; }

    public string CaseNumber { get; set; } = null!;

    public string Emails { get; set; } = null!;

    public int EmailLogAllocationCaseId { get; set; }

    public int? EmailLogCaseId { get; set; }

    public string EmailLogCaseNumber { get; set; } = null!;

    public int? ScheduledBy { get; set; }

    public string Email { get; set; } = null!;
}
