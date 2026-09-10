using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblCaseNotifications
{
    public int? Id { get; set; }

    public string? EmailAddress { get; set; }

    public int? NotificationTypeId { get; set; }

    public DateTime? DateCreated { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? DateModified { get; set; }

    public bool? Deleted { get; set; }
}
