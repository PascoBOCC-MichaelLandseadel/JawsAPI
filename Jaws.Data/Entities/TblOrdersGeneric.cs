using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblOrdersGeneric
{
    public int GenericId { get; set; }

    public int? OrderId { get; set; }

    public string? PetitionerCopies { get; set; }

    public string? RespondentCopies { get; set; }

    public string? CircuitJudge { get; set; }

    public string? Txt1 { get; set; }

    public string? Txt2 { get; set; }

    public string? Txt3 { get; set; }

    public string? Txt4 { get; set; }

    public string? Txt5 { get; set; }

    public string? TxtTitle { get; set; }

    public string? TxtBody { get; set; }

    public string? FurtherOrders { get; set; }

    public string? TxtSubTitle { get; set; }
}
