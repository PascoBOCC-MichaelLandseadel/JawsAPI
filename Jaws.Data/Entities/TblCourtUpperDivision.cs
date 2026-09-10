using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblCourtUpperDivision
{
    public int UpperDivisionId { get; set; }

    public string? UpperDivisionDesc { get; set; }

    public string? UpperAbbrev { get; set; }
}
