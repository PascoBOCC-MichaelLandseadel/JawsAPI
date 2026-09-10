using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblWorkQueueMoveLog
{
    public int WorkQueueMoveId { get; set; }

    public int? OrderId { get; set; }

    public int? FileId { get; set; }

    public int? UserId { get; set; }

    public DateTime? DateTimeMoved { get; set; }

    public int? DivisionIdFrom { get; set; }

    public int? DivisionIdTo { get; set; }
}
