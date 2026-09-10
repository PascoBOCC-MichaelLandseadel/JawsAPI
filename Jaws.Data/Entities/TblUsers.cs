using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblUsers
{
    public int AppUserId { get; set; }

    public string? Username { get; set; }

    public int? JudgeId { get; set; }

    public int? DivisionId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }
}
