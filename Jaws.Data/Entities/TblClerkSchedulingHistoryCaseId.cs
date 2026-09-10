using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblClerkSchedulingHistoryCaseId
{
    public int ClerkSchedulingHistoryCaseId { get; set; }

    public int? ClerkSchedulingHistoryId { get; set; }

    public int? CaseId { get; set; }

    public int? AllocationId { get; set; }

    public int? AllocationCaseId { get; set; }

    public DateTime? AllocationDate { get; set; }

    public DateTime? AllocationStartTime { get; set; }

    public DateTime? AllocationEndTime { get; set; }

    public int? EventTypeId { get; set; }

    public bool? Cancelled { get; set; }

    public string? UpdateDescription { get; set; }
}
