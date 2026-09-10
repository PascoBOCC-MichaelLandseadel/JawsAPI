using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblLkuGenMagistrate
{
    public int GmId { get; set; }

    public string? Gm { get; set; }

    public string? CourtRoom { get; set; }

    public string? Street { get; set; }

    public string? CityStateZip { get; set; }

    public string? Phone { get; set; }
}
