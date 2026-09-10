using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class VwCaseWorkflows
{
    public int WorkflowItemId { get; set; }

    public int CaseWorkflowId { get; set; }

    public int WorkflowGroupId { get; set; }

    public string WorkflowItem { get; set; } = null!;

    public int WorkflowParticipant { get; set; }

    public string? TblCaseWorkflowParticipant { get; set; }

    public DateTime? DateCompleted { get; set; }

    public string? DocumentType { get; set; }

    public DateTime? DueDate { get; set; }

    public int? WorkflowItemStatus { get; set; }

    public string? CaseWorkflowStatusDesc { get; set; }

    public DateTime? DateLastUpdated { get; set; }

    public int? CaseId { get; set; }

    public string? DivisionDescription { get; set; }
}
