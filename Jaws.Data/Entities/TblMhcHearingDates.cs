using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblMhcHearingDates
{
    public int MhcHearingDateId { get; set; }

    public int? Idnum { get; set; }

    public DateTime? MhcHearingDate { get; set; }

    public string? MhcHearingTime { get; set; }

    public int? StatusId { get; set; }

    public bool? Attended { get; set; }

    public string? Username { get; set; }
}
