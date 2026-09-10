using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblOrdersSystemOrders
{
    public int SystemOrderId { get; set; }

    public int? OrderTypeId { get; set; }
}
