using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class VwCalendarView
{
    public DateTime? AllocationDate { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public int? CaseId { get; set; }

    public int? ScheduledBy { get; set; }

    public string? Description { get; set; }

    public int? NumberCases { get; set; }

    public int? EventTypeId { get; set; }

    public int? DivisionId { get; set; }

    public string? CaseNumber { get; set; }

    public string? CaseDescription { get; set; }

    public string? CaseType { get; set; }

    public int? StartTimeId { get; set; }

    public DateTime? StartTimeAllocated { get; set; }

    public int? EndTimeId { get; set; }

    public DateTime? EndTimeAllocated { get; set; }

    public string? EventType { get; set; }

    public string? EventDescription { get; set; }

    public string? AllocationLabel { get; set; }

    public bool? Cancelled { get; set; }
}
