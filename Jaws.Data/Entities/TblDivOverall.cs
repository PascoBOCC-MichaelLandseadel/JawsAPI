using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblDivOverall
{
    public byte ParentCourt { get; set; }

    public byte? Division { get; set; }

    public string? Judge { get; set; }

    public string? Chambers { get; set; }

    public string? CourtRoom { get; set; }

    public string? Street { get; set; }

    public string? CityStateZip { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public string? County { get; set; }

    public string? Logon { get; set; }

    public string? Ja { get; set; }

    public virtual LkuCourtCircuitDivisionTbl ParentCourtNavigation { get; set; } = null!;
}
