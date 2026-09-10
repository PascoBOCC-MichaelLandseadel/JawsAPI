using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblEntityCase
{
    public int EntityCaseId { get; set; }

    public int CaseRecordId { get; set; }

    public int EntityRecordId { get; set; }

    public short CaseRole { get; set; }

    public DateTime EntityCaseCreationDate { get; set; }

    public string Username { get; set; } = null!;

    public DateTime? EntityCaseChangeDate { get; set; }
}
