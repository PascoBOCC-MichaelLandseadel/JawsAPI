using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblCalendarAllocationCase
{
    public int AllocationCaseId { get; set; }

    public int? AllocationId { get; set; }

    public int? CaseId { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? EndTime { get; set; }

    public int? ScheduledBy { get; set; }

    public bool? Cancelled { get; set; }

    public string? Description { get; set; }
}
