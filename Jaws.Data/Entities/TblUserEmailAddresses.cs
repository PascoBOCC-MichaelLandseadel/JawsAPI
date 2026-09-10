using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblUserEmailAddresses
{
    public int UserEmailId { get; set; }

    public int? UserId { get; set; }

    public string? Email { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }
}
