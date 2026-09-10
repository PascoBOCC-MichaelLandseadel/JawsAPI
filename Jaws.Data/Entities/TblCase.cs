using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblCase
{
    public int CaseId { get; set; }

    public string CaseNumber { get; set; } = null!;

    public string? CaseDescription { get; set; }

    public string? CaseStatus { get; set; }

    public string? CaseType { get; set; }

    public DateTime? FiledDate { get; set; }

    public string? Ucn { get; set; }

    public string? Ffn { get; set; }

    public string? CaseTypeCode { get; set; }
}
