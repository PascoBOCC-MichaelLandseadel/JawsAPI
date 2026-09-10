using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblFamilyLawFormsForHearing
{
    public int ForHearingId { get; set; }

    public int? OrderId { get; set; }

    public string? Petitioner { get; set; }

    public string? Respondent { get; set; }

    public string? Division { get; set; }

    public DateTime? OrderedOn { get; set; }

    public string? CircuitJudge { get; set; }

    public string? PetitionerAddress { get; set; }

    public string? PetitionerCityState { get; set; }

    public string? RespondentAddress { get; set; }

    public string? RespondentCityState { get; set; }
}
