using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblCourtDivisionsRecorderEnabled
{
    public int? DivisionId { get; set; }

    public string? IpAddress { get; set; }

    public int? PortNumber { get; set; }

    public bool? Active { get; set; }
}
