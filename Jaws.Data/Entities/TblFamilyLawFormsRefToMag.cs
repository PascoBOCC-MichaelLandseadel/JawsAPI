using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblFamilyLawFormsRefToMag
{
    public int RefToMagistrateId { get; set; }

    public int? OrderId { get; set; }

    public string? Petitioner { get; set; }

    public string? Respondent { get; set; }

    public string? Division { get; set; }

    public string? OrderedOn { get; set; }

    public string? CircuitJudge { get; set; }

    public string? OrderTitle { get; set; }

    public string? GeneralMagistrate { get; set; }

    public string? Phone { get; set; }

    public string? Issues { get; set; }

    public string? PetitionerAddress { get; set; }

    public string? PetitionerCityState { get; set; }

    public string? RespondentAddress { get; set; }

    public string? RespondentCityState { get; set; }

    public string? PetitionerExtra1 { get; set; }

    public string? PetitionerExtra2 { get; set; }

    public string? PetitionerExtra3 { get; set; }

    public string? PetitionerExtra4 { get; set; }

    public string? PetitionerExtra5 { get; set; }

    public string? PetitionerExtra6 { get; set; }

    public string? PetitionerExtra7 { get; set; }

    public string? RespondentExtra1 { get; set; }

    public string? RespondentExtra2 { get; set; }

    public string? RespondentExtra3 { get; set; }

    public string? RespondentExtra4 { get; set; }

    public string? RespondentExtra5 { get; set; }

    public string? RespondentExtra6 { get; set; }

    public string? RespondentExtra7 { get; set; }

    public string? GmAddress { get; set; }

    public string? GmRoom { get; set; }

    public string? GmCity { get; set; }

    public string? PetitionerCopies { get; set; }

    public string? RespondentCopies { get; set; }
}
