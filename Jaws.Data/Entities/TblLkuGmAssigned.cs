using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblLkuGmAssigned
{
    public int Id { get; set; }

    public int? MagId { get; set; }

    public int? DivisionId { get; set; }

    public string? CaseNumber { get; set; }
}
