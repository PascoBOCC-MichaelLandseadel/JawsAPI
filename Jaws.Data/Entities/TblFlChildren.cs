using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblFlChildren
{
    public int ChildId { get; set; }

    public string? CaseId { get; set; }

    public string? Name { get; set; }

    public DateTime? Dob { get; set; }

    public string? Ssn { get; set; }
}
