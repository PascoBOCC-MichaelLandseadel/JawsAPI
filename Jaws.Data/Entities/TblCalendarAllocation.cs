using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblCalendarAllocation
{
    public int AllocationId { get; set; }

    public int? DivisionId { get; set; }

    public DateTime? AllocationDate { get; set; }

    public int? EventTypeId { get; set; }

    public int? NumberCases { get; set; }

    public int? StartTimeId { get; set; }

    public int? EndTimeId { get; set; }

    public int? CaseCount { get; set; }
}
