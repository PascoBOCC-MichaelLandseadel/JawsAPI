using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblCaseReturnDate
{
    public int CaseReturnDateId { get; set; }

    public string? CaseId { get; set; }

    public int? JudgeId { get; set; }

    public DateTime? ReturnDate { get; set; }

    public string? EventType { get; set; }

    public int? OrderId { get; set; }
}
