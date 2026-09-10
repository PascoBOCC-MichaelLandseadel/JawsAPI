using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblDependencyChildren
{
    public int Id { get; set; }

    public int CaseId { get; set; }

    public string? ChildName { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public string? Placement { get; set; }

    public string? Father { get; set; }

    public string? FatherAttorney { get; set; }

    public DateTime? DateCreted { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public bool? Deleted { get; set; }

    public int? PartyId { get; set; }

    public int? ChildId { get; set; }
}
