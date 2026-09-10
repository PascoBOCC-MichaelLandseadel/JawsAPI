using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class CaseSecurityLevel
{
    public string? CourtType { get; set; }

    public string? CourtLocn { get; set; }

    public string? CaseType { get; set; }

    public string? SecurityLevel { get; set; }
}
