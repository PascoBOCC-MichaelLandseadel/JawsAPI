using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblTempHearingCheck
{
    public string? DivisionName { get; set; }

    public int? DivisionId { get; set; }

    public string? HearingDate { get; set; }

    public string? HearingTime { get; set; }

    public string? EventType { get; set; }

    public string? CaseNumber { get; set; }
}
