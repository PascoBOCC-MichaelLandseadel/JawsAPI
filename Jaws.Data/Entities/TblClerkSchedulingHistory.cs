using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblClerkSchedulingHistory
{
    public int ClerkSchedulingHistoryId { get; set; }

    public int? DivisionId { get; set; }

    public int? SchedulingUserId { get; set; }

    public DateTime? SchedulingDate { get; set; }

    public int? NumberOfCasesNew { get; set; }

    public string? ClerkEventType { get; set; }

    public int? NumberOfCasesUpdated { get; set; }
}
