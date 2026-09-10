using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblIlCaseNotes
{
    public int CaseNotesId { get; set; }

    public int? Idnum { get; set; }

    public DateTime? NoteDateDateTime { get; set; }

    public string? Note { get; set; }

    public string? Viewed { get; set; }

    public string UserName { get; set; } = null!;
}
