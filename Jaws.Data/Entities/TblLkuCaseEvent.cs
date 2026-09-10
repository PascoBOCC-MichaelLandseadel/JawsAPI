using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblLkuCaseEvent
{
    public int CaseEventId { get; set; }

    public string? CaseEvent { get; set; }

    public bool? Active { get; set; }
}
