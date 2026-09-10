using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblJudgeUser
{
    public int JudgeUserId { get; set; }

    public int? JudgeId { get; set; }

    public string? Username { get; set; }
}
