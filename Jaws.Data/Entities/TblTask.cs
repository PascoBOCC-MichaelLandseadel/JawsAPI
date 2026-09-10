using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblTask
{
    public int Id { get; set; }

    public DateTime? DateCreated { get; set; }

    public DateTime? DateModified { get; set; }

    public int? CreatedBy { get; set; }

    public int? ModifiedBy { get; set; }

    public bool? Deleted { get; set; }

    public string? CaseId { get; set; }

    public string? Description { get; set; }

    public int? AssignedUser { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? DueDate { get; set; }

    public int? Status { get; set; }

    public bool? ReminderNotification { get; set; }

    public string? ReminderTimeType { get; set; }

    public DateTime? ReminderDateTime { get; set; }

    public bool? IsPublic { get; set; }

    public string? Subject { get; set; }

    public bool? OwnerKeepsTaskCopy { get; set; }

    public string? Priority { get; set; }

    public string? PercentComplete { get; set; }

    public int? DivisionId { get; set; }

    public bool? AddWorkQueueItem { get; set; }

    public int? CategoryId { get; set; }
}
