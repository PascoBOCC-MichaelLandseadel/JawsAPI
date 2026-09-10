using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblCalendarAllocationCasePhone
{
    public int AllocationCaseId { get; set; }

    public int UserId { get; set; }

    public DateTime AddedDate { get; set; }
}
