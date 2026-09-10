using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblFamilyLawFormsOrfcs
{
    public int OrfcsId { get; set; }

    public int? OrderId { get; set; }

    public string? Petitioner { get; set; }

    public string? Respondent { get; set; }

    public string? Division { get; set; }

    public DateTime? OrderedOn { get; set; }

    public string? CircuitJudge { get; set; }

    public string? Text1 { get; set; }

    public bool? Chk1 { get; set; }

    public bool? Chk2 { get; set; }

    public bool? Chk3 { get; set; }

    public bool? Chk4 { get; set; }

    public bool? Chk5 { get; set; }

    public bool? Chk6 { get; set; }

    public bool? Chk7 { get; set; }

    public bool? Chk8 { get; set; }

    public string? Text2 { get; set; }

    public string? PetitionerAddress { get; set; }

    public string? PetitionerCityState { get; set; }

    public string? RespondentAddress { get; set; }

    public string? RespondentCityState { get; set; }
}
