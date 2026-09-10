using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblCaseTypeSecurityLevel
{
    public string CourtType { get; set; } = null!;

    public string CaseType { get; set; } = null!;

    public int SecurityLevel { get; set; }
}
