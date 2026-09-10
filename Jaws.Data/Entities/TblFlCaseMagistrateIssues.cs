using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblFlCaseMagistrateIssues
{
    public int CaseDocId { get; set; }

    public string CaseId { get; set; } = null!;

    public byte? MagistrateIssue { get; set; }
}
