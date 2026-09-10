using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class AspnetMembershipHistory
{
    public int Id { get; set; }

    public Guid UserId { get; set; }

    public string Password { get; set; } = null!;

    public string Salt { get; set; } = null!;

    public string? Email { get; set; }

    public DateTime ChangedDate { get; set; }
}
