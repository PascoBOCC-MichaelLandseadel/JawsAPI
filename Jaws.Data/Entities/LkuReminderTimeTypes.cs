using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class LkuReminderTimeTypes
{
    public int Id { get; set; }

    public bool? Deleted { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? DateCreated { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? DateModified { get; set; }

    public string? Description { get; set; }

    public string? ReminderTime { get; set; }

    public string? TimeType { get; set; }
}
