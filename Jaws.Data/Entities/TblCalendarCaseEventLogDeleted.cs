using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblCalendarCaseEventLogDeleted
{
    public int EventLogId { get; set; }

    public int? CaseId { get; set; }

    public string? CaseEvent { get; set; }

    public string? EventType { get; set; }

    public string? CancelReason { get; set; }

    public DateTime? ScheduledForDate { get; set; }

    public DateTime? ScheduledForTime { get; set; }

    public DateTime? EventDate { get; set; }

    public int? UserId { get; set; }
}
