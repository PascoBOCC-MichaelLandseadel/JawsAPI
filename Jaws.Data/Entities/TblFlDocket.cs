using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblFlDocket
{
    public int DocId { get; set; }

    public DateTime DocketPrepDateDatetime { get; set; }

    public byte MaxNumCases { get; set; }

    public string? Preparer { get; set; }

    public string? DocketManager { get; set; }

    public byte AttyManager { get; set; }

    public byte? Division { get; set; }

    public string? Origin { get; set; }

    public string UserName { get; set; } = null!;

    public DateTime CreationDate { get; set; }

    public DateTime? ChangeDate { get; set; }
}
