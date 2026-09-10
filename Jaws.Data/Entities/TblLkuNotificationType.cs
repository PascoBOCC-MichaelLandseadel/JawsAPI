using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblLkuNotificationType
{
    public int NotificationTypeId { get; set; }

    public string NotificationTypeDescription { get; set; } = null!;
}
