using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblLkuCaseStatus
{
    public int CaseStatusId { get; set; }

    public string? CaseStatus { get; set; }

    public bool? Active { get; set; }
}
