using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblIlClerkActionInstructions
{
    public int Id { get; set; }

    public int? Idnum { get; set; }

    public string? SchedCourtDocket { get; set; }

    public string? StrikeCase { get; set; }

    public DateTime? StrikeCaseDate { get; set; }

    public string? Comments { get; set; }

    public string? UserName { get; set; }

    public DateTime? CreationDate { get; set; }
}
