using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblWorkQueueProposedOrders
{
    public int ProposedOrderId { get; set; }

    public int? FileId { get; set; }

    public int? DivisionId { get; set; }

    public bool? Active { get; set; }

    public int? CategoryId { get; set; }
}
