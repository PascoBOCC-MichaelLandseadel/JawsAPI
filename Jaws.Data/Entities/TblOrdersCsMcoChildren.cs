using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class TblOrdersCsMcoChildren
{
    public int CsMcoChildrenId { get; set; }

    public int? CsMcoId { get; set; }

    public string? ChildFirstName { get; set; }

    public string? ChildMiddleName { get; set; }

    public string? ChildLastName { get; set; }

    public string? DateOfBirth { get; set; }

    public string? DateOfTermination { get; set; }

    public string? ReducedSupportObligation { get; set; }
}
