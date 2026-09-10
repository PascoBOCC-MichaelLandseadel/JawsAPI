using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class DupCases
{
    public int CaseId { get; set; }

    public string CaseNumber { get; set; } = null!;
}
