using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblJudge
{
    public int JudgeId { get; set; }

    public string? JudgeFirstName { get; set; }

    public string? JudgeLastName { get; set; }
}
