using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblOrdersCivilOocmc
{
    public int OocmcId { get; set; }

    public int? OrderId { get; set; }

    public string? PetitionerCopies { get; set; }

    public string? RespondentCopies { get; set; }

    public string? CircuitJudge { get; set; }

    public string? Txt2 { get; set; }

    public string? Txt3 { get; set; }

    public string? Txt4 { get; set; }

    public string? Txt5 { get; set; }

    public string? Txt6 { get; set; }

    public string? Txt7 { get; set; }

    public bool? Chk1 { get; set; }

    public bool? Chk2 { get; set; }

    public bool? Chk3 { get; set; }

    public bool? Chk4 { get; set; }

    public bool? Chk5 { get; set; }

    public bool? Chk6 { get; set; }
}
