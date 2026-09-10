using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblCaseWorkflowItemsProcess
{
    public int WorkflowItemProcessId { get; set; }

    public int CaseId { get; set; }

    public int WorkflowId { get; set; }

    public int WorkflowItemId { get; set; }

    public DateTime? DateCompleted { get; set; }

    public string? DocumentType { get; set; }

    public DateTime? DueDate { get; set; }

    public int? WorkflowItemStatus { get; set; }

    public DateTime? DateLastUpdated { get; set; }
}
