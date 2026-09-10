using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblOrdersUfcdrOshopfifp
{
    public int Id { get; set; }

    public int? OrderId { get; set; }

    public string? CircuitJudge { get; set; }

    public string? OrderedOn { get; set; }

    public string? PetitionerCopies { get; set; }

    public string? RespondentCopies { get; set; }

    public bool? Chk1 { get; set; }

    public bool? Chk2 { get; set; }

    public bool? Chk3 { get; set; }

    public bool? Chk4 { get; set; }

    public bool? Chk5 { get; set; }

    public bool? Chk6 { get; set; }

    public bool? Chk7 { get; set; }

    public string? Ddl1 { get; set; }

    public string? Txt2 { get; set; }

    public string? Txt3 { get; set; }
}
