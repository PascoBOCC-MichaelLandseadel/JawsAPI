using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblFlDocketHandler
{
    public int DocHandlerId { get; set; }

    public int DocId { get; set; }

    public string CaseId { get; set; } = null!;

    public short ReportId { get; set; }

    public DateTime? ReportDate { get; set; }

    public DateTime? HearingConferenceDate { get; set; }

    public short? Reserved { get; set; }

    public string? MatterToBeHeard { get; set; }

    public string? CaseMgmtOrder { get; set; }

    public string UserName { get; set; } = null!;

    public DateTime CreationDate { get; set; }
}
