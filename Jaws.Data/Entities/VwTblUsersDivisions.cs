using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class VwTblUsersDivisions
{
    public int UserId { get; set; }

    public int DivisionId { get; set; }

    public bool? DefaultDivision { get; set; }

    public string? DivisionLetter { get; set; }

    public int? UpperDivisionId { get; set; }
}
