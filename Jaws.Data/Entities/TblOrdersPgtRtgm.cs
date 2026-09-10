using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblOrdersPgtRtgm
{
    public int OrderPgtRtgmId { get; set; }

    public int? OrderId { get; set; }

    public string? PetitionerCopies { get; set; }

    public string? RespondentCopies { get; set; }

    public string? CircuitJudge { get; set; }

    public string? OrderedOn { get; set; }

    public string? Txt1 { get; set; }

    public string? Txt3 { get; set; }

    public string? Txt4 { get; set; }

    public string? Txt5 { get; set; }

    public string? Txt6 { get; set; }

    public string? Txt7 { get; set; }

    public bool? Chk1 { get; set; }

    public bool? Chk2 { get; set; }
}
