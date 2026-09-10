using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblReportReportCategory
{
    public int ReportIdReportCategoryId { get; set; }

    public int? ReportId { get; set; }

    public int? CategoryId { get; set; }
}
