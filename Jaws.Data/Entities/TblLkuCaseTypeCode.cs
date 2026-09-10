using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblLkuCaseTypeCode
{
    public string? CaseTypeCode { get; set; }

    public string? CaseTypeDesc { get; set; }

    public int? UpperDivisionId { get; set; }

    public int TempId { get; set; }
}
