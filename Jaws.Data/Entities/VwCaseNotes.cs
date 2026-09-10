using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class VwCaseNotes
{
    public int CaseNotesId { get; set; }

    public string? CaseId { get; set; }

    public string? CaseNotes { get; set; }

    public int? UserId { get; set; }

    public DateTime? CaseNotesDate { get; set; }

    public string UserName { get; set; } = null!;
}
