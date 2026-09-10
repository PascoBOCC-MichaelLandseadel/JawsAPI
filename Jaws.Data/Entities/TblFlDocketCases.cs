using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblFlDocketCases
{
    public int Id { get; set; }

    public int DocketId { get; set; }

    public string CaseId { get; set; } = null!;

    public string? NoticeSent { get; set; }
}
