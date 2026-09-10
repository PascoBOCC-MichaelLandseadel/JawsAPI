using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblUserViewerPreferences
{
    public int UserId { get; set; }

    public string? Wqdefault { get; set; }

    public bool? WqshowRejects { get; set; }

    public bool? FitToHeight { get; set; }

    public bool? FilterInfractions { get; set; }

    public bool? FilterClerkNotesPd { get; set; }
}
