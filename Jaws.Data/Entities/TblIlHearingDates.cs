using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblIlHearingDates
{
    public int Id { get; set; }

    public int Idnum { get; set; }

    public DateTime? HearingDate { get; set; }

    public int? Attended { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? Username { get; set; }
}
