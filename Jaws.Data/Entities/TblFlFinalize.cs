using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblFlFinalize
{
    public string? CaseId { get; set; }

    public string? Reportname { get; set; }

    public string? Finalize { get; set; }

    public DateTime? CreationDate { get; set; }
}
