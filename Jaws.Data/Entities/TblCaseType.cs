using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblCaseType
{
    public int CaseTypeId { get; set; }

    public string? CaseTypeCode { get; set; }

    public string? CaseTypeDesc { get; set; }
}
