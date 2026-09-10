using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class LkuHearingOfficerTbl
{
    public int HoId { get; set; }

    public int Division { get; set; }

    public string? Ho { get; set; }

    public string? CourtRoom { get; set; }

    public string? Street { get; set; }

    public string? CityStateZip { get; set; }

    public string? Phone { get; set; }

    public string? County { get; set; }

    public string? Assistant { get; set; }
}
