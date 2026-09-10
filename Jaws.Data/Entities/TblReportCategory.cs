using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblReportCategory
{
    public int ReportCategoryId { get; set; }

    public string? ReportCategory { get; set; }

    public bool? Active { get; set; }
}
