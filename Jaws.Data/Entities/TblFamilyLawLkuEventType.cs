using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblFamilyLawLkuEventType
{
    public int EventTypeId { get; set; }

    public int? DivisionId { get; set; }

    public string? EventType { get; set; }

    public bool? Active { get; set; }

    public string? EventDescription { get; set; }

    public bool PublicEvent { get; set; }

    public int? ActiveEventType { get; set; }
}
