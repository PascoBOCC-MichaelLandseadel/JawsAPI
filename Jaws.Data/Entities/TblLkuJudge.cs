using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblLkuJudge
{
    public int JudgeId { get; set; }

    public string? JudgeFirstName { get; set; }

    public string? JudgeMiddleName { get; set; }

    public string? JudgeLastName { get; set; }

    public string? Username { get; set; }
}
