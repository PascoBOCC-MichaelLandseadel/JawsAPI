using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblCaseWorkflow
{
    public int CaseWorkflowId { get; set; }

    public string CaseWorkflowName { get; set; } = null!;

    public bool Active { get; set; }

    public int? OrderSeq { get; set; }
}
