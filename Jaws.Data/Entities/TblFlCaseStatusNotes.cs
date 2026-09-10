using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblFlCaseStatusNotes
{
    public int CaseNotesId { get; set; }

    public string? CaseId { get; set; }

    public DateTime? NoteDateDateTime { get; set; }

    public string? Note { get; set; }

    public string UserName { get; set; } = null!;
}
