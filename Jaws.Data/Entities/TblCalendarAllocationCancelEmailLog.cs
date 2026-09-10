using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblCalendarAllocationCancelEmailLog
{
    public int AllocationCaseId { get; set; }

    public string Emails { get; set; } = null!;

    public int? EventTypeId { get; set; }
}
