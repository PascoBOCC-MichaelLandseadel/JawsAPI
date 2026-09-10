using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblUserPassword
{
    public int Id { get; set; }

    public Guid UserId { get; set; }

    public string Password { get; set; } = null!;
}
