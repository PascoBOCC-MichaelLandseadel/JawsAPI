using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblLkuClerkEventCode
{
    public int EventCodeId { get; set; }

    public string? EventCode { get; set; }

    public string? EventCodeDescription { get; set; }
}
