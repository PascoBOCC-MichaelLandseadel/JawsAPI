using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblFamilyLawFormsOpar
{
    public int OparId { get; set; }

    public int? OrderId { get; set; }

    public string? Petitioner { get; set; }

    public string? Respondent { get; set; }

    public string? Division { get; set; }

    public DateTime? OrderedOn { get; set; }

    public string? CircuitJudge { get; set; }

    public bool? Chk1 { get; set; }

    public bool? Chk2 { get; set; }

    public bool? Chk3 { get; set; }

    public bool? Chk4 { get; set; }

    public bool? Chk5 { get; set; }

    public bool? Chk6 { get; set; }

    public bool? Chk7 { get; set; }

    public bool? Chk8 { get; set; }

    public bool? Chk9 { get; set; }

    public bool? Chk10 { get; set; }

    public DateTime? Date1 { get; set; }

    public string? Text1 { get; set; }

    public string? Text2 { get; set; }

    public string? Text3 { get; set; }

    public string? Copies { get; set; }
}
