using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblIlHearingDates2
{
    public int IlHearingDateId { get; set; }

    public int? Idnum { get; set; }

    public DateTime? IlHearingDate { get; set; }

    public string? IlHearingTime { get; set; }

    public int? StatusId { get; set; }

    public bool? Attended { get; set; }

    public string? Username { get; set; }
}
