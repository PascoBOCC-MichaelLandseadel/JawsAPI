using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblLkuWorkQueueStatus
{
    public int WorkQueueStatusId { get; set; }

    public string? WorkQueueStatus { get; set; }

    public bool? Active { get; set; }
}
