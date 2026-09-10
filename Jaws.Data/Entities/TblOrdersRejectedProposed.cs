using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblOrdersRejectedProposed
{
    public int ProposedOrderRejectId { get; set; }

    public int? FileId { get; set; }

    public int? DivisionId { get; set; }

    public string? Reason { get; set; }
}
