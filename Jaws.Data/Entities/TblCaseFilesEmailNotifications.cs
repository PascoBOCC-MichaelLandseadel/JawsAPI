using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblCaseFilesEmailNotifications
{
    public int CaseNotesId { get; set; }

    public string? Emails { get; set; }

    public string? NotificationType { get; set; }

    public int? FileId { get; set; }

    public DateTime? DateCreated { get; set; }
}
