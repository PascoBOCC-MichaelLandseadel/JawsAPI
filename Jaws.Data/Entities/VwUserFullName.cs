using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class VwUserFullName
{
    public int UserId { get; set; }

    public string FullName { get; set; } = null!;
}
