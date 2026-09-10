using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblLkuCaseWorkflowStatus
{
    public int CaseWorkflowStatusId { get; set; }

    public string CaseWorkflowStatusDesc { get; set; } = null!;
}
