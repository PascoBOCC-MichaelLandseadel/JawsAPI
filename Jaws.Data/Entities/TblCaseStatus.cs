using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblCaseStatus
{
    public int CaseStatusId { get; set; }

    public string? CaseStatusCaseId { get; set; }

    public int? CaseStatusStatusId { get; set; }
}
