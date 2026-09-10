using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblCaseWatchListDetails
{
    public int Id { get; set; }

    public int WatchListId { get; set; }

    public bool? ReminderNotification { get; set; }

    public DateTime? ReminderDateTime { get; set; }

    public DateTime? DateFiled { get; set; }

    public string? DocumentType { get; set; }

    public string? DocumentDescription { get; set; }

    public DateTime CreateDate { get; set; }

    public DateTime ModifiedDate { get; set; }

    public int EventId { get; set; }
}
