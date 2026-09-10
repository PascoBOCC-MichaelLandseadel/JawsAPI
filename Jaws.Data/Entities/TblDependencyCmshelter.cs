using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblDependencyCmshelter
{
    public int Id { get; set; }

    public int CaseId { get; set; }

    public string? ChildName { get; set; }

    public DateTime? ShelterDate { get; set; }

    public string? Comment { get; set; }

    public DateTime? DateCreted { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public bool? Deleted { get; set; }

    public string? Adjudication { get; set; }

    public string? Disposition { get; set; }

    public string? CasePlan { get; set; }

    public string? Tprdate { get; set; }
}
