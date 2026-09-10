using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblCourtDivisionNotifications
{
    public int Id { get; set; }

    public int DivisionId { get; set; }

    public int NotificationTypeId { get; set; }

    public string EmailAddress { get; set; } = null!;

    public bool? Deleted { get; set; }

    public DateTime? DateCreated { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? DateModified { get; set; }

    public int? ModifiedBy { get; set; }
}
