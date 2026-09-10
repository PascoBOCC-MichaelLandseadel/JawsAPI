using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblCalendarAllocationRequest
{
    public int AllocationCaseId { get; set; }

    public bool RequestGranted { get; set; }

    public int? ScheduleBy { get; set; }
}
