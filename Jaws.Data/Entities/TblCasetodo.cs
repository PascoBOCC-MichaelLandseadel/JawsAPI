using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblCasetodo
{
    public int Id { get; set; }

    public string? CaseId { get; set; }

    public short? ItemId { get; set; }

    public DateTime? DueDate { get; set; }

    public bool Completed { get; set; }

    public DateTime? CompletionDate { get; set; }

    public string? Method { get; set; }

    public int? Step { get; set; }

    public string? Steppart { get; set; }

    public string? CompletionStatus { get; set; }

    public string? ReqtStatus { get; set; }

    public byte? DueStatus { get; set; }

    public string? UserName { get; set; }

    public string? Enabled { get; set; }

    public DateTime? CreationDate { get; set; }

    public DateTime? ChangeDate { get; set; }
}
