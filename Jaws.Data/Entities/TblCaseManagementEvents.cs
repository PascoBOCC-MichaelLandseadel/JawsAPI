using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblCaseManagementEvents
{
    public int CaseEventsId { get; set; }

    public string? CaseId { get; set; }

    public string? CaseEvents { get; set; }

    public int? UserId { get; set; }

    public DateTime? CaseEventsDate { get; set; }

    public bool? Active { get; set; }
}
