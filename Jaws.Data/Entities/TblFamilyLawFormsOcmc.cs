using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblFamilyLawFormsOcmc
{
    public int OcmcId { get; set; }

    public int? OrderId { get; set; }

    public string? Petitioner { get; set; }

    public string? Respondent { get; set; }

    public string? Division { get; set; }

    public DateTime? OrderedOn { get; set; }

    public string? CircuitJudge { get; set; }

    public string? LongDate1 { get; set; }

    public string? Date1 { get; set; }

    public string? Date2 { get; set; }

    public string? Date3 { get; set; }

    public string? Time1 { get; set; }

    public string? Time2 { get; set; }

    public string? Other { get; set; }

    public string? Judge { get; set; }

    public string? Copies { get; set; }

    public bool? Chk1 { get; set; }

    public bool? Chk2 { get; set; }

    public bool? Chk3 { get; set; }

    public bool? Chk4 { get; set; }

    public bool? Chk5 { get; set; }

    public bool? Chk6 { get; set; }

    public bool? Chk7 { get; set; }

    public bool? Chk8 { get; set; }
}
