using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblClerkContact
{
    public int ClerkContactId { get; set; }

    public int? DivisionId { get; set; }

    public string? ClerkFirstName { get; set; }

    public string? ClerkLastName { get; set; }

    public string? ClerkEmail { get; set; }
}
