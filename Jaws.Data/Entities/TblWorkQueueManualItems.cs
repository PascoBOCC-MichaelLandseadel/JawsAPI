using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblWorkQueueManualItems
{
    public int WorkQueueManualItemsId { get; set; }

    public int? DivisionId { get; set; }

    public int? ReminderId { get; set; }

    public string? ItemSubject { get; set; }

    public string? ItemBody { get; set; }

    public int? ClerkFileId { get; set; }

    public string? CaseNumber { get; set; }

    public DateTime? FilingDate { get; set; }

    public string? DocketType { get; set; }

    public string? DocketDescription { get; set; }

    public bool? HasImage { get; set; }

    public bool? HasReminder { get; set; }

    public int? CreatedByUserId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? DueDate { get; set; }

    public bool? Complete { get; set; }

    public int? StatusId { get; set; }

    public int? CategoryId { get; set; }
}
