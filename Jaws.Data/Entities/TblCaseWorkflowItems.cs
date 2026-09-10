using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblCaseWorkflowItems
{
    public int WorkflowItemId { get; set; }

    public int CaseWorkflowId { get; set; }

    public int WorkflowGroupId { get; set; }

    public int WorkflowDisplayId { get; set; }

    public string WorkflowItem { get; set; } = null!;

    public int WorkflowParticipant { get; set; }

    public bool? Active { get; set; }

    public string? WorkflowForms { get; set; }
}
