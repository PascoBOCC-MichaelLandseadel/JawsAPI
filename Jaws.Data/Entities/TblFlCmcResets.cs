using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblFlCmcResets
{
    public int ResetId { get; set; }

    public int DocId { get; set; }

    public DateTime ResetDate { get; set; }

    public int Duration { get; set; }

    public byte MaxNumCases { get; set; }

    public string UserName { get; set; } = null!;

    public DateTime CreationDate { get; set; }

    public DateTime? ChangeDate { get; set; }
}
