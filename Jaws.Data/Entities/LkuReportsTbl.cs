using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class LkuReportsTbl
{
    public short ReportId { get; set; }

    public string? ReportDesc { get; set; }

    public short ReportType { get; set; }

    public short ReportSortId { get; set; }

    public int? DisplayMainMenu { get; set; }
}
