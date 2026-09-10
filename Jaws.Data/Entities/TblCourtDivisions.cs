using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblCourtDivisions
{
    public int DivisionId { get; set; }

    public string? DivisionLetter { get; set; }

    public string? DivisionDescription { get; set; }

    public int? UpperDivisionId { get; set; }

    public string? CourtRoom { get; set; }

    public string? DivisionAddress { get; set; }
}
