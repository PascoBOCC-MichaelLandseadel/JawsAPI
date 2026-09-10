using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblDependencyCm
{
    public int Id { get; set; }

    public string CaseNumber { get; set; } = null!;

    public int CaseId { get; set; }

    public string? CaseName { get; set; }

    public string? TypeOfHearing { get; set; }

    public DateTime? HearingDate { get; set; }

    public int? DivisionId { get; set; }

    public string? Allegations { get; set; }

    public string? Cslr { get; set; }

    public string? Oag { get; set; }

    public string? Gal { get; set; }

    public string? Galattorney { get; set; }

    public string? Mother { get; set; }

    public string? MotherAttorney { get; set; }

    public DateTime? ShelterDate { get; set; }

    public string? Arraignment { get; set; }

    public string? Attorney1 { get; set; }

    public string? Attorney2 { get; set; }

    public string? Tprdates { get; set; }

    public string? CasePlan { get; set; }

    public DateTime? PreviousJr { get; set; }

    public DateTime? NextJr { get; set; }

    public string? NextCourtDate { get; set; }

    public DateTime? DateCreated { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? DateModified { get; set; }

    public int? ModifiedBy { get; set; }

    public string? HearingTime { get; set; }

    public string? Attorney1lbl { get; set; }

    public string? Attorney2lbl { get; set; }
}
