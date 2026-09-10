using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblCaseManagerProSe
{
    public int ProSeListId { get; set; }

    public int? CaseManagerId { get; set; }

    public int CaseId { get; set; }

    public DateTime? AssignedDate { get; set; }

    public int DivisionId { get; set; }

    public int? WorkflowId { get; set; }

    public int? PetitionerId { get; set; }

    public int? RspondentId { get; set; }
}
