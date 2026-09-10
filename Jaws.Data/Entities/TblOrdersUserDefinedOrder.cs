using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblOrdersUserDefinedOrder
{
    public int UserDefinedOrderId { get; set; }

    public int? OrderTypeId { get; set; }

    public string? Title { get; set; }

    public string? SubTitle { get; set; }

    public string? Body { get; set; }

    public string? FurtherOrdered { get; set; }
}
