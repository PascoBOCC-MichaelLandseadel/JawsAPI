using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblOrderSigningQueue
{
    public int OrderSigningQueueId { get; set; }

    public int? OrderId { get; set; }

    public int? DivisionId { get; set; }
}
