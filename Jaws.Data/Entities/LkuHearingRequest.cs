using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class LkuHearingRequest
{
    public int Id { get; set; }

    public int DivisionId { get; set; }

    public string RequestDescr { get; set; } = null!;

    public bool? Deleted { get; set; }

    public DateTime? DateModified { get; set; }

    public int? ModifiedUser { get; set; }
}
