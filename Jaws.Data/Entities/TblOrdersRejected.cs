using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblOrdersRejected
{
    public int RejectedOrderId { get; set; }

    public int? OrderId { get; set; }

    public int? DivisionId { get; set; }

    public string? Reason { get; set; }
}
