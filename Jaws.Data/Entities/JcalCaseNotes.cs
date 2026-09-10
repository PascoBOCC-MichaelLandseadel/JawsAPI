using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class JcalCaseNotes
{
    public string? ResourceName { get; set; }

    public string? ResourceType { get; set; }

    public string? ResourceEmail { get; set; }

    public DateTime? TimeStamp { get; set; }

    public string? Note { get; set; }

    public string? CaseNumber { get; set; }

    public string? Title { get; set; }

    public bool? CaseNotesPrivateFlag { get; set; }
}
