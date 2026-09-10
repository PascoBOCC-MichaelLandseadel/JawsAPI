using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblClerkEventCode
{
    public int ClerkEventCodeId { get; set; }

    public string? ClerkEventCode { get; set; }

    public string? ClerkEventCodeDescription { get; set; }
}
