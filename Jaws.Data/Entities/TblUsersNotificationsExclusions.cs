using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblUsersNotificationsExclusions
{
    public int UserId { get; set; }

    public int NotificationTypeId { get; set; }
}
